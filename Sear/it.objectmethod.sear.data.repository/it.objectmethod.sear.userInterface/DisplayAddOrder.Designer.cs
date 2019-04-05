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
            this.btn_AddItems = new System.Windows.Forms.Button();
            this.dataGridView_Orders = new System.Windows.Forms.DataGridView();
            this.displayAddOrderBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.displayAddOrderBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.displayAddOrderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.displayAddOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.displayAddOrderBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.displayAddOrderBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.displayAddOrderBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.staffnamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikeStoresDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffnamesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayAddOrderBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayAddOrderBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayAddOrderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayAddOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayAddOrderBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayAddOrderBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayAddOrderBindingSource6)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Olive;
            this.btn_back.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_back.Location = new System.Drawing.Point(574, 19);
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
            this.btn_AddOrder.Location = new System.Drawing.Point(552, 90);
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
            // btn_AddItems
            // 
            this.btn_AddItems.BackColor = System.Drawing.Color.Orange;
            this.btn_AddItems.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_AddItems.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_AddItems.Location = new System.Drawing.Point(454, 19);
            this.btn_AddItems.Name = "btn_AddItems";
            this.btn_AddItems.Size = new System.Drawing.Size(114, 23);
            this.btn_AddItems.TabIndex = 21;
            this.btn_AddItems.Text = "AddItems";
            this.btn_AddItems.UseVisualStyleBackColor = false;
            this.btn_AddItems.Click += new System.EventHandler(this.AddItems_Click);
            // 
            // dataGridView_Orders
            // 
            this.dataGridView_Orders.AllowUserToAddRows = false;
            this.dataGridView_Orders.AutoGenerateColumns = false;
            this.dataGridView_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.productionYearDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.TotalPrice,
            this.Delete});
            this.dataGridView_Orders.DataSource = this.displayAddOrderBindingSource6;
            this.dataGridView_Orders.Location = new System.Drawing.Point(4, 157);
            this.dataGridView_Orders.Name = "dataGridView_Orders";
            this.dataGridView_Orders.Size = new System.Drawing.Size(645, 150);
            this.dataGridView_Orders.TabIndex = 22;
            // 
            // displayAddOrderBindingSource6
            // 
            this.displayAddOrderBindingSource6.DataSource = typeof(Sear.it.objectmethod.sear.data.repository.it.objectmethod.Sear.UserInterface.DisplayAddOrder);
            // 
            // Product
            // 
            this.Product.DataPropertyName = "Product";
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.Width = 150;
            // 
            // productionYearDataGridViewTextBoxColumn
            // 
            this.productionYearDataGridViewTextBoxColumn.DataPropertyName = "ProductionYear";
            this.productionYearDataGridViewTextBoxColumn.HeaderText = "ProductionYear";
            this.productionYearDataGridViewTextBoxColumn.Name = "productionYearDataGridViewTextBoxColumn";
            this.productionYearDataGridViewTextBoxColumn.Width = 150;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "TotalPrice";
            this.TotalPrice.Name = "TotalPrice";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // DisplayAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 344);
            this.Controls.Add(this.dataGridView_Orders);
            this.Controls.Add(this.btn_AddItems);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayAddOrderBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayAddOrderBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayAddOrderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayAddOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayAddOrderBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayAddOrderBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayAddOrderBindingSource6)).EndInit();
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
        private System.Windows.Forms.Button btn_AddItems;
        private System.Windows.Forms.DataGridView dataGridView_Orders;
        private System.Windows.Forms.DataGridViewTextBoxColumn acceptButtonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn autoScrollDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn autoSizeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoSizeModeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoValidateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn backColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formBorderStyleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cancelButtonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn controlBoxDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn helpButtonDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn iconDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isMdiContainerDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn keyPreviewDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maximumSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainMenuStripDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimumSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn maximizeBoxDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn minimizeBoxDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rightToLeftLayoutDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn showInTaskbarDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn showIconDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeGripStyleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn topMostDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transparencyKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn windowStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoScrollMarginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoScrollMinSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessibleDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessibleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessibleRoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn allowDropDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anchorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn backgroundImageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn backgroundImageLayoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn causesValidationDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contextMenuStripDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataBindingsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn enabledDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fontDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foreColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rightToLeftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn useWaitCursorDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn visibleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paddingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeModeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource displayAddOrderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn16;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.BindingSource displayAddOrderBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productProductionYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource displayAddOrderBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn18;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn20;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn21;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn22;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn24;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn26;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn27;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn56;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn57;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn58;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn59;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn60;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn61;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn62;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn63;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn64;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn65;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn66;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn67;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn68;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn69;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn70;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn33;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn71;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn72;
        private System.Windows.Forms.BindingSource displayAddOrderBindingSource3;
        private System.Windows.Forms.BindingSource displayAddOrderBindingSource4;
        private System.Windows.Forms.BindingSource displayAddOrderBindingSource5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.BindingSource displayAddOrderBindingSource6;
    }
}