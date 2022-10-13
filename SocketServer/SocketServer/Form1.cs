using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.CodeDom.Compiler;

namespace SocketServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_connetti_Click(object sender, EventArgs e)
        {
            StartListening();
        }

        public static string data = null;

        public void StartListening()
        {
            
            // Data buffer for incoming data.  
            byte[] bytes = new Byte[1024];
            int i = 0;

            // Establish the local endpoint for the socket.  
            // Dns.GetHostName returns the name of the   
            // host running the application.  
            IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 5000);

            // Create a TCP/IP socket.  
            Socket listener = new Socket(ipAddress.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);

            // Bind the socket to the local endpoint and   
            // listen for incoming connections.  
            try
            {

                listener.Bind(localEndPoint);
                listener.Listen(10);

                // Start listening for connections.  
                while (true)
                {
                    label_connessione.Text = ("ASPETTANDO UNA CONNESSIONE...");
                    // Program is suspended while waiting for an incoming connection.  

                    Socket handler = listener.Accept();
                    data = null;
                    label_connessione.Text = ("Connesso...");
                    // An incoming connection needs to be processed.  
                    while (true)
                    {
                        int bytesRec = handler.Receive(bytes);
                        data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                        if (data.IndexOf("<EOF>") > -1)
                        {
                            break;
                        }
                    }
                    i = Genera_Numero();

                    // Show the data on the console.  
                    label_ric.Text = (data);

                    label_num.Text = (i.ToString());

                    label_invio.Text = ("Numero Inviato al client.");

                    // Echo the data back to the client.  
                    byte[] msg = Encoding.ASCII.GetBytes(i.ToString());

                    handler.Send(msg);
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            MessageBox.Show("Press to continue...");

        }

        public int Genera_Numero()
        {
            Random random = new Random();
            int n = random.Next(1, 1000);
            return n;
        }

    }
}
