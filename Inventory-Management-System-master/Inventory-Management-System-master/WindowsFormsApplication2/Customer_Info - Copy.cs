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
    public partial class Vendor_Info : Form
    {
        private bool nonNumberEntered = false;
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
        SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Inventory-Management-System-master\Inventory-Management-System-master\ss.db;Version=3;New=true;Compress=True");
        SQLiteDataAdapter da;
        DataSet ds = new DataSet();
        public Vendor_Info()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbSearch.Text != "")
            {
                if (cbSearch.Text.ToString() == "الاسم")
                {
                    if (txtSearch.Text == "")
                    {
                        MessageBox.Show("Empty Search Feild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        ds.Clear();
                        da = new SQLiteDataAdapter("Select Address,City,State,ContactNo,OfficeNo,EmailID FROM Vendor where VendorName LIKE'" + txtSearch.Text + "'", con);
                        da.Fill(ds);
                        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {
                            dataGridView1.DataSource = ds.Tables[0];
                        }
                        else
                        {
                            MessageBox.Show("Requested Company Name cannot be found", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                } 
                if (cbSearch.Text.ToString() == "العنوان")
                {
                    if (txtSearch.Text == "")
                    {
                        MessageBox.Show("Empty Search Feild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        ds.Clear();
                        da = new SQLiteDataAdapter("Select VendorName,City,State,ContactNo,OfficeNo,EmailID FROM Vendor where Address LIKE'%" + txtSearch.Text + "%'", con);
                        da.Fill(ds);
                        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {
                            dataGridView1.DataSource = ds.Tables[0];
                        }
                        else
                        {
                            MessageBox.Show("Requested Address cannot be found", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                }
                if (cbSearch.Text.ToString() == "المدينه")
                {
                    if (txtSearch.Text == "")
                    {
                        MessageBox.Show("Empty Search Feild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        ds.Clear();
                        da = new SQLiteDataAdapter("Select VendorName,Address,State,ContactNo,OfficeNo,EmailID FROM Vendor where City LIKE'" + txtSearch.Text + "'", con);
                        da.Fill(ds);
                        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {
                            dataGridView1.DataSource = ds.Tables[0];
                        }
                        else
                        {
                            MessageBox.Show("Requested City cannot be found", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                }
                if (cbSearch.Text.ToString() == "الدوله")
                {
                    if (txtSearch.Text == "")
                    {
                        MessageBox.Show("Empty Search Feild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        ds.Clear();
                        da = new SQLiteDataAdapter("Select VendorName,Address,City,ContactNo,OfficeNo,EmailID FROM Vendor where State LIKE'" + txtSearch.Text + "'", con);
                        da.Fill(ds);
                        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {
                            dataGridView1.DataSource = ds.Tables[0];
                        }
                        else
                        {
                            MessageBox.Show("Requested State cannot be found", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                }

                if (cbSearch.Text.ToString() == "التليفون")
                {
                    if (mtbSearch.Text == "")
                    {
                        MessageBox.Show("Empty Search Feild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        ds.Clear();
                        da = new SQLiteDataAdapter("Select VendorName,Address,City,State,OfficeNo,EmailID FROM Vendor where VendorName LIKE'" + mtbSearch.Text + "'", con);
                        da.Fill(ds);
                        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {
                            dataGridView1.DataSource = ds.Tables[0];
                        }
                        else
                        {
                            MessageBox.Show("Requested ContactNo cannot be found", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                }
                if (cbSearch.Text.ToString() == "تليفون المكتب")
                {
                    if (mtbSearch.Text == "")
                    {
                        MessageBox.Show("Empty Search Feild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        ds.Clear();
                        da = new SQLiteDataAdapter("Select VendorName,Address,City,State,ContactNo,EmailID FROM Vendor where OfficeNo like '" + mtbSearch.Text + "'", con);
                        da.Fill(ds);
                        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {
                            dataGridView1.DataSource = ds.Tables[0];
                        }
                        else
                        {
                            MessageBox.Show("Requested OfficeNo cannot be found", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                }
                if (cbSearch.Text.ToString() == "الايميل")
                {
                    if (txtSearch.Text == "")
                    {
                        MessageBox.Show("Empty Search Feild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        ds.Clear();
                        da = new SQLiteDataAdapter("Select VendorName,Address,City,State,ContactNo,OfficeNo FROM Vendor where EmailID like '" + txtSearch.Text + "'", con);
                        da.Fill(ds);
                        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {
                            dataGridView1.DataSource = ds.Tables[0];
                        }
                        else
                        {
                            MessageBox.Show("Requested EmailID cannot be found", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                }
            }
            else
                {
                    MessageBox.Show("Select Items to Search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }
       
        private void Customer_Info_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Customer_Info_Load(object sender, EventArgs e)
        {
            mtbSearch.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cust c = new cust();
            c.Show();
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updelvendor ud = new updelvendor();
            ud.Show();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;

            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    nonNumberEntered = true;
                }
            }

            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == false)
            {
                e.Handled = true;
            }
        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSearch.Text.ToString() == "الاسم")
            {
                mtbSearch.Hide();
                txtSearch.Show();
                txtSearch.Text = "";
                ds.Clear();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = con;
                SQLiteDataReader dReader;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT VendorName FROM Vendor WHERE VendorName LIKE'" + txtSearch.Text + "%'";
                con.Open();
                dReader = cmd.ExecuteReader();
                if (dReader.HasRows == true)
                {
                    while (dReader.Read())
                        namesCollection.Add(dReader["VendorName"].ToString());
                }
                else
                {
                    MessageBox.Show("Data not found");
                    //namesCollection.Add(dReader["No record found"].ToString());
                }
                dReader.Close();
                txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSearch.AutoCompleteCustomSource = namesCollection;
                con.Close();

            }
          
            else if (cbSearch.Text.ToString() == "المدينه")
            {
                mtbSearch.Hide();
                txtSearch.Show();
                txtSearch.Text = "";
                ds.Clear();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = con;
                SQLiteDataReader dReader;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT City FROM Vendor WHERE VendorName LIKE'" + txtSearch.Text + "%'";
                con.Open();
                dReader = cmd.ExecuteReader();
                if (dReader.HasRows == true)
                {
                    while (dReader.Read())
                        namesCollection.Add(dReader["City"].ToString());
                }
                else
                {
                    MessageBox.Show("Data not found");
                    //namesCollection.Add(dReader["No record found"].ToString());
                }
                dReader.Close();
                txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSearch.AutoCompleteCustomSource = namesCollection;
                con.Close();

            }
            else if (cbSearch.Text.ToString() == "الدوله")
            {
                mtbSearch.Hide();
                txtSearch.Show();
                txtSearch.Text = "";
                ds.Clear();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = con;
                SQLiteDataReader dReader;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT State FROM Vendor WHERE State LIKE'" + txtSearch.Text +"%'";
                con.Open();
                dReader = cmd.ExecuteReader();
                if (dReader.HasRows == true)
                {
                    while (dReader.Read())
                        namesCollection.Add(dReader["State"].ToString());
                }
                else
                {
                    MessageBox.Show("Data not found");
                    //namesCollection.Add(dReader["No record found"].ToString());
                }
                dReader.Close();
                txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSearch.AutoCompleteCustomSource = namesCollection;
                con.Close();
            }
            else if (cbSearch.Text.ToString() == "العنوان")
            {
                mtbSearch.Hide();
                txtSearch.Show();
                txtSearch.Text = "";
                ds.Clear();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = con;
                SQLiteDataReader dReader;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Address FROM Vendor WHERE Address LIKE'" +txtSearch.Text + "%'";
                con.Open();
                dReader = cmd.ExecuteReader();
                if (dReader.HasRows == true)
                {
                    while (dReader.Read())
                        namesCollection.Add(dReader["Address"].ToString());
                }
                else
                {
                         MessageBox.Show("Data not found");
                   // namesCollection.Add(dReader["No record found"].ToString());
                }
                dReader.Close();
                txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSearch.AutoCompleteCustomSource = namesCollection;
                con.Close();
            }
            else if (cbSearch.Text.ToString() == "الايميل")
            {
                mtbSearch.Hide();
                txtSearch.Show();
                txtSearch.Text = "";
                ds.Clear();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = con;
                SQLiteDataReader dReader;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT EmailID FROM Vendor WHERE EmailID LIKE '" +txtSearch.Text + "%'";
                con.Open();
                dReader = cmd.ExecuteReader();
                if (dReader.HasRows == true)
                {
                    while (dReader.Read())
                        namesCollection.Add(dReader["EmailID"].ToString());
                }
                else
                {
                    MessageBox.Show("Data not found");
                    // namesCollection.Add(dReader["No record found"].ToString());
                }
                dReader.Close();
                txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSearch.AutoCompleteCustomSource = namesCollection;
                con.Close();
            }
            else if (cbSearch.Text.ToString() == "التليفون")
            {
                mtbSearch.Show();
                txtSearch.Hide();
                txtSearch.Text = "";
                ds.Clear();
                mtbSearch.Text = "";
            }
            else if (cbSearch.Text.ToString() == "رقم المكتب")
            {
                mtbSearch.Show();
                txtSearch.Hide();
                txtSearch.Text = "";
                ds.Clear();
                mtbSearch.Text = "";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
