using BC00463_datndt_assignment2;
using Microsoft.VisualBasic.Logging;
using System.Diagnostics;

namespace BC00463_datndt_assignment2
{
    public partial class Form1 : Form
    {
        // List to store invoices
        public List<Invoice> Invoices = new List<Invoice>();

        // VAT tax rate
        const double VAT = 0.1;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Initialize customer types list

            cboTypeOfCustomer.Items.Add("Household customer");
            cboTypeOfCustomer.Items.Add("Administration agency, public services");
            cboTypeOfCustomer.Items.Add("Production units");
            cboTypeOfCustomer.Items.Add("Business services");

            // Configure the ListView

            lvWaterBill.View = View.Details;
            lvWaterBill.Columns.Add("Customer Name", 200);
            lvWaterBill.Columns.Add("Last Month Water Meter", 200);
            lvWaterBill.Columns.Add("This Month Water Meter", 200);
            lvWaterBill.Columns.Add("Amount Of Consumption", 200);
            lvWaterBill.Columns.Add("Total Water Bill", 200);

            //Initialize Sort Type List
            cboArrange.Items.Add("Sort by Name (A-Z)");
            cboArrange.Items.Add("Sort by Consumption (Low to High)");
            cboArrange.Items.Add("Sort by Consumption (High to Low)");
            cboArrange.Items.Add("Sort by Total Bill (Low to High)");
            cboArrange.Items.Add("Sort by Total Bill (High to Low)");
        }

       

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Get input data from form fields

            string customername = txtCustomerName.Text.Trim();
            string customertype = cboTypeOfCustomer.Text.Trim();
            int numberofmember = 0;
            double lastmonthwatermeter = 0;
            double thismonthwatermeter = 0;

            // Validate input data

