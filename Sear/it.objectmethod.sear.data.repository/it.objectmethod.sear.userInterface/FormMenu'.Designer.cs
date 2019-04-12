namespace Sear.it.objectmethod.sear.data.repository.it.objectmethod.sear.userInterface
{
    partial class FormMenu
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
            this.btn_StatisticsOpen = new System.Windows.Forms.Button();
            this.btn_OrderOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_StatisticsOpen
            // 
            this.btn_StatisticsOpen.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btn_StatisticsOpen.FlatAppearance.BorderSize = 0;
            this.btn_StatisticsOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StatisticsOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StatisticsOpen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_StatisticsOpen.Location = new System.Drawing.Point(12, 12);
            this.btn_StatisticsOpen.Name = "btn_StatisticsOpen";
            this.btn_StatisticsOpen.Size = new System.Drawing.Size(167, 63);
            this.btn_StatisticsOpen.TabIndex = 0;
            this.btn_StatisticsOpen.Text = "STATISTICS";
            this.btn_StatisticsOpen.UseVisualStyleBackColor = false;
            this.btn_StatisticsOpen.Click += new System.EventHandler(this.btn_StatisticsOpen_Click);
            // 
            // btn_OrderOpen
            // 
            this.btn_OrderOpen.BackColor = System.Drawing.Color.DarkRed;
            this.btn_OrderOpen.FlatAppearance.BorderSize = 0;
            this.btn_OrderOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OrderOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OrderOpen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_OrderOpen.Location = new System.Drawing.Point(12, 93);
            this.btn_OrderOpen.Name = "btn_OrderOpen";
            this.btn_OrderOpen.Size = new System.Drawing.Size(167, 63);
            this.btn_OrderOpen.TabIndex = 1;
            this.btn_OrderOpen.Text = "ORDER MANAGEMENT";
            this.btn_OrderOpen.UseVisualStyleBackColor = false;
            this.btn_OrderOpen.Click += new System.EventHandler(this.btn_OrderOpen_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(190, 172);
            this.Controls.Add(this.btn_OrderOpen);
            this.Controls.Add(this.btn_StatisticsOpen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_StatisticsOpen;
        private System.Windows.Forms.Button btn_OrderOpen;
    }
}