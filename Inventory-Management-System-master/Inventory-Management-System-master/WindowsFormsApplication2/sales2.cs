using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using DGVPrinterHelper;

namespace WindowsFormsApplication2
{
    public partial class sales2 : Form
    {
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
        //   SQLiteConnection con = new   SQLiteConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\bele\Downloads\Inventory-Management-System-master\WindowsFormsApplication2\IMS.mdf;Integrated Security=True;Connect Timeout=30");
SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Inventory-Management-System-master\Inventory-Management-System-master\ss.db;Version=3;New=true;Compress=True");
        int av, ts;

        DataTable dt = new DataTable();
        SQLiteCommand cmd = new SQLiteCommand();
        SQLiteCommand cmmd = new SQLiteCommand();
        Double win;
     
        string valueidm, valueidu;
       

       

        public sales2()
        {
            InitializeComponent();
            txtAmount.Enabled = false;
            total.Enabled = false;
            txtAvail.Enabled = false;

        }

        private void btnAddC_Click(object sender, EventArgs e)
        {
            cust c = new cust();
            c.Show();
        }

        private void btnAddM_Click(object sender, EventArgs e)
        {
            Material m = new Material();
            m.Show();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            


            
            

            con.Open();
            int ah = Convert.ToInt32(mtbQuantity.Text);

            int aa = Convert.ToInt32(txtAvail.Text);
            ah =  aa-ah;

            SQLiteCommand cmxd = new SQLiteCommand("UPDATE Temp SET Quantity= '" + ah + "' WHERE MaterialID= '" + valueidm + "'", con);

            cmxd.ExecuteNonQuery();

            cmxd = new SQLiteCommand("Insert into SalesOrder_Sub(MaterialID,Quantity,UnitID,Total,OrderID,Amount,win) values(@a,@b,@c,@d,@j,@k,@s)", con);


            cmxd.Parameters.AddWithValue("@j",order.Text);
            cmxd.Parameters.AddWithValue("@a", valueidm);
            cmxd.Parameters.AddWithValue("@b", mtbQuantity.Text);
            cmxd.Parameters.AddWithValue("@c", valueidu);
            cmxd.Parameters.AddWithValue("@k", txtAmount.Text);

            cmxd.Parameters.AddWithValue("@d", Convert.ToDouble(total.Text) * Convert.ToDouble(mtbQuantity.Text));
            win = ((Convert.ToDouble(total.Text)) * Convert.ToDouble(mtbQuantity.Text) )- Convert.ToDouble(mtbQuantity.Text) * Convert.ToDouble(pri.Text);
            cmxd.Parameters.AddWithValue("@s", win);

            int r = cmxd.ExecuteNonQuery();
          
          
            try
            {


            }
            finally
            {

                cbMtrlName.Text = "";
                cbUnit.Text = "";
                mtbQuantity.Text = "";

                txtAmount.Text = "";
                txtAvail.Text = "";

                con.Close();


            }
        }
           



        
        private void SalesOrder_Load(object sender, EventArgs e)
        {


            //
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = con;
            SQLiteDataReader dReader;


            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT MaterialName FROM MaterialInfo WHERE MaterialName LIKE'" + cbMtrlName.Text + "%'";
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
            cbMtrlName.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbMtrlName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbMtrlName.AutoCompleteCustomSource = namesCollection;


            // TODO: This line of code loads data into the 'iMSDataSet.MaterialInfo' table. You can move, or remove it, as needed.
            //   this.materialInfoTableAdapter.Fill(this.iMSDataSet.MaterialInfo);

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
            con.Close();

            cbUnit.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbUnit.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbUnit.AutoCompleteCustomSource = namesCollection;



        }

        


        private void SalesOrder_FormClosing(object sender, FormClosingEventArgs e)
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void order_TextChanged(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //  e.Graphics.DrawImage(bitmap, 10, 500);







        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mtbQuantity_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        

        private void total_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalcus_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cbMtrlName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAvail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAvailable_Click(object sender, EventArgs e)
        {

        }

        private void btnCnfrm_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter("Select a.MaterialID ,b.UnitID  FROM MaterialInfo a, Unit b where( MaterialName  LIKE'" + cbMtrlName.Text + "'AND QuantityType  LIKE'" + cbUnit.Text + "')", con);

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
            da = new SQLiteDataAdapter("Select Temp.Quantity,MaterialInfo.price ,MaterialInfo.sale FROM MaterialInfo INNER JOIN Temp ON  Temp.MaterialID = MaterialInfo.MaterialID where MaterialInfo.MaterialID  LIKE '" + valueidm + "'", con);

            ds = new DataSet();

            try
            {
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {

                    txtAvail.Text = ds.Tables[0].Rows[0]["Quantity"].ToString();
                    txtAmount.Text = ds.Tables[0].Rows[0]["price"].ToString();
                    pri.Text = ds.Tables[0].Rows[0]["sale"].ToString();

                    av = Convert.ToInt32(txtAvail.Text);



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
            av = Convert.ToInt32(txtAvail.Text);
            ts = Convert.ToInt32(mtbQuantity.Text);
            if (mtbQuantity.Text == "" || cbMtrlName.Text == "" || txtAmount.Text == "" || av < 1)
            {
                MessageBox.Show("Fill the required feilds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

                int value = Convert.ToInt32(mtbQuantity.Text);
                Double value1 = Convert.ToDouble(txtAmount.Text);
                Double value2 = Convert.ToDouble(sale.Text) / 100;

                value1 = value1 - (value1 * value2);
                total.Text = value1.ToString();
                Double valuet = (value * value1);

                string m = valuet.ToString();
                if (av < ts || av < 0)
                {
                    MessageBox.Show("Stock out of range", "Sale Quantity", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {

                    SQLiteCommand cmnd = new SQLiteCommand();


                    con.Close();
                }
            }


        }

        

    }
}


