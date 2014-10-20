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
namespace WindowsFormsApplication1
{
    public partial class CambioContraseña : Form
    {
        ControladoraUsuario controladora = new ControladoraUsuario();
        Usuario oUsuario;
        public CambioContraseña()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CambioContraseña_Load(object sender, EventArgs e)
        {
            try
            {
            listBox1.DataSource = controladora.TraerUsuarios();
            listBox1.DisplayMember = "nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            oUsuario = (Usuario)listBox1.SelectedItem;
            lbluser.Text = oUsuario.Nombre;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == textBox2.Text)
                {
                    oUsuario.Contraseña = textBox1.Text;
                    oUsuario.Nivel = Convert.ToInt32(comboBox1.Text);
                    controladora.Modificar(oUsuario);
                    MessageBox.Show("Cambio Realizado");
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                    MessageBox.Show("Las contraseñas deben ser iguales");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
