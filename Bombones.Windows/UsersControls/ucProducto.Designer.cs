namespace Bombones.Windows.UsersControls
{
    partial class ucProducto
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            picImagenProducto = new PictureBox();
            lblNombreProducto = new Label();
            lblPrecioProducto = new Label();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)picImagenProducto).BeginInit();
            SuspendLayout();
            // 
            // picImagenProducto
            // 
            picImagenProducto.Location = new Point(25, 20);
            picImagenProducto.Name = "picImagenProducto";
            picImagenProducto.Size = new Size(108, 79);
            picImagenProducto.SizeMode = PictureBoxSizeMode.StretchImage;
            picImagenProducto.TabIndex = 0;
            picImagenProducto.TabStop = false;
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombreProducto.ForeColor = Color.FromArgb(255, 128, 0);
            lblNombreProducto.Location = new Point(0, 108);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(159, 23);
            lblNombreProducto.TabIndex = 1;
            lblNombreProducto.Text = "label1";
            lblNombreProducto.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPrecioProducto
            // 
            lblPrecioProducto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPrecioProducto.ForeColor = Color.FromArgb(192, 64, 0);
            lblPrecioProducto.Location = new Point(0, 131);
            lblPrecioProducto.Name = "lblPrecioProducto";
            lblPrecioProducto.Size = new Size(159, 23);
            lblPrecioProducto.TabIndex = 1;
            lblPrecioProducto.Text = "label1";
            lblPrecioProducto.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(40, 157);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 35);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // ucProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnAgregar);
            Controls.Add(lblPrecioProducto);
            Controls.Add(lblNombreProducto);
            Controls.Add(picImagenProducto);
            Name = "ucProducto";
            Size = new Size(162, 204);
            MouseEnter += ucProducto_MouseEnter;
            MouseLeave += ucProducto_MouseLeave;
            ((System.ComponentModel.ISupportInitialize)picImagenProducto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picImagenProducto;
        private Label lblNombreProducto;
        private Label lblPrecioProducto;
        public Button btnAgregar;
    }
}
