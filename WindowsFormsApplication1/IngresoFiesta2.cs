using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Entidades;
using Controladora;

namespace WindowsFormsApplication1
{
    public partial class IngresoFiesta2 : Form
    {
        ControladoraEntradas ControladoraEntradas = new ControladoraEntradas();
        Fiesta fiesta;
    

     
        public Fiesta Fiesta
        {
            get { return fiesta; }
            set { fiesta = value; }
        }

        public IngresoFiesta2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IngresoFiesta2_Load(object sender, EventArgs e)
        {
            try
            {
                txtdisponibles.Text = ControladoraEntradas.CantEntradasDisponibles(fiesta.Id).ToString();
                txtusadas.Text= ControladoraEntradas.CantEntradasUsadas(fiesta.Id).ToString();
                txttotal.Text = (ControladoraEntradas.CantEntradasUsadas(fiesta.Id) + ControladoraEntradas.CantEntradasDisponibles(fiesta.Id)).ToString();
                label1.Text = "Fiesta: " + fiesta.Colegios + "";
                lblCursos.Text = "Cursos: " + fiesta.Cursos + "";
                lblFecha.Text = "Fecha: " + fiesta.Fecha + "";
                dataGridView1.DataSource = ControladoraEntradas.TraerEntradasxFiesta(fiesta.Id);
                dataGridView1.Columns["FiestaID1"].Visible = false;
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["USADA"].Visible = false;
                dataGridView1.Columns["fechaventa"].Visible = false;
                dataGridView1.Columns[0].HeaderText = "Numero";
                dataGridView1.Columns[1].HeaderText = "Nombre";
                dataGridView1.Columns[2].HeaderText = "Apellido";
                dataGridView1.Columns[4].HeaderText = "Nombre de Fiesta";
               
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToInt32(row.Cells[6].Value) == 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.Green;
                    }
                    if (Convert.ToInt32(row.Cells[6].Value) == 1)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                    if (Convert.ToInt32(row.Cells[6].Value) == 2)
                    {
                        row.DefaultCellStyle.BackColor = Color.SlateGray;
                    }
                }

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
                List<Entrada> lista;
                if (radioButton1.Checked == true)
                {
                    if (textBox1.TextLength != 0)
                    {
                        lista = ControladoraEntradas.TraerEntradasxFiestaxDNI(fiesta.Id, Convert.ToInt32(textBox1.Text));
                        dataGridView1.DataSource = lista;
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (Convert.ToInt32(row.Cells[6].Value) == 0)
                            {
                                row.DefaultCellStyle.BackColor = Color.Green;
                            }
                            if (Convert.ToInt32(row.Cells[6].Value) == 1)
                            {
                                row.DefaultCellStyle.BackColor = Color.Red;
                            }
                            if (Convert.ToInt32(row.Cells[6].Value) == 2)
                            {
                                row.DefaultCellStyle.BackColor = Color.SlateGray;
                            }
                        }
                    }
                    else
                        MessageBox.Show("Por favor ingresar un número de DNI");
                }
                if (radioButton2.Checked == true)
                {
                    lista = ControladoraEntradas.TraerEntradasxFiestaxApellido(fiesta.Id, textBox1.Text);
                    dataGridView1.DataSource = lista;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (Convert.ToInt32(row.Cells[6].Value) == 0)
                        {
                            row.DefaultCellStyle.BackColor = Color.Green;
                        }
                        if (Convert.ToInt32(row.Cells[6].Value) == 1)
                        {
                            row.DefaultCellStyle.BackColor = Color.Red;
                        }
                        if (Convert.ToInt32(row.Cells[6].Value) == 2)
                        {
                            row.DefaultCellStyle.BackColor = Color.SlateGray;
                        }
                    }
                }
                if (radioButton3.Checked == true)
                {
                    if (textBox1.TextLength != 0)
                    {
                        lista = ControladoraEntradas.TraerEntradasxFiestaxNum(fiesta.Id, Convert.ToInt32(textBox1.Text));
                        dataGridView1.DataSource = lista;
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (Convert.ToInt32(row.Cells[6].Value) == 0)
                            {
                                row.DefaultCellStyle.BackColor = Color.Green;
                            }
                            if (Convert.ToInt32(row.Cells[6].Value) == 1)
                            {
                                row.DefaultCellStyle.BackColor = Color.Red;
                            }
                            if (Convert.ToInt32(row.Cells[6].Value) == 2)
                            {
                                row.DefaultCellStyle.BackColor = Color.SlateGray;
                            }
                        }
                    }
                    else
                        MessageBox.Show("Por favor ingresar un número de Entrada");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int idEntrada = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                Entrada oEntrada = ControladoraEntradas.TraerEntradaFiestaxID(idEntrada);
                if (oEntrada.USADA == 0)
                {
                    IngresoFiesta3 form = new IngresoFiesta3();
                    form.IdEntrada = idEntrada;
                    form.FormClosed += new System.Windows.Forms.FormClosedEventHandler(IngresoFiesta2_Load);
                    form.Show();
                }
                if (oEntrada.USADA == 1)
                {
                    MessageBox.Show("La entrada número " + oEntrada.NRO + " con el DNI " + oEntrada.DNI + " ya fué utilizada");
                }
                if (oEntrada.USADA == 2)
                {
                    MessageBox.Show("La entrada número " + oEntrada.NRO + " con el DNI " + oEntrada.DNI + " fué ANULADA");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
