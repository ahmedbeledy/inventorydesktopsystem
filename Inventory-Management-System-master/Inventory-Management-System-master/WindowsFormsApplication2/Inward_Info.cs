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
    public partial class Inward_Info : Form
    {

        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Inventory-Management-System-master\Inventory-Management-System-master\ss.db;Version=3;New=true;Compress=True");
        SQLiteDataAdapter da;
        DataSet ds = new DataSet();
        public Inward_Info()
        {
            InitializeComponent();
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
                if (cbSearch.Text!="")
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
                            da = new SQLiteDataAdapter("Select Inward.Date التاريخ, Vendor.VendorName المورد,MaterialInfo.price السعربالخصم, MaterialInfo.sale السعرالاصلى  ,Inward.Quantity الكميه , Unit.QuantityType نوعالكميه   FROM Inward INNER JOIN Unit ON Inward.UnitID = Unit.UnitID INNER JOIN MaterialInfo ON Inward.MaterialID = MaterialInfo.MaterialID INNER JOIN Vendor ON Inward.VendorID = Vendor.VendorID where MaterialInfo.MaterialName LIKE'" + txtSearch.Text + "'", con);
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
                    else if (cbSearch.Text.ToString() == "المورد")
                    {
                        if (txtSearch.Text == "")
                        {
                            MessageBox.Show("Empty Search Feild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            ds.Clear();
                            da = new SQLiteDataAdapter("Select Inward.Date التاريخ , MaterialInfo.MaterialName الاسم ,MaterialInfo.price السعربالخصم , MaterialInfo.sale السعرالاصلى,Inward.Quantity الكميه, Unit.QuantityType نوعالكميه   FROM Inward INNER JOIN Unit ON Inward.UnitID = Unit.UnitID INNER JOIN MaterialInfo ON Inward.MaterialID = MaterialInfo.MaterialID INNER JOIN Vendor ON Inward.VendorID = Vendor.VendorID where Vendor.VendorName LIKE'" + txtSearch.Text + "'", con);
                            da.Fill(ds);
                            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                            {
                                dataGridView1.DataSource = ds.Tables[0];
                            }
                            else
                            {
                                MessageBox.Show("Requested Vendor does not exist", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                            da = new SQLiteDataAdapter("Select Inward.Date التاريخ , MaterialInfo.MaterialName الاسم ,MaterialInfo.price السعربالخصم , MaterialInfo.sale السعرالاصلى,Inward.Quantity الكميه, Unit.QuantityType نوعالكميه FROM Inward INNER JOIN Unit ON Inward.UnitID = Unit.UnitID INNER JOIN MaterialInfo ON Inward.MaterialID = MaterialInfo.MaterialID INNER JOIN Vendor ON Inward.VendorID = Vendor.VendorID where Inward.Quantity > '" + mtbFrom.Text + "' AND Inward.Quantity < '" + mtbTo.Text + "'", con);
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
                            da = new SQLiteDataAdapter("Select Inward.Date التاريخ , MaterialInfo.MaterialName الاسم ,MaterialInfo.price السعربالخصم , MaterialInfo.sale السعرالاصلى,Inward.Quantity الكميه, Unit.QuantityType نوعالكميه FROM Inward INNER JOIN Unit ON Inward.UnitID = Unit.UnitID INNER JOIN MaterialInfo ON Inward.MaterialID = MaterialInfo.MaterialID INNER JOIN Vendor ON Inward.VendorID = Vendor.VendorID where Unit.QuantityType LIKE'" + txtSearch.Text + "'", con);
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
                            da = new SQLiteDataAdapter("Select Inward.Date التاريخ , MaterialInfo.MaterialName الاسم ,MaterialInfo.price السعربالخصم , MaterialInfo.sale السعرالاصلى,Inward.Quantity الكميه, Unit.QuantityType نوعالكميه FROM Inward INNER JOIN Unit ON Inward.UnitID = Unit.UnitID INNER JOIN MaterialInfo ON Inward.MaterialID = MaterialInfo.MaterialID INNER JOIN Vendor ON Inward.VendorID = Vendor.VendorID where Inward.Date > '" + dtpFrom.Text.ToString() + "' AND Inward.Date <= '" + dtpTo.Text.ToString() + "'", con);
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
                double sum = 0, sum1 = 0, sum2 = 0,sum3=0,sum4=0;
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Select Items to Search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        sum = Convert.ToDouble(dataGridView1.Rows[i].Cells["السعربالخصم"].Value);
                        sum1 = Convert.ToDouble(dataGridView1.Rows[i].Cells["الكميه"].Value);
                        sum3 = Convert.ToDouble(dataGridView1.Rows[i].Cells["السعرالاصلى"].Value);

                        sum2 += sum * sum1;
                        sum4 += sum1 * sum3;
                    }
                }
                sale.Text = sum2.ToString();
                textBox1.Text = sum4.ToString();
                sale.Enabled = false;
                textBox1.Enabled = false;
          
                con.Close();
            }

        }

        private void Inward_Info_Load(object sender, EventArgs e)
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            Inward i = new Inward();
            i.Show();
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
                    namesCollection.Add(dReader["No record found"].ToString());
                }
                dReader.Close();
                txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSearch.AutoCompleteCustomSource = namesCollection;
                con.Close();
            }
            else if (cbSearch.Text.ToString() == "المنتج")
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
                    namesCollection.Add(dReader["No record found"].ToString());
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

        private void Inward_Info_FormClosing(object sender, FormClosingEventArgs e)
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

        private void sale_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     }
}
