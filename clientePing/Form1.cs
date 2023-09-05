using System.Configuration;
using System.Globalization;
using System.Net;
using System.Net.NetworkInformation;

namespace clientePing
{

    //programa que ejecuta >ping hostname
    public partial class Form1 : Form
    {
        Ping clientePing = new Ping();
        public Form1()
        {
            InitializeComponent();
            clientePing.PingCompleted += ClientePing_PingCompleted;
        }

        private void ClientePing_PingCompleted(object sender, PingCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                if (e.Cancelled)
                {
                    mostrarMensaje("ping cancelado");
                }
                else
                {
                    if (e.Reply.Status == IPStatus.Success)
                    {
                        mostrarMensaje
                            (" " + e.Reply.Address.ToString()
                            + e.Reply.RoundtripTime.ToString(
                                NumberFormatInfo.CurrentInfo) + "ms");

                    }
                    else
                    {
                        mostrarMensaje(" " + obtenerStatus(e.Reply.Status));
                    }
                }
            }
            else
            {
                mostrarMensaje("Ocurrio un error al hacer el ping" + e.Error.InnerException.Message);
            }
        }

        private string obtenerStatus(IPStatus status)
        {
            string statusReturn = "";
            switch (status)
            {
                case IPStatus.Unknown:
                    break;
                case IPStatus.Success:
                    break;
                case IPStatus.DestinationNetworkUnreachable:
                    break;
                case IPStatus.DestinationHostUnreachable:
                    break;
                case IPStatus.DestinationProhibited:
                    break;

                case IPStatus.DestinationPortUnreachable:
                    statusReturn = "DestinationPortUnreachable";
                    break;
                case IPStatus.NoResources:
                    break;
                case IPStatus.BadOption:
                    break;
                case IPStatus.HardwareError:
                    break;
                case IPStatus.PacketTooBig:
                    break;
                case IPStatus.TimedOut:
                    break;
                case IPStatus.BadRoute:
                    break;
                case IPStatus.TtlExpired:
                    break;
                case IPStatus.TtlReassemblyTimeExceeded:
                    break;
                case IPStatus.ParameterProblem:
                    break;
                case IPStatus.SourceQuench:
                    break;
                case IPStatus.BadDestination:
                    break;
                case IPStatus.DestinationUnreachable:
                    break;
                case IPStatus.TimeExceeded:
                    break;
                case IPStatus.BadHeader:
                    break;
                case IPStatus.UnrecognizedNextHeader:
                    break;
                case IPStatus.IcmpError:
                    break;
                case IPStatus.DestinationScopeMismatch:
                    break;
                default:
                    statusReturn = "Fallo ping";
                    break;
            }
            return statusReturn;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //IPHostEntry resolverNombreServidor = Dns.GetHostEntry(
            //    txtMensaje.Text);
            clientePing.SendAsync(txtMensaje.Text, null);
        }

        private void mostrarMensaje(string msg)
        {
            rtbMensaje.SelectionStart = rtbMensaje.Text.Length;
            rtbMensaje.SelectedText = msg + "\n\r";

        }
    }
}