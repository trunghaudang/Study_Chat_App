using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;

namespace Design
{
    public partial class Form1 : Form
    {
        IPEndPoint ip;
        Socket client;
        public Form1()
        {
            InitializeComponent();
            //CheckForIllegalCrossThreadCalls = false;

            //connect();
        }

        void connect()
        {
            ip = new IPEndPoint(IPAddress.Parse("192.168.2.170"), 8082);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                client.Connect(ip);
            }
            catch
            {
                MessageBox.Show("Not Correct", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //client.Send(Ser("login"));
            this.Hide();
            LogIn logIn = new LogIn();
            logIn.Show();
            
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
           //client.Send(Ser("sign"));
            //client.Close();
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
            

        }

        private void btnHowtoUse_Click(object sender, EventArgs e)
        {
            this.Hide();
            HowtoUse howtoUse = new HowtoUse();
            howtoUse.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}