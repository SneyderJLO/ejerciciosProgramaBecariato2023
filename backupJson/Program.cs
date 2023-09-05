using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace backupJson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string connectionString = "data source=localhost; initial catalog=tarjetasCredito; user=sa; password=123*abc*456";
            string query = "SELECT * FROM transaccion;";
            try
            {
                string outputPath = @"C:\Users\usrTechsoft\source\repos\backupJson\archivosJson\salida.json";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            List<Transaccion> transacciones = new List<Transaccion>();
                            foreach (DataRow row in dataTable.Rows)
                            {
                                Transaccion transaccion = new Transaccion
                                {
                                    idTransaccion = Convert.ToInt32(row["idTransaccion"]),
                                    idTarjeta = Convert.ToInt32(row["idTarjeta"]),
                                    idProducto = Convert.ToInt32(row["idProducto"]),
                                    fecha = Convert.ToDateTime(row["fecha"]),
                                    producto = (row["producto"].ToString()),
                                    valor = Convert.ToDecimal(row["valor"])
                                };
                                transacciones.Add(transaccion);
                            }

                            string jsonResult = JsonConvert.SerializeObject(transacciones, Newtonsoft.Json.Formatting.Indented);

                            File.WriteAllText(outputPath, jsonResult);

                            Console.WriteLine("Archivo JSON guardado exitosamente.");
                        }
                    }
                }




                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex); Console.ReadLine();
            }

        }
    }
}
