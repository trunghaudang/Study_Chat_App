using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;

namespace Design
{
    public partial class LogIn : Form
    {
        string str_connect = @"Data Source=LAPTOP-3H9V4GA9\SQLEXPRESS;Initial Catalog=data_server;Integrated Security=True";
        //SqlConnection sql_connection = null; // doi tuong connect


        IPEndPoint ip;
        Socket client;
        List<string> myStrings = new List<string>();

        void connect()
        {
            ip = new IPEndPoint(IPAddress.Parse("192.168.2.223"), 8081);
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


        string Deser(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

             Object a = formatter.Deserialize(stream);
            string b = a.ToString();
            return b;
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
        void sent(string a)
        {
            client.Send(Ser( GetMD5Hash(a) ));

        }


        public LogIn()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            connect();
        }

        private void lbForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.ShowDialog();
            this.Show();
        }

        private void lbSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
            this.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        void receive()
        {
            byte[] data = new byte[1024 * 5000];
            client.Receive(data);

            string message = Deser(data);

            if (message == "ok")
            {
                MainForm mainForm = new MainForm();
                Form1 form1 = new Form1();

                this.Hide();
                mainForm.Show();

            }
            else MessageBox.Show("Tài khoảng hoặc mật khâu sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            sent(txt_name.Text);
            sent(txt_password.Text);

            receive();


        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Close();
        }
    }
}
