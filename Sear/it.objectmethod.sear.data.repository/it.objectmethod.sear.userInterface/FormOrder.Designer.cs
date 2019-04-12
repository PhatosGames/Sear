namespace Sear.it.objectmethod.sear.data.repository.it.objectmethod.sear.userInterface
{
    partial class YourOrders
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
            this.dataGridView_mod = new System.Windows.Forms.DataGridView();
            this.btn_ModOrder = new System.Windows.Forms.Button();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_User = new System.Windows.Forms.Button();
            this.btn_AddOrder = new System.Windows.Forms.Button();
            this.btn_Statistics = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mod)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_mod
            // 
            this.dataGridView_mod.AllowUserToAddRows = false;
            this.dataGridView_mod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_mod.Location = new System.Drawing.Point(12, 51);
            this.dataGridView_mod.Name = "dataGridView_mod";
            this.dataGridView_mod.ReadOnly = true;
            this.dataGridView_mod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_mod.Size = new System.Drawing.Size(482, 450);
            this.dataGridView_mod.TabIndex = 0;
            this.dataGridView_mod.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_mod_CellDoubleClick);
            // 
            // btn_ModOrder
            // 
            this.btn_ModOrder.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_ModOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ModOrder.Location = new System.Drawing.Point(661, 73);
            this.btn_ModOrder.Name = "btn_ModOrder";
            this.btn_ModOrder.Size = new System.Drawing.Size(75, 21);
            this.btn_ModOrder.TabIndex = 15;
            this.btn_ModOrder.Text = "Modify &Order";
            this.btn_ModOrder.UseVisualStyleBackColor = false;
            this.btn_ModOrder.Click += new System.EventHandler(this.btn_ModOrder_Click);
            // 
            // txt_Code
            // 
            this.txt_Code.Location = new System.Drawing.Point(504, 74);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.ReadOnly = true;
            this.txt_Code.Size = new System.Drawing.Size(151, 20);
            this.txt_Code.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OliveDrab;
            this.label7.Location = new System.Drawing.Point(500, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Order &Code:";
            // 
            // btn_User
            // 
            this.btn_User.BackColor = System.Drawing.Color.DarkViolet;
            this.btn_User.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_User.Location = new System.Drawing.Point(12, 12);
            this.btn_User.Name = "btn_User";
            this.btn_User.Size = new System.Drawing.Size(190, 23);
            this.btn_User.TabIndex = 18;
            this.btn_User.Text = "Change User";
            this.btn_User.UseVisualStyleBackColor = false;
            this.btn_User.Click += new System.EventHandler(this.btn_User_Click);
            // 
            // btn_AddOrder
            // 
            this.btn_AddOrder.BackColor = System.Drawing.Color.Brown;
            this.btn_AddOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_AddOrder.Location = new System.Drawing.Point(504, 100);
            this.btn_AddOrder.Name = "btn_AddOrder";
            this.btn_AddOrder.Size = new System.Drawing.Size(232, 23);
            this.btn_AddOrder.TabIndex = 19;
            this.btn_AddOrder.Text = "Add A New &Order";
            this.btn_AddOrder.UseVisualStyleBackColor = false;
            this.btn_AddOrder.Click += new System.EventHandler(this.btn_AddOrder_Click);
            // 
            // btn_Statistics
            // 
            this.btn_Statistics.BackColor = System.Drawing.Color.Gold;
            this.btn_Statistics.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Statistics.Location = new System.Drawing.Point(208, 12);
            this.btn_Statistics.Name = "btn_Statistics";
            this.btn_Statistics.Size = new System.Drawing.Size(193, 23);
            this.btn_Statistics.TabIndex = 20;
            this.btn_Statistics.Text = "Go To &Statistics";
            this.btn_Statistics.UseVisualStyleBackColor = false;
            this.btn_Statistics.Click += new System.EventHandler(this.btn_Statistics_Click);
            // 
            // YourOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 527);
            this.Controls.Add(this.btn_Statistics);
            this.Controls.Add(this.btn_AddOrder);
            this.Controls.Add(this.btn_User);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Code);
            this.Controls.Add(this.btn_ModOrder);
            this.Controls.Add(this.dataGridView_mod);
            this.Name = "YourOrders";
            this.Text = "YourOrders";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_mod;
        private System.Windows.Forms.Button btn_ModOrder;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_User;
        private System.Windows.Forms.Button btn_AddOrder;
        private System.Windows.Forms.Button btn_Statistics;
    }
}