using System.Net;

using System.Threading;
using System.Net.Sockets;
using System.Windows.Forms;
using System.IO;
namespace tcpIP
{
    public partial class frmServidor : Form
    {
        delegate void delegadoRichTextBox(RichTextBox richTextBox, string msg);
        private delegadoRichTextBox delegadoValor;
        private StreamReader reader = null;
        private StreamWriter writer = null;
        private TcpListener servidor = null;
        private Socket clienteSocket = null;
        private Socket servidorSocket = null;
        public frmServidor()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            delegadoValor = new delegadoRichTextBox(valorRichTexto);
            Thread th = new Thread(inicioServidorIPV6);
            th.Start();
        }

        private void valorRichTexto(RichTextBox richTextBox, string value)
        {
            richTextBox.SelectionStart = rtbServidor.Text.Length;
            richTextBox.SelectedText = value + "" + "\n";
        }

        private void Servidor()
        {
            try
            {
                Int32 puerto = 15479;
                IPAddress direccionIP = IPAddress.Parse("192.168.1.107");

                servidor = new TcpListener(direccionIP, puerto);

                servidor.Start();
                while (true)
                {

                    mostrarMensaje("wait to conecction TCP/IP");
                    TcpClient client = servidor.AcceptTcpClient();
                    mostrarMensaje("conected");
                    NetworkStream cadena = client.GetStream(); //obtener informacion que envía el cliente
                    int i;
                    Byte[] bytes = new Byte[256];
                    string data = null;
                    while ((i = cadena.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                        mostrarMensaje("data obtenida: " + data);

                        data = data.ToUpper();
                        byte[] msj = System.Text.Encoding.ASCII.GetBytes(data);
                        cadena.Write(msj, 0, msj.Length);
                        mostrarMensaje("Data enviada: " + data);

                    }
                    client.Close();
                }
            }
            catch (SocketException e)
            {
                mostrarMensaje("error de socker: " + e.ToString());

            }
            catch (Exception e)
            {
                mostrarMensaje("error: " + e.ToString());
            }


        }

        private void inicioServidorIPV6()
        {
            IPAddress dirIP = IPAddress.Parse("fe80::ba4d:5a50:7633:bd6c");
            IPEndPoint endPoint = new IPEndPoint(dirIP, 55774);

            servidorSocket = new Socket(AddressFamily.InterNetworkV6,
                SocketType.Stream,
                ProtocolType.Tcp);

            try
            {

                //obtiene el puerto y la ip sobre la cual se escucha
                servidorSocket.Bind(endPoint);
                servidorSocket.Listen(int.MaxValue);
                mostrarMensaje("Servidor iniciado.");

                mostrarMensaje("Escuchando en: " + endPoint.Address.ToString());
                while (true)
                {
                    clienteSocket = servidorSocket.Accept();
                    mostrarMensaje("Conexion acepetada desde: " + clienteSocket.RemoteEndPoint.ToString());

                    NetworkStream netStream = new NetworkStream(clienteSocket);
                    reader = new StreamReader(netStream);
                    string datosCliente = reader.ReadLine();
                    mostrarMensaje("Mensaje cliente: " + datosCliente);

                    writer = new StreamWriter(netStream);
                    string mensajeServidor = "Hola cliente";
                    writer.WriteLine(mensajeServidor);
                    writer.Flush();
                    mostrarMensaje("servidor envió: " + mensajeServidor);
                    if (datosCliente == "fin")
                    {
                        break;
                    }
                }

            }
            catch (SocketException ex)
            {
                if (ex.ErrorCode == 10004)
                    mostrarMensaje("El server estaba esperando un client.");
                else
                    mostrarMensaje(ex.ToString());
            }
            catch (Exception ex)
            {

                mostrarMensaje(ex.Message.ToString());
            }
        }
        private void mostrarMensaje(string msg)
        {
            this.Invoke(delegadoValor, new object[]
           {
                rtbServidor, msg
           });
            //rtbServidor.SelectionStart = rtbServidor.Text.Length;
            //rtbServidor.SelectedText = msg + "\n\r";
        }

        private void frmServidor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (servidorSocket != null)
            {

                servidorSocket.Close();
            }
        }

        private void bntDetener_Click(object sender, EventArgs e)
        {
            if (reader != null) reader.Close();
            if (writer != null) writer.Close();
            if (servidorSocket != null) servidorSocket.Close();
        }
    }
}