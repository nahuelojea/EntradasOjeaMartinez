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
            try
            {
                exportaraexcel(dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void exportaraexcel(DataGridView tabla)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                List<Entrada> lista = new List<Entrada>();
                lista = controladora.TraerEntradasxfecha(dateTimePicker1.Text, dateTimePicker2.Text);
                dataGridView1.DataSource = lista;
                decimal total = 0;                          
                lblCant.Text = lista.Count().ToString();
                foreach (Entrada aux in lista)
                {
                    total = total + aux.Precio;
                }
                lbltotal.Text = total.ToString();
                dataGridView1.Columns["FiestaID1"].Visible = false;
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["USADA"].Visible = false;
                dataGridView1.Columns[0].HeaderText = "Numero";
                dataGridView1.Columns[1].HeaderText = "Nombre";
                dataGridView1.Columns[2].HeaderText = "Apellido";
                dataGridView1.Columns[4].HeaderText = "Nombre de Fiesta";
                dataGridView1.Columns[9].HeaderText = "Fecha de Venta";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


    }
}
