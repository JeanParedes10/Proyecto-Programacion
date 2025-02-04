
namespace GestionRiobambaZapateria
{
    partial class Form2
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
            btnNike = new Button();
            btnAdidas = new Button();
            btnPuma = new Button();
            btnTodos = new Button();
            dgvInventario = new DataGridView();
            btnMenu = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            SuspendLayout();
            // 
            // btnNike
            // 
            btnNike.Location = new Point(430, 61);
            btnNike.Name = "btnNike";
            btnNike.Size = new Size(75, 28);
            btnNike.TabIndex = 6;
            btnNike.Text = "ADIDAS";
            btnNike.Click += btnNike_Click;
            // 
            // btnAdidas
            // 
            btnAdidas.Location = new Point(564, 55);
            btnAdidas.Name = "btnAdidas";
            btnAdidas.Size = new Size(94, 29);
            btnAdidas.TabIndex = 1;
            btnAdidas.Text = "NIKE";
            btnAdidas.UseVisualStyleBackColor = true;
            btnAdidas.Click += btnAdidas_Click_1;
            // 
            // btnPuma
            // 
            btnPuma.Location = new Point(781, 55);
            btnPuma.Name = "btnPuma";
            btnPuma.Size = new Size(94, 29);
            btnPuma.TabIndex = 2;
            btnPuma.Text = "PUMA";
            btnPuma.UseVisualStyleBackColor = true;
            btnPuma.Click += btnPuma_Click_1;
            // 
            // btnTodos
            // 
            btnTodos.Location = new Point(1001, 58);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(75, 31);
            btnTodos.TabIndex = 5;
            btnTodos.Text = "TODOS";
            btnTodos.Click += btnTodos_Click_1;
            // 
            // dgvInventario
            // 
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Location = new Point(245, 117);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.RowHeadersWidth = 51;
            dgvInventario.Size = new Size(1013, 368);
            dgvInventario.TabIndex = 4;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(50, 441);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(94, 29);
            btnMenu.TabIndex = 7;
            btnMenu.Text = "Menú";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1291, 441);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1417, 574);
            Controls.Add(btnSalir);
            Controls.Add(btnMenu);
            Controls.Add(dgvInventario);
            Controls.Add(btnTodos);
            Controls.Add(btnPuma);
            Controls.Add(btnAdidas);
            Controls.Add(btnNike);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ResumeLayout(false);
        }




        #endregion

        private Button btnNike;
        private Button btnAdidas;
        private Button btnPuma;
        private Button btnTodos;
        private DataGridView dgvInventario;
        private Button btnMenu;
        private Button btnSalir;
    }
}