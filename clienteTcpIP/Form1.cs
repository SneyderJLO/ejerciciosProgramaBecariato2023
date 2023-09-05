using System.Net;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace clienteTcpIP

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            clienteIPV6();
        }
        private void clienteIPv4()
        {
            Int32 puerto = 15479;
            TcpClient tcpClient = new TcpClient("192.168.1.107", puerto);
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(txtMensaje.Text);
            NetworkStream cadena = tcpClient.GetStream();
            cadena.Write(data, 0, data.Length);
            mostrarMensaje("Data enviada : " + txtMensaje.Text);
            data = new Byte[256];
            string respuesta = null;
            Int32 bytes = cadena.Read(data, 0, data.Length);
            respuesta = System.Text.Encoding.ASCII.GetString(data, 0, bytes);

            mostrarMensaje("Data recibida : " + respuesta);
            cadena.Close();
            tcpClient.Close();
        }
        private void clienteIPV6()
        {
            IPAddress direccion = IPAddress.Parse("fe80::ba4d:5a50:7633:bd6c");
            IPEndPoint endPointSrv = new IPEndPoint(
                direccion, 55774
                );
            Socket tcpSocket = new Socket(direccion.AddressFamily,
                SocketType.Stream,
                ProtocolType.Tcp
                );

            try
            {

                tcpSocket.Connect(endPointSrv);
                StreamWriter writer = null;
                StreamReader reader = null;
                NetworkStream netStream = new NetworkStream(tcpSocket);
                writer = new StreamWriter(netStream);
                string mensajeCliente = txtMensaje.Text;
                writer.WriteLine(mensajeCliente);
                writer.Flush();
                mostrarMensaje("cliente envió mensaje: " + mensajeCliente);
                reader = new StreamReader(netStream);
                string mensajeServer = reader.ReadLine();
                reader.Close();
                writer.Close();
                tcpSocket.Close();
                mostrarMensaje("cliente recibe mensaje: " + mensajeServer);

            }
            catch (SocketException ex)
            {
                mostrarMensaje("error socket: " + ex.Message.ToString());

            }
            catch (Exception ex)
            {
                mostrarMensaje("error: " + ex.Message.ToString());

            }

        }
        private void mostrarMensaje(string msg)
        {
            rtbSalida.SelectionStart = rtbSalida.Text.Length;
            rtbSalida.SelectedText = msg + "\n\r";
        }
    }
}