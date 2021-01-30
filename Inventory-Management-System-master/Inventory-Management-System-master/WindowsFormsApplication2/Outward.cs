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
    public partial class Outward : Form
    {
        private bool nonNumberEntered = false;
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Inventory-Management-System-master\Inventory-Management-System-master\ss.db;Version=3;New=true;Compress=True");
        SQLiteCommand cmd;
        string valueidm, valueidu,vendor;
        public Outward()
        {
            InitializeComponent();
        }

        private void Outward_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd hh-mm-ss";
            dateTimePicker1.CustomFormat = "yyyy-MM-dd hh-mm-ss";
            txtAvail.Enabled = false;
            btnSave.Enabled = false;
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = con;
            SQLiteDataReader dReader;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT VendorName FROM Vendor WHERE VendorName LIKE'" + textBox2.Text + "%'";
            con.Open();
            dReader = cmd.ExecuteReader();
            if (dReader.HasRows == true)
            {
                while (dReader.Read())
                    namesCollection.Add(dReader["VendorName"].ToString());

            }
            else
            {
                // namesCollection.Add(dReader["No record found"].ToString());
                MessageBox.Show("Data not found");

            }
            dReader.Close();
            con.Close();
            textBox2.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox2.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox2.AutoCompleteCustomSource = namesCollection;




            //


            //
             cmd = new SQLiteCommand();
            cmd.Connection = con;
         

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT MaterialName FROM MaterialInfo WHERE MaterialName LIKE '" + txtCstName.Text + "%'";
            con.Open();
            dReader = cmd.ExecuteReader();
            if (dReader.HasRows == true)
            {
                while (dReader.Read())
                    namesCollection.Add(dReader["MaterialName"].ToString());

            }
            else
            {
                // namesCollection.Add(dReader["No record found"].ToString());
                MessageBox.Show("Data not found");

            }
            dReader.Close();
            con.Close();
            txtCstName.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtCstName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtCstName.AutoCompleteCustomSource = namesCollection;



            //
            cmd.Connection = con;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT QuantityType FROM Unit WHERE QuantityType LIKE'" + cbUnit.Text + "%'";
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

            cbUnit.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbUnit.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbUnit.AutoCompleteCustomSource = namesCollection;



            con.Close();


          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
           if (txtCstName.Text == "" || mtbQuantity.Text == ""||txtAvail.Text=="")
            {
                MessageBox.Show("Enter The Value in Feilds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (dateTimePicker1.Value.Date != System.DateTime.Today)
                {
                    MessageBox.Show("Wrong data Selected", "InAppropriate Date", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {

                   
                    int av = Convert.ToInt32(txtAvail.Text);
                    int ts = Convert.ToInt32(mtbQuantity.Text);
                    if (av < ts)
                    {
                        MessageBox.Show("Stock out of range", "Sale Quantity", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        
                            try
                            {
                                con.Open();
                                SQLiteDataAdapter da = new SQLiteDataAdapter("Select VendorID  FROM Vendor  where VendorName  LIKE'" + textBox2.Text + "'", con);

                                DataSet ds = new DataSet();

                                try
                                {
                                    da.Fill(ds);

                                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                                    {

                                        vendor = ds.Tables[0].Rows[0]["VendorID"].ToString();





                                    }
                                    else
                                    {
                                        MessageBox.Show("Selected Material does not exist", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    }
                                }
                                finally
                                {
                                }

                                cmd = new SQLiteCommand("Insert into Outward(Date,MaterialID,Quantity,UnitID,vendor) values(@a,@b,@c,@d,@f)", con);
                                cmd.Parameters.AddWithValue("@a", dateTimePicker1.Value.Date);
                                cmd.Parameters.AddWithValue("@b", valueidm);
                                cmd.Parameters.AddWithValue("@c", mtbQuantity.Text);
                                cmd.Parameters.AddWithValue("@d", valueidu);
                                cmd.Parameters.AddWithValue("@f", vendor);

                                cmd.ExecuteNonQuery();
                                
                                    
                                    SQLiteDataAdapter sda = new SQLiteDataAdapter("Select Quantity from Temp where MaterialID like '" + valueidm + "' ", con);
                                    DataSet ds1 = new DataSet();
                                    sda.Fill(ds1);
                                    textBox1.Text = ds1.Tables[0].Rows[0][0].ToString();
                                    int a = Convert.ToInt32(textBox1.Text);
                                    int b = Convert.ToInt32(mtbQuantity.Text);
                                    int c = a - b;
                                    textBox1.Text = c.ToString();
                                    cmd = new SQLiteCommand("UPDATE Temp SET Quantity='" + textBox1.Text + "' WHERE MaterialID='" + valueidm + "'", con);
                                    cmd.ExecuteNonQuery();
                                }

                            
                            catch (Exception exc)
                            {
                                MessageBox.Show(exc.ToString());
                            }
                            finally
                            {
                                txtCstName.Text = "";
                                mtbQuantity.Text = "";
                                txtAvail.Text = "";
                                cbUnit.Text = "";
                                MessageBox.Show("material added");
                            }
                        }

                        con.Close();
                    }
                }
            }
        
        private void txtMaterial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == false)
            {
                e.Handled = true;
            }
        }

        private void txtMaterial_KeyDown(object sender, KeyEventArgs e)
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

        private void btnAvailable_Click(object sender, EventArgs e)
        {
            con.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter("Select a.MaterialID ,b.UnitID  FROM MaterialInfo a, Unit b where( MaterialName  LIKE'" + txtCstName.Text + "'AND QuantityType  LIKE'" + cbUnit.Text + "')", con);

            DataSet ds = new DataSet();

            try
            {
                da.Fill(ds);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {

                    valueidm = ds.Tables[0].Rows[0]["MaterialID"].ToString();
                    valueidu = ds.Tables[0].Rows[0]["UnitID"].ToString();





                }
                else
                {
                    MessageBox.Show("Selected Material does not exist", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            finally
            {
                con.Close();
            }

            con.Open();
             da = new SQLiteDataAdapter("Select Quantity from Temp where MaterialID like '"+valueidm+"' ", con);
            ds = new DataSet();

            try
            {
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    txtAvail.Text = ds.Tables[0].Rows[0][0].ToString();
                }
                if(txtAvail.Text=="")
                {
                    MessageBox.Show("Selected Material does not exist", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            finally
            {
                con.Close();
            }
            btnSave.Enabled = true;
        }

        private void btnAddM_Click(object sender, EventArgs e)
        {
            Material m = new Material();
            m.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}