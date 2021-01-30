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
    public partial class VAT_Info : Form
    {
        private bool nonNumberEntered = false;
        //public string strConnection =ConfigurationManager.AppSettings["ConnString"];
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Inventory-Management-System-master\Inventory-Management-System-master\ss.db;Version=3;New=true;Compress=True");
        SQLiteDataAdapter da;
        DataSet ds = new DataSet();
        public VAT_Info()
        {
            InitializeComponent();
        }

        private void VAT_Info_Load(object sender, EventArgs e)
        {
            ///
            SQLiteCommand cmd=new SQLiteCommand();
            SQLiteDataReader dReader;
            cmd.Connection = con;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT QuantityType FROM Unit WHERE QuantityType LIKE'" + txtSearch.Text + "%'";
            con.Open();
            dReader = cmd.ExecuteReader();
            if (dReader.HasRows == true)
            {
                while (dReader.Read())
                    namesCollection.Add(dReader["QuantityType"].ToString());

            }
            else
            {
                // namesCollection.Add(dReader["No record found"].ToString());
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
            this.Dispose(true);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text != "")
                {
                    ds.Clear();
                    con.Open();
                    da = new SQLiteDataAdapter("SELECT QuantityType FROM Unit WHERE QuantityType LIKE'" + txtSearch.Text + "'", con);
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("Enter State Name", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            finally
            {
                con.Close();
                txtSearch.Text = "";
            }

        }

        private void VAT_Info_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
