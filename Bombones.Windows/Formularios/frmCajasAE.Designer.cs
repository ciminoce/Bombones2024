namespace Bombones.Windows.Formularios
{
    partial class frmCajasAE
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCajasAE));
            panel1 = new Panel();
            txtNivel = new TextBox();
            label9 = new Label();
            txtStock = new TextBox();
            label7 = new Label();
            groupBox2 = new GroupBox();
            txtPrecioVta = new TextBox();
            txtPrecioCosto = new TextBox();
            label6 = new Label();
            label5 = new Label();
            btnBuscarImagen = new Button();
            groupBox3 = new GroupBox();
            picImagen = new PictureBox();
            chkSuspendido = new CheckBox();
            txtDescripcion = new TextBox();
            label8 = new Label();
            txtCaja = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            btnCancelar = new Button();
            btnOk = new Button();
            splitContainer1 = new SplitContainer();
            dgvDatos = new DataGridView();
            colBombon = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            btnEditarBombon = new Button();
            btnBorrarBombon = new Button();
            btnAgregarBombon = new Button();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtNivel);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtStock);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(btnBuscarImagen);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(chkSuspendido);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtCaja);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(999, 272);
            panel1.TabIndex = 0;
            // 
            // txtNivel
            // 
            txtNivel.Location = new Point(394, 219);
            txtNivel.Name = "txtNivel";
            txtNivel.Size = new Size(86, 23);
            txtNivel.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(262, 224);
            label9.Name = "label9";
            label9.Size = new Size(114, 15);
            label9.TabIndex = 17;
            label9.Text = "Nivel de Reposición:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(153, 219);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(86, 23);
            txtStock.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(108, 222);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 18;
            label7.Text = "Stock:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPrecioVta);
            groupBox2.Controls.Add(txtPrecioCosto);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(101, 146);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(412, 67);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = " Precios ";
            // 
            // txtPrecioVta
            // 
            txtPrecioVta.Location = new Point(262, 25);
            txtPrecioVta.Name = "txtPrecioVta";
            txtPrecioVta.Size = new Size(100, 23);
            txtPrecioVta.TabIndex = 1;
            // 
            // txtPrecioCosto
            // 
            txtPrecioCosto.Location = new Point(81, 23);
            txtPrecioCosto.Name = "txtPrecioCosto";
            txtPrecioCosto.Size = new Size(100, 23);
            txtPrecioCosto.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(194, 27);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 0;
            label6.Text = "P. Vta.:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 25);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 0;
            label5.Text = "P. Costo:";
            // 
            // btnBuscarImagen
            // 
            btnBuscarImagen.Image = Properties.Resources.Buscar;
            btnBuscarImagen.Location = new Point(530, 197);
            btnBuscarImagen.Name = "btnBuscarImagen";
            btnBuscarImagen.Size = new Size(182, 49);
            btnBuscarImagen.TabIndex = 15;
            btnBuscarImagen.Text = "Buscar";
            btnBuscarImagen.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarImagen.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(picImagen);
            groupBox3.Location = new Point(530, 17);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(182, 174);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = " Imágen ";
            // 
            // picImagen
            // 
            picImagen.Location = new Point(17, 21);
            picImagen.Name = "picImagen";
            picImagen.Size = new Size(152, 139);
            picImagen.TabIndex = 0;
            picImagen.TabStop = false;
            // 
            // chkSuspendido
            // 
            chkSuspendido.AutoSize = true;
            chkSuspendido.Location = new Point(733, 27);
            chkSuspendido.Name = "chkSuspendido";
            chkSuspendido.Size = new Size(88, 19);
            chkSuspendido.TabIndex = 13;
            chkSuspendido.Text = "Suspendido";
            chkSuspendido.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(101, 49);
            txtDescripcion.MaxLength = 256;
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(412, 91);
            txtDescripcion.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 52);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 9;
            label8.Text = "Descripción:";
            // 
            // txtCaja
            // 
            txtCaja.Location = new Point(101, 20);
            txtCaja.MaxLength = 120;
            txtCaja.Name = "txtCaja";
            txtCaja.Size = new Size(412, 23);
            txtCaja.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 23);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 10;
            label1.Text = "Caja:";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCancelar);
            panel2.Controls.Add(btnOk);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 622);
            panel2.Name = "panel2";
            panel2.Size = new Size(999, 100);
            panel2.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.Cancelar;
            btnCancelar.Location = new Point(638, 23);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 54);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOk
            // 
            btnOk.Image = (Image)resources.GetObject("btnOk.Image");
            btnOk.Location = new Point(306, 23);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(289, 54);
            btnOk.TabIndex = 12;
            btnOk.Text = "Ok";
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 272);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvDatos);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnEditarBombon);
            splitContainer1.Panel2.Controls.Add(btnBorrarBombon);
            splitContainer1.Panel2.Controls.Add(btnAgregarBombon);
            splitContainer1.Size = new Size(999, 350);
            splitContainer1.SplitterDistance = 833;
            splitContainer1.TabIndex = 2;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colBombon, colCantidad });
            dgvDatos.Location = new Point(30, 0);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(780, 301);
            dgvDatos.TabIndex = 0;
            // 
            // colBombon
            // 
            colBombon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colBombon.HeaderText = "Bombón";
            colBombon.Name = "colBombon";
            colBombon.ReadOnly = true;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad";
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            // 
            // btnEditarBombon
            // 
            btnEditarBombon.Image = Properties.Resources.edit_property_24px;
            btnEditarBombon.Location = new Point(22, 148);
            btnEditarBombon.Name = "btnEditarBombon";
            btnEditarBombon.Size = new Size(117, 56);
            btnEditarBombon.TabIndex = 0;
            btnEditarBombon.Text = "Editar";
            btnEditarBombon.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEditarBombon.UseVisualStyleBackColor = true;
            btnEditarBombon.Click += btnEditarBombon_Click;
            // 
            // btnBorrarBombon
            // 
            btnBorrarBombon.Image = Properties.Resources.minus_24px;
            btnBorrarBombon.Location = new Point(22, 86);
            btnBorrarBombon.Name = "btnBorrarBombon";
            btnBorrarBombon.Size = new Size(117, 56);
            btnBorrarBombon.TabIndex = 0;
            btnBorrarBombon.Text = "Borrar";
            btnBorrarBombon.TextImageRelation = TextImageRelation.ImageAboveText;
            btnBorrarBombon.UseVisualStyleBackColor = true;
            btnBorrarBombon.Click += btnBorrarBombon_Click;
            // 
            // btnAgregarBombon
            // 
            btnAgregarBombon.Image = Properties.Resources.plus_24px;
            btnAgregarBombon.Location = new Point(22, 24);
            btnAgregarBombon.Name = "btnAgregarBombon";
            btnAgregarBombon.Size = new Size(117, 56);
            btnAgregarBombon.TabIndex = 0;
            btnAgregarBombon.Text = "Agregar";
            btnAgregarBombon.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgregarBombon.UseVisualStyleBackColor = true;
            btnAgregarBombon.Click += btnAgregarBombon_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmCajasAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 722);
            Controls.Add(splitContainer1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmCajasAE";
            Text = "frmCajasAE";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            panel2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CheckBox chkSuspendido;
        private TextBox txtDescripcion;
        private Label label8;
        private TextBox txtCaja;
        private Label label1;
        private Button btnBuscarImagen;
        private GroupBox groupBox3;
        private PictureBox picImagen;
        private TextBox txtNivel;
        private Label label9;
        private TextBox txtStock;
        private Label label7;
        private GroupBox groupBox2;
        private TextBox txtPrecioVta;
        private TextBox txtPrecioCosto;
        private Label label6;
        private Label label5;
        private Panel panel2;
        private Button btnCancelar;
        private Button btnOk;
        private SplitContainer splitContainer1;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colBombon;
        private DataGridViewTextBoxColumn colCantidad;
        private Button btnAgregarBombon;
        private Button btnEditarBombon;
        private Button btnBorrarBombon;
        private ErrorProvider errorProvider1;
    }
}