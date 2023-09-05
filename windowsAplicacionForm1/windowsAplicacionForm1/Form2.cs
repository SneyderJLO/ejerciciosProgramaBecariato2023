using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsAplicacionForm1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        static DataTable GenerateRandomDataTable(int numRows, int numCols)
        {
            DataTable dataTable = new DataTable();

            // Agregar columnas al DataTable
            for (int col = 0; col < numCols; col++)
            {
                dataTable.Columns.Add("Columna " + (col + 1), typeof(int));
            }

            // Generar filas con datos aleatorios
            Random random = new Random();
            for (int row = 0; row < numRows; row++)
            {
                DataRow newRow = dataTable.NewRow();
                for (int col = 0; col < numCols; col++)
                {
                    newRow[col] = random.Next(1, 101); // Generar números aleatorios entre 1 y 100
                }
                dataTable.Rows.Add(newRow);
            }

            return dataTable;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dgvtabla.DataSource = GenerateRandomDataTable(3, 3);
        }
    }
}
