using SSIP.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSIP.Forms
{
    public partial class Dashboard1 : Form
    {
        CustomersController cc = new CustomersController();
        ComboBox combo;
        public Dashboard1()
        {
            InitializeComponent();            
        }

        public void SampleData()
        {
            dataGridView1.DataSource = cc.GetCustomers();
            this.dataGridView1.Columns["PersonID"].Visible = false;
            this.dataGridView1.Columns["AddressID"].Visible = false;
            this.dataGridView1.ReadOnly = false;
            dataGridView1.Columns[1].HeaderText = "Firstname";
            dataGridView1.Columns[2].HeaderText = "Lastname";
            dataGridView1.Columns[3].HeaderText = "Mobile No";
            dataGridView1.Columns[4].HeaderText = "Telephone No";
            dataGridView1.Columns[5].HeaderText = "House No";
            dataGridView1.Columns[6].HeaderText = "Street";
            dataGridView1.Columns[7].HeaderText = "Barangay";
            dataGridView1.Columns[8].HeaderText = "City";
            dataGridView1.Columns[9].HeaderText = "Status";
            dataGridView1.Columns[10].HeaderText = "Email";
        }

        private void rb_both_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_both.Checked)
            {
                SampleData();
            }else
            {
                dataGridView1.DataSource = null;
                dataGridView1.Update();
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            int no = 1;
            lbl_currentPageNo.Text = "page " + no++;
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            int no = 1;
            lbl_currentPageNo.Text = "page " + no--;
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            combo = e.Control as ComboBox;
            if (combo != null)
            {
                combo.SelectedIndexChanged -= new EventHandler(combo_SelectedIndexChanged);
                combo.SelectedIndexChanged += combo_SelectedIndexChanged;
            }

        }

        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selected = (sender as ComboBox).SelectedItem.ToString();

                //  var action = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                if (selected == "Edit")
                {
                    MessageBox.Show("We are editing now");
                }
                else
                {
                    if (MessageBox.Show("Delete now", "This can't be undo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        //
                    }
                }
            }
            catch (Exception error)
            {
                error.ToString();
            }
        }

        private void rb_active_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
