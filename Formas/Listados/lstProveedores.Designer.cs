namespace Proyecto1.Formas.Listados
{
    partial class lstProveedores
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
            this.textBox1_buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1_buscar = new System.Windows.Forms.Button();
            this.dataGridView1_proveedor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_proveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1_buscar
            // 
            this.textBox1_buscar.Location = new System.Drawing.Point(32, 55);
            this.textBox1_buscar.Name = "textBox1_buscar";
            this.textBox1_buscar.Size = new System.Drawing.Size(258, 20);
            this.textBox1_buscar.TabIndex = 7;
            this.textBox1_buscar.TextChanged += new System.EventHandler(this.textBox1_buscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Proveedor a bsucar";
            // 
            // button1_buscar
            // 
            this.button1_buscar.Location = new System.Drawing.Point(318, 53);
            this.button1_buscar.Name = "button1_buscar";
            this.button1_buscar.Size = new System.Drawing.Size(75, 23);
            this.button1_buscar.TabIndex = 5;
            this.button1_buscar.Text = "Buscar";
            this.button1_buscar.UseVisualStyleBackColor = true;
            this.button1_buscar.Click += new System.EventHandler(this.button1_buscar_Click);
            // 
            // dataGridView1_proveedor
            // 
            this.dataGridView1_proveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1_proveedor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1_proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_proveedor.Location = new System.Drawing.Point(32, 95);
            this.dataGridView1_proveedor.Name = "dataGridView1_proveedor";
            this.dataGridView1_proveedor.Size = new System.Drawing.Size(378, 263);
            this.dataGridView1_proveedor.TabIndex = 4;
            // 
            // lstProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 393);
            this.Controls.Add(this.textBox1_buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1_buscar);
            this.Controls.Add(this.dataGridView1_proveedor);
            this.Name = "lstProveedores";
            this.Text = "lstProveedores";
            this.Load += new System.EventHandler(this.lstProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_proveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1_buscar;
        private System.Windows.Forms.DataGridView dataGridView1_proveedor;
    }
}