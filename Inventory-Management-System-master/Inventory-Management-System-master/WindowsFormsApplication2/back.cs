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
    public partial class back : Form
    {
SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Inventory-Management-System-master\Inventory-Management-System-master\ss.db;Version=3;New=true;Compress=True");
        SQLiteCommand cmd = new SQLiteCommand();
        SQLiteCommand cmxd = new SQLiteCommand();

        SQLiteDataAdapter da = new SQLiteDataAdapter();
        String valueidm;
        int st ;
        int av;
        string ahmed;
        public back()
        {
            InitializeComponent();
        }

        private void back_Load(object sender, EventArgs e)
        {
        

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            da = new SQLiteDataAdapter("select Quantity from SalesOrder_Sub where  OrderID = '" + order.Text + "'AND MaterialID = '" + textBox1.Text + "' ", con);
    DataSet ds = new DataSet();

            try
            {
                da.Fill(ds);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {

                    valueidm = ds.Tables[0].Rows[0]["Quantity"].ToString();
                 
                   
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

             av =Convert.ToInt32(valueidm);
            st= Convert.ToInt32(mtbQuantity.Text);
            if (mtbQuantity.Text == "" || textBox1.Text == "" || order.Text == "" || av < st)
            {
                MessageBox.Show("Fill the required feilds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
            }if(av ==st){
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd = new SQLiteCommand("DELETE From SalesOrder_Sub WHERE OrderID= '" + order.Text + "'AND MaterialID = '" + textBox1.Text + "'", con);

                int r = cmd.ExecuteNonQuery();
                if (r != 0)
                {
                    MessageBox.Show("Deleted Succesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    da = new SQLiteDataAdapter("Select Quantity from Temp where MaterialID LIKE '" + textBox1.Text + "'", con);

                    ds = new DataSet();


                    da.Fill(ds);
                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {

                        ahmed = ds.Tables[0].Rows[0]["Quantity"].ToString();
                    }
                    int xxx = Convert.ToInt32(ahmed);
                 int yyy=   Convert.ToInt32(mtbQuantity.Text);
                 yyy = yyy + xxx;
                 cmxd = new SQLiteCommand("UPDATE Temp SET Quantity= '" + yyy + "' WHERE MaterialID= '" +  textBox1.Text+ "'", con);

                 cmxd.ExecuteNonQuery();
                    textBox1.Text = "";
                    order.Text = "";
                    mtbQuantity.Text = "";
                }
                else
                {
                    MessageBox.Show("No Record Deleted", "Delete Fail", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    textBox1.Text = "";
                    order.Text = "";
                    mtbQuantity.Text = "";
                }




            }
            else if (av > st){
                try
                {
                   string cc  = (av-st).ToString();
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd = new SQLiteCommand("UPDATE SalesOrder_Sub SET Quantity= '" + cc + "' ,total= (total/ '" + av + "') *  '"  +   cc + "' WHERE OrderID = '" + order.Text + "' AND  MaterialID = '" + textBox1.Text + "' ", con);

                    int r = cmd.ExecuteNonQuery();
                    if (r != 0)
                    {
                        MessageBox.Show("Updated Succesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        da = new SQLiteDataAdapter("Select Quantity from Temp where MaterialID LIKE '" + textBox1.Text + "'", con);

                        ds = new DataSet();


                        da.Fill(ds);
                        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {

                            ahmed = ds.Tables[0].Rows[0]["Quantity"].ToString();
                        }
                        int xxx = Convert.ToInt32(ahmed);
                        int yyy = Convert.ToInt32(mtbQuantity.Text);
                        yyy = yyy + xxx;
                        cmxd = new SQLiteCommand("UPDATE Temp SET Quantity= '" + yyy + "' WHERE MaterialID= '" + textBox1.Text + "'", con);

                        cmxd.ExecuteNonQuery();
                        textBox1.Text = "";
                        order.Text = "";
                        mtbQuantity.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("No Record Updated", "Update Fail", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        textBox1.Text = "";
                        order.Text = "";
                        mtbQuantity.Text = "";
                    }
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
