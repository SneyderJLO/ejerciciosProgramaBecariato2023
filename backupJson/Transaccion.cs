using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backupJson
{
    public class Transaccion
    {
        public int idTransaccion { get; set; }
        public int idTarjeta { get; set; }
        public int idProducto { get; set; }
        public DateTime fecha { get; set; }
        public string producto { get; set; }
        public decimal valor { get; set; }
    }
}
