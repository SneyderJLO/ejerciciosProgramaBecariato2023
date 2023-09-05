
using Microsoft.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;

namespace nuevoInsertar
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            SqlConnection sc = null;
            try
            {
                scsb.DataSource = "192.168.1.55";
                scsb.UserID = "sa";
                scsb.Password = "123*456*abc";
                scsb.InitialCatalog = "DB_PRACTICAS";
                scsb.IntegratedSecurity = true;


                sc.Open();
                Console.WriteLine("conexion abierta");
                DataTable dt = new DataTable();
                dt.Columns.Add("pr_id", typeof(int));
                dt.Columns.Add("pr_fecha", typeof(DateTime));
                dt.Columns.Add("pr_comercio", typeof(int));
                dt.Columns.Add("pr_tarjeta", typeof(string));
                dt.Columns.Add("pr_valor", typeof(decimal));
                dt.Columns.Add("pr_tipotrx", typeof(string));
                dt.Columns.Add("pr_razon", typeof(string));
                dt.Columns.Add("pr_autoriza", typeof(string));
                Dictionary<int, string> tipoTrx = new Dictionary<int, string>();

                for (int i = 1; i <= 1000; i++)
                {
                    dt.Rows.Add(i);

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                sc.Close();
            }
        }
    }
}
