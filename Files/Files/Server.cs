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
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Files
{
    public partial class Server : Form
    {
        private TcpListener tcpListener;
        private Thread listenThread;
        private List<TcpClient> connectedClients;

        public Server()
        {
            InitializeComponent();
            connectedClients = new List<TcpClient>();
        }

        private void Server_Load(object sender, EventArgs e)
        {
            tcpListener = new TcpListener(IPAddress.Any, 1234);
            listenThread = new Thread(new ThreadStart(ListenForClients));
            listenThread.Start();
            AddStatusMessage("Server started. Listening for clients...");
        }
        private void ListenForClients()
        {
            tcpListener.Start();

            while (true)
            {
                TcpClient client = tcpListener.AcceptTcpClient();
                connectedClients.Add(client);
                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientConnection));
                clientThread.Start(client);
                AddStatusMessage("Client connected: " + client.Client.RemoteEndPoint.ToString());
            }
        }
        private void HandleClientConnection(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();

            while (true)
            {
                byte[] commandBytes = new byte[4];
                clientStream.Read(commandBytes, 0, 4);
                string command = Encoding.ASCII.GetString(commandBytes);

                if (command == "SEND")
                {
                    ReceiveFile(tcpClient, clientStream);
                }
                else if (command == "DOWNLOAD")
                {
                    SendFileList(tcpClient, clientStream);
                    ReceiveFile(tcpClient, clientStream);
                }
                else if (command == "DISCONNECT")
                {
                    break;
                }
            }

            clientStream.Close();
            tcpClient.Close();

            connectedClients.Remove(tcpClient);
            AddStatusMessage("Client disconnected: " + tcpClient.Client.RemoteEndPoint.ToString());
        }
        private void ReceiveFile(TcpClient tcpClient, NetworkStream clientStream)
        {
            byte[] fileNameLengthBytes = new byte[4];
            clientStream.Read(fileNameLengthBytes, 0, 4);
            int fileNameLength = BitConverter.ToInt32(fileNameLengthBytes, 0);

            byte[] fileNameBytes = new byte[fileNameLength];
            clientStream.Read(fileNameBytes, 0, fileNameLength);
            string fileName = Path.GetFileNameWithoutExtension(Encoding.ASCII.GetString(fileNameBytes));

            byte[] fileDataLengthBytes = new byte[4];
            clientStream.Read(fileDataLengthBytes, 0, 4);
            int fileDataLength = BitConverter.ToInt32(fileDataLengthBytes, 0);

            byte[] fileDataBytes = new byte[fileDataLength];
            clientStream.Read(fileDataBytes, 0, fileDataLength);

            string savePath = Path.Combine(Application.StartupPath, "ReceivedFiles");
            Directory.CreateDirectory(savePath);
            string filePath = Path.Combine(savePath, fileName);

            using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                fileStream.Write(fileDataBytes, 0, fileDataBytes.Length);
            }

            AddStatusMessage("File received from client: " + tcpClient.Client.RemoteEndPoint.ToString());

            // Send acknowledgment to client
            byte[] acknowledgment = Encoding.ASCII.GetBytes("RECEIVED");
            clientStream.Write(acknowledgment, 0, acknowledgment.Length);
        }
        private void SendFileList(TcpClient tcpClient, NetworkStream clientStream)
        {
            string[] fileNames = Directory.GetFiles(Application.StartupPath, "*.txt");
            byte[] fileListBytes = CombineFileList(fileNames);
            clientStream.Write(fileListBytes, 0, fileListBytes.Length);
        }

        private byte[] CombineFileList(string[] fileNames)
        {
            string fileList = string.Join(",", fileNames);
            byte[] fileListBytes = Encoding.ASCII.GetBytes(fileList);

            byte[] fileListLengthBytes = BitConverter.GetBytes(fileListBytes.Length);
            byte[] combinedBytes = new byte[fileListLengthBytes.Length + fileListBytes.Length];

            Buffer.BlockCopy(fileListLengthBytes, 0, combinedBytes, 0, fileListLengthBytes.Length);
            Buffer.BlockCopy(fileListBytes, 0, combinedBytes, fileListLengthBytes.Length, fileListBytes.Length);

            return combinedBytes;
        }
        private void AddStatusMessage(string message)
        {
            if (listBoxStatus.InvokeRequired)
            {
                listBoxStatus.Invoke(new Action<string>(AddStatusMessage), message);
            }
            else
            {
                listBoxStatus.Items.Add(message);
            }
        }
    }
}
