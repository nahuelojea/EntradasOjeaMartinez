﻿namespace WindowsFormsApplication1
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colegiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fiestasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaDeEntradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaionDeEntradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anulacionDeEntradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoALaFiestaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasVendidasPorFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasVendidasPorFiestaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambioDeContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(806, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salonesToolStripMenuItem,
            this.colegiosToolStripMenuItem,
            this.fiestasToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // salonesToolStripMenuItem
            // 
            this.salonesToolStripMenuItem.Name = "salonesToolStripMenuItem";
            this.salonesToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.salonesToolStripMenuItem.Text = "Salones";
            this.salonesToolStripMenuItem.Click += new System.EventHandler(this.salonesToolStripMenuItem_Click);
            // 
            // colegiosToolStripMenuItem
            // 
            this.colegiosToolStripMenuItem.Name = "colegiosToolStripMenuItem";
            this.colegiosToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.colegiosToolStripMenuItem.Text = "Colegios";
            this.colegiosToolStripMenuItem.Click += new System.EventHandler(this.colegiosToolStripMenuItem_Click);
            // 
            // fiestasToolStripMenuItem
            // 
            this.fiestasToolStripMenuItem.Name = "fiestasToolStripMenuItem";
            this.fiestasToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.fiestasToolStripMenuItem.Text = "Fiestas";
            this.fiestasToolStripMenuItem.Click += new System.EventHandler(this.fiestasToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(117, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventaDeEntradasToolStripMenuItem,
            this.modificaionDeEntradasToolStripMenuItem,
            this.anulacionDeEntradasToolStripMenuItem});
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            this.ventaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.ventaToolStripMenuItem.Text = "Venta ";
            // 
            // ventaDeEntradasToolStripMenuItem
            // 
            this.ventaDeEntradasToolStripMenuItem.Name = "ventaDeEntradasToolStripMenuItem";
            this.ventaDeEntradasToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.ventaDeEntradasToolStripMenuItem.Text = "Venta de entradas";
            this.ventaDeEntradasToolStripMenuItem.Click += new System.EventHandler(this.ventaDeEntradasToolStripMenuItem_Click);
            // 
            // modificaionDeEntradasToolStripMenuItem
            // 
            this.modificaionDeEntradasToolStripMenuItem.Name = "modificaionDeEntradasToolStripMenuItem";
            this.modificaionDeEntradasToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.modificaionDeEntradasToolStripMenuItem.Text = "Modificacion de entradas";
            this.modificaionDeEntradasToolStripMenuItem.Click += new System.EventHandler(this.modificaionDeEntradasToolStripMenuItem_Click);
            // 
            // anulacionDeEntradasToolStripMenuItem
            // 
            this.anulacionDeEntradasToolStripMenuItem.Name = "anulacionDeEntradasToolStripMenuItem";
            this.anulacionDeEntradasToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.anulacionDeEntradasToolStripMenuItem.Text = "Anulacion de entradas";
            this.anulacionDeEntradasToolStripMenuItem.Click += new System.EventHandler(this.anulacionDeEntradasToolStripMenuItem_Click);
            // 
            // ingresoToolStripMenuItem
            // 
            this.ingresoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoALaFiestaToolStripMenuItem});
            this.ingresoToolStripMenuItem.Name = "ingresoToolStripMenuItem";
            this.ingresoToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ingresoToolStripMenuItem.Text = "Ingreso";
            // 
            // ingresoALaFiestaToolStripMenuItem
            // 
            this.ingresoALaFiestaToolStripMenuItem.Name = "ingresoALaFiestaToolStripMenuItem";
            this.ingresoALaFiestaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.ingresoALaFiestaToolStripMenuItem.Text = "Ingreso a la fiesta";
            this.ingresoALaFiestaToolStripMenuItem.Click += new System.EventHandler(this.ingresoALaFiestaToolStripMenuItem_Click);
            // 
            // listadosToolStripMenuItem
            // 
            this.listadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradasVendidasPorFechaToolStripMenuItem,
            this.entradasVendidasPorFiestaToolStripMenuItem});
            this.listadosToolStripMenuItem.Name = "listadosToolStripMenuItem";
            this.listadosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.listadosToolStripMenuItem.Text = "Listados";
            // 
            // entradasVendidasPorFechaToolStripMenuItem
            // 
            this.entradasVendidasPorFechaToolStripMenuItem.Name = "entradasVendidasPorFechaToolStripMenuItem";
            this.entradasVendidasPorFechaToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.entradasVendidasPorFechaToolStripMenuItem.Text = "Entradas vendidas por fecha";
            this.entradasVendidasPorFechaToolStripMenuItem.Click += new System.EventHandler(this.entradasVendidasPorFechaToolStripMenuItem_Click);
            // 
            // entradasVendidasPorFiestaToolStripMenuItem
            // 
            this.entradasVendidasPorFiestaToolStripMenuItem.Name = "entradasVendidasPorFiestaToolStripMenuItem";
            this.entradasVendidasPorFiestaToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.entradasVendidasPorFiestaToolStripMenuItem.Text = "Entradas vendidas por fiesta";
            this.entradasVendidasPorFiestaToolStripMenuItem.Click += new System.EventHandler(this.entradasVendidasPorFiestaToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambioDeContraseñaToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // cambioDeContraseñaToolStripMenuItem
            // 
            this.cambioDeContraseñaToolStripMenuItem.Name = "cambioDeContraseñaToolStripMenuItem";
            this.cambioDeContraseñaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cambioDeContraseñaToolStripMenuItem.Text = "Configuracion";
            this.cambioDeContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambioDeContraseñaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(12, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario Activo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(97, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.fondomenuprincipal1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 496);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "Eventos de Egresados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salonesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colegiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fiestasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaDeEntradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoALaFiestaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambioDeContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaionDeEntradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anulacionDeEntradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasVendidasPorFechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasVendidasPorFiestaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}