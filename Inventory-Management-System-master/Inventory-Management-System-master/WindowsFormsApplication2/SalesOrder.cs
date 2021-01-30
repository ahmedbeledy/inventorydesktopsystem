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
    public partial class SalesOrder : Form
    {
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
        //   SQLiteConnection con = new   SQLiteConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\bele\Downloads\Inventory-Management-System-master\WindowsFormsApplication2\IMS.mdf;Integrated Security=True;Connect Timeout=30");
SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Inventory-Management-System-master\Inventory-Management-System-master\ss.db;Version=3;New=true;Compress=True");
        int av, ts;
        string t;
        int moslsl = 1;
        DataTable dt = new DataTable();
        SQLiteCommand cmd = new SQLiteCommand();
        SQLiteCommand cmmd = new SQLiteCommand();
        Double win;
        Double old = 0;
        string res;
        Double sum = 0;
        string valueidm, valueidu,valueids;
     
      
        // The PrintDocument to be used for printing.
       
        // The class that will do the printing process.

        public SalesOrder()
        {
            InitializeComponent();
            txtAmount.Enabled = false;
            total.Enabled = false;
            btnGenerate.Enabled = false;
            btnCnfrm.Enabled = false;
            btnAdd.Enabled = false;
            btnPO.Enabled = false;
            txtAvail.Enabled = false;
            totalcus.Enabled = false;
            printToolStripButton.Enabled = false;
            order.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;

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
            btnAdd.Click -= new EventHandler(this.button1_Click_1);

             av = Convert.ToInt32(txtAvail.Text);
            ts = Convert.ToInt32(mtbQuantity.Text);
            if (txtCstName.Text == "" || mtbQuantity.Text == "" || cbMtrlName.Text == "" || txtAmount.Text == "" || av<1)
            {
                MessageBox.Show("Fill the required feilds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

                int value = Convert.ToInt32(mtbQuantity.Text);
                Double value1 = Convert.ToDouble(txtAmount.Text);
                Double value2 = Convert.ToDouble(sale.Text)/100;
               
                value1 = value1 -(value1 * value2);
                total.Text = value1.ToString();
                Double valuet = (value * value1);
              
                string m = valuet.ToString();
                if (av < ts || av < 0)
                {
                    MessageBox.Show("Stock out of range", "Sale Quantity", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                   SQLiteCommand cmxd = new SQLiteCommand();

                    int a = Convert.ToInt32(txtAvail.Text);
                    int b = Convert.ToInt32(mtbQuantity.Text);
                    int c = a - b;
                    txtAvail.Text = c.ToString();
                    con.Open();
                 
                    DataColumn dco4 = new DataColumn("السعر قبل الخصم");
                    DataColumn dco3 = new DataColumn("كميه");
                    DataColumn dco2 = new DataColumn("نوع كميه");
                    DataColumn dco1 = new DataColumn("اسم المنتج");
                    DataColumn dco5 = new DataColumn("السعر بعد الخصم");
                    DataColumn dco6 = new DataColumn("المبلغ الكلى بعد الخصم");
                    DataColumn dco7 = new DataColumn("كود الماده");
                    DataColumn dco8 = new DataColumn("م");


                    if (dt.Columns.Count == 0)
                    {
                                                dt.Columns.Add(dco8);

                        dt.Columns.Add(dco1);
                        dt.Columns.Add(dco3);
                        dt.Columns.Add(dco2);
                        dt.Columns.Add(dco4);
                        dt.Columns.Add(dco5);
                        dt.Columns.Add(dco6);                
                        dt.Columns.Add(dco7);

                    }

                    for (int i = 1; i < 2; i++)
                    {
                        DataRow row1 = dt.NewRow();

                       
                        row1["اسم المنتج"] = cbMtrlName.Text;
                        row1["كميه"] = mtbQuantity.Text;
                        row1["نوع كميه"] = cbUnit.Text;
                        row1["السعر قبل الخصم"] = txtAmount.Text;
                        row1["كود الماده"] = valueidm;
                        row1["السعر بعد الخصم"] = total.Text;
                        row1["المبلغ الكلى بعد الخصم"] = m;
                        row1["م"] = (dataGridView1.Rows.Count)+1;
                        dt.Rows.Add(row1);
                        //}           
                    }
                    dataGridView1.DataSource = dt;
                  // dataGridView1.AutoResizeColumns();

                    dataGridView1.Columns[0].Width = 30;
                    dataGridView1.Columns[1].Width = 240;
                    dataGridView1.Columns[2].Width = 45;
                    dataGridView1.Columns[3].Width = 80;
                    dataGridView1.Columns[4].Width = 60;
                    dataGridView1.Columns[5].Width = 80;
                    dataGridView1.Columns[6].Width = 80;
                    dataGridView1.Columns[7].Width = 60;
                    dataGridView1.AllowUserToResizeRows = false;
                    dataGridView1.AllowUserToResizeColumns = false;
                }
                SQLiteCommand cmnd = new SQLiteCommand();

            
                con.Close();
            }



        }
        private void SalesOrder_Load(object sender, EventArgs e)
        {


            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd hh-mm-ss";
            dateTimePicker1.CustomFormat = "yyyy-MM-dd hh-mm-ss";
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





            cmd.Connection = con;
            con.Open();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT CompanyName FROM CustomerInfo WHERE CompanyName LIKE '" + txtCstName.Text + "%'";
            dReader = cmd.ExecuteReader();
            if (dReader.HasRows == true)
            {
                while (dReader.Read())
                    namesCollection.Add(dReader["CompanyName"].ToString());

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


        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            btnCnfrm.Enabled = true;
            btnGenerate.Enabled = false;
            SQLiteDataReader dr;
            cmmd = new SQLiteCommand("Select OrderID from SalesOrder_Master ORDER BY OrderID  ", con);

            dr = cmmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                   
                    res = dr[0].ToString();
                }
               
                order.Text = res.ToString();
            }
            dr.Close();
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            
     
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
             
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells["المبلغ الكلى بعد الخصم"].Value);
            }
            btnGenerate.Enabled = true;
            btnPO.Enabled = false;
           
            btnAdd.Enabled = false;
            double total = sum + Convert.ToDouble(totalcus.Text);
            total = total - Convert.ToDouble(textBox1.Text);
            textBox3.Text = total.ToString();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //DataRow row2 = dt.NewRow();
            //dt.Rows.Add(row2);
            //int remp=e.RowIndex;
            //MessageBox.Show(remp.ToString());
            //remp++;
        }



        private void btnNew_Click(object sender, EventArgs e)
        {
            txtCstName.Enabled = false;
            cbMtrlName.Text = "";
            cbUnit.Text = "";
            txtAmount.Text = "";
            mtbQuantity.Text = "";
            txtAvail.Text = "";
            total.Text = "";
            btnAdd.Enabled = false;
            btnPO.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }
    
  private void button1_Click_1(object sender, EventArgs e)
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
            btnAdd.Enabled = true;
            btnPO.Enabled = true;
            
        }
    
        private void btnCnfrm_Click(object sender, EventArgs e)
        {
            btnCnfrm.Enabled = false;
            printToolStripButton.Enabled = true;
            SQLiteCommand cmmmd = new SQLiteCommand();
            cmmmd.Connection = con;
            SQLiteCommand cmd = new SQLiteCommand();
            SQLiteCommand cmxd = new SQLiteCommand();
            SQLiteCommand cmrd = new SQLiteCommand();

            int ah,aa;
            string ahmed="";
            int count = dataGridView1.Rows.Count;
          
            int i = 0;
            cmd = new SQLiteCommand("Insert into SalesOrder_Master(Date,CustomerName,paid,stay) values(@a,@b,@c,@d)", con);

            cmd.Parameters.AddWithValue("@a", dateTimePicker1.Value.Date);
            cmd.Parameters.AddWithValue("@b", txtCstName.Text);
            cmd.Parameters.AddWithValue("@c", textBox1.Text);
            cmd.Parameters.AddWithValue("@d", totalcus.Text);
            con.Open();
            int k = cmd.ExecuteNonQuery();
          

            for (i = 0; i < count; i++)
            {

                SQLiteDataAdapter da = new SQLiteDataAdapter("Select Quantity from Temp where MaterialID LIKE '" + dataGridView1.Rows[i].Cells["كود الماده"].Value + "'", con);

                DataSet ds = new DataSet();

                try
                {
                    da.Fill(ds);
                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {

                        ahmed = ds.Tables[0].Rows[0]["Quantity"].ToString();



                    }
                    else
                    {
                        MessageBox.Show("Selected Material does not exist", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                finally
                {
                }
                da = new SQLiteDataAdapter("Select a.MaterialID,a.sale ,b.UnitID  FROM MaterialInfo a, Unit b where( MaterialID  LIKE'" + dataGridView1.Rows[i].Cells["كود الماده"].Value + "'AND QuantityType  LIKE'" + dataGridView1.Rows[i].Cells["نوع كميه"].Value + "')", con);

                ds = new DataSet();


                da.Fill(ds);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {

                    valueidm = ds.Tables[0].Rows[0]["MaterialID"].ToString();
                    valueidu = ds.Tables[0].Rows[0]["UnitID"].ToString();
                    valueids = ds.Tables[0].Rows[0]["sale"].ToString();
                }


                ah = Convert.ToInt32(ahmed);

                aa = Convert.ToInt32(dataGridView1.Rows[i].Cells["كميه"].Value);

                ah = ah - aa;
                SQLiteDataReader dr;
                cmmd = new SQLiteCommand("Select OrderID from SalesOrder_Master ORDER BY OrderID ", con);
                dr = cmmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {

                        res = dr[0].ToString();
                    }

                    order.Text = res.ToString();
                }
                dr.Close();
                cmxd = new SQLiteCommand("UPDATE Temp SET Quantity= '" + ah + "' WHERE MaterialID='" + dataGridView1.Rows[i].Cells["كود الماده"].Value + "'", con);

                cmxd.ExecuteNonQuery();

                cmxd = new SQLiteCommand("Insert into SalesOrder_Sub(MaterialID,Quantity,UnitID,Total,OrderID,Amount,win) values(@a,@b,@c,@d,@j,@k,@s)", con);


                cmxd.Parameters.AddWithValue("@j", Convert.ToInt32(res));
                cmxd.Parameters.AddWithValue("@a", dataGridView1.Rows[i].Cells["كود الماده"].Value);
                cmxd.Parameters.AddWithValue("@b", dataGridView1.Rows[i].Cells["كميه"].Value);
                cmxd.Parameters.AddWithValue("@c", valueidu);
                cmxd.Parameters.AddWithValue("@k", dataGridView1.Rows[i].Cells["السعر قبل الخصم"].Value);

                cmxd.Parameters.AddWithValue("@d", dataGridView1.Rows[i].Cells["المبلغ الكلى بعد الخصم"].Value);
                win = (Convert.ToDouble(dataGridView1.Rows[i].Cells["المبلغ الكلى بعد الخصم"].Value)) - (Convert.ToDouble(dataGridView1.Rows[i].Cells["كميه"].Value) * Convert.ToDouble(valueids));
                cmxd.Parameters.AddWithValue("@s", win);
                MessageBox.Show(i.ToString());
                cmxd.ExecuteNonQuery();

                cmrd = new SQLiteCommand("UPDATE CustomerInfo SET State = '" + textBox3.Text + "',data='" + DateTime.Now + "' WHERE CompanyName= '" + txtCstName.Text + "'", con);

                int r = cmrd.ExecuteNonQuery();
                 da = new SQLiteDataAdapter("Select CustomerID  FROM CustomerInfo where CompanyName LIKE'" + txtCstName.Text + "'", con);

                ds = new DataSet();
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {

                    t = ds.Tables[0].Rows[0]["CustomerID"].ToString();


                }
            }

                cmd = new SQLiteCommand("Insert into money(paid,stay,time,idc) values(@b,@c,@d,@k)", con);


                cmd.Parameters.AddWithValue("@b", textBox1.Text);
                cmd.Parameters.AddWithValue("@c", textBox3.Text);
                cmd.Parameters.AddWithValue("@d", dateTimePicker1.Value.Date);

                cmd.Parameters.AddWithValue("@k", t);


             int   y = cmd.ExecuteNonQuery();
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

                    //((DataTable)dataGridView1.DataSource).Rows.Clear();

                }

            con.Close();

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

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            

            DGVPrinter printer = new DGVPrinter();

            printer.Title = "فاتوره بيع منتجات من ابناء الاشراف للتجاره " + "\n"+"رقم  تليفون    محمود 01003285295      01116911007 ";

            printer.SubTitle = res + "     اسم العميل   " + "    " + txtCstName.Text + "     رقم  الفاتوره      "+ "\n" +dateTimePicker1.Value;
          

            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |

                StringFormatFlags.NoClip;

            printer.PageNumbers = true;

            printer.PageNumberInHeader = false;

            printer.PorportionalColumns = true;
            
         printer.HeaderCellAlignment = StringAlignment.Near;
        Double sum1 = sum + old;
        double sumx = sum1 - Convert.ToDouble(textBox1.Text);
        printer.Footer = sum + "     الاجمالى     " + "\n" + old.ToString() + "      السابق     " + "\n" + "    " + "الاجمالى الكلى  " + sum1.ToString() + "\n" + "           الواصل   "+ textBox1.Text   + "\n" + "         الباقى   "+ sumx.ToString();
            
            printer.FooterSpacing = 1;

          

            // use saved settings





            if (DialogResult.OK == printer.DisplayPrintDialog())  // replace DisplayPrintDialog() 

            // with your own print dialog
            {

                // save users' settings 




                // print without displaying the printdialog

                printer.PrintNoDisplay(dataGridView1);

            }

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

        private void review_Click(object sender, EventArgs e)
        {

            SQLiteDataAdapter da = new SQLiteDataAdapter("Select State,data FROM CustomerInfo where CompanyName LIKE'" + txtCstName.Text + "'", con);

            DataSet ds = new DataSet();



            da.Fill(ds);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                totalcus.Text = ds.Tables[0].Rows[0]["State"].ToString();

                old = Double.Parse(totalcus.Text);
                textBox2.Text = ds.Tables[0].Rows[0]["data"].ToString();


            }
            else
            {
                MessageBox.Show(" not exist", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                old = 0;


            }






        }
      
        
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cbMtrlName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void newcus_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void txtCstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        
    }
}


