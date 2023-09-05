using System.Net;
using System.IO;
using System.Text;

namespace Cliente_FTP_Tutorial_.NET
{
    public partial class frmClienteFtp : Form
    {
        private Uri uri;
        private FtpWebRequest clienteRequest;
        private NetworkCredential credenciales;
        public frmClienteFtp()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            uri = new Uri("ftp://" + txtServidor.Text + "//");
            clienteRequest = (FtpWebRequest)WebRequest.Create(uri);
            credenciales = new NetworkCredential();
            credenciales.Domain = "TECHSOFT";
            credenciales.UserName = txtLogin.Text;
            credenciales.Password = txtPassword.Text;

            clienteRequest.Credentials = credenciales;
            clienteRequest.EnableSsl = false;
            clienteRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            clienteRequest.KeepAlive = true;
            clienteRequest.UsePassive = true;
            FtpWebResponse respuesta = (FtpWebResponse)clienteRequest.GetResponse();
            StreamReader sr = new StreamReader(respuesta.GetResponseStream(),
            Encoding.ASCII);
            string restultado = sr.ReadToEnd();
            rtbMensaje.Text = respuesta.WelcomeMessage + "\r\n" + restultado;

            respuesta.Close();

            List<Archivo> archivos = obtieneLista(restultado);
            ltvArchivo.View = View.List;
            foreach (var item in archivos)
            {
                ltvArchivo.Items.Add(item.nombre);
            }

        }

        public List<Archivo> obtieneLista(string datos)
        {

            List<Archivo> retorno = new List<Archivo>();
            try
            {
                string[] registro = datos.Split('\n', StringSplitOptions.RemoveEmptyEntries);
                string procesaItem = "", fechaStr, horaStr;
                foreach (var item in registro)
                {
                    Archivo f = new Archivo();
                    f.nombre = "..";
                    procesaItem = item.Trim();
                    fechaStr = procesaItem.Substring(0, 8);
                    procesaItem = (procesaItem.Substring(8, procesaItem.Length - 8)).Trim();
                    horaStr = procesaItem.Substring(0, 7);
                    procesaItem = (procesaItem.Substring(7, procesaItem.Length - 7)).Trim();

                    f.fecha = fechaStr + "" + horaStr;
                    if (procesaItem.Substring(0, 5) == "<DIR>")
                    {
                        f.bDirectorio = true;
                        procesaItem = (procesaItem.Substring(5, procesaItem.Length - 5)).Trim();
                    }
                    else
                    {
                        string[] strs = procesaItem.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        f.tamanio = Int64.Parse(strs[0]);
                        procesaItem = String.Join(" ", strs, 1, strs.Length - 1);
                        f.bDirectorio = false;

                    }
                    f.nombre = procesaItem;
                    if (f.nombre != "" && f.nombre != "." && f.nombre != "..")
                    {
                        retorno.Add(f);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.ToString());
            }
            return retorno;
        }

        private void btnDescarga_Click(object sender, EventArgs e)
        {
            string archivoDescarga = ltvArchivo.SelectedItems[0].Text;


            uri = new Uri("ftp://" + txtServidor.Text + "//" + archivoDescarga);
            clienteRequest = (FtpWebRequest)WebRequest.Create(uri);

            clienteRequest.Method = WebRequestMethods.Ftp.DownloadFile;
            FtpWebResponse respuesta = (FtpWebResponse)clienteRequest.GetResponse();
            Stream sr = respuesta.GetResponseStream();

            FileStream fs = new FileStream(@"C:\archivos\" + archivoDescarga,
                FileMode.Create, FileAccess.Write);
            crearArchivo(sr, fs);
        }

        private void crearArchivo(Stream origen, Stream destino)
        {
            byte[] buffer = new byte[1024];
            int bytesLeidos = origen.Read(buffer, 0, 1024);
            while (bytesLeidos != 0)

            {
                destino.Write(buffer, 0, bytesLeidos);
                bytesLeidos = origen.Read(buffer, 0, 1024);

            }
            origen.Close();
            destino.Close();
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {


            uri = new Uri("ftp://" + txtServidor.Text + "//" + txtArchivoCarga.Text);
            clienteRequest = (FtpWebRequest)WebRequest.Create(uri);

            clienteRequest.Method = WebRequestMethods.Ftp.UploadFile;
            //FtpWebResponse respuesta = (FtpWebResponse)clienteRequest.GetResponse();
            Stream destino = clienteRequest.GetRequestStream();

            FileStream origen = new FileStream(txtRuta.Text + @"\" + txtArchivoCarga.Text,
                FileMode.Open, FileAccess.Read);
            crearArchivo(origen, destino);
        }
    }


    public struct Archivo
    {
        public string nombre;
        public bool bDirectorio;
        public Int64 tamanio;
        public string fecha;

    }
}