namespace BC00463_datndt_assignment2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCalculate = new Button();
            txtThisMonthWaterMeter = new TextBox();
            txtLastMonthWaterMeter = new TextBox();
            txtNumberOfMembers = new TextBox();
            txtCustomerName = new TextBox();
            cboTypeOfCustomer = new ComboBox();
            lvWaterBill = new ListView();
            txtSearch = new TextBox();
            label6 = new Label();
            cboArrange = new ComboBox();
            label7 = new Label();
            btnClear = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Linen;
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnCalculate);
            groupBox1.Controls.Add(txtThisMonthWaterMeter);
            groupBox1.Controls.Add(txtLastMonthWaterMeter);
            groupBox1.Controls.Add(txtNumberOfMembers);
            groupBox1.Controls.Add(txtCustomerName);
            groupBox1.Controls.Add(cboTypeOfCustomer);
            groupBox1.Location = new Point(23, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(318, 428);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Calculator";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 296);
            label5.Name = "label5";
            label5.Size = new Size(171, 20);
            label5.TabIndex = 13;
            label5.Text = "This Month Water Meter:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 227);
            label4.Name = "label4";
            label4.Size = new Size(171, 20);
            label4.TabIndex = 12;
            label4.Text = "Last Month Water Meter:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 160);
            label3.Name = "label3";
            label3.Size = new Size(152, 20);
            label3.TabIndex = 11;
            label3.Text = "Number Of Members:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 96);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 10;
            label2.Text = "Type Of Customer:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 31);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 9;
            label1.Text = "Customer Name:";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(202, 370);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtThisMonthWaterMeter
            // 
            txtThisMonthWaterMeter.Location = new Point(38, 319);
            txtThisMonthWaterMeter.Name = "txtThisMonthWaterMeter";
            txtThisMonthWaterMeter.PlaceholderText = "This month water meter";
            txtThisMonthWaterMeter.Size = new Size(192, 27);
            txtThisMonthWaterMeter.TabIndex = 7;
            // 
            // txtLastMonthWaterMeter
            // 
            txtLastMonthWaterMeter.Location = new Point(38, 250);
            txtLastMonthWaterMeter.Name = "txtLastMonthWaterMeter";
            txtLastMonthWaterMeter.PlaceholderText = "Last month water meter";
            txtLastMonthWaterMeter.Size = new Size(192, 27);
            txtLastMonthWaterMeter.TabIndex = 6;
            // 
            // txtNumberOfMembers
            // 
            txtNumberOfMembers.Enabled = false;
            txtNumberOfMembers.Location = new Point(38, 183);
            txtNumberOfMembers.Name = "txtNumberOfMembers";
            txtNumberOfMembers.PlaceholderText = "Number of members";
            txtNumberOfMembers.Size = new Size(192, 27);
            txtNumberOfMembers.TabIndex = 5;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(38, 54);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.PlaceholderText = "Customer Name";
            txtCustomerName.Size = new Size(192, 27);
            txtCustomerName.TabIndex = 4;
            // 
            // cboTypeOfCustomer
            // 
            cboTypeOfCustomer.FormattingEnabled = true;
            cboTypeOfCustomer.Location = new Point(38, 119);
            cboTypeOfCustomer.Name = "cboTypeOfCustomer";
            cboTypeOfCustomer.Size = new Size(192, 28);
            cboTypeOfCustomer.TabIndex = 3;
            cboTypeOfCustomer.SelectedIndexChanged += cboTypeOfCustomer_SelectedIndexChanged;
            // 
            // lvWaterBill
            // 
            lvWaterBill.FullRowSelect = true;
            lvWaterBill.GridLines = true;
            lvWaterBill.Location = new Point(371, 52);
            lvWaterBill.Name = "lvWaterBill";
            lvWaterBill.Size = new Size(742, 376);
            lvWaterBill.TabIndex = 1;
            lvWaterBill.UseCompatibleStateImageBehavior = false;
            lvWaterBill.SelectedIndexChanged += lvWaterBill_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(449, 20);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(207, 27);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(383, 23);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 3;
            label6.Text = "Search:";
            // 
            // cboArrange
            // 
            cboArrange.FormattingEnabled = true;
            cboArrange.Location = new Point(772, 20);
            cboArrange.Name = "cboArrange";
            cboArrange.Size = new Size(151, 28);
            cboArrange.TabIndex = 4;
            cboArrange.SelectedIndexChanged += cboArrange_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(701, 23);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 5;
            label7.Text = "Arrange:";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(22, 370);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 450);
            Controls.Add(label7);
            Controls.Add(cboArrange);
            Controls.Add(label6);
            Controls.Add(txtSearch);
            Controls.Add(lvWaterBill);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtThisMonthWaterMeter;
        private TextBox txtLastMonthWaterMeter;
        private TextBox txtNumberOfMembers;
        private TextBox txtCustomerName;
        private ComboBox cboTypeOfCustomer;
        private Button btnCalculate;
        private ListView lvWaterBill;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtSearch;
        private Label label6;
        private ComboBox cboArrange;
        private Button btnClear;
        private Label label7;
    }
}
