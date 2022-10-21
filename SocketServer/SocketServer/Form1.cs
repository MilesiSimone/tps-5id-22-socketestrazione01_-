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
using System.Threading;

namespace SocketServer
{
    public partial class Form1 : Form
    {
        Thread t1;
        public static string data = null;

        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void button_connetti_Click(object sender, EventArgs e)
        {
            t1 = new Thread(StartListening);
            t1.Start();
        }

        public void StartListening()
        {
            byte[] bytes = new Byte[1024];
            int i = 0;

            IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 5000);

            Socket listener = new Socket(ipAddress.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);

            try
            {

                listener.Bind(localEndPoint);
                listener.Listen(10);
                
                while (true)
                {
                    label_connessione.Text = "ASPETTANDO UNA CONNESSIONE...";
                    label_connessione.ForeColor = System.Drawing.Color.Black;
                    Application.DoEvents();
                    Socket handler = listener.Accept();
                    data = null;
                    label_connessione.Text = "Connesso...";
                    label_connessione.ForeColor = System.Drawing.Color.Green;
                    Application.DoEvents();
 
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

                    data = data.Remove(data.Length - 5);

                    label_ric.Text = data;

                    label_num.Text = i.ToString();

                    label_invio.Text = "Numero Inviato al client.";
 
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
