namespace Sear
{
    partial class FormStatistics
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
            this.btn_OpenOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "City:";
            // 
            // txt_city
            // 
            this.txt_city.Location = new System.Drawing.Point(12, 62);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(168, 20);
            this.txt_city.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(186, 60);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(322, 24);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(587, 423);
            this.dataGridView.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "SalesByYear:";
            // 
            // txt_sales
            // 
            this.txt_sales.Location = new System.Drawing.Point(12, 121);
            this.txt_sales.Name = "txt_sales";
            this.txt_sales.Size = new System.Drawing.Size(168, 20);
            this.txt_sales.TabIndex = 5;
            // 
            // btn_fatturato
            // 
            this.btn_fatturato.Location = new System.Drawing.Point(186, 118);
            this.btn_fatturato.Name = "btn_fatturato";
            this.btn_fatturato.Size = new System.Drawing.Size(75, 23);
            this.btn_fatturato.TabIndex = 6;
            this.btn_fatturato.Text = "Search";
            this.btn_fatturato.UseVisualStyleBackColor = true;
            this.btn_fatturato.Click += new System.EventHandler(this.btn_fatturato_Click);
            // 
            // Export
            // 
            this.Export.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Export.BackColor = System.Drawing.Color.DarkRed;
            this.Export.ForeColor = System.Drawing.SystemColors.Window;
            this.Export.Location = new System.Drawing.Point(213, 430);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(75, 23);
            this.Export.TabIndex = 7;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = false;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // txt_exp
            // 
            this.txt_exp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_exp.Location = new System.Drawing.Point(200, 404);
            this.txt_exp.Name = "txt_exp";
            this.txt_exp.Size = new System.Drawing.Size(100, 20);
            this.txt_exp.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "&Export AS:";
            // 
            // btn_OpenOrder
            // 
            this.btn_OpenOrder.BackColor = System.Drawing.Color.Indigo;
            this.btn_OpenOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_OpenOrder.Location = new System.Drawing.Point(12, 12);
            this.btn_OpenOrder.Name = "btn_OpenOrder";
            this.btn_OpenOrder.Size = new System.Drawing.Size(246, 21);
            this.btn_OpenOrder.TabIndex = 10;
            this.btn_OpenOrder.Text = "Go to order managment";
            this.btn_OpenOrder.UseVisualStyleBackColor = false;
            this.btn_OpenOrder.Click += new System.EventHandler(this.btn_OpenOrder_Click);
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 480);
            this.Controls.Add(this.btn_OpenOrder);
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
            this.MinimumSize = new System.Drawing.Size(976, 519);
            this.Name = "FormStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btn_OpenOrder;
    }
}

