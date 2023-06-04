namespace Files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            server.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }
    }
}