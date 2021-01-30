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
    public partial class Inventory : Form
    {
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Inventory-Management-System-master\Inventory-Management-System-master\ss.db;Version=3;New=true;Compress=True");
        SQLiteDataAdapter da;
        DataSet ds = new DataSet();
        public Inventory()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ds.Clear();
            con.Open();
            da = new SQLiteDataAdapter("select MaterialInfo.MaterialID as رقمالمنتج, MaterialInfo.MaterialName as المنتج,MaterialInfo.sale as سعراصل,MaterialInfo.price as بالخصم ,Temp.Quantity as الكميه FROM MaterialInfo INNER JOIN Temp ON Temp.MaterialID = MaterialInfo.MaterialID ", con);
            da.Fill(ds);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Requested Material does not exist", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            double sum = 0,sum1=0,sum2=0,sum3=0,sum4=0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum = Convert.ToDouble(dataGridView1.Rows[i].Cells["سعراصل"].Value);
                sum3 = Convert.ToDouble(dataGridView1.Rows[i].Cells["بالخصم"].Value);
                sum1 = Convert.ToDouble(dataGridView1.Rows[i].Cells["الكميه"].Value);
                sum2 += sum * sum1;
                sum4 += sum1 * sum3;
            }
            sale.Text = sum2.ToString();
            textBox1.Text = sum4.ToString();
            sale.Enabled = false;
            textBox1.Enabled = false;

            con.Close();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {

        }

       
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
