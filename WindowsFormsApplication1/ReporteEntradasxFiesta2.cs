﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controladora;
using Entidades;

namespace WindowsFormsApplication1
{
    public partial class ReporteEntradasxFiesta2 : Form
    {
        ControladoraEntradas ControladoraEntradas = new ControladoraEntradas();
        Fiesta fiesta;

        public Fiesta Fiesta
        {
            get { return fiesta; }
            set { fiesta = value; }
        }

        public ReporteEntradasxFiesta2()
        {
            InitializeComponent();
        }

        private void ReporteEntradasxFiesta2_Load(object sender, EventArgs e)
        {
            try
            {
                txtdisponibles.Text = ControladoraEntradas.CantEntradasDisponibles(fiesta.Id).ToString();
                txtusadas.Text = ControladoraEntradas.CantEntradasUsadas(fiesta.Id).ToString();
                txttotal.Text = (ControladoraEntradas.CantEntradasUsadas(fiesta.Id) + ControladoraEntradas.CantEntradasDisponibles(fiesta.Id)).ToString();
                label1.Text = "Fiesta: " + fiesta.Colegios + "";
                dataGridView1.DataSource = ControladoraEntradas.TraerEntradasxFiesta(fiesta.Id);
                dataGridView1.Columns["FiestaID1"].Visible = false;
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["USADA"].Visible = false;
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
                exportaraexcel(dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}