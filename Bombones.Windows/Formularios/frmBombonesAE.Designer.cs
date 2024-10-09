namespace Bombones.Windows.Formularios
{
    partial class frmBombonesAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBombonesAE));
            cboFabricas = new ComboBox();
            btnCancelar = new Button();
            btnOk = new Button();
            label10 = new Label();
            chkSuspendido = new CheckBox();
            label9 = new Label();
            label7 = new Label();
            btnBuscarImagen = new Button();
            groupBox3 = new GroupBox();
            picImagen = new PictureBox();
            groupBox2 = new GroupBox();
            txtPrecioVta = new TextBox();
            txtPrecioCosto = new TextBox();
            label6 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            cboNueces = new ComboBox();
            cboRellenos = new ComboBox();
            cboChocolates = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtDescripcion = new TextBox();
            label8 = new Label();
            txtBombon = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            nudStock = new NumericUpDown();
            nudNivel = new NumericUpDown();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNivel).BeginInit();
            SuspendLayout();
            // 
            // cboFabricas
            // 
            cboFabricas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFabricas.FormattingEnabled = true;
            cboFabricas.Location = new Point(148, 305);
            cboFabricas.Name = "cboFabricas";
            cboFabricas.Size = new Size(211, 23);
            cboFabricas.TabIndex = 16;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.Cancelar;
            btnCancelar.Location = new Point(462, 455);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 54);
            btnCancelar.TabIndex = 26;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOk
            // 
            btnOk.Image = (Image)resources.GetObject("btnOk.Image");
            btnOk.Location = new Point(130, 455);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(289, 54);
            btnOk.TabIndex = 27;
            btnOk.Text = "Ok";
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(63, 308);
            label10.Name = "label10";
            label10.Size = new Size(48, 15);
            label10.TabIndex = 13;
            label10.Text = "Fábrica:";
            // 
            // chkSuspendido
            // 
            chkSuspendido.AutoSize = true;
            chkSuspendido.Location = new Point(541, 39);
            chkSuspendido.Name = "chkSuspendido";
            chkSuspendido.Size = new Size(88, 19);
            chkSuspendido.TabIndex = 25;
            chkSuspendido.Text = "Suspendido";
            chkSuspendido.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(210, 407);
            label9.Name = "label9";
            label9.Size = new Size(114, 15);
            label9.TabIndex = 21;
            label9.Text = "Nivel de Reposición:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(56, 405);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 22;
            label7.Text = "Stock:";
            // 
            // btnBuscarImagen
            // 
            btnBuscarImagen.Image = Properties.Resources.Buscar;
            btnBuscarImagen.Location = new Point(463, 370);
            btnBuscarImagen.Name = "btnBuscarImagen";
            btnBuscarImagen.Size = new Size(182, 49);
            btnBuscarImagen.TabIndex = 20;
            btnBuscarImagen.Text = "Buscar";
            btnBuscarImagen.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarImagen.UseVisualStyleBackColor = true;
            btnBuscarImagen.Click += btnBuscarImagen_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(picImagen);
            groupBox3.Location = new Point(460, 176);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(185, 188);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = " Imágen ";
            // 
            // picImagen
            // 
            picImagen.Location = new Point(17, 21);
            picImagen.Name = "picImagen";
            picImagen.Size = new Size(152, 152);
            picImagen.TabIndex = 0;
            picImagen.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPrecioVta);
            groupBox2.Controls.Add(txtPrecioCosto);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(49, 329);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(379, 67);
            groupBox2.TabIndex = 18;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(cboNueces);
            groupBox1.Controls.Add(cboRellenos);
            groupBox1.Controls.Add(cboChocolates);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(49, 176);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(379, 123);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = " Ingredientes ";
            // 
            // cboNueces
            // 
            cboNueces.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNueces.FormattingEnabled = true;
            cboNueces.Location = new Point(99, 88);
            cboNueces.Name = "cboNueces";
            cboNueces.Size = new Size(211, 23);
            cboNueces.TabIndex = 1;
            // 
            // cboRellenos
            // 
            cboRellenos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRellenos.FormattingEnabled = true;
            cboRellenos.Location = new Point(99, 57);
            cboRellenos.Name = "cboRellenos";
            cboRellenos.Size = new Size(211, 23);
            cboRellenos.TabIndex = 1;
            // 
            // cboChocolates
            // 
            cboChocolates.DropDownStyle = ComboBoxStyle.DropDownList;
            cboChocolates.FormattingEnabled = true;
            cboChocolates.Location = new Point(99, 24);
            cboChocolates.Name = "cboChocolates";
            cboChocolates.Size = new Size(211, 23);
            cboChocolates.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 91);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 0;
            label4.Text = "Nuez:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 60);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 0;
            label3.Text = "Relleno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 27);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 0;
            label2.Text = "Chocolate:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(112, 68);
            txtDescripcion.MaxLength = 256;
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(412, 91);
            txtDescripcion.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 71);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 12;
            label8.Text = "Descripción:";
            // 
            // txtBombon
            // 
            txtBombon.Location = new Point(112, 39);
            txtBombon.MaxLength = 120;
            txtBombon.Name = "txtBombon";
            txtBombon.Size = new Size(412, 23);
            txtBombon.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 42);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 11;
            label1.Text = "Bombón:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // nudStock
            // 
            nudStock.Location = new Point(101, 402);
            nudStock.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(72, 23);
            nudStock.TabIndex = 28;
            nudStock.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudNivel
            // 
            nudNivel.Location = new Point(330, 405);
            nudNivel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNivel.Name = "nudNivel";
            nudNivel.Size = new Size(72, 23);
            nudNivel.TabIndex = 28;
            nudNivel.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // frmBombonesAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 532);
            Controls.Add(nudNivel);
            Controls.Add(nudStock);
            Controls.Add(cboFabricas);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(label10);
            Controls.Add(chkSuspendido);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(btnBuscarImagen);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtDescripcion);
            Controls.Add(label8);
            Controls.Add(txtBombon);
            Controls.Add(label1);
            Name = "frmBombonesAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBombonesAE";
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNivel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboFabricas;
        private Button btnCancelar;
        private Button btnOk;
        private Label label10;
        private CheckBox chkSuspendido;
        private Label label9;
        private Label label7;
        private Button btnBuscarImagen;
        private GroupBox groupBox3;
        private PictureBox picImagen;
        private GroupBox groupBox2;
        private TextBox txtPrecioVta;
        private TextBox txtPrecioCosto;
        private Label label6;
        private Label label5;
        private GroupBox groupBox1;
        private ComboBox cboNueces;
        private ComboBox cboRellenos;
        private ComboBox cboChocolates;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtDescripcion;
        private Label label8;
        private TextBox txtBombon;
        private Label label1;
        private ErrorProvider errorProvider1;
        private OpenFileDialog openFileDialog1;
        private NumericUpDown nudStock;
        private NumericUpDown nudNivel;
    }
}