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
    public partial class Outward_Info : Form
    {
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
        SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Inventory-Management-System-master\Inventory-Management-System-master\ss.db;Version=3;New=true;Compress=True");
        SQLiteDataAdapter da;
        DataSet ds = new DataSet();
        public Outward_Info()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Outward o = new Outward();
            o.Show();
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
                if (cbSearch.Text != "")
                {
                    if (cbSearch.Text.ToString() == "المنتج")
                    {
                        if (txtSearch.Text == "")
                        {
                            MessageBox.Show("Empty Search Feild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            ds.Clear();
                            da = new SQLiteDataAdapter("Select Outward.Date as التاريخ,Outward.Quantity as الكميه , Unit.QuantityType  FROM Outward INNER JOIN Unit ON Outward.UnitID = Unit.UnitID INNER JOIN MaterialInfo ON Outward.MaterialID = MaterialInfo.MaterialID  where MaterialInfo.MaterialName LIKE'" + txtSearch.Text + "'", con);
                            da.Fill(ds);
                            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                            {
                                dataGridView1.DataSource = ds.Tables[0];
                            }
                            else
                            {
                                MessageBox.Show("Requested Material does not exist", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                    }
                    if (cbSearch.Text.ToString() == "المورد")
                    {
                        if (txtSearch.Text == "")
                        {
                            MessageBox.Show("Empty Search Feild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            ds.Clear();
                            da = new SQLiteDataAdapter("Select MaterialInfo.MaterialName, Outward.Date as التاريخ,Outward.Quantity as الكميه , Unit.QuantityType  FROM Outward INNER JOIN Unit ON Outward.UnitID = Unit.UnitID INNER JOIN MaterialInfo ON Outward.MaterialID = MaterialInfo.MaterialID inner join Vendor on Vendor.VendorID= Outward.vendor where Vendor.VendorName LIKE'" + txtSearch.Text + "'", con);
                            da.Fill(ds);
                            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                            {
                                dataGridView1.DataSource = ds.Tables[0];
                            }
                            else
                            {
                                MessageBox.Show("Requested Material does not exist", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                    }
                    else if (cbSearch.Text.ToString() == "الكميه")
                    {
                        if (mtbFrom.Text == "" && mtbTo.Text == "")
                        {
                            MessageBox.Show("Empty Search Feild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            ds.Clear();
                            da = new SQLiteDataAdapter("Select Outward.Date as التاريخ , MaterialInfo.MaterialName as  الماده,Outward.Quantity, Unit.QuantityType  FROM Outward INNER JOIN Unit ON Outward.UnitID = Unit.UnitID INNER JOIN MaterialInfo ON Outward.MaterialID = MaterialInfo.MaterialID where Outward.Quantity > '" + mtbFrom.Text + "' AND Outward.Quantity < '" + mtbTo.Text + "'", con);
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
                    else if (cbSearch.Text.ToString() == "الفئه")
                    {
                        if (txtSearch.Text == "")
                        {
                            MessageBox.Show("Empty Search Feild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            ds.Clear();
                            da = new SQLiteDataAdapter("Select Outward.Date as التاريخ , MaterialInfo.MaterialName as  الماده, Outward.Quantity FROM Outward INNER JOIN Unit ON Outward.UnitID = Unit.UnitID INNER JOIN MaterialInfo ON Outward.MaterialID = MaterialInfo.MaterialID where Unit.QuantityType LIKE'%" + txtSearch.Text + "%'", con);
                            da.Fill(ds);
                            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                            {
                                dataGridView1.DataSource = ds.Tables[0];
                            }
                            else
                            {
                                MessageBox.Show("Quantity Type does not exist", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                            da = new SQLiteDataAdapter("Select Outward.Date as التاريخ, MaterialInfo.MaterialName as المنتج ,Outward.Quantity as الكميه, Unit.QuantityType  FROM Outward INNER JOIN Unit ON Outward.UnitID = Unit.UnitID INNER JOIN MaterialInfo ON Outward.MaterialID = MaterialInfo.MaterialID where Outward.Date > '" + dtpFrom.Text.ToString() + "' AND Outward.Date <= '" + dtpTo.Text.ToString() + "'", con);
                            da.Fill(ds);
                            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                            {
                                dataGridView1.DataSource = ds.Tables[0];
                            }
                            else
                            {
                                MessageBox.Show("No records exist within Specified Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                con.Close();
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
            if (cbSearch.Text.ToString() == "الكميه")
            {
                txtSearch.Hide();
                mtbFrom.Show();
                mtbTo.Show();
                dtpFrom.Hide();
                dtpTo.Hide();
                label3.Show();
            }
            else if (cbSearch.Text.ToString() == "الفئه")
            {
                txtSearch.Show();
                mtbFrom.Hide();
                mtbTo.Hide();
                dtpFrom.Hide();
                dtpTo.Hide();
                label3.Hide();
                ds.Clear();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = con;
                SQLiteDataReader dReader;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT QuantityType FROM Unit WHERE QuantityType LIKE '" + txtSearch.Text + "%'";
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
            else if (cbSearch.Text.ToString() == "المنتج" )
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
                cmd.CommandText = "SELECT MaterialName FROM MaterialInfo WHERE MaterialName LIKE '" + txtSearch.Text + "%'";
                con.Open();
                dReader = cmd.ExecuteReader();
                if (dReader.HasRows == true)
                {
                    while (dReader.Read())
                        namesCollection.Add(dReader["MaterialName"].ToString());
                }
                else
                {
                    //namesCollection.Add(dReader["No record found"].ToString());
                    MessageBox.Show("Data not found");
                }
                dReader.Close();
                txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSearch.AutoCompleteCustomSource = namesCollection;
                con.Close();
            }
            else if (cbSearch.Text.ToString() == "المورد")
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
                cmd.CommandText = "SELECT VendorName FROM Vendor WHERE VendorName LIKE '" + txtSearch.Text + "%'";
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
    }
}
