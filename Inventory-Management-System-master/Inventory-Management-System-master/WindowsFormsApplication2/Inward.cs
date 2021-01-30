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
    public partial class Inward : Form
    {
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
        SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Inventory-Management-System-master\Inventory-Management-System-master\ss.db;Version=3;New=true;Compress=True");
        SQLiteCommand cmd = new SQLiteCommand();
        String valueidm, valueidu, valueidv;
        public Inward()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)

        {
            if (txtCstName.Text == "" || mtbQuantity.Text == "" || cbVendor.Text == "")
            {
                MessageBox.Show("Enter The Value in Feilds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            else
            {
                con.Open();
                SQLiteDataAdapter da = new SQLiteDataAdapter("Select a.MaterialID ,b.UnitID ,c.VendorID FROM MaterialInfo a, Unit b, Vendor c  where( MaterialName  LIKE'" + txtCstName.Text + "'AND QuantityType  LIKE'" + cbUnit.Text + "' AND  VendorName LIKE'" + cbVendor.Text + "')", con);

                DataSet ds = new DataSet();
       
                try
                {
                    da.Fill(ds);
                    
                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        
                        valueidm = ds.Tables[0].Rows[0]["MaterialID"].ToString();
                        valueidu = ds.Tables[0].Rows[0]["UnitID"].ToString();
                        valueidv = ds.Tables[0].Rows[0]["VendorID"].ToString();
                
                         
                 

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



          
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.Connection = con;
                    con.Open();
                
                        cmd = new SQLiteCommand("Insert into Inward(Date,MaterialID,Quantity,UnitID,VendorID) values(@a,@b,@c,@d,@e)", con);
                        cmd.Parameters.AddWithValue("@a", dateTimePicker1.Value.Date);
                        cmd.Parameters.AddWithValue("@b", valueidm);
                        cmd.Parameters.AddWithValue("@c", mtbQuantity.Text);
                        cmd.Parameters.AddWithValue("@d", valueidu);
                        cmd.Parameters.AddWithValue("@e", valueidv);

                        try
                        {
                            int r = cmd.ExecuteNonQuery();
                            MessageBox.Show("Inward Entry", "Added Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           
                           
                               
                                SQLiteDataAdapter sda = new SQLiteDataAdapter("Select Quantity from Temp where MaterialID like '" + valueidm + "' ", con);
                                DataSet ds1 = new DataSet();
                                sda.Fill(ds1);
                                textBox1.Text = ds1.Tables[0].Rows[0][0].ToString();
                                int a = Convert.ToInt32(textBox1.Text);
                                int b = Convert.ToInt32(mtbQuantity.Text);
                                int c = a + b;
                                textBox1.Text = c.ToString();
                                cmd = new SQLiteCommand("UPDATE Temp SET Quantity='" + c.ToString() + "' WHERE MaterialID='" + valueidm + "'", con);
                                cmd.ExecuteNonQuery();
                          
                                
                            
                        }
                        catch
                        {

                        }
                     
                        finally
                        {
                            txtCstName.Text = "";
                            mtbQuantity.Text = "";
                            cbVendor.Text = "";
                            cbUnit.Text = "";
                        }
                    }
                        con.Close();
            }
        

        private void Inward_Load(object sender, EventArgs e)
        {

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd hh-mm-ss";
            dateTimePicker1.CustomFormat = "yyyy-MM-dd hh-mm-ss";
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = con;
            SQLiteDataReader dReader;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT VendorName FROM Vendor WHERE VendorName LIKE'" + cbVendor.Text + "%'";
            con.Open();
            dReader = cmd.ExecuteReader();
            if (dReader.HasRows == true)
            {
                while (dReader.Read())
                    namesCollection.Add(dReader["VendorName"].ToString());

            }
            else
            {

            }
            dReader.Close();
            con.Close();
            cbVendor.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbVendor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbVendor.AutoCompleteCustomSource = namesCollection;




            //
            //
            cmd.Connection = con;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT MaterialName FROM MaterialInfo WHERE MaterialName LIKE'" + txtCstName.Text + "%'";
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
            con.Close();

            cbUnit.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbUnit.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbUnit.AutoCompleteCustomSource = namesCollection;

        
        }
                private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbVendor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mtbQuantity_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
