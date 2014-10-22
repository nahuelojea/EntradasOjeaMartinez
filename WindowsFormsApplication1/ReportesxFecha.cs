using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Controladora;

namespace WindowsFormsApplication1
{
    public partial class ReportesxFecha : Form
    {
        ControladoraEntradas controladora = new ControladoraEntradas();
        public ReportesxFecha()
        {
            InitializeComponent();
        }

        private void ReportesxFecha_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            exportaraexcel(dataGridView1);
        }

        public void exportaraexcel(DataGridView tabla)
        {
            if (tabla != null)
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(true);
                int IndiceColumna = 0;
                foreach (DataGridViewColumn col in tabla.Columns) // Columnas
                {
                    IndiceColumna++;
                    excel.Cells[1, IndiceColumna] = col.Name;
                }
                int IndeceFila = 0;
                foreach (DataGridViewRow row in tabla.Rows) // Filas
                {
                    IndeceFila++;
                    IndiceColumna = 0;
                    foreach (DataGridViewColumn col in tabla.Columns)
                    {
                        IndiceColumna++;
                        excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
                    }
                }
                excel.Visible = true;
            }
            else
                MessageBox.Show("No hay datos para exportar");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = controladora.TraerEntradasxfecha(dateTimePicker1.Text, dateTimePicker2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
