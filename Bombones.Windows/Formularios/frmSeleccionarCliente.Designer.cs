namespace Bombones.Windows.Formularios
{
    partial class frmSeleccionarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeleccionarCliente));
            label1 = new Label();
            cboClientes = new ComboBox();
            btnCancelar = new Button();
            btnOk = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 31);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // cboClientes
            // 
            cboClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClientes.FormattingEnabled = true;
            cboClientes.Location = new Point(107, 23);
            cboClientes.Name = "cboClientes";
            cboClientes.Size = new Size(361, 23);
            cboClientes.TabIndex = 1;
            cboClientes.SelectedIndexChanged += cboClientes_SelectedIndexChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.Cancelar;
            btnCancelar.Location = new Point(363, 65);
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
            btnOk.Location = new Point(31, 65);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(289, 54);
            btnOk.TabIndex = 12;
            btnOk.Text = "Ok";
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // frmSeleccionarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 154);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(cboClientes);
            Controls.Add(label1);
            Name = "frmSeleccionarCliente";
            Text = "frmSeleccionarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboClientes;
        private Button btnCancelar;
        private Button btnOk;
    }
}