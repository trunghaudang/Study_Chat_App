using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.IO;
using System.Security.Cryptography;


namespace Design
{
    public partial class SignUp : Form
    {
        string str_connect = @"Data Source=LAPTOP-3H9V4GA9\SQLEXPRESS;Initial Catalog=data_server;Integrated Security=True";


        IPEndPoint ip;
        Socket client;
        // List<string> myStrings = new List<string>();

        void connect()
        {
            ip = new IPEndPoint(IPAddress.Parse("192.168.0.28"), 8080);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                client.Connect(ip);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Not Correct", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }

        byte[] Ser(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }

        public static string GetMD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                // Chuyển đổi chuỗi thành một mảng byte
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);

                // Tính toán mã hash MD5
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Chuyển đổi mảng byte thành chuỗi hexa
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    stringBuilder.Append(hashBytes[i].ToString("x2"));
                }

                return stringBuilder.ToString();
            }
        }
        void sent()
        {
            client.Send(Ser(txt_username.Text + "," + txt_email.Text + "," + GetMD5Hash(txt_password.Text) + "," + txt_birth.Value.ToString()));
        }


        public SignUp()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            connect();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            sent();
        }

        private void txt_birth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Close();
        }
    }
}
