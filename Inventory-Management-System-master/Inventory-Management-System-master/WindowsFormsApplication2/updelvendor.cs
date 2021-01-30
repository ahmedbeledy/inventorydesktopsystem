using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication2
{
    public partial class updelvendor : Form
    {
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Inventory-Management-System-master\Inventory-Management-System-master\ss.db;Version=3;New=true;Compress=True");
        public updelvendor()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (txtCmpnyName.Text != "")
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Vendor WHERE VendorName LIKE'" + txtCmpnyName.Text + "'", con);
                SQLiteDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {                        
                       
                        txtAddress.Text = dr[2].ToString();
                        txtCity.Text = dr[3].ToString();
                        txtState.Text = dr[4].ToString();
                        mtbContact.Text = dr[5].ToString();
                        mtbOffice.Text = dr[6].ToString();
                        txtEmail.Text = dr[7].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No Record Found", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Enter VendorID", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void rbdelete_CheckedChanged(object sender, EventArgs e)
        {
            txtCmpnyName.Show(); txtAddress.Hide(); txtCity.Hide();
            txtState.Hide(); mtbContact.Hide(); mtbOffice.Hide(); txtEmail.Hide(); 
            label5.Hide(); label6.Hide(); label17.Show(); label8.Hide(); label9.Hide(); label10.Hide();
            label6.Hide(); label7.Hide(); label5.Hide();  label12.Hide(); label13.Hide();
            label3.Hide(); label14.Hide(); label15.Hide(); label16.Show();  btnUpdate.Hide();
            btnExit.Hide(); deldel.Show(); delexit.Show(); 
        }

        private void rbupdate_CheckedChanged(object sender, EventArgs e)
        {
            txtCmpnyName.Show();  txtAddress.Show(); txtCity.Show();
            txtState.Show(); mtbContact.Show(); mtbOffice.Show(); txtEmail.Show(); 
            label5.Show(); label6.Show(); label17.Show(); label8.Show(); label9.Show(); label10.Show();
            label6.Show(); label7.Show(); label5.Show(); label12.Show(); label13.Show();
            label3.Show(); label14.Show(); label15.Show(); label16.Show();  btnUpdate.Show();
            btnExit.Show(); deldel.Hide(); delexit.Hide(); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCmpnyName.Text == "" || txtAddress.Text == "" || txtCity.Text == "" || txtState.Text == "")
            {
                MessageBox.Show("Fill All the Required Fields", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (mtbOffice.Text != "" || mtbContact.Text != "")
                {
                    if (mtbOffice.Text.Length < 10 && mtbContact.Text.Length < 10)
                    {
                        MessageBox.Show("Incorrect No.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {

                        string valid;
                        Regex strregex = new Regex("([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})");

                        valid = txtEmail.Text;

                        if (strregex.IsMatch(valid))
                        {
                            try
                            {
                                con.Open();
                                SQLiteCommand cmd = new SQLiteCommand();
                                cmd = new SQLiteCommand("UPDATE Vendor SET Address= '" + txtAddress.Text + "',City= '" + txtCity.Text + "',State= '" + txtState.Text + "',ContactNo= '" + mtbContact.Text + "',OfficeNo= '" + mtbOffice.Text + "',EmailID= '" + txtEmail.Text + "' WHERE VendorName= '" + txtCmpnyName.Text + "'", con);

                                int r = cmd.ExecuteNonQuery();
                                if (r != 0)
                                {
                                    MessageBox.Show("Updated Succesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txtCmpnyName.Text = ""; txtEmail.Text = "";  txtCity.Text = "";
                                    txtAddress.Text = ""; txtState.Text = ""; mtbOffice.Text = ""; mtbContact.Text = ""; 
                                }
                                else
                                {
                                    MessageBox.Show("No Record Updated", "Update Fail", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                            }
                            finally
                            {
                                con.Close();
                            }

                        }
                        else if (!strregex.IsMatch(valid))
                        {
                            MessageBox.Show("Incorrect Email", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                }
            }
        }

        private void deldel_Click(object sender, EventArgs e)
        {
            if (txtCmpnyName.Text != "")
            {
                try
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd = new SQLiteCommand("DELETE From Vendor WHERE VendorName= '" + txtCmpnyName.Text + "'", con);

                    int r = cmd.ExecuteNonQuery();
                    if (r != 0)
                    {
                        MessageBox.Show("Deleted Succesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCmpnyName.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("No Record Deleted", "Delete Fail", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtCmpnyName.Text = "";
                    }
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Fill Required Feilds", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void updelcust_FormClosing(object sender, FormClosingEventArgs e)
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

        private void delexit_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        //private void txtCntctPerson_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (nonNumberEntered == false)
        //    {
        //        e.Handled = true;
        //    }
        //}

        //private void txtCntctPerson_KeyDown(object sender, KeyEventArgs e)
        //{
        //    nonNumberEntered = false;

        //    if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
        //    {
        //        if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
        //        {
        //            nonNumberEntered = true;
        //        }
        //    }

        //    if (Control.ModifierKeys == Keys.Shift)
        //    {
        //        nonNumberEntered = true;
        //    }
        //}

        private void updelcust_Load(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = con;
            SQLiteDataReader dReader;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT VendorName FROM Vendor WHERE VendorName LIKE'" + txtCmpnyName.Text + "%'";
            con.Open();
            dReader = cmd.ExecuteReader();
            if (dReader.HasRows == true)
            {
                while (dReader.Read())
                    namesCollection.Add(dReader["VendorName"].ToString());

            }
            else
            {
                //namesCollection.Add(dReader["No record found"].ToString());
                MessageBox.Show("Data not found");

            }
            dReader.Close();

            txtCmpnyName.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtCmpnyName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtCmpnyName.AutoCompleteCustomSource = namesCollection;
            con.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCntctPerson_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
