using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BC00463_datndt_assignment2
{
    public partial class Form2 : Form
    {
        public Form2(string customerName, double lastMonthWaterMeter, double thisMonthWaterMeter, double consumption, double waterMoney)
        {
            InitializeComponent();

            lbCustomerName.Text = customerName;
            lbLastMonthWaterMeter.Text = lastMonthWaterMeter.ToString();
            lbThisMonthWaterMeter.Text = thisMonthWaterMeter.ToString();
            lbAmountOfConsumption.Text = consumption.ToString();
            lbTotalWaterBill.Text = waterMoney.ToString("C") ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for paying the bill.", "Notification", MessageBoxButtons.OK);
        }
    }
}
