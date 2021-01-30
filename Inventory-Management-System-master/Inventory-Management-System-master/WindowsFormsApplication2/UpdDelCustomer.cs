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
    public partial class updel : Form
    {
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
       string t;
SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Inventory-Management-System-master\Inventory-Management-System-master\ss.db;Version=3;New=true;Compress=True");
        public updel()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
                       txtCntctPerson.Show();
                        txtState.Hide();              
                         btnUpdate.Hide(); btnExit.Hide();  label7.Hide();
        }

       
        private void update_CheckedChanged(object sender, EventArgs e)
        {
            txtCntctPerson.Show();
                        txtState.Show(); btnUpdate.Show();
                        btnExit.Show(); 
                       
                         label7.Show(); 
                       
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCntctPerson.Text == "" || txtState.Text == "")
            {
                MessageBox.Show("Fill All the Required Fields", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    con.Open();
                    
                    SQLiteCommand cmd = new SQLiteCommand("UPDATE CustomerInfo SET State= '" + txtState.Text + "',data='" + DateTime.UtcNow.Date + "' WHERE CompanyName= '" + txtCntctPerson.Text + "'", con);

                    int r = cmd.ExecuteNonQuery();



                    SQLiteDataAdapter da = new SQLiteDataAdapter("Select CustomerID  FROM CustomerInfo where CompanyName LIKE'" + txtCntctPerson.Text + "'", con);

                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {

                        t = ds.Tables[0].Rows[0]["CustomerID"].ToString();


                    }

                    cmd = new SQLiteCommand("Insert into money(paid,stay,time,idc) values(@b,@c,@d,@k)", con);


                    cmd.Parameters.AddWithValue("@b", "0");
                    cmd.Parameters.AddWithValue("@c", txtState.Text);
                    cmd.Parameters.AddWithValue("@d", DateTime.UtcNow.Date);

                    cmd.Parameters.AddWithValue("@k", t);


                    r = cmd.ExecuteNonQuery();


            
                }
                finally
                {
                    txtState.Text = "";
                         txtCntctPerson.Text="";
                         MessageBox.Show("تم بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    con.Close();
                }
            }
            
        }
           

        private void UpdDel_FormClosing(object sender, FormClosingEventArgs e)
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

       
        private void updel_Load(object sender, EventArgs e)
        {
            
        }

        private void txtCmpnyName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCntctPerson_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtState_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void updel_Load_1(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = con;
            SQLiteDataReader dReader;

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT CompanyName FROM CustomerInfo WHERE CompanyName LIKE'" + txtCntctPerson.Text + "%'";
            con.Open();
            dReader = cmd.ExecuteReader();
            if (dReader.HasRows == true)
            {
                while (dReader.Read())
                    namesCollection.Add(dReader["CompanyName"].ToString());
            }
            else
            {
            }
            dReader.Close();
            txtCntctPerson.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtCntctPerson.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtCntctPerson.AutoCompleteCustomSource = namesCollection;
            con.Close();
        }

        private void txtCntctPerson_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
    }

