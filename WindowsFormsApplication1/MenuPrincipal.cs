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
    public partial class MenuPrincipal : Form
    {
        ControladoraUsuario ControladoraUsuario = new ControladoraUsuario();
        Usuario oUsuario;

        public Usuario OUsuario
        {
            get { return oUsuario; }
            set { oUsuario = value; }
        }

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void formFactura_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Impedir que el formulario se cierre pulsando X o Alt + F4 
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (oUsuario.Nivel == 2)
            {
                ABMSalones form = new ABMSalones();
                form.Show();
            }
            else
                MessageBox.Show("Usted no tiene acceso a esta parte del sistema");
        }

        private void fiestasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (oUsuario.Nivel == 2)
            {
            MenuFiestas form = new MenuFiestas();
            form.Show();
            }
            else
                MessageBox.Show("Usted no tiene acceso a esta parte del sistema");
        }

        private void ventaDeEntradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentaEntrada1N form = new VentaEntrada1N();
            form.Show();
        }

        private void ingresoALaFiestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
             if (oUsuario.Nivel == 2)
            {
            IngresoFiesta1 form = new IngresoFiesta1();
            form.Show();
            }
             else
                 MessageBox.Show("Usted no tiene acceso a esta parte del sistema");
        }

        private void modificaionDeEntradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarEntrada form = new ModificarEntrada();
            form.Show();
        }

        private void colegiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
              if (oUsuario.Nivel == 2)
            {
            ABMColegios form = new ABMColegios();
            form.Show();
            }
              else
                  MessageBox.Show("Usted no tiene acceso a esta parte del sistema");
        }

        private void anulacionDeEntradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (oUsuario.Nivel == 2)
            {
                AnularEntrada1 form = new AnularEntrada1();
                form.Show();
            }
            else
                MessageBox.Show("Usted no tiene acceso a esta parte del sistema");
        }

        private void cambioDeContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (oUsuario.Nivel == 2)
            {
                CambioContraseña form = new CambioContraseña();
                form.Show();
            }
            else
                MessageBox.Show("Usted no tiene acceso a esta parte del sistema");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void entradasVendidasPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (oUsuario.Nivel == 2)
            {
                ReportesxFecha form = new ReportesxFecha();
                form.Show();
            }
            else
                MessageBox.Show("Usted no tiene acceso a esta parte del sistema");
        }

        private void entradasVendidasPorFiestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (oUsuario.Nivel == 2)
            {
                ReporteEntradasxFiesta form = new ReporteEntradasxFiesta();
                form.Show();
            }
            else
                MessageBox.Show("Usted no tiene acceso a esta parte del sistema");
        }
    }
}