            if (customername == "")
            {
                MessageBox.Show("Please enter the customer's name", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (customertype == "")
            {
                MessageBox.Show("Select customer type", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (customertype == "Household customer")
            {
                if (!int.TryParse(txtNumberOfMembers.Text, out numberofmember) || numberofmember == 0)
                {
                    MessageBox.Show("Please enter number of member", " Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (!double.TryParse(txtLastMonthWaterMeter.Text, out lastmonthwatermeter) || lastmonthwatermeter <= 0)

            {
                MessageBox.Show("Last month water meter should be a positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtThisMonthWaterMeter.Text, out thismonthwatermeter) || thismonthwatermeter < 0)
            {
                MessageBox.Show("This month water meter should be a positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            


            // Calculate water bill

            var waterBill = Calculator(customertype, numberofmember, lastmonthwatermeter, thismonthwatermeter);

            // Display result in ListView

            ListViewItem item = new ListViewItem(customername);
            item.SubItems.Add(lastmonthwatermeter.ToString());
            item.SubItems.Add(thismonthwatermeter.ToString());
            item.SubItems.Add(waterBill.Item1.ToString());
            item.SubItems.Add(waterBill.Item2.ToString());
            lvWaterBill.Items.Add(item);


            // Store data in the list of invoices

            Invoice invoice = new Invoice
            {
                CustomerName = customername,
                LastMonthWaterMeter = lastmonthwatermeter,
                ThisMonthWaterMeter = thismonthwatermeter,
                Consumption = waterBill.Item1,
                WaterMoney = waterBill.Item2,
            };

            Invoices.Add(invoice);



        }

        private void cboTypeOfCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Enable or disable the number of members input based on customer type
            string customertype = cboTypeOfCustomer.Text;
            if (customertype == "Household customer")
            {
                txtNumberOfMembers.Enabled = true; // Enable input for household customers

            }
            else
            {
                txtNumberOfMembers.Enabled = false; // Disable input for other types
                txtNumberOfMembers.Text = ""; // Clear input field
            }
        }

        // Method to calculate the water bill based on customer type

        private (double, double) Calculator(string customertype, int numberofmember, double lastmonthwatermeter, double thismonthwatermeter)
        {
            double consumption = thismonthwatermeter - lastmonthwatermeter;
            double waterMoney = 0;

            // Check if the water consumption this month is negative.
            if (consumption < 0) 
            {
                MessageBox.Show
                    (
                    "Please check the water information from last month and this month",
                    "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
            } 
               
            // Calculate water money based on customer type
            if (customertype == "Household customer")
            {
                double averagePerson = consumption / numberofmember;

                if (averagePerson < 10)
                {
                    waterMoney = consumption * 5973;
                }
                else if (averagePerson >= 10 && averagePerson < 20)
                {
                    waterMoney = consumption * 7052;
                }
                else if (averagePerson >= 20 && averagePerson < 30)
                {
                    waterMoney = consumption * 8699;
                }
                else if (averagePerson >= 30)
                {
                    waterMoney = consumption * 15929;
                }
            }
            else if (customertype == "Administration agency, public services")
            {
                waterMoney = consumption * 9955;
            }
            else if (customertype == "Production units")
            {
                waterMoney = consumption * 11615;
            }
            else if (customertype == "Business services")
            {
                waterMoney = consumption * 22068;
            }

            // Apply VAT tax
            waterMoney += (waterMoney * VAT);
            return (consumption, waterMoney);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Search invoices by customer name
            string search = txtSearch.Text.Trim();
            lvWaterBill.Items.Clear();
            bool foundResult = false;

            if (search == "")
            {
                // Display all invoices if search box is empty
                foreach (Invoice invoice in Invoices)
                {
                    ListViewItem item = new ListViewItem(invoice.CustomerName);
                    item.SubItems.Add(invoice.LastMonthWaterMeter.ToString());
                    item.SubItems.Add(invoice.ThisMonthWaterMeter.ToString());
                    item.SubItems.Add(invoice.Consumption.ToString());
                    item.SubItems.Add(invoice.WaterMoney.ToString());
                    lvWaterBill.Items.Add(item);
                }
                foundResult = true;
            }
            else
            {
                // Search for invoices by customer name
                foreach (Invoice invoice in Invoices)
                {
                    if (invoice.CustomerName.ToLower().Contains(search))
                    {
                        ListViewItem item = new ListViewItem(invoice.CustomerName);
                        item.SubItems.Add(invoice.LastMonthWaterMeter.ToString());
                        item.SubItems.Add(invoice.ThisMonthWaterMeter.ToString());
                        item.SubItems.Add(invoice.Consumption.ToString());
                        item.SubItems.Add(invoice.WaterMoney.ToString());
                        lvWaterBill.Items.Add(item);
                        foundResult = true;
                    }
                }

            }
            if (!foundResult)
            {
                // Display a message if no results are found
                ListViewItem item = new ListViewItem("No results found.");
                lvWaterBill.Items.Add(item);
            }
        }


        // Invoice class representing an invoice
        public class Invoice
        {
            public string CustomerName { get; set;}

            public double LastMonthWaterMeter { get; set; }

            public double ThisMonthWaterMeter { get; set; }

            public double Consumption { get; set; }

            public double WaterMoney { get; set; }

        }

        private void lvWaterBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if any item is selected
            if (lvWaterBill.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvWaterBill.SelectedItems[0];

                // Retrieve details from the selected item
                string customerName = selectedItem.SubItems[0].Text;
                double lastMonthWaterMeter = double.Parse(selectedItem.SubItems[1].Text);
                double thisMonthWaterMeter = double.Parse(selectedItem.SubItems[2].Text);
                double consumption = double.Parse(selectedItem.SubItems[3].Text);
                double waterMoney = double.Parse(selectedItem.SubItems[4].Text);

                // Instantiate Form2 and pass the selected item details to it
                Form2 form2 = new Form2(customerName, lastMonthWaterMeter, thisMonthWaterMeter, consumption, waterMoney);
                form2.Show();
            }
        }

        private void cboArrange_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Retrieve the selected sort option
            string sortOption = cboArrange.SelectedItem.ToString();

            //Sort the invoices list based on the selected option
            switch (sortOption)
            {
                case "Sort by Name (A-Z)":
                    // Nested loop to sort invoices by CustomerName in ascending order
                    for (int i = 0; i < Invoices.Count; i++)
                    {
                        Invoice temp = Invoices[i];
                        for (int j = i + 1; j < Invoices.Count; j++)
                        {
                            if (string.Compare(Invoices[i].CustomerName, Invoices[j].CustomerName) > 0)
                            {
                                Invoices[i] = Invoices[j];
                                Invoices[j] = temp;
                                temp = Invoices[i];
                            }
                        }
                    }
                    break;

                case "Sort by Consumption (Low to High)":
                    // Nested loop to sort invoices by Consumption in ascending order
                    for (int i = 0; i < Invoices.Count - 1; i++)
                    {
                        for (int j = i + 1; j < Invoices.Count; j++)
                        {
                            if (Invoices[i].Consumption > Invoices[j].Consumption)
                            {
                                Invoice temp = Invoices[i];
                                Invoices[i] = Invoices[j];
                                Invoices[j] = temp;
                            }
                        }
                    }
                    break;

                case "Sort by Consumption (High to Low)":
                    // Nested loop to sort invoices by Consumption in descending order
                    for (int i = 0; i < Invoices.Count; i++)
                    {
                        for (int j = i + 1; j < Invoices.Count; j++)
                        {
                            if (Invoices[i].Consumption < Invoices[j].Consumption)
                            {
                                Invoice temp = Invoices[i];
                                Invoices[i] = Invoices[j];
                                Invoices[j] = temp;
                            }
                        }
                    }
                    break;
                case "Sort by Total Bill (Low to High)":
                    // Nested loop to sort invoices by WaterMoney in ascending order
                    for (int i = 0; i < Invoices.Count; i++)
                    {
                        for (int j = i + 1; j < Invoices.Count; j++)
                        {
                            if (Invoices[i].WaterMoney > Invoices[j].WaterMoney)
                            {
                                Invoice temp = Invoices[i];
                                Invoices[i] = Invoices[j];
                                Invoices[j] = temp;
                            }
                        }
                    }
                    break;
                case "Sort by Total Bill (High to Low)":
                    // Nested loop to sort invoices by WaterMoney in descending order
                    for (int i = 0; i < Invoices.Count; i++)
                    {
                        for (int j = i + 1; j < Invoices.Count; j++)
                        {
                            if (Invoices[i].WaterMoney < Invoices[j].WaterMoney)
                            {
                                Invoice temp = Invoices[i];
                                Invoices[i] = Invoices[j];
                                Invoices[j] = temp;
                            }
                        }
                    }
                    break;
                default:
                    break;
            }
            UpdateListView();
        }


        private void UpdateListView()
        {
            // Clear the ListView before adding updated items
            lvWaterBill.Items.Clear();

            // Add sorted invoices to ListView
            foreach (Invoice invoice in Invoices)
            {
                ListViewItem item = new ListViewItem(invoice.CustomerName);
                item.SubItems.Add(invoice.LastMonthWaterMeter.ToString());
                item.SubItems.Add(invoice.ThisMonthWaterMeter.ToString());
                item.SubItems.Add(invoice.Consumption.ToString());
                item.SubItems.Add(invoice.WaterMoney.ToString());
                lvWaterBill.Items.Add(item);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //used to delete information
            txtCustomerName.Text = "";
            cboTypeOfCustomer.Text = "";
            txtNumberOfMembers.Text = "";
            txtLastMonthWaterMeter.Text = "";
            txtThisMonthWaterMeter.Text = "";
        }
    }
}