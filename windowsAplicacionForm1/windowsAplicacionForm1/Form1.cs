using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsAplicacionForm1

{
    public partial class Form1 : Form
    {
        string rutaconexion = "Data Source =192.168.1.55; Initial Catalog = DB_PRACTICAS; User=sa; Password=123*abc*456; Persist Security Info=True";
        public Dictionary<string, string> keyValueTipoTrx = null;
        List<string> descripcionesRazon = new List<string>();
        Dictionary<int, Dictionary<string, string>> valoresTipoDescripcion = null;
        public Form1()

        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
            InitializeComponent();

        }

        private void lblComprobarTransaccion_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(rutaconexion.ToString());
            try
            {
                conexion.Open();
                MessageBox.Show("succes");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }


        }


        public Dictionary<string, string> obtenerDescripcionTipoDeTrx(SqlConnection conexion)
        {
            string query = "";
            int indexTipo = 1;


            //            keyValueTipoTrx = new Dictionary<string, string>();
            valoresTipoDescripcion = new Dictionary<int, Dictionary<string, string>>();
            query = "select id, descripcion from tipotrx;";
            try
            {
                SqlCommand command = new SqlCommand(query, conexion);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string idtipo = reader[0].ToString();
                    string descripcionTipo = reader[1].ToString();
                    keyValueTipoTrx = new Dictionary<string, string>
                    {
                        { idtipo, descripcionTipo }
                    };
                    valoresTipoDescripcion.Add(indexTipo, keyValueTipoTrx);
                    indexTipo++;

                }
                reader.Close();



            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //MessageBox.Show(keyValueTipoTrx.Count() + "");
            return keyValueTipoTrx;
        }


        public List<string> obtenerRazonesDescripcion(SqlConnection conexion)
        {
            string query = "";
            List<string> list = new List<string>();
            query = "select descripcion from razontrx;";
            try
            {
                SqlCommand command = new SqlCommand(query, conexion);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string descripcion = reader[0].ToString();
                    list.Add(descripcion.ToLower());

                }
                reader.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }

            //MessageBox.Show(keyValueTipoTrx.Count() + "");
            return list;
        }

        public List<string> obtenerRazonesDescripcion(SqlConnection conexion, string idTipo)
        {
            string query = "";
            List<string> list = new List<string>();
            query = $"select tr.descripcion from razontrx as tr inner join TRtrx as trx on (trx.id_razon = tr.id) inner join tipotrx as tip on tip.id = trx.id_tipo where tip.id = {idTipo}";
            try
            {
                SqlCommand command = new SqlCommand(query, conexion);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string descripcion = reader[0].ToString();
                        list.Add(descripcion.ToLower());

                    }
                    reader.Close();
                }
                else
                {
                    list = descripcionesRazon;

                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //MessageBox.Show(keyValueTipoTrx.Count() + "");
            return list;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //lblNombreBanco.Parent = pctCard;
            //lblNombre.Parent = pctCard;
            //lblNumero.Parent = pctCard;
            //labelfECHA.Parent = pctCard;
            //LBLvISA.Parent = pctCard;
            SqlConnection conexion = new SqlConnection(rutaconexion.ToString());
            string innerKey = "";
            try
            {
                conexion.Open();
                keyValueTipoTrx = obtenerDescripcionTipoDeTrx(conexion);
                descripcionesRazon = obtenerRazonesDescripcion(conexion);
                List<string> list = new List<string>();
                foreach (var entryExterno in valoresTipoDescripcion)
                {
                    keyValueTipoTrx = entryExterno.Value;


                    foreach (var entryInterno in keyValueTipoTrx)
                    {
                        string claveInterna = entryInterno.Key;
                        string valor = entryInterno.Value;
                        list.Add(valor.ToLower());
                        //MessageBox.Show(valor);
                    }

                }
                cmbDescripcionTipo.DataSource = list;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conexion.Close();
            }


        }
        public static long GenerarNumeroAleatorio()
        {
            Guid guid = Guid.NewGuid();
            byte[] bytes = guid.ToByteArray();
            long numeroAleatorio = BitConverter.ToInt64(bytes, 0);
            numeroAleatorio = Math.Abs(numeroAleatorio);
            numeroAleatorio %= 9000000000;
            numeroAleatorio += 1000000000000000;
            return numeroAleatorio;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long tarjeta = GenerarNumeroAleatorio();
            //txtTarjeta.Text = tarjeta.ToString();
            //lblNumero.Text = tarjeta.ToString();
            //labelfECHA.Text = DateTime.Now.Month.ToString() + " / " + DateTime.Now.Year.ToString();
            //lblNombre.Text = "neysser enewrksa";
        }

        private void cmbDescripcionTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(rutaconexion.ToString());
            string idTipo = "";
            try
            {

                conexion.Open();

                ComboBox cmb = (ComboBox)sender;
                txtTipo.Text = (string)cmb.SelectedItem.ToString().ToUpper();
                int posTipo = 1 + cmbDescripcionTipo.SelectedIndex;
                string key = "";
                var result0 = from r in valoresTipoDescripcion
                              select r.Value.First();
                // MessageBox.Show(result0.ToString());
                var result = from r in keyValueTipoTrx
                             where r.Key == "01"
                             select r.Value;
                string claveInterna = "";
                foreach (var item in valoresTipoDescripcion[posTipo])
                {
                    txtValueTipo.Text = item.Key;
                    idTipo = item.Key;
                }
                cmbDescripcionRazon.DataSource = obtenerRazonesDescripcion(conexion, idTipo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
            finally
            {
                conexion.Close();
            }

        }
        public override string ToString()
        {
            return base.ToString();

        }

        private void cmbDescripcionRazon_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            txtRazon.Text = cmb.SelectedItem.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }
    }
}