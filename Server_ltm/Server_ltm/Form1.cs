using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net.PeerToPeer;
using SimpleTCP;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.SqlTypes;
using System.Xml.Serialization;
using System.Runtime.Remoting.Contexts;

namespace Server_ltm
{
    public partial class Form1 : Form
    {
        IPEndPoint ip;
        Socket sever ;
        List<Socket> client_list;
        List<string> data_client = new List<string>();
        string str_chose;

        List<string> clinet_online = new List<string>();

        string str_connect = @"Data Source=LAPTOP-3H9V4GA9\SQLEXPRESS;Initial Catalog=data_server;Integrated Security=True";

        void connect_client()
        {
            client_list = new List<Socket>();
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse("192.168.2.170"), 8082);

             sever = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            sever.Bind(ip);

            Thread lisiten = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        sever.Listen(100);
                        Socket client = sever.Accept();
                        client_list.Add(client);

                        Thread Receive = new Thread(receive_client);
                        Receive.IsBackground = true;
                        Receive.Start(client);
                    }
                }
                catch
                {
                    ip = new IPEndPoint(IPAddress.Any, 0);
                    sever = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }

            });

            lisiten.IsBackground = true;
            lisiten.Start();



        }
        void connect_login()
        {
            //client_list = new List<Socket>();

            client_list = new List<Socket>();
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse("192.168.2.223"), 8081);

            sever = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            sever.Bind(ip);

            Thread lisiten = new Thread(() =>
            {
                
                try
                {
                    while (true)
                    {

                        sever.Listen(100);
                        Socket client = sever.Accept();
                        client_list.Add(client);


                        Thread Receive = new Thread(receive_login);
                        Receive.IsBackground = true;
                        Receive.Start(client);
                    }
                }
                catch
                {
                    //ip = new IPEndPoint(IPAddress.Any, 0);
                    sever = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }

            });

            lisiten.IsBackground = true;
            lisiten.Start();
            
          //  connectDone.Set();
        }

        void connect_sign()
        {
            client_list = new List<Socket>();
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse("192.168.2.223"), 8080);

            sever = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            sever.Bind(ip);


            //sever.Accept(client_list);
            Thread lisiten = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        sever.Listen(100);
                        Socket client = sever.Accept();
                        client_list.Add(client);

                        Thread Receive = new Thread(receive_sign);
                        Receive.IsBackground = true;
                        Receive.Start(client);
                    }
                }
                catch
                {
                    //ip = new IPEndPoint(IPAddress.Any, 0);
                    sever = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }

            });

            lisiten.IsBackground = true;
            lisiten.Start();

           // connectDone.Set();
           
        }
        void close()
        {
            sever.Close();
        }

        void receive_sign(object obj)
        {
            Socket client = obj as Socket;

            //sever = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            //sever.Bind(ip);


            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = (string)Deser(data);
                    string[] client_data = message.Split(',');

                    if (client_data[0] == "")
                        MessageBox.Show("Enter the Username");
                    else if (client_data[2] == "")
                        MessageBox.Show("Enter the Password");
                    else if (client_data[1] == "")
                        MessageBox.Show("Enter the Email");
                    else if (client_data[3] == "")
                        MessageBox.Show("Enter the Birth");
                    else
                    {
                        try
                        {
                            SqlConnection sql_connection = new SqlConnection(str_connect);
                            //sql_connection.Open();

                            SqlCommand sqlCommand = new SqlCommand("INSERT INTO users VALUES('11', @name, @email, '12/03/2003', @password)", sql_connection);

                            //sqlCommand.CommandText = "INSERT INTO users VALUES('1', '@name', @email, @birth, @password)";
                            sqlCommand.Parameters.AddWithValue("@name", client_data[0]);
                            sqlCommand.Parameters.AddWithValue("@password", client_data[2]);
                            sqlCommand.Parameters.AddWithValue("@birth", client_data[3]);
                            sqlCommand.Parameters.AddWithValue("@email", client_data[1]);

                            SqlDataAdapter data1 = new SqlDataAdapter(sqlCommand);
                            DataTable dataTable = new DataTable();
                            data1.Fill(dataTable);
                            
                            
                            int check_ketqua = sqlCommand.ExecuteNonQuery();
                            if (check_ketqua > 0)
                            {
                                MessageBox.Show("Đã thêm dữ liệu ", "Thông báo", MessageBoxButtons.OK);
                                
                            }
                            else MessageBox.Show("Thêm dữ liệu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);


                            if (dataTable.Rows.Count > 0)
                            {
                                MessageBox.Show("ok");
                            }
                            else MessageBox.Show("no");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(" " + ex);
                        }
                    }
                }
            }
            catch
            {
                //client_list.Remove(client);
                //.client.Close();
                MessageBox.Show("ko");
            }
        }

        void receive_client(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                int i = 0;
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    string message = (string)Deser(data);
                    str_chose = message;
                }
            }
            catch (Exception ex) { }
        }
        void receive_login(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                int i = 0;
                while ( true )
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    string message = (string)Deser(data);

                    data_client.Add(message);

                    if (i == 0)
                        data_client[0] = (message);
                    else data_client[1] = (message);

                    i++;
                    if (i > 1)
                    {                                       
                        SqlConnection sql_connection = new SqlConnection(str_connect);

                        SqlCommand sqlCommand = new SqlCommand("Select * from users where username = @username and password_user = @password", sql_connection);
                        sqlCommand.Parameters.AddWithValue("@username", data_client[0]);
                        sqlCommand.Parameters.AddWithValue("@password", data_client[1]);
                        SqlDataAdapter data1 = new SqlDataAdapter(sqlCommand);
                        DataTable dataTable = new DataTable();
                        data1.Fill(dataTable);

                     
                        
                        if (dataTable.Rows.Count > 0)   
                            client.Send(Ser("ok"));
                        else
                            client.Send(Ser("ko"));

                        i = 0;
                    }
                }
            }
            catch
            {
                //client_list.Remove(client);
                //client.Close();
            } 
        }

        
        byte[] Ser(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }

        object Deser(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }

        static ManualResetEvent connectDone = new ManualResetEvent(false);
        public Form1()
        {
            InitializeComponent();
            /*
            CheckForIllegalCrossThreadCalls = false;
            //SqlConnection sql_connection = new SqlConnection(str_connect);
            
            Thread t = new Thread(() => {
                /*IPEndPoint ip1 = new IPEndPoint(IPAddress.Parse("192.168.2.170"), 8081);

                Socket sever1 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

                sever1.Bind(ip1);

                sever1.Listen(100);

                sever1.Accept();*/
            /*
                connect_login();
            });
            t.IsBackground = true;
            t.Start();

            Thread t1 = new Thread(() => {
                IPEndPoint ip = new IPEndPoint(IPAddress.Parse("192.168.2.170"), 8080);

                sever = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

                sever.Bind(ip);

                sever.Listen(100);
                
                sever.Accept(); 

                connect_sign();
            });
            t1.IsBackground = true;
            t1.Start();

            
           
            connect_sign();  */


            //chat
            //CheckForIllegalCrossThreadCalls = false;
            //Thread a = new Thread(connect_chat);
            //Thread v = new Thread(connect_user_online);
            //Thread d = new Thread(connect_login);
            //Thread e = new Thread(connect_sign);
            /*
            Thread lisiten = new Thread(() =>
            {

                Thread a = new Thread(connect_chat);
                Thread v = new Thread(connect_user_online);
                Thread d = new Thread(connect_login);
                Thread e = new Thread(connect_sign);

                a.IsBackground = true;
                a.Start();

                v.IsBackground = true;
                v.Start();

                d.IsBackground = true;
                d.Start();

                e.IsBackground = true;
                e.Start();
            });
            lisiten.IsBackground = true;
            lisiten.Start();*/
            ThreadPool.QueueUserWorkItem(state =>
            {
                // Xử lý kết nối trong luồng ThreadPool
                connect_login();
                connect_sign();
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //Chat room

        void connect_chat()
        {
            client_list = new List<Socket>();
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse("192.168.0.28"), 8082);
            sever = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            sever.Bind(ip);

            Thread lisiten = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        sever.Listen(100);
                        Socket client = sever.Accept();
                        client_list.Add(client);

                        Thread Receive = new Thread(receive_chat);
                        Receive.IsBackground = true;
                        Receive.Start(client);
                    }
                }
                catch
                {
                    ip = new IPEndPoint(IPAddress.Any, 0);
                    sever = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }

            });

            lisiten.IsBackground = true;
            lisiten.Start();
        }


        void receive_chat(object obj)
        {
            Socket client = obj as Socket;

            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = (string)Deser(data);

                    foreach (Socket iteam in client_list)
                    {
                        if (iteam != null && iteam != client)
                            iteam.Send(Ser(message));
                    }

                    lv_message.Items.Add(new ListViewItem() { Text = message });

                }
            }
            catch
            {
                client_list.Remove(client);
                client.Close();
            }
        }

        //User online
        void connect_user_online()
        {
            client_list = new List<Socket>();
            ip = new IPEndPoint(IPAddress.Parse("192.168.0.28"), 8083);
            sever = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            sever.Bind(ip);

            Thread lisiten = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        sever.Listen(100);
                        Socket client = sever.Accept();
                        client_list.Add(client);

                        Thread Receive = new Thread(receive_user_online);
                        Receive.IsBackground = true;
                        Receive.Start(client);
                    }
                }
                catch
                {
                    ip = new IPEndPoint(IPAddress.Any, 0);
                    sever = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }

            });

            lisiten.IsBackground = true;
            lisiten.Start();
        }

        void receive_user_online(object obj)
        {
            Socket client = obj as Socket;

            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = (string)Deser(data);
                    clinet_online.Add(message);

                    foreach (Socket iteam in client_list)
                    {
                        foreach (string iteam1 in clinet_online)
                        {
                                iteam.Send(Ser(iteam1));
                        }
                    }

                    lv_message.Items.Add(new ListViewItem() { Text = message });

                }
            }
            catch
            {
                client_list.Remove(client);
                client.Close();
            }
        }
    }
}
