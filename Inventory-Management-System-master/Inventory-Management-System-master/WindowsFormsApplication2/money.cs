using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WindowsFormsApplication2
{
    public partial class money : Form
    {
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Inventory-Management-System-master\Inventory-Management-System-master\ss.db;Version=3;New=true;Compress=True");
        SQLiteDataAdapter da;
        DataSet ds = new DataSet();
        public money()
        {
            InitializeComponent();
            textBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                ds = new DataSet();

                if (cbSearch.Text != "")
                {
                    
                    if (cbSearch.Text.ToString() == "العميل")
                    {
                        if (txtSearch.Text == "")
                        {
                            MessageBox.Show("Empty Search Feild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            ds.Clear();
                            da = new SQLiteDataAdapter("Select money.paid as المدفوع,money.stay as المتبقى , money.time as التاريخ,CustomerInfo.CompanyName as الاسم  FROM money INNER JOIN CustomerInfo ON money.idc=CustomerInfo.CustomerID  where CustomerInfo.CompanyName LIKE'" + txtSearch.Text + "'", con);
                            da.Fill(ds);
                            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                            {
                                dataGridView1.DataSource = ds.Tables[0];
                            }
                            else
                            {
                                MessageBox.Show("خطا", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                    }
                    else if (cbSearch.Text.ToString() == "المبلغ المدفوع")
                    {
                        if (mtbFrom.Text == "" && mtbTo.Text == "")
                        {
                            MessageBox.Show("Empty Search Feild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            ds.Clear();
                            da = new SQLiteDataAdapter("Select money.paid as المدفوع,money.stay as المتبقى , money.time as التاريخ,CustomerInfo.CompanyName as الاسم  FROM money INNER JOIN CustomerInfo ON money.idc=CustomerInfo.CustomerID  where money.paid > '" + mtbFrom.Text + "' AND money.paid  < '" + mtbTo.Text + "'", con);
                            da.Fill(ds);
                            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                            {
                                dataGridView1.DataSource = ds.Tables[0];
                            }
                            else
                            {
                                MessageBox.Show("خطا", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                    }
                    else if (cbSearch.Text.ToString() == "المبلغ الباقى ")
                    {
                        if (mtbFrom.Text == "" && mtbTo.Text == "")
                        {
                            MessageBox.Show("Empty Search Feild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            ds.Clear();
                            da = new SQLiteDataAdapter("Select money.paid as المدفوع,money.stay as المتبقى , money.time as التاريخ,CustomerInfo.CompanyName as الاسم  FROM money INNER JOIN CustomerInfo ON money.idc=CustomerInfo.CustomerID  where money.stay > '" + mtbFrom.Text + "' AND money.stay  < '" + mtbTo.Text + "'", con);
                            da.Fill(ds);
                            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                            {
                                dataGridView1.DataSource = ds.Tables[0];
                            }
                            else
                            {
                                MessageBox.Show("No records exist within Quantity Range", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                    }
                    else if (cbSearch.Text.ToString() == "التاريخ")
                    {
                        if (dtpFrom.Value.Date > System.DateTime.Today)
                        {
                            MessageBox.Show("Invalid Selected Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            ds.Clear();
                            da = new SQLiteDataAdapter("Select money.paid as المدفوع,money.stay as المتبقى , money.time as التاريخ,CustomerInfo.CompanyName as الاسم  FROM money INNER JOIN CustomerInfo ON money.idc=CustomerInfo.CustomerID where money.time > '" + dtpFrom.Text.ToString() + "' AND money.time <= '" + dtpTo.Text.ToString() + "'", con);
                            da.Fill(ds);
                            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                            {
                                dataGridView1.DataSource = ds.Tables[0];
                            }
                            else
                            {
                                MessageBox.Show("خطا", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Select Items to Search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
           
            }
            finally
            {
                label4.Text = "المبلغ المدفوع";
                con.Close();
                double sum5 = 0;

                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    sum5 = sum5 + (Convert.ToDouble(dataGridView1.Rows[i].Cells["المدفوع"].Value));
                    textBox1.Text = sum5.ToString();

                }
            }

        }

        private void Outward_Info_Load(object sender, EventArgs e)
        {
            mtbTo.Hide();
            mtbFrom.Hide();
            txtSearch.Show();
            dtpFrom.Hide();
            dtpTo.Hide();
            label3.Hide();
            dtpTo.Format = DateTimePickerFormat.Custom;
            dtpFrom.Format = DateTimePickerFormat.Custom;
            dtpTo.CustomFormat = "yyyy-MM-dd hh-mm-ss";
            dtpFrom.CustomFormat = "yyyy-MM-dd hh-mm-ss";
        }

       
        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSearch.Text.ToString() == "المبلغ المدفوع")
            {
                txtSearch.Hide();
                mtbFrom.Show();
                mtbTo.Show();
                dtpFrom.Hide();
                dtpTo.Hide();
                label3.Show();
            }
            else if (cbSearch.Text.ToString() == "المبلغ الباقى ")
            {
                txtSearch.Hide();
                mtbFrom.Show();
                mtbTo.Show();
                dtpFrom.Hide();
                dtpTo.Hide();
                label3.Show();
            }
            else if (cbSearch.Text.ToString() == "العميل")
            {
                txtSearch.Show();
                mtbFrom.Hide();
                mtbTo.Hide();
                label3.Hide();
                dtpFrom.Hide();
                dtpTo.Hide();
                txtSearch.Text = "";
                ds.Clear();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = con;
                SQLiteDataReader dReader;

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT CompanyName FROM CustomerInfo WHERE CompanyName LIKE '" + txtSearch.Text + "%'";
                con.Open();
                dReader = cmd.ExecuteReader();
                if (dReader.HasRows == true)
                {
                    while (dReader.Read())
                        namesCollection.Add(dReader["CompanyName"].ToString());
                }
                else
                {
                    //namesCollection.Add(dReader["No record found"].ToString());
                }
                dReader.Close();
                txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSearch.AutoCompleteCustomSource = namesCollection;
                con.Close();
            }
            else if (cbSearch.Text.ToString() == "التاريخ")
            {
                dtpFrom.Show();
                dtpTo.Show();
                txtSearch.Hide();
                mtbFrom.Hide();
                mtbTo.Hide();
                label3.Show();
            }
        }

        private void Outward_Info_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit?", "Exit?", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label4.Text = "مجموع حساب العملاء";
            ds = new DataSet();

            ds.Clear();
            da = new SQLiteDataAdapter("Select CompanyName as الاسم ,State as الحساب ,data as تاريخاخردفع  FROM CustomerInfo ", con);
            da.Fill(ds);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Requested Address cannot be found", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            double sum5 = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                 sum5= sum5+( Convert.ToDouble(dataGridView1.Rows[i].Cells["الحساب"].Value));
                textBox1.Text = sum5.ToString();
            }
        
        }
    }
}
