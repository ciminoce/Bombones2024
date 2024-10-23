namespace Bombones.Windows
{
    partial class frmNuevoMenuPrincipal
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
            BarraMenu = new ToolStrip();
            tsbArchivos = new ToolStripDropDownButton();
            rellenosToolStripMenuItem = new ToolStripMenuItem();
            nuecesToolStripMenuItem = new ToolStripMenuItem();
            chocolatesToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            paísesToolStripMenuItem = new ToolStripMenuItem();
            estadosToolStripMenuItem = new ToolStripMenuItem();
            ciudadesToolStripMenuItem = new ToolStripMenuItem();
            tsbClientes = new ToolStripButton();
            tsbProductos = new ToolStripDropDownButton();
            bombonesToolStripMenuItem = new ToolStripMenuItem();
            cajasToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbVentas = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            tsbUsuarios = new ToolStripButton();
            tsbEmpleados = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            tsbSalir = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblUsuario = new ToolStripStatusLabel();
            BarraMenu.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // BarraMenu
            // 
            BarraMenu.Items.AddRange(new ToolStripItem[] { tsbArchivos, tsbClientes, tsbProductos, toolStripSeparator2, tsbVentas, toolStripSeparator3, tsbUsuarios, tsbEmpleados, toolStripSeparator4, tsbSalir });
            BarraMenu.Location = new Point(0, 0);
            BarraMenu.Name = "BarraMenu";
            BarraMenu.Size = new Size(800, 70);
            BarraMenu.TabIndex = 1;
            BarraMenu.Text = "toolStrip1";
            // 
            // tsbArchivos
            // 
            tsbArchivos.DropDownItems.AddRange(new ToolStripItem[] { rellenosToolStripMenuItem, nuecesToolStripMenuItem, chocolatesToolStripMenuItem, toolStripSeparator1, paísesToolStripMenuItem, estadosToolStripMenuItem, ciudadesToolStripMenuItem });
            tsbArchivos.Image = Properties.Resources.Files;
            tsbArchivos.ImageScaling = ToolStripItemImageScaling.None;
            tsbArchivos.ImageTransparentColor = Color.Magenta;
            tsbArchivos.Name = "tsbArchivos";
            tsbArchivos.Size = new Size(66, 67);
            tsbArchivos.Text = "Archivos";
            tsbArchivos.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // rellenosToolStripMenuItem
            // 
            rellenosToolStripMenuItem.Name = "rellenosToolStripMenuItem";
            rellenosToolStripMenuItem.Size = new Size(133, 22);
            rellenosToolStripMenuItem.Text = "Rellenos";
            rellenosToolStripMenuItem.Click += rellenosToolStripMenuItem_Click;
            // 
            // nuecesToolStripMenuItem
            // 
            nuecesToolStripMenuItem.Name = "nuecesToolStripMenuItem";
            nuecesToolStripMenuItem.Size = new Size(133, 22);
            nuecesToolStripMenuItem.Text = "Nueces";
            nuecesToolStripMenuItem.Click += nuecesToolStripMenuItem_Click;
            // 
            // chocolatesToolStripMenuItem
            // 
            chocolatesToolStripMenuItem.Name = "chocolatesToolStripMenuItem";
            chocolatesToolStripMenuItem.Size = new Size(133, 22);
            chocolatesToolStripMenuItem.Text = "Chocolates";
            chocolatesToolStripMenuItem.Click += chocolatesToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(130, 6);
            // 
            // paísesToolStripMenuItem
            // 
            paísesToolStripMenuItem.Name = "paísesToolStripMenuItem";
            paísesToolStripMenuItem.Size = new Size(133, 22);
            paísesToolStripMenuItem.Text = "Países";
            paísesToolStripMenuItem.Click += paísesToolStripMenuItem_Click;
            // 
            // estadosToolStripMenuItem
            // 
            estadosToolStripMenuItem.Name = "estadosToolStripMenuItem";
            estadosToolStripMenuItem.Size = new Size(133, 22);
            estadosToolStripMenuItem.Text = "Estados";
            estadosToolStripMenuItem.Click += estadosToolStripMenuItem_Click;
            // 
            // ciudadesToolStripMenuItem
            // 
            ciudadesToolStripMenuItem.Name = "ciudadesToolStripMenuItem";
            ciudadesToolStripMenuItem.Size = new Size(133, 22);
            ciudadesToolStripMenuItem.Text = "Ciudades";
            ciudadesToolStripMenuItem.Click += ciudadesToolStripMenuItem_Click;
            // 
            // tsbClientes
            // 
            tsbClientes.Image = Properties.Resources.Clientes;
            tsbClientes.ImageScaling = ToolStripItemImageScaling.None;
            tsbClientes.ImageTransparentColor = Color.Magenta;
            tsbClientes.Name = "tsbClientes";
            tsbClientes.Size = new Size(53, 67);
            tsbClientes.Text = "Clientes";
            tsbClientes.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbClientes.Click += tsbClientes_Click;
            // 
            // tsbProductos
            // 
            tsbProductos.DropDownItems.AddRange(new ToolStripItem[] { bombonesToolStripMenuItem, cajasToolStripMenuItem });
            tsbProductos.Image = Properties.Resources.barcode_48px;
            tsbProductos.ImageScaling = ToolStripItemImageScaling.None;
            tsbProductos.ImageTransparentColor = Color.Magenta;
            tsbProductos.Name = "tsbProductos";
            tsbProductos.Size = new Size(74, 67);
            tsbProductos.Text = "Productos";
            tsbProductos.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // bombonesToolStripMenuItem
            // 
            bombonesToolStripMenuItem.Image = Properties.Resources.candy_28px;
            bombonesToolStripMenuItem.Name = "bombonesToolStripMenuItem";
            bombonesToolStripMenuItem.Size = new Size(180, 22);
            bombonesToolStripMenuItem.Text = "Bombones";
            bombonesToolStripMenuItem.Click += bombonesToolStripMenuItem_Click;
            // 
            // cajasToolStripMenuItem
            // 
            cajasToolStripMenuItem.Image = Properties.Resources.christmas_gift_28px;
            cajasToolStripMenuItem.Name = "cajasToolStripMenuItem";
            cajasToolStripMenuItem.Size = new Size(180, 22);
            cajasToolStripMenuItem.Text = "Cajas";
            cajasToolStripMenuItem.Click += cajasToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 70);
            // 
            // tsbVentas
            // 
            tsbVentas.Image = Properties.Resources.Ventas;
            tsbVentas.ImageScaling = ToolStripItemImageScaling.None;
            tsbVentas.ImageTransparentColor = Color.Magenta;
            tsbVentas.Name = "tsbVentas";
            tsbVentas.Size = new Size(52, 67);
            tsbVentas.Text = "Ventas";
            tsbVentas.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbVentas.Click += tsbVentas_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 70);
            // 
            // tsbUsuarios
            // 
            tsbUsuarios.Image = Properties.Resources.Usuarios;
            tsbUsuarios.ImageScaling = ToolStripItemImageScaling.None;
            tsbUsuarios.ImageTransparentColor = Color.Magenta;
            tsbUsuarios.Name = "tsbUsuarios";
            tsbUsuarios.Size = new Size(56, 67);
            tsbUsuarios.Text = "Usuarios";
            tsbUsuarios.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // tsbEmpleados
            // 
            tsbEmpleados.Image = Properties.Resources.Empleados;
            tsbEmpleados.ImageScaling = ToolStripItemImageScaling.None;
            tsbEmpleados.ImageTransparentColor = Color.Magenta;
            tsbEmpleados.Name = "tsbEmpleados";
            tsbEmpleados.Size = new Size(69, 67);
            tsbEmpleados.Text = "Empleados";
            tsbEmpleados.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 70);
            // 
            // tsbSalir
            // 
            tsbSalir.Image = Properties.Resources.shutdown_48px1;
            tsbSalir.ImageScaling = ToolStripItemImageScaling.None;
            tsbSalir.ImageTransparentColor = Color.Magenta;
            tsbSalir.Name = "tsbSalir";
            tsbSalir.Size = new Size(52, 67);
            tsbSalir.Text = "Salir";
            tsbSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbSalir.Click += tsbSalir_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblUsuario });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(50, 17);
            toolStripStatusLabel1.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 17);
            lblUsuario.Text = "Usuario";
            // 
            // frmNuevoMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CausesValidation = false;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(statusStrip1);
            Controls.Add(BarraMenu);
            IsMdiContainer = true;
            Name = "frmNuevoMenuPrincipal";
            Text = "frmNuevoMenuPrincipal";
            WindowState = FormWindowState.Maximized;
            BarraMenu.ResumeLayout(false);
            BarraMenu.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip BarraMenu;
        private ToolStripDropDownButton tsbArchivos;
        private ToolStripMenuItem rellenosToolStripMenuItem;
        private ToolStripMenuItem nuecesToolStripMenuItem;
        private ToolStripMenuItem chocolatesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem paísesToolStripMenuItem;
        private ToolStripMenuItem estadosToolStripMenuItem;
        private ToolStripMenuItem ciudadesToolStripMenuItem;
        private ToolStripButton tsbClientes;
        private ToolStripDropDownButton tsbProductos;
        private ToolStripMenuItem bombonesToolStripMenuItem;
        private ToolStripMenuItem cajasToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbVentas;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton tsbUsuarios;
        private ToolStripButton tsbEmpleados;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton tsbSalir;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblUsuario;
    }
}