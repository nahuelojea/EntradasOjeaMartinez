using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controladora;
using Entidades;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;
using System.IO;
using System.Data;
using System.Reflection;


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
                lblAnuladas.Text = ControladoraEntradas.CantEntradasAnuladas(fiesta.Id).ToString();
                txtusadas.Text = ControladoraEntradas.CantEntradasUsadas(fiesta.Id).ToString();
                txttotal.Text = (ControladoraEntradas.CantEntradasUsadas(fiesta.Id) + ControladoraEntradas.CantEntradasDisponibles(fiesta.Id)).ToString();
                label1.Text = "Fiesta: " + fiesta.Colegios + "";
                List<Entrada> lista = new List<Entrada>();
                lista =ControladoraEntradas.TraerEntradasxFiesta(fiesta.Id);
                dataGridView1.DataSource = lista;
                decimal total = 0;           
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Creating iTextSharp Table from the DataTable data
                PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 30;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfTable.DefaultCell.BorderWidth = 1;

                //Adding Header row
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                    pdfTable.AddCell(cell);
                }

                //Adding DataRow
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfTable.AddCell(cell.Value.ToString());
                    }
                }

                //Exporting to PDF
                string folderPath = "C:\\PDFs\\";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                using (FileStream stream = new FileStream(folderPath + "Entradas Por Fiesta.pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A2, 20f, 20f, 20f, 20f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("d:\\Test.pdf", FileMode.Create));

            doc.Open();//Open Document to write


            Paragraph paragraph = new Paragraph("data Exported From DataGridview!");

            //Create table by setting table value

            Table t1 = new Table(2);
            DataTable dt = (DataTable)dataGridView1.DataSource;

            //Create Table Header

            Cell cid = new Cell("ID");
            Cell cname = new Cell("Name");

            t1.AddCell(cid);
            t1.AddCell(cname);

            foreach (DataGridViewRow rows in dataGridView1.Rows)
            {

                string id = dataGridView1.Rows[rows.Index].Cells["empid"].Value.ToString();
                string name = dataGridView1.Rows[rows.Index].Cells["ename"].Value.ToString();
                //Create Cells
                Cell c2 = new Cell(id);
                Cell c1 = new Cell(name);
                //Adding cells
                t1.AddCell(c1);
                t1.AddCell(c2);

            }
            doc.Add(paragraph);
            doc.Add(t1);
            doc.Close(); //Close document
            //
            MessageBox.Show("PDF Created!");
        }


    }
}
