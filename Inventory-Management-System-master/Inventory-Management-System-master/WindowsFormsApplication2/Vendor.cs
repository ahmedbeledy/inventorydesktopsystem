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
    public partial class cus : Form
    {
        private bool nonNumberEntered = false;
SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Inventory-Management-System-master\Inventory-Management-System-master\ss.db;Version=3;New=true;Compress=True");

        SQLiteCommand cmd;
        int r;
        string res;

        public cus()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtAddress.Text == "" || txtCity.Text == "" || txtState.Text == "")
            {
                MessageBox.Show("Fill All the Required Fields", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (mtbMobile.Text != "" || mtbContact.Text != "")
                {
                    
                        if (true)
                        {
                            con.Open();
                            cmd = new SQLiteCommand("Insert into Vendor(VendorName,Address,City,State,ContactNo,officeNo,EmailID) values( '" +txtName.Text+ "','" + txtAddress.Text+ "','" +  txtCity.Text+ "','" + txtState.Text+ "','" + mtbContact.Text+ "','" +  mtbMobile.Text+ "','" + txtEmail.Text+ "')", con);
                            //cmd.Parameters.AddWithValue("@b", txtName.Text);
                            //cmd.Parameters.AddWithValue("@c", txtAddress.Text);
                            //cmd.Parameters.AddWithValue("@d", txtCity.Text);
                            //cmd.Parameters.AddWithValue("@e", txtState.Text);
                            //cmd.Parameters.AddWithValue("@f", mtbContact.Text);
                            //cmd.Parameters.AddWithValue("@g", mtbMobile.Text);
                            //cmd.Parameters.AddWithValue("@h", txtEmail.Text);


                            try
                            {
                                r = cmd.ExecuteNonQuery();
                                cmd = new SQLiteCommand("Select VendorID from Vendor", con);
                                SQLiteDataReader dr = cmd.ExecuteReader();
                                if (dr.HasRows)
                                {
                                    while (dr.Read())
                                    {
                                        res = dr[0].ToString();
                                    }
                                }
                                MessageBox.Show("Vendor Unique Number"+":"+""+""+res, "Succesfully Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            catch (Exception exc)
                            {
                                MessageBox.Show(exc.ToString());
                            }
                            finally
                            {
                                txtAddress.Text = "";
                                txtCity.Text = "";
                                txtEmail.Text = "";
                                txtName.Text = "";
                                txtState.Text = "";
                                mtbMobile.Text = "";
                                mtbContact.Text = "";
                                con.Close();
                            }
                        
                        
                    } 
                    cus v = new cus();
                    v.Show();
                }
            }            
        }

        private void Vendor_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtAddress.Text == "" || txtCity.Text == "" || txtState.Text == "")
            {
                MessageBox.Show("Fill All the Required Fields", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (mtbMobile.Text != "" || mtbContact.Text != "")
                {
                    
                        if (true)
                        {
                            con.Open();
                            cmd = new SQLiteCommand("Insert into Vendor(VendorName,Address,City,State,ContactNo,officeNo,EmailID) values( '" + txtName.Text + "','" + txtAddress.Text + "','" + txtCity.Text + "','" + txtState.Text + "','" + mtbContact.Text + "','" + mtbMobile.Text + "','" + txtEmail.Text + "')", con);
                            ////////cmd.Parameters.AddWithValue("@b", txtName.Text);
                            //cmd.Parameters.AddWithValue("@c", txtAddress.Text);
                            //cmd.Parameters.AddWithValue("@d", txtCity.Text);
                            //cmd.Parameters.AddWithValue("@e", txtState.Text);
                            //cmd.Parameters.AddWithValue("@f", mtbContact.Text);
                            //cmd.Parameters.AddWithValue("@g", mtbMobile.Text);
                            //cmd.Parameters.AddWithValue("@h", txtEmail.Text);


                            try
                            {
                                r = cmd.ExecuteNonQuery();
                                cmd = new SQLiteCommand("Select VendorID from Vendor", con);
                                SQLiteDataReader dr = cmd.ExecuteReader();
                                if (dr.HasRows)
                                {
                                    while (dr.Read())
                                    {
                                        res = dr[0].ToString();
                                    }
                                }
                                MessageBox.Show("Vendor Unique Number"+":"+""+""+res, "Succesfully Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            catch (Exception exc)
                            {
                                MessageBox.Show(exc.ToString());
                            }
                            finally
                            {
                                txtAddress.Text = "";
                                txtCity.Text = "";
                                txtEmail.Text = "";
                                txtName.Text = "";
                                txtState.Text = "";
                                mtbMobile.Text = "";
                                mtbContact.Text = "";
                                con.Close();
                            }
                        
                       
                    }
                    this.Dispose(true);
                }
            }            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updelvendor udv = new updelvendor();
            udv.Show();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Vendor_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
