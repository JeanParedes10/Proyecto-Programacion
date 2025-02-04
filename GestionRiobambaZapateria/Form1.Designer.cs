namespace GestionRiobambaZapateria
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            comboBoxDias = new ComboBox();
            mtbAdidas = new MaskedTextBox();
            label2 = new Label();
            label3 = new Label();
            mtbNike = new MaskedTextBox();
            label4 = new Label();
            mtbPuma = new MaskedTextBox();
            label5 = new Label();
            mtbPrecioPuma = new MaskedTextBox();
            label6 = new Label();
            mtbPrecioAdidas = new MaskedTextBox();
            label7 = new Label();
            mtbPrecioNike = new MaskedTextBox();
            btnGuardar = new Button();
            btnSiguiente = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(444, 20);
            label1.Name = "label1";
            label1.Size = new Size(323, 20);
            label1.TabIndex = 0;
            label1.Text = "RIOBAMBA ZAPATOS AL POR MAYOR Y MENOR";
            // 
            // comboBoxDias
            // 
            comboBoxDias.FormattingEnabled = true;
            comboBoxDias.Location = new Point(197, 109);
            comboBoxDias.Name = "comboBoxDias";
            comboBoxDias.Size = new Size(151, 28);
            comboBoxDias.TabIndex = 1;
            // 
            // mtbAdidas
            // 
            mtbAdidas.Location = new Point(496, 120);
            mtbAdidas.Mask = "999";
            mtbAdidas.Name = "mtbAdidas";
            mtbAdidas.Size = new Size(125, 27);
            mtbAdidas.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(526, 88);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 3;
            label2.Text = "NIKE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(720, 88);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 5;
            label3.Text = "ADIDAS";
            // 
            // mtbNike
            // 
            mtbNike.Location = new Point(686, 120);
            mtbNike.Mask = "999";
            mtbNike.Name = "mtbNike";
            mtbNike.Size = new Size(125, 27);
            mtbNike.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(948, 78);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 7;
            label4.Text = "PUMA";
            // 
            // mtbPuma
            // 
            mtbPuma.Location = new Point(919, 110);
            mtbPuma.Mask = "999";
            mtbPuma.Name = "mtbPuma";
            mtbPuma.Size = new Size(125, 27);
            mtbPuma.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(893, 247);
            label5.Name = "label5";
            label5.Size = new Size(173, 20);
            label5.TabIndex = 13;
            label5.Text = "PRECIO UNITARIO PUMA";
            // 
            // mtbPrecioPuma
            // 
            mtbPrecioPuma.Location = new Point(919, 279);
            mtbPrecioPuma.Mask = "999";
            mtbPrecioPuma.Name = "mtbPrecioPuma";
            mtbPrecioPuma.Size = new Size(125, 27);
            mtbPrecioPuma.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(664, 247);
            label6.Name = "label6";
            label6.Size = new Size(186, 20);
            label6.TabIndex = 11;
            label6.Text = "PRECIO UNITARIO ADIDAS";
            // 
            // mtbPrecioAdidas
            // 
            mtbPrecioAdidas.Location = new Point(692, 279);
            mtbPrecioAdidas.Mask = "999";
            mtbPrecioAdidas.Name = "mtbPrecioAdidas";
            mtbPrecioAdidas.Size = new Size(125, 27);
            mtbPrecioAdidas.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(457, 247);
            label7.Name = "label7";
            label7.Size = new Size(164, 20);
            label7.TabIndex = 9;
            label7.Text = "PRECIO UNITARIO NIKE";
            // 
            // mtbPrecioNike
            // 
            mtbPrecioNike.Location = new Point(483, 279);
            mtbPrecioNike.Mask = "999";
            mtbPrecioNike.Name = "mtbPrecioNike";
            mtbPrecioNike.Size = new Size(125, 27);
            mtbPrecioNike.TabIndex = 8;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(526, 358);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(708, 358);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(94, 29);
            btnSiguiente.TabIndex = 15;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 623);
            Controls.Add(btnSiguiente);
            Controls.Add(btnGuardar);
            Controls.Add(label5);
            Controls.Add(mtbPrecioPuma);
            Controls.Add(label6);
            Controls.Add(mtbPrecioAdidas);
            Controls.Add(label7);
            Controls.Add(mtbPrecioNike);
            Controls.Add(label4);
            Controls.Add(mtbPuma);
            Controls.Add(label3);
            Controls.Add(mtbNike);
            Controls.Add(label2);
            Controls.Add(mtbAdidas);
            Controls.Add(comboBoxDias);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxDias;
        private MaskedTextBox mtbAdidas;
        private Label label2;
        private Label label3;
        private MaskedTextBox mtbNike;
        private Label label4;
        private MaskedTextBox mtbPuma;
        private Label label5;
        private MaskedTextBox mtbPrecioPuma;
        private Label label6;
        private MaskedTextBox mtbPrecioAdidas;
        private Label label7;
        private MaskedTextBox mtbPrecioNike;
        private Button btnGuardar;
        private Button btnSiguiente;
    }
}
