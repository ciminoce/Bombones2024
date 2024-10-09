namespace Bombones.Windows.Formularios
{
    partial class frmCajaDetalle
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
            txtStock = new TextBox();
            label7 = new Label();
            txtPrecioVta = new TextBox();
            label6 = new Label();
            groupBox3 = new GroupBox();
            picImagen = new PictureBox();
            chkSuspendido = new CheckBox();
            txtDescripcion = new TextBox();
            label8 = new Label();
            txtCaja = new TextBox();
            label1 = new Label();
            dgvDatos = new DataGridView();
            btnCerrar = new Button();
            colId = new DataGridViewTextBoxColumn();
            colBombon = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // txtStock
            // 
            txtStock.Location = new Point(399, 159);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(86, 23);
            txtStock.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(354, 162);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 30;
            label7.Text = "Stock:";
            // 
            // txtPrecioVta
            // 
            txtPrecioVta.Location = new Point(145, 157);
            txtPrecioVta.Name = "txtPrecioVta";
            txtPrecioVta.Size = new Size(100, 23);
            txtPrecioVta.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(77, 159);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 0;
            label6.Text = "P. Vta.:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(picImagen);
            groupBox3.Location = new Point(502, 20);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(182, 174);
            groupBox3.TabIndex = 26;
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
            chkSuspendido.Location = new Point(705, 30);
            chkSuspendido.Name = "chkSuspendido";
            chkSuspendido.Size = new Size(88, 19);
            chkSuspendido.TabIndex = 25;
            chkSuspendido.Text = "Suspendido";
            chkSuspendido.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(73, 52);
            txtDescripcion.MaxLength = 256;
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(412, 91);
            txtDescripcion.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(2, 55);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 21;
            label8.Text = "Descripción:";
            // 
            // txtCaja
            // 
            txtCaja.Location = new Point(73, 23);
            txtCaja.MaxLength = 120;
            txtCaja.Name = "txtCaja";
            txtCaja.Size = new Size(412, 23);
            txtCaja.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 26);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 22;
            label1.Text = "Caja:";
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colId, colBombon, colCantidad });
            dgvDatos.Location = new Point(8, 200);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(780, 301);
            dgvDatos.TabIndex = 33;
            // 
            // btnCerrar
            // 
            btnCerrar.Image = Properties.Resources.Cancelar;
            btnCerrar.Location = new Point(683, 507);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(105, 54);
            btnCerrar.TabIndex = 34;
            btnCerrar.Text = "Cerrar";
            btnCerrar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
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
            // frmCajaDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 569);
            Controls.Add(btnCerrar);
            Controls.Add(dgvDatos);
            Controls.Add(txtPrecioVta);
            Controls.Add(label6);
            Controls.Add(txtStock);
            Controls.Add(label7);
            Controls.Add(groupBox3);
            Controls.Add(chkSuspendido);
            Controls.Add(txtDescripcion);
            Controls.Add(label8);
            Controls.Add(txtCaja);
            Controls.Add(label1);
            Name = "frmCajaDetalle";
            Text = "frmCajaDetalle";
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStock;
        private Label label7;
        private TextBox txtPrecioVta;
        private Label label6;
        private GroupBox groupBox3;
        private PictureBox picImagen;
        private CheckBox chkSuspendido;
        private TextBox txtDescripcion;
        private Label label8;
        private TextBox txtCaja;
        private Label label1;
        private DataGridView dgvDatos;
        private Button btnCerrar;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colBombon;
        private DataGridViewTextBoxColumn colCantidad;
    }
}