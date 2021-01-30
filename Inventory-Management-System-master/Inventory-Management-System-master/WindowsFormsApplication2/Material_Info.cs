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
    public partial class Material_Info : Form
    {
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Inventory-Management-System-master\Inventory-Management-System-master\ss.db;Version=3;New=true;Compress=True");
        SQLiteDataAdapter da;
        DataSet ds = new DataSet();
        public Material_Info()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text != "")
                {
                    con.Open();
                    da = new SQLiteDataAdapter("select MaterialInfo.MaterialID as مسلسل ,MaterialInfo.MaterialName as اسم,MaterialInfo.sale as اصل,MaterialInfo.price as بالخصم ,Temp.Quantity as كميه   FROM MaterialInfo INNER JOIN Temp ON Temp.MaterialID = MaterialInfo.MaterialID where MaterialName like  '" + txtSearch.Text + "'", con);

                 //   da = new SQLiteDataAdapter("Select MaterialName,Department,Make,Model,price from MaterialInfo where MaterialName like  '" + txtSearch.Text + "'", con);
                    da.Fill(ds);
                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        dataGridView1.DataSource = ds.Tables[0]; 
                    }
                    else
                    {
                        MessageBox.Show("Selected Material does not exist", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    } 

                }
                else
                {
                    MessageBox.Show("Enter MaterialName","",MessageBoxButtons.OK,MessageBoxIcon.Stop);

                }
            }
            finally
            {
                con.Close();
                txtSearch.Text = "";
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        

        private void Material_Info_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Material_Info_Load(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = con;
            SQLiteDataReader dReader;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT MaterialName FROM MaterialInfo WHERE MaterialName LIKE'" + txtSearch.Text + "%'";
            con.Open();
            dReader = cmd.ExecuteReader();
            if (dReader.HasRows == true)
            {
                while (dReader.Read())
                    namesCollection.Add(dReader["MaterialName"].ToString());

            }
            else
            {
                MessageBox.Show("Data not found");
            }
            dReader.Close();

            txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearch.AutoCompleteCustomSource = namesCollection;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Material m = new Material();
            m.Show();
        }

        //private void txtSearch_KeyDown(object sender, KeyEventArgs e)
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

        

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
