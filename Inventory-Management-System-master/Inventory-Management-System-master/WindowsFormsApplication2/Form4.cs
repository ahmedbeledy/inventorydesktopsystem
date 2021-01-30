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
    public partial class Form4 : Form
    {
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
        //   SQLiteConnection con = new   SQLiteConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\bele\Downloads\Inventory-Management-System-master\WindowsFormsApplication2\IMS.mdf;Integrated Security=True;Connect Timeout=30");
SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Inventory-Management-System-master\Inventory-Management-System-master\ss.db;Version=3;New=true;Compress=True");
        SQLiteCommand cmd = new SQLiteCommand();
        string t ;
        SQLiteDataReader dReader ;
        public Form4()
        {
            InitializeComponent();
            textBox2.Enabled = false;
            textBox4.Enabled = false;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd hh-mm-ss";
            dateTimePicker1.CustomFormat = "yyyy-MM-dd hh-mm-ss";
            cmd.Connection = con;
            con.Open();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT CompanyName FROM CustomerInfo WHERE CompanyName LIKE '" + textBox1.Text + "%'";
            dReader = cmd.ExecuteReader();
            if (dReader.HasRows == true)
            {
                while (dReader.Read())
                    namesCollection.Add(dReader["CompanyName"].ToString());

            }
            else
            {
                // namesCollection.Add(dReader["No record found"].ToString());

            }
            dReader.Close();
            con.Close();
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox1.AutoCompleteCustomSource = namesCollection;

            // this.unitTableAdapter.Fill(this.iMSDataSet.Unit);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
            
        {
            con.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter("Select State  FROM CustomerInfo where CompanyName LIKE'" + textBox1.Text + "'", con);

            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                textBox2.Text = ds.Tables[0].Rows[0]["State"].ToString();


            }
            else
            {
                MessageBox.Show(" not exist", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBox2.Text = "0";
                

            }
            con.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAvailable_Click(object sender, EventArgs e)
        {
            con.Open();

            SQLiteDataAdapter da = new SQLiteDataAdapter("Select State  FROM CustomerInfo where CompanyName LIKE'" + textBox1.Text + "'", con);

            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                textBox2.Text = ds.Tables[0].Rows[0]["State"].ToString();


            }
            else
            {

                MessageBox.Show(" not exist", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBox2.Text = "0";
            }
            double xy = Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textbox3.Text);
                if (xy >= 0)
                {
                    textBox4.Text = xy.ToString();
                    cmd = new SQLiteCommand();
                    cmd = new SQLiteCommand("UPDATE CustomerInfo SET State= '" + textBox4.Text + "',data='" + dateTimePicker1.Value.Date + "' WHERE CompanyName= '" + textBox1.Text + "'", con);

                    int r = cmd.ExecuteNonQuery();



                     da = new SQLiteDataAdapter("Select CustomerID  FROM CustomerInfo where CompanyName LIKE'" + textBox1.Text + "'", con);

                     ds = new DataSet();
                    da.Fill(ds);
                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {

                        t= ds.Tables[0].Rows[0]["CustomerID"].ToString();


                    }

                    cmd = new SQLiteCommand("Insert into money(paid,stay,time,idc) values(@b,@c,@d,@k)", con);


                    cmd.Parameters.AddWithValue("@b",textbox3.Text );
                    cmd.Parameters.AddWithValue("@c", textBox4.Text);
                    cmd.Parameters.AddWithValue("@d", dateTimePicker1.Value.Date);

                    cmd.Parameters.AddWithValue("@k",t);
                   

                     r = cmd.ExecuteNonQuery();
                    
                    MessageBox.Show(" تمت بنجاح", " goodjob", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Text = "";
                    textBox2.Text = "0";
                    textbox3.Text = "0";
                    textBox4.Text = "0";




                }
                else
                {
                    MessageBox.Show(" المبلغ اكبر من المبلغ الموجود", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);


                }
                con.Close();  
        }
        

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
