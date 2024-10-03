﻿namespace Bombones.Windows.Formularios
{
    partial class frmManejarBombonCajaAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManejarBombonCajaAE));
            nudCantidad = new NumericUpDown();
            label2 = new Label();
            cboBombones = new ComboBox();
            label1 = new Label();
            btnCancelar = new Button();
            btnOk = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(129, 79);
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 23);
            nudCantidad.TabIndex = 24;
            nudCantidad.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 81);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 23;
            label2.Text = "Cantidad:";
            // 
            // cboBombones
            // 
            cboBombones.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBombones.FormattingEnabled = true;
            cboBombones.Location = new Point(129, 34);
            cboBombones.Name = "cboBombones";
            cboBombones.Size = new Size(469, 23);
            cboBombones.TabIndex = 22;
            cboBombones.SelectedIndexChanged += cboBombones_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 37);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 21;
            label1.Text = "Bombón:";
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.Cancelar;
            btnCancelar.Location = new Point(434, 129);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 54);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOk
            // 
            btnOk.Image = (Image)resources.GetObject("btnOk.Image");
            btnOk.Location = new Point(102, 129);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(289, 54);
            btnOk.TabIndex = 20;
            btnOk.Text = "Ok";
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmManejarBombonCajaAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 199);
            Controls.Add(nudCantidad);
            Controls.Add(label2);
            Controls.Add(cboBombones);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Name = "frmManejarBombonCajaAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmManejarBombonCajaAE";
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudCantidad;
        private Label label2;
        private ComboBox cboBombones;
        private Label label1;
        private Button btnCancelar;
        private Button btnOk;
        private ErrorProvider errorProvider1;
    }
}