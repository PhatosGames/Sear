namespace Sear
{
    partial class Display
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sales = new System.Windows.Forms.TextBox();
            this.btn_fatturato = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.txt_exp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_addOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "City:";
            // 
            // txt_city
            // 
            this.txt_city.Location = new System.Drawing.Point(12, 24);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(168, 20);
            this.txt_city.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(186, 22);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(289, 24);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(460, 393);
            this.dataGridView.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "SalesByYear:";
            // 
            // txt_sales
            // 
            this.txt_sales.Location = new System.Drawing.Point(12, 83);
            this.txt_sales.Name = "txt_sales";
            this.txt_sales.Size = new System.Drawing.Size(168, 20);
            this.txt_sales.TabIndex = 5;
            // 
            // btn_fatturato
            // 
            this.btn_fatturato.Location = new System.Drawing.Point(186, 80);
            this.btn_fatturato.Name = "btn_fatturato";
            this.btn_fatturato.Size = new System.Drawing.Size(75, 23);
            this.btn_fatturato.TabIndex = 6;
            this.btn_fatturato.Text = "Search";
            this.btn_fatturato.UseVisualStyleBackColor = true;
            this.btn_fatturato.Click += new System.EventHandler(this.btn_fatturato_Click);
            // 
            // Export
            // 
            this.Export.BackColor = System.Drawing.Color.DarkRed;
            this.Export.ForeColor = System.Drawing.SystemColors.Window;
            this.Export.Location = new System.Drawing.Point(199, 394);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(75, 23);
            this.Export.TabIndex = 7;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = false;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // txt_exp
            // 
            this.txt_exp.Location = new System.Drawing.Point(186, 368);
            this.txt_exp.Name = "txt_exp";
            this.txt_exp.Size = new System.Drawing.Size(100, 20);
            this.txt_exp.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "&Export AS:";
            // 
            // btn_addOrder
            // 
            this.btn_addOrder.BackColor = System.Drawing.Color.Olive;
            this.btn_addOrder.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_addOrder.Location = new System.Drawing.Point(12, 131);
            this.btn_addOrder.Name = "btn_addOrder";
            this.btn_addOrder.Size = new System.Drawing.Size(249, 23);
            this.btn_addOrder.TabIndex = 10;
            this.btn_addOrder.Text = "Add New Order";
            this.btn_addOrder.UseVisualStyleBackColor = false;
            this.btn_addOrder.Click += new System.EventHandler(this.btn_addOrder_Click);
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_addOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_exp);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.btn_fatturato);
            this.Controls.Add(this.txt_sales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.label1);
            this.Name = "Display";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sales;
        private System.Windows.Forms.Button btn_fatturato;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.TextBox txt_exp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_addOrder;
    }
}

