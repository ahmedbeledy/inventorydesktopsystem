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
    public partial class Unit : Form
    {
        private bool nonNumberEntered = false;
SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Inventory-Management-System-master\Inventory-Management-System-master\ss.db;Version=3;New=true;Compress=True");
        SQLiteCommand cmd;
        public Unit()
        {
            InitializeComponent();
        }

        private void Unit_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (txtUnit.Text != "")
            {
                con.Open();
                cmd = new SQLiteCommand("Insert into Unit(QuantityType) values('" + txtUnit.Text + "')", con);
                cmd.Parameters.AddWithValue("@b", txtUnit.Text);
                try
                {
                    int r = cmd.ExecuteNonQuery();
                    MessageBox.Show("Material Unit Added Succesfully", "Unit Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
                finally
                {
                    txtUnit.Text = "";
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Fill Required Feilds", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            Unit u = new Unit();
            u.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            if (txtUnit.Text != "")
            {
                con.Open();
                cmd = new SQLiteCommand("Insert into Unit(QuantityType) values('" + txtUnit.Text +"')", con);
                //cmd.Parameters.AddWithValue("@b", txtUnit.Text);
                try
                {
                    int r = cmd.ExecuteNonQuery();
                    MessageBox.Show("Material Unit Added Succesfully", "Unit Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
                finally
                {
                    txtUnit.Text = "";
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Fill Required Feilds", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            this.Dispose(true);
        }

        private void txtUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == false)
            {
                e.Handled = true;
            }
        }

        private void txtUnit_KeyDown(object sender, KeyEventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Unit_Load(object sender, EventArgs e)
        {

        }

        private void txtUnit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
