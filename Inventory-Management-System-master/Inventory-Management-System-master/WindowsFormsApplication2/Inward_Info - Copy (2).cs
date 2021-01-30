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
    public partial class salesinfo : Form
    {
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Inventory-Management-System-master\Inventory-Management-System-master\ss.db;Version=3;New=true;Compress=True");
        SQLiteDataAdapter da;
        bool flag;
        DataSet ds = new DataSet();
        string xx, yy, zz,uu;
        public salesinfo()
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
                if (cbSearch.Text != "")
                {
                    if (cbSearch.Text.ToString() == "العميل")
                    {
                        if (txtSearch.Text == "")
                        {
                            MessageBox.Show("Empty Search Feild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            flag = false;
                            ds = new DataSet();

                            dataGridView1.Hide();
                            dataGridView1.Show();
                            ds.Clear();
                            da = new SQLiteDataAdapter("Select  SalesOrder_Master.Date التاريخ ,SalesOrder_Sub.win المكسب, SalesOrder_Sub.Quantity الكميه , SalesOrder_Sub.UnitID رقمالوحده,SalesOrder_Sub.Amount سعرقبل ,SalesOrder_Sub.OrderID رقمالفاتوره  ,SalesOrder_Sub.Total المبلغالكلى ,SalesOrder_Master.CustomerName اسمالعميل ,MaterialInfo.MaterialName اسمالمنتج,MaterialInfo.price سعربعدالخصم,MaterialInfo.sale اصلسعر FROM SalesOrder_Sub INNER JOIN SalesOrder_Master ON SalesOrder_Master.OrderID=SalesOrder_Sub.OrderID JOIN MaterialInfo ON MaterialInfo.MaterialID=SalesOrder_Sub.MaterialID  where SalesOrder_Master.CustomerName LIKE'%" + txtSearch.Text + "%'ORDER BY SalesOrder_Sub.OrderID", con);
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

                    else if (cbSearch.Text.ToString() == "المنتج")
                    {
                        if (txtSearch.Text == "")
                        {
                            MessageBox.Show("Empty Search Feild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            flag = false;
                            dataGridView1.Hide();
                            dataGridView1.Show();
                            ds = new DataSet();

                            ds.Clear();
                            da = new SQLiteDataAdapter("select   SalesOrder_Master.Date التاريخ ,SalesOrder_Sub.win المكسب, SalesOrder_Sub.Quantity الكميه , SalesOrder_Sub.UnitID رقمالوحده,SalesOrder_Sub.Amount سعرقبل ,SalesOrder_Sub.OrderID رقمالفاتوره  ,SalesOrder_Sub.Total المبلغالكلى ,SalesOrder_Master.CustomerName اسمالعميل ,MaterialInfo.MaterialName اسمالمنتج,MaterialInfo.price سعربعدالخصم,MaterialInfo.sale اصلسعر from SalesOrder_Sub INNER JOIN SalesOrder_Master ON SalesOrder_Master.OrderID=SalesOrder_Sub.OrderID INNER JOIN MaterialInfo on SalesOrder_Sub.MaterialID = MaterialInfo.MaterialID INNER JOIN Temp on SalesOrder_Sub.MaterialID =Temp.MaterialID where MaterialInfo.MaterialName LIKE'%" + txtSearch.Text + "%'ORDER BY SalesOrder_Sub.OrderID", con);
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
                    else if (cbSearch.Text.ToString() == "الفاتوره")
                    {
                        if (txtSearch.Text == "")
                        {
                            MessageBox.Show("Empty Search Feild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            flag = false;
                            dataGridView1.Hide();
                            dataGridView1.Show();
                            ds = new DataSet();

                            ds.Clear();
                            da = new SQLiteDataAdapter("Select  SalesOrder_Master.Date التاريخ ,SalesOrder_Sub.win المكسب, SalesOrder_Sub.Quantity الكميه , SalesOrder_Sub.UnitID رقمالوحده,SalesOrder_Sub.Amount سعرقبل ,SalesOrder_Sub.OrderID رقمالفاتوره  ,SalesOrder_Sub.Total المبلغالكلى ,SalesOrder_Master.CustomerName اسمالعميل ,MaterialInfo.MaterialName اسمالمنتج,MaterialInfo.price سعربعدالخصم,MaterialInfo.sale اصلسعر FROM SalesOrder_Sub INNER JOIN SalesOrder_Master ON SalesOrder_Master.OrderID=SalesOrder_Sub.OrderID  JOIN MaterialInfo ON MaterialInfo.MaterialID=SalesOrder_Sub.MaterialID where SalesOrder_Sub.OrderID like '" + txtSearch.Text + "'ORDER BY SalesOrder_Sub.OrderID", con);
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
                            flag = false;
                            dataGridView1.Hide();
                            dataGridView1.Show();
                            ds = new DataSet();

                            ds.Clear();
                            da = new SQLiteDataAdapter("Select  SalesOrder_Master.Date التاريخ ,SalesOrder_Sub.win المكسب, SalesOrder_Sub.Quantity الكميه , SalesOrder_Sub.UnitID رقمالوحده,SalesOrder_Sub.Amount سعرقبل ,SalesOrder_Sub.OrderID رقمالفاتوره  ,SalesOrder_Sub.Total المبلغالكلى ,SalesOrder_Master.CustomerName اسمالعميل ,MaterialInfo.MaterialName اسمالمنتج,MaterialInfo.price سعربعدالخصم,MaterialInfo.sale اصلسعر FROM SalesOrder_Sub INNER JOIN SalesOrder_Master ON SalesOrder_Master.OrderID=SalesOrder_Sub.OrderID JOIN MaterialInfo ON MaterialInfo.MaterialID=SalesOrder_Sub.MaterialID where SalesOrder_Sub.Quantity > '" + mtbFrom.Text + "' AND SalesOrder_Sub.Quantity < '" + mtbTo.Text + "'ORDER BY SalesOrder_Sub.OrderID", con);
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
                    else if (cbSearch.Text.ToString() == "التاريخ")
                    {
                        if (dtpFrom.Value.Date > System.DateTime.Today)
                        {
                            MessageBox.Show("Invalid Selected Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            flag = false;
                            dataGridView1.Hide();
                            dataGridView1.Show();
                            ds = new DataSet();


                            ds.Clear();
                            da = new SQLiteDataAdapter("Select  SalesOrder_Master.Date التاريخ ,SalesOrder_Sub.win المكسب, SalesOrder_Sub.Quantity الكميه , SalesOrder_Sub.UnitID رقمالوحده,SalesOrder_Sub.Amount سعرقبل ,SalesOrder_Sub.OrderID رقمالفاتوره  ,SalesOrder_Sub.Total المبلغالكلى ,SalesOrder_Master.CustomerName اسمالعميل ,MaterialInfo.MaterialName اسمالمنتج ,MaterialInfo.price سعربعدالخصم,MaterialInfo.sale اصلسعر FROM SalesOrder_Sub INNER JOIN SalesOrder_Master ON SalesOrder_Master.OrderID=SalesOrder_Sub.OrderID JOIN MaterialInfo ON MaterialInfo.MaterialID=SalesOrder_Sub.MaterialID where SalesOrder_Master.Date > '" + dtpFrom.Text.ToString() + "' AND SalesOrder_Master.Date <= '" + dtpTo.Text.ToString() + "'ORDER BY SalesOrder_Sub.win", con);
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

                    else if (cbSearch.Text.ToString() == "طباعه فاتوره")
                    {
                        if (txtSearch.Text == "")
                        {
                            MessageBox.Show("Empty Search Feild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            flag = true;
                            dataGridView1.Hide();
                            dataGridView1.Show();


                            ds.Clear();
                            ds = new DataSet();
                            da = new SQLiteDataAdapter("Select SalesOrder_Sub.Total المبلغالكلى ,SalesOrder_Sub.Total / SalesOrder_Sub.Quantity سعربعدالخصم ,  SalesOrder_Sub.Amount سعرقبل ,SalesOrder_Sub.OrderID ,SalesOrder_Master.Date  ,SalesOrder_Master.CustomerName   ,SalesOrder_Sub.Quantity الكميه,MaterialInfo.MaterialName اسمالمنتج FROM SalesOrder_Sub INNER JOIN SalesOrder_Master ON SalesOrder_Master.OrderID=SalesOrder_Sub.OrderID  JOIN MaterialInfo ON MaterialInfo.MaterialID=SalesOrder_Sub.MaterialID where SalesOrder_Sub.OrderID like '" + txtSearch.Text + "'ORDER BY SalesOrder_Sub.OrderID", con);
                            da.Fill(ds);
                            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                            {
                                dataGridView1.DataSource = ds.Tables[0];



                                xx = (dataGridView1.Rows[0].Cells["OrderID"].Value).ToString();
                                yy = (dataGridView1.Rows[0].Cells["CustomerName"].Value).ToString();
                                zz = (dataGridView1.Rows[0].Cells["Date"].Value).ToString();
                                dataGridView1.Columns.Remove("Date");
                                dataGridView1.Columns.Remove("OrderID");
                                dataGridView1.Columns.Remove("CustomerName");


                            }

                            else
                            {
                                MessageBox.Show("Requested Vendor does not exist", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }

                            da = new SQLiteDataAdapter("Select stay,paid   FROM SalesOrder_Master where OrderID LIKE'" + xx + "'", con);

                            DataSet dss = new DataSet();



                            da.Fill(dss);

                            if (dss != null && dss.Tables.Count > 0 && dss.Tables[0].Rows.Count > 0)
                            {
                                win.Text = dss.Tables[0].Rows[0]["stay"].ToString();
                                uu = dss.Tables[0].Rows[0]["paid"].ToString();
                            }
                            else
                            {
                                MessageBox.Show(" not exist", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                win.Text = "0";

                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Select Items to Search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                double sum = 0, sum1 = 0, sum2 = 0;
                double sum5 = 0, x = 0;

                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    sum5 = Convert.ToDouble(dataGridView1.Rows[i].Cells["المبلغالكلى"].Value);
                    if (flag)
                    { sum2 = Convert.ToDouble(win.Text); }
                    else
                    {
                        sum1 = Convert.ToDouble(dataGridView1.Rows[i].Cells["المكسب"].Value);
                        sum2 += sum1;

                    }

                    x += sum5;
                }
                sale.Text = x.ToString();
                win.Text = (sum2).ToString();







            }
            finally
            {
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
                label4.Text = "المكسب";
                dataGridView1.AllowUserToResizeRows = true;
                dataGridView1.AllowUserToResizeColumns = true;
            }
            else if (cbSearch.Text.ToString() == "طباعه فاتوره")
            {

                txtSearch.Show();
                mtbFrom.Hide();
                mtbTo.Hide();
                label3.Hide();
                dtpFrom.Hide();
                dtpTo.Hide();
                txtSearch.Text = "";
                ds.Clear();
                label4.Text = "السابق";
                dataGridView1.AllowUserToResizeRows = false;
                dataGridView1.AllowUserToResizeColumns = false;
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
                label4.Text = "المكسب";
                dataGridView1.AllowUserToResizeRows = true;
                dataGridView1.AllowUserToResizeColumns = true;
                ds.Clear();
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
                    MessageBox.Show("no data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //namesCollection.Add(dReader["No record found"].ToString());
                }
                dReader.Close();
                txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSearch.AutoCompleteCustomSource = namesCollection;
                con.Close();
            }

            else if (cbSearch.Text.ToString() == "الفاتوره")
            {
                txtSearch.Show();
                mtbFrom.Hide();
                mtbTo.Hide();
                label3.Hide();
                dtpFrom.Hide();
                dtpTo.Hide();
                txtSearch.Text = "";
                ds.Clear();
                label4.Text = "المكسب";
                dataGridView1.AllowUserToResizeRows = true;
                dataGridView1.AllowUserToResizeColumns = true;
            }
            else if (cbSearch.Text.ToString() == "العميل")
            {
                txtSearch.Show();
                mtbFrom.Hide();
                mtbTo.Hide();
                label3.Hide();
                dtpFrom.Hide();
                dtpTo.Hide();
                txtSearch.Text = "";
                label4.Text = "المكسب";
                dataGridView1.AllowUserToResizeRows = true;
                dataGridView1.AllowUserToResizeColumns = true;
                ds.Clear();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = con;
                SQLiteDataReader dReader;

                cmd.CommandType = CommandType.Text;
                //   cmd.CommandText = "SELECT CustomerName FROM SalesOrder_Master WHERE CustomerName LIKE '%" + txtSearch.Text + "%'";
                cmd.CommandText = "SELECT CustomerName FROM SalesOrder_Master WHERE CustomerName LIKE'" + txtSearch.Text + "%'";

                con.Open();
                dReader = cmd.ExecuteReader();
                if (dReader.HasRows == true)
                {
                    while (dReader.Read())
                        namesCollection.Add(dReader["CustomerName"].ToString());
                }
                else
                {
                    MessageBox.Show("no data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //namesCollection.Add(dReader["No record found"].ToString());
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
                label4.Text = "المكسب";
                dataGridView1.AllowUserToResizeRows = true;
                dataGridView1.AllowUserToResizeColumns = true;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void sale_TextChanged(object sender, EventArgs e)
        {

        }

        private void win_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                DGVPrinter printer = new DGVPrinter();

                printer.Title = "فاتوره بيع منتجات من ابناء الاشراف للتجاره " + "\n" + "رقم  تليفون    محمود 01003285295      01116911007 ";

                printer.SubTitle = xx + "     اسم العميل   " + "    " + yy + "     رقم  الفاتوره      " + "\n" + zz;


                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |

                    StringFormatFlags.NoClip;

                printer.PageNumbers = true;

                printer.PageNumberInHeader = false;

                printer.PorportionalColumns = true;

                printer.HeaderCellAlignment = StringAlignment.Near;
                Double sum1 = Convert.ToDouble(sale.Text);
                Double sum2 = Convert.ToDouble(win.Text);

                double total = sum1 + sum2;
                double qq = total - Convert.ToDouble(uu);

                printer.Footer = sum1 + "     الاجمالى     " + "\n" + sum2 + "      السابق     " + "\n" + "    " + total + "الاجمالى الكلى  " + "\n" + "    " + uu + "           الواصل   " + "\n" + "    " + qq + "         الباقى   ";

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
            else {
                MessageBox.Show(" not exist", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
     }
    }
    }
