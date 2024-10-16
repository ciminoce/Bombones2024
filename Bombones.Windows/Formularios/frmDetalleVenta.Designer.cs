namespace Bombones.Windows.Formularios
{
    partial class frmDetalleVenta
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
            panelInferior = new Panel();
            txtTotal = new TextBox();
            label5 = new Label();
            btnCerrar = new Button();
            panelSuperior = new Panel();
            chkRegalo = new CheckBox();
            txtEstado = new TextBox();
            label4 = new Label();
            txtFecha = new TextBox();
            label2 = new Label();
            txtCliente = new TextBox();
            label3 = new Label();
            txtVentaNro = new TextBox();
            label1 = new Label();
            panelGrilla = new Panel();
            dgvDatos = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colProducto = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            panelInferior.SuspendLayout();
            panelSuperior.SuspendLayout();
            panelGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // panelInferior
            // 
            panelInferior.Controls.Add(txtTotal);
            panelInferior.Controls.Add(label5);
            panelInferior.Controls.Add(btnCerrar);
            panelInferior.Dock = DockStyle.Bottom;
            panelInferior.Location = new Point(0, 420);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(800, 100);
            panelInferior.TabIndex = 0;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtTotal.Location = new Point(722, 3);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(66, 23);
            txtTotal.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(669, 6);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 5;
            label5.Text = "Total:";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(352, 19);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(91, 60);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panelSuperior
            // 
            panelSuperior.Controls.Add(chkRegalo);
            panelSuperior.Controls.Add(txtEstado);
            panelSuperior.Controls.Add(label4);
            panelSuperior.Controls.Add(txtFecha);
            panelSuperior.Controls.Add(label2);
            panelSuperior.Controls.Add(txtCliente);
            panelSuperior.Controls.Add(label3);
            panelSuperior.Controls.Add(txtVentaNro);
            panelSuperior.Controls.Add(label1);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(800, 110);
            panelSuperior.TabIndex = 1;
            // 
            // chkRegalo
            // 
            chkRegalo.AutoSize = true;
            chkRegalo.CheckAlign = ContentAlignment.MiddleRight;
            chkRegalo.Location = new Point(102, 79);
            chkRegalo.Name = "chkRegalo";
            chkRegalo.Size = new Size(62, 19);
            chkRegalo.TabIndex = 11;
            chkRegalo.Text = "Regalo";
            chkRegalo.TextAlign = ContentAlignment.MiddleRight;
            chkRegalo.UseVisualStyleBackColor = true;
            // 
            // txtEstado
            // 
            txtEstado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtEstado.Location = new Point(669, 45);
            txtEstado.Name = "txtEstado";
            txtEstado.ReadOnly = true;
            txtEstado.Size = new Size(100, 23);
            txtEstado.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(598, 48);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 3;
            label4.Text = "Estado:";
            // 
            // txtFecha
            // 
            txtFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtFecha.Location = new Point(669, 16);
            txtFecha.Name = "txtFecha";
            txtFecha.ReadOnly = true;
            txtFecha.Size = new Size(100, 23);
            txtFecha.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(598, 19);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 4;
            label2.Text = "Fecha Vta.:";
            // 
            // txtCliente
            // 
            txtCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtCliente.Location = new Point(102, 42);
            txtCliente.Name = "txtCliente";
            txtCliente.ReadOnly = true;
            txtCliente.Size = new Size(460, 23);
            txtCliente.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 45);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 5;
            label3.Text = "Cliente: ";
            // 
            // txtVentaNro
            // 
            txtVentaNro.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtVentaNro.Location = new Point(102, 13);
            txtVentaNro.Name = "txtVentaNro";
            txtVentaNro.ReadOnly = true;
            txtVentaNro.Size = new Size(100, 23);
            txtVentaNro.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 16);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 6;
            label1.Text = "Venta Nro.:";
            // 
            // panelGrilla
            // 
            panelGrilla.Controls.Add(dgvDatos);
            panelGrilla.Dock = DockStyle.Fill;
            panelGrilla.Location = new Point(0, 110);
            panelGrilla.Name = "panelGrilla";
            panelGrilla.Size = new Size(800, 310);
            panelGrilla.TabIndex = 2;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colId, colProducto, colCantidad, colPrecio, colTotal });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.Size = new Size(800, 310);
            dgvDatos.TabIndex = 2;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            // 
            // colProducto
            // 
            colProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colProducto.HeaderText = "Producto";
            colProducto.Name = "colProducto";
            colProducto.ReadOnly = true;
            // 
            // colCantidad
            // 
            colCantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colCantidad.HeaderText = "Cant.";
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            colCantidad.Width = 60;
            // 
            // colPrecio
            // 
            colPrecio.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colPrecio.HeaderText = "P. Unit";
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            colPrecio.Width = 67;
            // 
            // colTotal
            // 
            colTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colTotal.HeaderText = "P. Total";
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            colTotal.Width = 70;
            // 
            // frmDetalleVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 520);
            Controls.Add(panelGrilla);
            Controls.Add(panelSuperior);
            Controls.Add(panelInferior);
            Name = "frmDetalleVenta";
            Text = "frmDetalleVenta";
            Load += frmDetalleVenta_Load;
            panelInferior.ResumeLayout(false);
            panelInferior.PerformLayout();
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            panelGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelInferior;
        private TextBox txtTotal;
        private Label label5;
        private Button btnCerrar;
        private Panel panelSuperior;
        private CheckBox chkRegalo;
        private TextBox txtEstado;
        private Label label4;
        private TextBox txtFecha;
        private Label label2;
        private TextBox txtCliente;
        private Label label3;
        private TextBox txtVentaNro;
        private Label label1;
        private Panel panelGrilla;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colTotal;
    }
}