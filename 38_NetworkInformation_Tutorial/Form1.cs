using System.Net;
using System.Net.NetworkInformation;
namespace _38_NetworkInformation_Tutorial
{
    public partial class Form1 : Form
    {
        private NetworkInterface[] networkInterfaces;
        private NetworkInterface networkInterfaceActual;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NetworkChange.NetworkAddressChanged += NetworkChange_NetworkAddressChanged;
            NetworkChange.NetworkAvailabilityChanged += NetworkChange_NetworkAvailabilityChanged;
            networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            actualizaDisponible(NetworkInterface.GetIsNetworkAvailable());
            actualizarInformacionRed();
        }

        private void actualizaDisponible(bool bDisponible)
        {
            if (bDisponible)
            {

                lblDisponibilidadRed.Text = "Por lo menos una interfaz de red está disponible";

            }
            else
            {
                lblDisponibilidadRed.Text = "No hay red disponible.";
            }
        }

        private void actualizarInformacionRed()
        {
            networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            cmbRed.Items.Clear();
            foreach (var item in networkInterfaces)
            {
                cmbRed.Items.Add(item.Description);
            }
            if (networkInterfaces.Length == 0)
            {
                cmbRed.Items.Add("No existen NetworkInterfaces en la máquina.");

            }
            else
            {
                networkInterfaceActual = networkInterfaces[0];
                actualizaInformacionNic();
            }
            cmbRed.SelectedIndex = 0;
        }

        private void actualizaInformacionNic()
        {
            IPInterfaceProperties iPProperties = networkInterfaceActual.GetIPProperties();
            lblDnsSuffix.Text = iPProperties.DnsSuffix.ToString();
            lstDireccionesIp.Items.Clear();
            IPAddressInformationCollection anyCastInfo = iPProperties.AnycastAddresses;
            foreach (var item in anyCastInfo) insertaDireccionIP(item.Address, "AnyCast");
            UnicastIPAddressInformationCollection uniCastInfo = iPProperties.UnicastAddresses;
            foreach (var item in uniCastInfo) insertaDireccionIP(item.Address, "UniCast");
            MulticastIPAddressInformationCollection multiCastInfo = iPProperties.MulticastAddresses;
            foreach (var item in multiCastInfo) insertaDireccionIP(item.Address, "MultiCast");
            GatewayIPAddressInformationCollection gatewayCastInfo = iPProperties.GatewayAddresses;
            foreach (var item in gatewayCastInfo) insertaDireccionIP(item.Address, "MultiCast");

            IPAddressCollection direccionesIP = iPProperties.WinsServersAddresses;

            insertaDireccionesIp(direccionesIP, "WINS Server");
            direccionesIP = iPProperties.DhcpServerAddresses;
            insertaDireccionesIp(direccionesIP, "DHCP Server");
            direccionesIP = iPProperties.DnsAddresses;
            insertaDireccionesIp(direccionesIP, "DNS Server");
        }

        private void insertaDireccionesIp(IPAddressCollection direccionesIp, string tipoDireccion)
        {
            foreach (var item in direccionesIp)
            {
                insertaDireccionIP(item, tipoDireccion);
            }
        }

        private void insertaDireccionIP(IPAddress ip, string tipoDireccion)

        {
            string[] informacionLista = new string[2];
            informacionLista[0] = ip.ToString();
            informacionLista[1] = tipoDireccion;
            ListViewItem item = new ListViewItem(informacionLista);
            lstDireccionesIp.Items.Add(item);
        }
        private void NetworkChange_NetworkAvailabilityChanged(object? sender, NetworkAvailabilityEventArgs e)
        {

        }

        private void NetworkChange_NetworkAddressChanged(object? sender, EventArgs e)
        {

        }
    }
}