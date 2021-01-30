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
    public partial class Material : Form
    {
        private bool nonNumberEntered = false;
SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Inventory-Management-System-master\Inventory-Management-System-master\ss.db;Version=3;New=true;Compress=True");
        SQLiteCommand cmd;
        SQLiteCommand cmmd;
        string res;
        int cc = 0;
        public Material()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                con.Open();
                cmd = new SQLiteCommand("Insert into MaterialInfo(MaterialName,Department,Make,Model,price,sale) values('" + txtName.Text + "','" + txtDepartment.Text + "','" + txtMake.Text + "','" + txtModel.Text + "','" + float.Parse(mtbQuantity.Text) + "','" + float.Parse(textBox1.Text) + "')", con);
             //   cmd.Parameters.AddWithValue("@b", txtName.Text);
              //  cmd.Parameters.AddWithValue("@c", txtDepartment.Text);
              //  cmd.Parameters.AddWithValue("@d", txtMake.Text);
              //  cmd.Parameters.AddWithValue("@e", txtModel.Text);
                try
                {
                    int r = cmd.ExecuteNonQuery();
                    cmd = new SQLiteCommand("Select MaterialID from MaterialInfo", con);
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            res = dr[0].ToString();
                        }
                    }
                    dr.Close();
                    MessageBox.Show("Material Unique Number" + ":" + "" + "" + res, "Material Added Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmd = new SQLiteCommand("Insert into Temp  values(@a,@b)", con);
                    cmd.Parameters.AddWithValue("@a", res);
                    cmd.Parameters.AddWithValue("@b", cc); 
                    cmd.ExecuteNonQuery();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
                finally
                {
                    txtName.Text = "";
                    txtDepartment.Text = "";
                    txtMake.Text = "";
                    txtModel.Text = "";
                    con.Close();
                }
                this.Hide();
                Material m = new Material();
                m.Show(); 
            }
            else
            {
                MessageBox.Show("Fill Required Feilds","",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                con.Open();
                cmd = new SQLiteCommand("Insert into MaterialInfo(MaterialName,Department,Make,Model,price,sale) values('" + txtName.Text + "','" + txtDepartment.Text + "','" + txtMake.Text + "','" + txtModel.Text + "','" + float.Parse(mtbQuantity.Text) + "','" + float.Parse(textBox1.Text) + "')", con);

                //cmd.Parameters.AddWithValue("@b", txtName.Text);
                //cmd.Parameters.AddWithValue("@c", txtDepartment.Text);
                //cmd.Parameters.AddWithValue("@d", txtMake.Text);
                //cmd.Parameters.AddWithValue("@e", txtModel.Text);
                try
                {
                    int r = cmd.ExecuteNonQuery();
                    cmd = new SQLiteCommand("Select MaterialID from MaterialInfo", con);
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            res = dr[0].ToString();
                        }
                    }
                    dr.Close();
                    MessageBox.Show("Material Unique Number" + ":" + "" + "" + res, "Material Added Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmd = new SQLiteCommand("Insert into Temp  values(@a,@b)", con);
                    cmd.Parameters.AddWithValue("@a", res);
                    cmd.Parameters.AddWithValue("@b", cc);
                    cmd.ExecuteNonQuery();
                
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
                finally
                {
                    mtbQuantity.Text = "";
                    txtName.Text = "";
                    txtDepartment.Text = "";
                    txtMake.Text = "";
                    txtModel.Text = "";
                    con.Close();
                }
                this.Dispose(true);
            }

            else
            {
                MessageBox.Show("Fill Required Feilds", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }

        private void Material_FormClosing(object sender, FormClosingEventArgs e)
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

        //private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (nonNumberEntered == false)
        //    {
        //        e.Handled = true;
        //    }
        //}

        private void txtDepartment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == false)
            {
                e.Handled = true;
            }
        }

        //private void txtMake_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (nonNumberEntered == false)
        //    {
        //        e.Handled = true;
        //    }
        //}

        //private void txtName_KeyDown(object sender, KeyEventArgs e)
        //{
        //    nonNumberEntered = false;

        //    if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
        //    {
        //        if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
        //        {
        //            nonNumberEntered = true;
        //        }
        //    }

        //    if (Control.ModifierKeys == Keys.Shift)
        //    {
        //        nonNumberEntered = true;
        //    }
        //}

        private void txtDepartment_KeyDown(object sender, KeyEventArgs e)
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

        //private void txtMake_KeyDown(object sender, KeyEventArgs e)
        //{
        //    nonNumberEntered = false;

        //    if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
        //    {
        //        if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
        //        {
        //            nonNumberEntered = true;
        //        }
        //    }

        //    if (Control.ModifierKeys == Keys.Shift)
        //    {
        //        nonNumberEntered = true;
        //    }
        //}

        private void Material_Load(object sender, EventArgs e)
        {

        }

        private void price_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbQuantity_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            this.Hide();
            updatep m = new updatep();
            m.Show();
         
        }
    }
}
