using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Files
{
    public partial class Client : Form
    {
        private TcpClient tcpClient;
        private OpenFileDialog openFileDialog;

        public Client()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
        }
        private void AddStatusMessage(string message)
        {
            if (txtStatus.InvokeRequired)
            {
                txtStatus.Invoke(new Action<string>(AddStatusMessage), message);
            }
            else
            {
                txtStatus.AppendText(message + Environment.NewLine);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                string serverIP = "192.168.0.157"; // Thay thế địa chỉ IP này bằng địa chỉ IP của máy chủ
                tcpClient = new TcpClient(serverIP, 1234);
                AddStatusMessage("Connected to server.");
                btnConnect.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to server: " + ex.Message);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
                       
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Xử lý gửi file
                    AddStatusMessage("Sending file...");

                    // Lấy thông tin file
                    string fileName = Path.GetFileName(openFileDialog.FileName);
                    byte[] fileNameBytes = Encoding.ASCII.GetBytes(fileName);

                    // Gửi tên file
                    NetworkStream networkStream = tcpClient.GetStream();
                    networkStream.Write(fileNameBytes, 0, fileNameBytes.Length);
                    networkStream.Flush(); // Flush bộ đệm để gửi dữ liệu ngay lập tức

                    // Mở file và gửi dữ liệu
                    using (FileStream fileStream = File.OpenRead(openFileDialog.FileName))
                    {
                        byte[] buffer = new byte[4096];
                        int bytesRead;
                        while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            networkStream.Write(buffer, 0, bytesRead);
                            networkStream.Flush(); // Flush bộ đệm để gửi dữ liệu ngay lập tức
                        }
                    }

                    AddStatusMessage("File sent successfully!");
                }
                catch (Exception ex)
                {
                    AddStatusMessage("Error sending file: " + ex.Message);
                }
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                NetworkStream clientStream = tcpClient.GetStream();

                byte[] commandBytes = Encoding.ASCII.GetBytes("DOWNLOAD");
                clientStream.Write(commandBytes, 0, commandBytes.Length);
                AddStatusMessage("Downloading file...");
                byte[] fileListLengthBytes = new byte[4];
                clientStream.Read(fileListLengthBytes, 0, 4);
                int fileListLength = BitConverter.ToInt32(fileListLengthBytes, 0);

                byte[] fileListBytes = new byte[fileListLength];
                clientStream.Read(fileListBytes, 0, fileListLength);

                string fileList = Encoding.ASCII.GetString(fileListBytes);
                string[] files = fileList.Split(',');

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFile = saveFileDialog.FileName;
                    byte[] selectedFileBytes = Encoding.ASCII.GetBytes(selectedFile);
                    byte[] selectedFileLengthBytes = BitConverter.GetBytes(selectedFileBytes.Length);

                    clientStream.Write(selectedFileLengthBytes, 0, selectedFileLengthBytes.Length);
                    clientStream.Write(selectedFileBytes, 0, selectedFileBytes.Length);

                    byte[] fileDataLengthBytes = new byte[4];
                    clientStream.Read(fileDataLengthBytes, 0, 4);
                    int fileDataLength = BitConverter.ToInt32(fileDataLengthBytes, 0);

                    byte[] fileDataBytes = new byte[fileDataLength];
                    clientStream.Read(fileDataBytes, 0, fileDataLength);

                    File.WriteAllBytes(selectedFile, fileDataBytes);

                    AddStatusMessage("File downloaded successfully!");
                }
            }
            catch (Exception ex)
            {
                AddStatusMessage("Error downloading file: " + ex.Message);
            }
            */

            try
            {
                NetworkStream clientStream = tcpClient.GetStream();

                byte[] commandBytes = Encoding.ASCII.GetBytes("DOWNLOAD");
                clientStream.Write(commandBytes, 0, commandBytes.Length);
                clientStream.Flush(); // Flush bộ đệm để gửi lệnh DOWNLOAD ngay lập tức

                AddStatusMessage("Downloading file...");
                byte[] fileListLengthBytes = new byte[4];
                clientStream.Read(fileListLengthBytes, 0, 4);
                int fileListLength = BitConverter.ToInt32(fileListLengthBytes, 0);

                byte[] fileListBytes = new byte[fileListLength];
                clientStream.Read(fileListBytes, 0, fileListLength);

                string fileList = Encoding.ASCII.GetString(fileListBytes);
                string[] files = fileList.Split(',');

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFile = saveFileDialog.FileName;
                    byte[] selectedFileBytes = Encoding.ASCII.GetBytes(selectedFile);
                    byte[] selectedFileLengthBytes = BitConverter.GetBytes(selectedFileBytes.Length);

                    clientStream.Write(selectedFileLengthBytes, 0, selectedFileLengthBytes.Length);
                    clientStream.Write(selectedFileBytes, 0, selectedFileBytes.Length);
                    clientStream.Flush(); // Flush bộ đệm để gửi tên file ngay lập tức

                    byte[] fileDataLengthBytes = new byte[4];
                    clientStream.Read(fileDataLengthBytes, 0, 4);
                    int fileDataLength = BitConverter.ToInt32(fileDataLengthBytes, 0);

                    byte[] fileDataBytes = new byte[fileDataLength];
                    clientStream.Read(fileDataBytes, 0, fileDataLength);
                    clientStream.Flush(); // Flush bộ đệm để nhận dữ liệu file ngay lập tức

                    File.WriteAllBytes(selectedFile, fileDataBytes);

                    AddStatusMessage("File downloaded successfully!");
                }
            }
            catch (Exception ex)
            {
                AddStatusMessage("Error downloading file: " + ex.Message);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            NetworkStream clientStream = tcpClient.GetStream();

            byte[] commandBytes = Encoding.ASCII.GetBytes("DISCONNECT");
            clientStream.Write(commandBytes, 0, commandBytes.Length);

            clientStream.Close();
            tcpClient.Close();
            AddStatusMessage("Disconnected from server.");
            btnConnect.Enabled = true;
        }
    }
}
