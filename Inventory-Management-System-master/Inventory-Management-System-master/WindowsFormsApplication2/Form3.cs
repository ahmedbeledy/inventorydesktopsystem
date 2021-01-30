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
    public partial class updatep : Form
    {
        public updatep()
        {
            InitializeComponent();
        }
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Inventory-Management-System-master\Inventory-Management-System-master\ss.db;Version=3;New=true;Compress=True");
        SQLiteDataAdapter da;
        DataSet ds = new DataSet();
        private void updatep_Load(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = con;
            SQLiteDataReader dReader;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT MaterialName FROM MaterialInfo WHERE MaterialName LIKE'" + txtName.Text + "%'";
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

            txtName.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtName.AutoCompleteCustomSource = namesCollection;
            con.Close();

        }

        private void update_Click(object sender, EventArgs e)
        {
             try
                            {
                                con.Open();
                                SQLiteCommand cmd = new SQLiteCommand();
                                cmd = new SQLiteCommand("UPDATE MaterialInfo SET price= '" + mtbQuantity.Text + "',sale= '" + textBox1.Text + "' WHERE MaterialName= '" + txtName.Text + "'", con);

                                int r = cmd.ExecuteNonQuery();
                                if (r != 0)
                                {
                                    MessageBox.Show("Updated Succesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    mtbQuantity.Text = ""; txtName.Text = ""; 
                                   
                                }
                                else
                                {
                                    MessageBox.Show("No Record Updated", "Update Fail", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                            }
                            finally
                            {
                                con.Close();
                                this.Hide();
                           
             }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
