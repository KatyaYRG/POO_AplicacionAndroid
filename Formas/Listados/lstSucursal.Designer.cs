namespace Proyecto1.Formas.Listados
{
    partial class lstSucursal
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
            this.textBox1_Sucursal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1_buscar = new System.Windows.Forms.Button();
            this.dataGridView1_Sucursal = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Sucursal)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1_Sucursal
            // 
            this.textBox1_Sucursal.Location = new System.Drawing.Point(35, 58);
            this.textBox1_Sucursal.Name = "textBox1_Sucursal";
            this.textBox1_Sucursal.Size = new System.Drawing.Size(258, 20);
            this.textBox1_Sucursal.TabIndex = 7;
            this.textBox1_Sucursal.TextChanged += new System.EventHandler(this.textBox1_Sucursal_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sucursal a bsucar";
            // 
            // button1_buscar
            // 
            this.button1_buscar.Location = new System.Drawing.Point(321, 56);
            this.button1_buscar.Name = "button1_buscar";
            this.button1_buscar.Size = new System.Drawing.Size(75, 23);
            this.button1_buscar.TabIndex = 5;
            this.button1_buscar.Text = "Buscar";
            this.button1_buscar.UseVisualStyleBackColor = true;
            this.button1_buscar.Click += new System.EventHandler(this.button1_buscar_Click);
            // 
            // dataGridView1_Sucursal
            // 
            this.dataGridView1_Sucursal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1_Sucursal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1_Sucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_Sucursal.Location = new System.Drawing.Point(35, 98);
            this.dataGridView1_Sucursal.Name = "dataGridView1_Sucursal";
            this.dataGridView1_Sucursal.Size = new System.Drawing.Size(378, 263);
            this.dataGridView1_Sucursal.TabIndex = 4;
            // 
            // lstSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 416);
            this.Controls.Add(this.textBox1_Sucursal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1_buscar);
            this.Controls.Add(this.dataGridView1_Sucursal);
            this.Name = "lstSucursal";
            this.Text = "lstSucursal";
            this.Load += new System.EventHandler(this.lstSucursal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Sucursal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_Sucursal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1_buscar;
        private System.Windows.Forms.DataGridView dataGridView1_Sucursal;
    }
}