namespace Sear.it.objectmethod.sear.data.repository.it.objectmethod.Sear.UserInterface
{
    partial class DisplayAddOrder
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
            this.components = new System.ComponentModel.Container();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_AddOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Customer = new System.Windows.Forms.TextBox();
            this.staffnamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bikeStoresDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffnamesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.staffDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox_StoreNames = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.staffnamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikeStoresDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffnamesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Olive;
            this.btn_back.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_back.Location = new System.Drawing.Point(316, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "go back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_AddOrder
            // 
            this.btn_AddOrder.BackColor = System.Drawing.Color.DarkRed;
            this.btn_AddOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_AddOrder.Location = new System.Drawing.Point(304, 90);
            this.btn_AddOrder.Name = "btn_AddOrder";
            this.btn_AddOrder.Size = new System.Drawing.Size(87, 46);
            this.btn_AddOrder.TabIndex = 1;
            this.btn_AddOrder.Text = "AddNewOrder";
            this.btn_AddOrder.UseVisualStyleBackColor = false;
            this.btn_AddOrder.Click += new System.EventHandler(this.btn_AddOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Staff:";
            // 
            // txt_Customer
            // 
            this.txt_Customer.Location = new System.Drawing.Point(99, 19);
            this.txt_Customer.Name = "txt_Customer";
            this.txt_Customer.Size = new System.Drawing.Size(120, 20);
            this.txt_Customer.TabIndex = 7;
            // 
            // staffnamesBindingSource
            // 
            this.staffnamesBindingSource.DataMember = "staff_names";
            // 
            // staffsBindingSource
            // 
            this.staffsBindingSource.DataMember = "staffs";
            // 
            // staffnamesBindingSource1
            // 
            this.staffnamesBindingSource1.DataMember = "staff_names";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(98, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // comboBox_StoreNames
            // 
            this.comboBox_StoreNames.FormattingEnabled = true;
            this.comboBox_StoreNames.Location = new System.Drawing.Point(98, 45);
            this.comboBox_StoreNames.Name = "comboBox_StoreNames";
            this.comboBox_StoreNames.Size = new System.Drawing.Size(121, 21);
            this.comboBox_StoreNames.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Stores:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Data:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(99, 101);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker.TabIndex = 20;
            // 
            // DisplayAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 163);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_StoreNames);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_Customer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AddOrder);
            this.Controls.Add(this.btn_back);
            this.Name = "DisplayAddOrder";
            this.Text = "AddOrder";
            this.Load += new System.EventHandler(this.DisplayAddOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staffnamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikeStoresDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffnamesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_AddOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Customer;

        private System.Windows.Forms.BindingSource staffnamesBindingSource;
        private System.Windows.Forms.BindingSource bikeStoresDataSet1BindingSource;
        private System.Windows.Forms.BindingSource staffsBindingSource;
        private System.Windows.Forms.BindingSource staffDataSetBindingSource;
        private System.Windows.Forms.BindingSource staffnamesBindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox_StoreNames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}