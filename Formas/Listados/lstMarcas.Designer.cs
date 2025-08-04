namespace Proyecto1.Formas.Listados
{
    partial class lstMarcas
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
            this.dataGridView1_marcas = new System.Windows.Forms.DataGridView();
            this.button1_buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_buscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_marcas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1_marcas
            // 
            this.dataGridView1_marcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1_marcas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1_marcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_marcas.Location = new System.Drawing.Point(40, 89);
            this.dataGridView1_marcas.Name = "dataGridView1_marcas";
            this.dataGridView1_marcas.Size = new System.Drawing.Size(378, 263);
            this.dataGridView1_marcas.TabIndex = 0;
            // 
            // button1_buscar
            // 
            this.button1_buscar.Location = new System.Drawing.Point(326, 47);
            this.button1_buscar.Name = "button1_buscar";
            this.button1_buscar.Size = new System.Drawing.Size(75, 23);
            this.button1_buscar.TabIndex = 1;
            this.button1_buscar.Text = "Buscar";
            this.button1_buscar.UseVisualStyleBackColor = true;
            this.button1_buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marca a bsucar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1_buscar
            // 
            this.textBox1_buscar.Location = new System.Drawing.Point(40, 49);
            this.textBox1_buscar.Name = "textBox1_buscar";
            this.textBox1_buscar.Size = new System.Drawing.Size(258, 20);
            this.textBox1_buscar.TabIndex = 3;
            this.textBox1_buscar.TextChanged += new System.EventHandler(this.textBox1_buscar_TextChanged);
            // 
            // lstMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(462, 401);
            this.Controls.Add(this.textBox1_buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1_buscar);
            this.Controls.Add(this.dataGridView1_marcas);
            this.Name = "lstMarcas";
            this.Text = "lstMarcas";
            this.Load += new System.EventHandler(this.lstMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_marcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1_marcas;
        private System.Windows.Forms.Button button1_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_buscar;
    }
}