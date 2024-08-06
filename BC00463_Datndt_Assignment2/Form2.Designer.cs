namespace BC00463_datndt_assignment2
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
            label1 = new Label();
            lbCustomerName = new Label();
            lbLastMonthWaterMeter = new Label();
            lbThisMonthWaterMeter = new Label();
            lbAmountOfConsumption = new Label();
            lbTotalWaterBill = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(321, 37);
            label1.Name = "label1";
            label1.Size = new Size(146, 38);
            label1.TabIndex = 0;
            label1.Text = "Water Bill";
            // 
            // lbCustomerName
            // 
            lbCustomerName.AutoSize = true;
            lbCustomerName.Font = new Font("Segoe UI", 12F);
            lbCustomerName.Location = new Point(428, 112);
            lbCustomerName.Name = "lbCustomerName";
            lbCustomerName.Size = new Size(157, 28);
            lbCustomerName.TabIndex = 1;
            lbCustomerName.Text = "Customer Name:";
            // 
            // lbLastMonthWaterMeter
            // 
            lbLastMonthWaterMeter.AutoSize = true;
            lbLastMonthWaterMeter.Font = new Font("Segoe UI", 12F);
            lbLastMonthWaterMeter.Location = new Point(428, 169);
            lbLastMonthWaterMeter.Name = "lbLastMonthWaterMeter";
            lbLastMonthWaterMeter.Size = new Size(228, 28);
            lbLastMonthWaterMeter.TabIndex = 2;
            lbLastMonthWaterMeter.Text = "Last Month Water Meter:";
            // 
            // lbThisMonthWaterMeter
            // 
            lbThisMonthWaterMeter.AutoSize = true;
            lbThisMonthWaterMeter.Font = new Font("Segoe UI", 12F);
            lbThisMonthWaterMeter.Location = new Point(428, 221);
            lbThisMonthWaterMeter.Name = "lbThisMonthWaterMeter";
            lbThisMonthWaterMeter.Size = new Size(228, 28);
            lbThisMonthWaterMeter.TabIndex = 3;
            lbThisMonthWaterMeter.Text = "This Month Water Meter:";
            // 
            // lbAmountOfConsumption
            // 
            lbAmountOfConsumption.AutoSize = true;
            lbAmountOfConsumption.Font = new Font("Segoe UI", 12F);
            lbAmountOfConsumption.Location = new Point(428, 268);
            lbAmountOfConsumption.Name = "lbAmountOfConsumption";
            lbAmountOfConsumption.Size = new Size(236, 28);
            lbAmountOfConsumption.TabIndex = 4;
            lbAmountOfConsumption.Text = "Amount Of Consumption:";
            // 
            // lbTotalWaterBill
            // 
            lbTotalWaterBill.AutoSize = true;
            lbTotalWaterBill.Font = new Font("Segoe UI", 12F);
            lbTotalWaterBill.Location = new Point(428, 324);
            lbTotalWaterBill.Name = "lbTotalWaterBill";
            lbTotalWaterBill.Size = new Size(146, 28);
            lbTotalWaterBill.TabIndex = 5;
            lbTotalWaterBill.Text = "Total Water Bill:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button1.Location = new Point(562, 383);
            button1.Name = "button1";
            button1.Size = new Size(94, 38);
            button1.TabIndex = 6;
            button1.Text = "Pay";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(191, 112);
            label2.Name = "label2";
            label2.Size = new Size(157, 28);
            label2.TabIndex = 7;
            label2.Text = "Customer Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(191, 169);
            label3.Name = "label3";
            label3.Size = new Size(228, 28);
            label3.TabIndex = 8;
            label3.Text = "Last Month Water Meter:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(191, 221);
            label4.Name = "label4";
            label4.Size = new Size(228, 28);
            label4.TabIndex = 9;
            label4.Text = "This Month Water Meter:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(191, 268);
            label5.Name = "label5";
            label5.Size = new Size(236, 28);
            label5.TabIndex = 10;
            label5.Text = "Amount Of Consumption:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(191, 324);
            label6.Name = "label6";
            label6.Size = new Size(146, 28);
            label6.TabIndex = 11;
            label6.Text = "Total Water Bill:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(lbTotalWaterBill);
            Controls.Add(lbAmountOfConsumption);
            Controls.Add(lbThisMonthWaterMeter);
            Controls.Add(lbLastMonthWaterMeter);
            Controls.Add(lbCustomerName);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbCustomerName;
        private Label lbLastMonthWaterMeter;
        private Label lbThisMonthWaterMeter;
        private Label lbAmountOfConsumption;
        private Label lbTotalWaterBill;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}