using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WaterBill.Models;

namespace WinFormsApp10
{
    public partial class WaterBill : Form
    {
        public List<Bill> Bills { get; set; } = new List<Bill>();
        string currentPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        public WaterBill()
        {
            InitializeComponent();
            InitDatatable();
            LoadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = comboboxtype.Text.Trim().ToLower();
            if (type.Equals("household customer"))
            {
                txtNumberFamily.Enabled = true;
            }
            else
            {
                txtNumberFamily.Enabled = false;
                txtNumberFamily.Text = null;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dataTable.Rows.Add(
                txtName.Text,
              comboboxtype.Text, 
              txtNumberFamily.Text, 
             Convert.ToInt32(txtLastMonth.Text),
             Convert.ToInt32(txtThisMonth.Text), 
             Convert.ToInt32(txtWaterNumBer.Text), 
             Convert.ToSingle(txtPrices.Text)
            );
            dataGridView1.DataSource = dataTable;
            var bill = new Bill
            {
                Id = Bills.LastOrDefault() == null ? 1 : Bills.LastOrDefault().Id + 1,
                Name = txtName.Text,
                Type = comboboxtype.Text,
                FamilyOfNumber = string.IsNullOrEmpty(txtNumberFamily.Text) ? 0 : Convert.ToInt32(txtNumberFamily.Text),
                LastMonth = Convert.ToInt32(txtLastMonth.Text),
                ThisMonth = Convert.ToInt32(txtThisMonth.Text),
                WaterNumBer = Convert.ToInt32(txtWaterNumBer.Text),
                Price = Convert.ToSingle(txtPrices.Text)
            };
            Bills.Add(bill);
            // save to file json using Text.Json
            var json = System.Text.Json.JsonSerializer.Serialize(Bills);
            var path = System.IO.Path.Combine(currentPath, "Data", "bills.json");
            if (!System.IO.Directory.Exists(System.IO.Path.Combine(currentPath, "Data")))
            {
                System.IO.Directory.CreateDirectory(System.IO.Path.Combine(currentPath, "Data"));
            }
            System.IO.File.WriteAllText(path, json);
        }

        private void LoadData()
        {
            var path = System.IO.Path.Combine(currentPath, "Data", "bills.json");
            if (!System.IO.File.Exists(path))
            {
                return;
            }
            var json = System.IO.File.ReadAllText(path);
            Bills = System.Text.Json.JsonSerializer.Deserialize<List<Bill>>(json);
            foreach (var bill in Bills)
            {
                dataTable.Rows.Add(
                    bill.Name,
                    bill.Type,
                    bill.FamilyOfNumber,
                    bill.LastMonth,
                    bill.ThisMonth,
                    bill.WaterNumBer,
                    bill.Price
                );
            }
            dataGridView1.DataSource = dataTable;
        }


        private DataTable dataTable = new DataTable();

        
        void InitDatatable()
        {
            dataTable.Columns.Add("Customer name", typeof(string));
            dataTable.Columns.Add("Type", typeof(string));
            dataTable.Columns.Add("Member", typeof(string));
            dataTable.Columns.Add("Water last month", typeof(int));
            dataTable.Columns.Add("Water this month", typeof(int));
            dataTable.Columns.Add("Water number", typeof(int));
            dataTable.Columns.Add("Money", typeof(float));
            dataGridView1.DataSource = dataTable;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to escape or not", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;

            
            dataTable.Rows.RemoveAt(rowIndex);


            
            dataGridView1.DataSource = dataTable;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private bool IsNumber(string value)
        {
            double number;
            return double.TryParse(value, out number);
        }

        private bool IsAlphabet(string value)
        {
            return Regex.IsMatch(value, @"^[a-zA-Z]+$");
        }
        private void BtnCaculate_Click(object sender, EventArgs e)
        {
            if (comboboxtype.Text == "household customer")
            {

                if (string.IsNullOrEmpty(txtName.Text) ||

                string.IsNullOrEmpty(txtNumberFamily.Text) ||
                string.IsNullOrEmpty(txtLastMonth.Text) ||
                string.IsNullOrEmpty(txtThisMonth.Text))
                {
                    MessageBox.Show("Can not be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtName.Text) ||
                    string.IsNullOrEmpty(comboboxtype.Text) ||
                    string.IsNullOrEmpty(txtLastMonth.Text) ||
                    string.IsNullOrEmpty(txtThisMonth.Text))
                {
                    MessageBox.Show("Can not be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            string txtNameValue = txtName.Text;
            if (!IsAlphabet(txtNameValue))
            {
                MessageBox.Show("Invalid value. Please enter letters in the name.");
                return;
            }

            string comboBoxTypeValue = comboboxtype.Text;


            if (comboboxtype.Text == "Household Customer")
            {
                string txtNumberFamilyValue = txtNumberFamily.Text;
                if (!IsNumber(txtNumberFamilyValue))
                {
                    MessageBox.Show("Invalid value. Please re-enter your member number.");
                    return;
                }
                int numberFamily = int.Parse(txtNumberFamilyValue);
                if (numberFamily <= 0)
                {
                    MessageBox.Show("Please enter a valid number of family members.");
                    return;
                }
                string txtLastMonthValue = txtLastMonth.Text;
                if (!IsNumber(txtLastMonthValue))
                {
                    MessageBox.Show("Invalid value. Please re-enter the previous month's water number.");
                    return;
                }

                string txtThisMonthValue = txtThisMonth.Text;
                if (!IsNumber(txtThisMonthValue))
                {
                    MessageBox.Show("Invalid value. Please re-enter this month's water number.");
                    return;
                }

            }

            if (comboboxtype.Text == "Administrative Agency" || comboboxtype.Text == "Prodution Units" || comboboxtype.Text == "Business Services")
            {


                string txtLastMonthValue = txtLastMonth.Text;
                if (!IsNumber(txtLastMonthValue))
                {
                    MessageBox.Show("Invalid value. Please re-enter the previous month's water number.");
                    return;
                }

                string txtThisMonthValue = txtThisMonth.Text;
                if (!IsNumber(txtThisMonthValue))
                {
                    MessageBox.Show("Invalid value. Please re-enter this month's water number.");
                    return;
                }
            }

            int a = Convert.ToInt32(txtLastMonth.Text);
            int b = Convert.ToInt32(txtThisMonth.Text);
            if (a < 0 || b < 0)
            {
                MessageBox.Show("The number of water cannot be negative!");
                return;
            }
            int waterPreviousMonth, waterCurrentMonth;
            waterPreviousMonth = Convert.ToInt32(txtLastMonth.Text);
            waterCurrentMonth = Convert.ToInt32(txtThisMonth.Text);
            if (waterPreviousMonth > waterCurrentMonth)
            {
                MessageBox.Show("Water consumption of the previous month must be less than or equal to this month");
                return;
            }
            
            var typeselect = comboboxtype.Text;
            var ttNumberFamily = txtNumberFamily.Text;
            /*Household Customer
            Administrative Agency
            Prodution Units 
            Business Services */
            int totalWater = waterCurrentMonth - waterPreviousMonth;
            txtWaterNumBer.Text = totalWater.ToString();
            if (typeselect.Contains("Household Customer"))
            {
                int numberFamily = Convert.ToInt32(ttNumberFamily);
                double waterPerPerson = totalWater / numberFamily;

                {

                    if (waterPreviousMonth <= waterCurrentMonth)
                    {

                        if (waterPerPerson > 0 && totalWater <= 10)
                        {
                            double bill = (totalWater * 5.973) * 1.1;
                            txtPrices.Text = bill.ToString();
                            btnAdd.Enabled = true;
                        }
                        else if (waterPerPerson > 10 && waterPerPerson <= 20)
                        {
                            double bill = (totalWater * 7.052) * 1.1;
                            txtPrices.Text = bill.ToString();
                            btnAdd.Enabled = true;
                        }
                        else if (waterPerPerson > 20 && waterPerPerson <= 30)
                        {
                            double bill = (totalWater * 8.699) * 1.1;

                            txtPrices.Text = bill.ToString();
                            btnAdd.Enabled = true;
                        }
                        else
                        {
                            double bill = (totalWater * 15.929) * 1.1;
                            txtPrices.Text = bill.ToString();
                            btnAdd.Enabled = true;
                        }
                    }
                    else
                    {
                        //Console.Write("Water consumption of the previous month must be less than or equal to this month ");
                        MessageBox.Show("Water consumption of the previous month must be less than or equal to this month");
                    }

                }
            }
            else if (typeselect.Contains("Administrative Agency"))
            {


                double bill = (waterCurrentMonth - waterPreviousMonth) * 9955 * 1.1;
                //Console.WriteLine("{0:N}VND water bill for administrative public service agency", bill);
                txtPrices.Text = bill.ToString();
                btnAdd.Enabled = true;

            }
            else if (typeselect.Contains("Prodution Units"))
            {
                double bill = (waterCurrentMonth - waterPreviousMonth) * 11.615 * 1.1;
                //Console.WriteLine("{0:N}VND water bill for manufacturing unit", bill);
                txtPrices.Text = bill.ToString();

                btnAdd.Enabled = true;

            }
            else if (typeselect.Contains("Business Services"))
            {
                double bill = (waterCurrentMonth - waterPreviousMonth) * 22.068 * 1.1;
                //Console.WriteLine("{0:N}VND water bill for business service", bill);
                txtPrices.Text = bill.ToString();
                btnAdd.Enabled = true;

            }
            else
            {
                MessageBox.Show("Error: Please select customer type again");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPrices.Text = null;
            txtLastMonth.Text = null;
            txtName.Text = null;
            txtNumberFamily.Text = null;
            txtThisMonth.Text = null;
            txtWaterNumBer.Text = null;
            comboboxtype.Text = null;
            btnAdd.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void WaterBill_Load(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string name = txtFind.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter the name you want to search for", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var bills = Bills.Where(x => x.Name.ToLower().Contains(name.ToLower())).ToList();
            dataTable.Rows.Clear();
            foreach (var bill in bills)
            {
                dataTable.Rows.Add(
                    bill.Name,
                    bill.Type,
                    bill.FamilyOfNumber,
                    bill.LastMonth,
                    bill.ThisMonth,
                    bill.WaterNumBer,
                    bill.Price
                );
            }
            dataGridView1.DataSource = dataTable;

        }
    }
}
