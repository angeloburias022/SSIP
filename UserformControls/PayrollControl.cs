using SSIP.Controllers;
using SSIP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSIP.UserformControls
{
    public partial class PayrollControl : UserControl
    {
        #region declarations
        AuditController aud = new AuditController();
        PayRollController pr = new PayRollController();
        EmployeesController emp = new EmployeesController();
        AccessController ac = new AccessController();

        public string UserFirstname { get; set; }

        public PayrollControl()
        {
            InitializeComponent();
        }
        #endregion

        #region main operations    
        private bool SavePayRoll()
        {
            #region fields
            var details = new Payroll
            {
                empID = Convert.ToInt32(tb_empID.Text),
                hrly_rate = Convert.ToDecimal(tb_hourlyRate.Text),
                total_hrs = Convert.ToDecimal(tb_workhrs.Text),
                cashAdvance = Convert.ToDecimal(tb_cashAdvance.Text),
                sss = Convert.ToDecimal(tb_sss.Text),
                pagibig = Convert.ToDecimal(tb_pagIbig.Text),
                philhealth = Convert.ToDecimal(tb_philHealth.Text),
                other_deduc = Convert.ToDecimal(tb_otherAmount.Text),
                payRollDate = payroll_date.Value,
                DateFrom = date_from.Value,
                DateTo = date_to.Value,
                total_amount = Convert.ToDecimal(tb_totalAmount.Text)
            };

            #endregion

            var tools = new PayRollController();

            var results = tools.SavePayRoll(details, tb_unameAccess.Text);

            if (results != true)
            {
                var failed = new AuditTrails
                {
                    Username = tb_unameAccess.Text,
                    AuditActionTypeENUM = (Enums.ActionTypes)3,
                    DateTimeStamp = DateTime.Now.ToString(),
                    Result = "Failed",
                    Description = "Failed to add new payroll"
                };

                aud.Logs(failed);
                return false;
            }
            else
            {
                UpdateGrid();

                var success = new AuditTrails
                {
                    Username = tb_unameAccess.Text,
                    AuditActionTypeENUM = (Enums.ActionTypes)3,
                    DateTimeStamp = DateTime.Now.ToString(),
                    Result = "Succeed",
                    Description = "Added a new Payroll"
                };

                aud.Logs(success);
                return true;

            }

        }
        private bool UpdateChanges()
        {
            var details = new Payroll
            {
                payrollID = Convert.ToInt32(tb_id.Text),
                hrly_rate = Convert.ToDecimal(tb_hourlyRate.Text),
                total_hrs = Convert.ToDecimal(tb_workhrs.Text),
                cashAdvance = Convert.ToDecimal(tb_cashAdvance.Text),
                sss = Convert.ToDecimal(tb_sss.Text),
                pagibig = Convert.ToDecimal(tb_pagIbig.Text),
                philhealth = Convert.ToDecimal(tb_philHealth.Text),
                other_deduc = Convert.ToDecimal(tb_otherAmount.Text),
                payRollDate = payroll_date.Value,
                DateFrom = date_from.Value,
                DateTo = date_to.Value,
                total_amount = Convert.ToDecimal(tb_totalAmount.Text)
            };
            
            var results = pr.UpdatePayroll(details, tb_unameAccess.Text);

            if (results != true)
            {                
                return false;
            }
            else
            {                
                return true;
            }
        }
        private void ComputeWage(int Hrly_rate, int Total_hrs, int ca)
        {
            try
            {
                int sss = 0, pagibig = 0, ph = 0, others_deduc = 0, result;

                if (int.Parse(tb_otherAmount.Text) < 0
                    && int.Parse(tb_pagIbig.Text) < 0
                    && int.Parse(tb_sss.Text) < 0
                    && int.Parse(tb_philHealth.Text) < 0
                    )
                {
                    sss += sss;
                    pagibig += pagibig;
                    ph += ph;
                    others_deduc += others_deduc;
                }
                else
                {
                    others_deduc = int.Parse(tb_otherAmount.Text);
                    sss = int.Parse(tb_sss.Text);
                    pagibig = int.Parse(tb_pagIbig.Text);
                    ph = int.Parse(tb_philHealth.Text);

                    result = (Hrly_rate * Total_hrs - ca - sss - pagibig - ph - others_deduc);

                    if (MessageBox.Show("Compute wage?", "Confirm",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                        == DialogResult.OK)
                    {
                        tb_workhrs.Text = Convert.ToString(Total_hrs);
                        tb_totalAmount.Text = Convert.ToString(result);
                        tb_cashAdvance.Text = Convert.ToString(ca);

                        var success = new AuditTrails
                        {
                            Username = tb_unameAccess.Text,
                            AuditActionTypeENUM = (Enums.ActionTypes)7,
                            DateTimeStamp = DateTime.Now.ToString(),
                            Result = "Succeed",
                            Description = "Computed a Payroll"
                        };

                        aud.Logs(success);
                    }
                    else
                    {
                        MessageBox.Show("Cancelled Successfuly");
                    }
                }
            }
            catch (Exception error)
            {
                error.ToString();
            }
        }
        private void Filter()
        {
            if (Authorized())
            {
                tb_workhrs.Text = "0";
              
                try
                {
                    var result = pr.Filter(cmb_empname.SelectedValue.ToString(), date_from.Value, date_to.Value);
                    empGrid.DataSource = result;
                }
                catch (Exception error)
                {                  
                    error.ToString();
                }        
            }
            else
            {
                NotAuthorized();
            }
        }
        private void ViewPayrollList()
        {
            if (HighAuthority())
            {
                payrollMainPanel.Dock = DockStyle.Fill;
                payrollMainPanel.Visible = true;

                payrollGrid.DataSource = pr.GetPayRolls();
            }
            else
            {
                NotHighAuthorized();
            }
        }
        private void StartCompute()
        {
            if (Authorized())
            {

                int hrlyrate = Convert.ToInt32(tb_hourlyRate.Text);
                int hrs = Convert.ToInt32(tb_workhrs.Text);
                int cashAdv = Convert.ToInt32(tb_cashAdvance.Text);

                if (hrlyrate != 0)
                {
                    ComputeWage(hrlyrate, hrs, cashAdv);
                    tb_hourlyRate.BackColor = Color.White;
                }
                else
                {
                    MessageBox.Show("Hourly rate value is invalid");
                    tb_hourlyRate.FillColor = Color.Red;
                }
            }
            else
            {
                NotHighAuthorized();
            }
        }
        private void GenerateLayout()
        {
            if (Authorized())
            {
                if (MessageBox.Show("Generate layout?", "Confirm",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                   == DialogResult.OK)
                {
                    btn_printLayout.Enabled = true;

                    date_now.Text = Convert.ToString(DateTime.Now);
                    lbl_empN.Text = cmb_empname.Text;
                    lbl_totalwrkhrs.Text = tb_workhrs.Text;
                    lbl_ca.Text = tb_cashAdvance.Text;
                    lbl_sss_print.Text = tb_sss.Text;
                    lbl_pagibig_print.Text = tb_pagIbig.Text;
                    lbl_ph_print.Text = tb_philHealth.Text;
                    //     lbl_ph_print.Text = tb_pagibig.Text;
                    lbl_others_print.Text = tb_otherAmount.Text;
                    lbl_wage.Text = tb_totalAmount.Text;
                    lbl_signature.Text = lbl_usersfname.Text;
                }
                else
                {
                    MessageBox.Show("Cancelled Successfuly");
                }
            }
            else
            {
                NotHighAuthorized();
            }
        }
        private void PrintLayout()
        {
            if (MessageBox.Show("Print the layout?", "Confirm",
                               MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                               == DialogResult.OK)
            {
                if (Authorized())
                {
                    if (tb_id.Text == "0")
                    {
                        if (SavePayRoll())
                        {
                            printSlipDialog.Document = printSlipDocument;
                            printSlipDialog.ShowDialog();
                        }
                    }
                    else
                    {
                        printSlipDialog.Document = printSlipDocument;
                        printSlipDialog.ShowDialog();
                    }

                    var success = new AuditTrails
                    {
                        Username = tb_unameAccess.Text,
                        AuditActionTypeENUM = (Enums.ActionTypes)6,
                        DateTimeStamp = DateTime.Now.ToString(),
                        Result = "Succeed",
                        Description = "Printed a receipt"
                    };
                    aud.Logs(success);
                }
                else
                {
                    NotAuthorized();
                }
            }
            else
            {
                MessageBox.Show("Cancelled Successfully");
            }
        }
        private void UpdatePayroll()
        {
            if (HighAuthority())
            {
                if (MessageBox.Show("Are you want to apply this changes?", "Updating a payroll",
                     MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                     == DialogResult.OK)
                {
                    if (UpdateChanges())
                    {
                        UpdateGrid();
                        var success = new AuditTrails
                        {
                            Username = tb_unameAccess.Text,
                            AuditActionTypeENUM = (Enums.ActionTypes)4,
                            DateTimeStamp = DateTime.Now.ToString(),
                            Result = "Succeed",
                            Description = "Updated Payroll ID: " + tb_id.Text + " "
                        };

                        aud.Logs(success);
                        MessageBox.Show("Changes Applied Sucessfully");
                    }
                    else
                    {
                        var failed = new AuditTrails
                        {
                            Username = tb_unameAccess.Text,
                            AuditActionTypeENUM = (Enums.ActionTypes)4,
                            DateTimeStamp = DateTime.Now.ToString(),
                            Result = "Failed",
                            Description = "Failed to update Payroll ID: " + tb_id.Text + " "
                        };

                        aud.Logs(failed);
                        MessageBox.Show("Something went wrong");
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled Sucessfully");
                }
            }
            else
            {
                NotHighAuthorized();
            }
        }
        private void UpdateGrid()
        {
            payrollGrid.DataSource = pr.GetPayRolls();
            payrollGrid.Update();
        }
        private void ClearFields()
        {
            payrollGrid.DataSource = null;
            payrollGrid.Update();
            tb_sss.Text = "0";
            tb_pagIbig.Text = "0";
            tb_philHealth.Text = "0";

            tb_id.Text = "0";
            tb_empID.Text = "0";

            tb_otherAmount.Text = "0";
            tb_totalAmount.Text = "0";

            tb_workhrs.Text = "0";
            tb_hourlyRate.Text = "0";

            cmb_empname.SelectedIndex = -1;
            cmb_others.SelectedIndex = -1;
            cmb_benefits.SelectedIndex = -1;
            
        }

        public void Reset()
        {
            payrollGrid.DataSource = null;
            payrollGrid.Update();
            tb_sss.Text = "0";
            tb_pagIbig.Text = "0";
            tb_philHealth.Text = "0";

            tb_id.Text = "0";
            tb_empID.Text = "0";

            tb_otherAmount.Text = "0";
            tb_totalAmount.Text = "0";

            tb_workhrs.Text = "0";
            tb_hourlyRate.Text = "0";

            cmb_empname.SelectedIndex = -1;
            cmb_others.SelectedIndex = -1;
            cmb_benefits.SelectedIndex = -1;

            payrollMainPanel.Visible = false;

            tb_unameAccess.Clear();
            tb_pass.Clear();
        }
        private void CMB_EmployeeName()
        {
            cmb_empname.DataSource = emp.GetEmployeeName();
            cmb_empname.ValueMember = "EmployeeID";
            cmb_empname.DisplayMember = "EmployeeName";

        }

        #endregion

        #region others     
        private void empGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (empGrid.DataSource != null)
            {

                int sum = 0;
                for (int i = 0; i < empGrid.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(empGrid.Rows[i].Cells[3].Value);
                }

                tb_workhrs.Text = sum.ToString();
                //   tb_empName.Text = this.empGrid.CurrentRow.Cells[0].Value.ToString();
                tb_empID.Text = this.empGrid.CurrentRow.Cells[6].Value.ToString();

            }
        }
        private void PayrollControl_Load(object sender, EventArgs e)
        {
            CMB_EmployeeName();          
        }      
        private void tb_workhrs_TextChanged(object sender, EventArgs e)
        {
            if(tb_hourlyRate.Text != "0" || tb_hourlyRate.Text != "")
            {
                tb_hourlyRate.FillColor = Color.White;
            }
            else
            {
                tb_hourlyRate.FillColor = Color.Red;
            }
        }
        private void tb_cashAdvance_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void tb_sss_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void tb_pagIbig_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void tb_philHealth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void tb_otherAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void tb_hourlyRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void cmb_others_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_others.Text != "")
            {
                lbl_othersAmount.Visible = true;
                tb_otherAmount.Visible = true;
            }
            else
            {
                lbl_othersAmount.Visible = false;
                tb_otherAmount.Visible = false;
            }

        }
        private void cmb_benefits_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_benefits.SelectedIndex == 0) // with benefits
            {
                lbl_pagIbig.Visible = true;
                lbl_philHealth.Visible = true;
                lbl_sss.Visible = true;

                tb_sss.Visible = true;
                tb_philHealth.Visible = true;
                tb_pagIbig.Visible = true;
            }
            else
            {
                lbl_pagIbig.Visible = false;
                lbl_philHealth.Visible = false;
                lbl_sss.Visible = false;

                tb_sss.Visible = false;
                tb_philHealth.Visible = false;
                tb_pagIbig.Visible = false;
            }

        }
        private void tb_unameAccess_TextChanged(object sender, EventArgs e)
        {
            if (tb_unameAccess.Text != "")
            {
                tb_pass.Enabled = true;
            }
            else
            {
                tb_pass.Enabled = false;
            }
        }
        private void btn_addPayroll_Click(object sender, EventArgs e)
        {
            payrollMainPanel.Dock = DockStyle.None;
            payrollMainPanel.Visible = false;
            ClearFields();
            btn_update.Enabled = false;
        }
        private void payrollGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btn_update.Enabled = true;
                payrollMainPanel.Visible = false;
                payrollMainPanel.Dock = DockStyle.None;

                cmb_empname.Text = this.payrollGrid.CurrentRow.Cells[0].Value.ToString();
                tb_workhrs.Text = this.payrollGrid.CurrentRow.Cells[1].Value.ToString();
                tb_hourlyRate.Text = this.payrollGrid.CurrentRow.Cells[2].Value.ToString();
                tb_totalAmount.Text = this.payrollGrid.CurrentRow.Cells[3].Value.ToString();
                tb_cashAdvance.Text = this.payrollGrid.CurrentRow.Cells[4].Value.ToString();
                date_from.Value = Convert.ToDateTime(this.payrollGrid.CurrentRow.Cells[5].Value.ToString());
                date_to.Value = Convert.ToDateTime(this.payrollGrid.CurrentRow.Cells[6].Value.ToString());
                payroll_date.Value = Convert.ToDateTime(this.payrollGrid.CurrentRow.Cells[7].Value.ToString());

                tb_philHealth.Text = this.payrollGrid.CurrentRow.Cells[8].Value.ToString();
                tb_sss.Text = this.payrollGrid.CurrentRow.Cells[9].Value.ToString();
                tb_pagIbig.Text = this.payrollGrid.CurrentRow.Cells[10].Value.ToString();
                tb_otherAmount.Text = this.payrollGrid.CurrentRow.Cells[11].Value.ToString();
                tb_id.Text = this.payrollGrid.CurrentRow.Cells[12].Value.ToString();

                lbl_philHealth.Visible = true;
                tb_philHealth.Visible = true;

                lbl_sss.Visible = true;
                tb_sss.Visible = true;

                lbl_pagIbig.Visible = true;
                tb_pagIbig.Visible = true;

                lbl_othersAmount.Visible = true;
                tb_otherAmount.Visible = true;
            }
            catch (Exception error)
            {
                error.ToString();
            }
        }      
        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            if (HighAuthority())
            {
                var tools = new PayRollController();

                var result = tools.FindPayRoll(tb_search.Text);

                payrollGrid.DataSource = result;

                if (tb_search.Text == "")
                {
                    UpdateGrid();
                } 
            }
        }
        #endregion

        #region event handlers
        private void btn_filter_Click(object sender, EventArgs e)
        {
            Filter();
        }
        private void btn_viewPayrolls_Click(object sender, EventArgs e)
        {
            ViewPayrollList();
        }
        private void btn_compute_Click(object sender, EventArgs e)
        {
            StartCompute();
        }
        private void btn_generateLayout_Click(object sender, EventArgs e)
        {
            GenerateLayout();
        }
        private void btn_printLayout_Click(object sender, EventArgs e)
        {
            PrintLayout();
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdatePayroll();
        }
        private void printSlipDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (Authorized())
            {
                e.Graphics.DrawString(lblstar.Text, new Font("Microsoft Sans Serif", 25, FontStyle.Bold), Brushes.Black, new Point(100, 30));
                e.Graphics.DrawString(lbl_title.Text, new Font("Microsoft Sans Serif", 25, FontStyle.Bold), Brushes.Black, new Point(180, 60));

                e.Graphics.DrawString(lbl_rfb.Text, new Font("Microsoft Sans Serif", 25, FontStyle.Bold), Brushes.LimeGreen, new Point(180, 90));
                e.Graphics.DrawString(lbl_address.Text, new Font("Microsoft Sans Serif", 25, FontStyle.Bold), Brushes.Black, new Point(140, 120));
                e.Graphics.DrawString(lbl_contactNO.Text, new Font("Microsoft Sans Serif", 25, FontStyle.Bold), Brushes.Black, new Point(60, 150));

                e.Graphics.DrawString("Date: " + payroll_date.Text, new Font("Microsoft Sans Serif", 21, FontStyle.Bold), Brushes.Black, new Point(120, 220));
                e.Graphics.DrawString("Employee Name: " + lbl_empN.Text, new Font("Microsoft Sans Serif", 21, FontStyle.Bold), Brushes.Black, new Point(120, 250));
                e.Graphics.DrawString("Total work hrs: " + lbl_totalwrkhrs.Text, new Font("Microsoft Sans Serif", 21, FontStyle.Bold), Brushes.Black, new Point(120, 280));
                e.Graphics.DrawString("Cash-advance: " + lbl_ca.Text, new Font("Microsoft Sans Serif", 21, FontStyle.Bold), Brushes.Black, new Point(120, 310));
                e.Graphics.DrawString("SSS: " + lbl_sss_print.Text, new Font("Microsoft Sans Serif", 21, FontStyle.Bold), Brushes.Black, new Point(120, 340));
                e.Graphics.DrawString("Pag-ibig " + lbl_pagibig_print.Text, new Font("Microsoft Sans Serif", 21, FontStyle.Bold), Brushes.Black, new Point(120, 370));
                e.Graphics.DrawString("Philhealth " + lbl_ph_print.Text, new Font("Microsoft Sans Serif", 21, FontStyle.Bold), Brushes.Black, new Point(120, 400));
                e.Graphics.DrawString("Total wage: " + lbl_wage.Text, new Font("Microsoft Sans Serif", 21, FontStyle.Bold), Brushes.Black, new Point(120, 430));
                e.Graphics.DrawString("Recorded by: " + lbl_signature.Text, new Font("Microsoft Sans Serif", 21, FontStyle.Bold), Brushes.Black, new Point(120, 460));
                e.Graphics.DrawString("_____________________", new Font("Microsoft Sans Serif", 21, FontStyle.Bold), Brushes.Black, new Point(120, 565));
                e.Graphics.DrawString(" Authorized Signature:  ", new Font("Microsoft Sans Serif", 21, FontStyle.Bold), Brushes.Black, new Point(120, 600));
            }
            else
            {
                NotAuthorized();
            }
        }

        #endregion

        #region access
        private void tb_pass_Leave(object sender, EventArgs e)
        {
            var creds = new User
            {
                Username = tb_unameAccess.Text,
                Password = tb_pass.Text
            };

            var result = AccessLogin(creds);

            if (result != true)
            {
                MessageBox.Show("Make sure your credentials is correct");
                //btn_filter.Enabled = false;
                //btn_generateLayout.Enabled = false;
                //btn_printLayout.Enabled = false;
                //btn_viewPayrolls.Enabled = false;
                //btn_compute.Enabled = false;

                //tb_unameAccess.ReadOnly = false;
                //tb_pass.ReadOnly = false;
            }
            else
            {
                //btn_filter.Enabled = true;
                //btn_generateLayout.Enabled = true;
                //btn_printLayout.Enabled = true;
                //btn_viewPayrolls.Enabled = true;
                //btn_compute.Enabled = true;

                //    tb_unameAccess.ReadOnly = true;
                //    tb_pass.ReadOnly = true;
       
                lbl_usersfname.Text = ac.GetCurrentUserDetails(tb_unameAccess.Text);
            
            }
        }
        private bool AccessLogin(User users)
        {
            var user = new User
            {
                Username = users.Username,
                Password = users.Password
            };

            var result = ac.ConfirmAccess(user);

            if (result == true)
            {

                var accesslog = new AuditTrails
                {
                    Username = user.Username,
                    AuditActionTypeENUM = (Enums.ActionTypes)1,
                    DateTimeStamp = DateTime.Now.ToString(),
                    Result = "Succeed",
                    Description = "'" + user.Username + "' access payroll feature"
                };
                aud.Logs(accesslog);
                return true;
            }
            else
            {
                var accesslog = new AuditTrails
                {
                    Username = user.Username,
                    AuditActionTypeENUM = (Enums.ActionTypes)1,
                    DateTimeStamp = DateTime.Now.ToString(),
                    Result = "Failed",
                    Description = "'" + user.Username + "'Failed to access payroll feature"
                };
                aud.Logs(accesslog);
                return false;
            }
        }
        private void NotHighAuthorized()
        {           
           MessageBox.Show("Higher Authoritization Required");              
        }
        private void NotAuthorized()
        {
            MessageBox.Show("Authentication Required");
        }
        private bool HighAuthority()
        {
            var access = new AccessController();

            var creds = new User
            {
                Username = tb_unameAccess.Text,
                Password = tb_pass.Text
            };

            var result = access.ConfirmAuthority(creds);

            if (result != true)
            {
                return false;
            }
            else
            {
                return true;
            }           
        }
        private bool Authorized()
        {
            var user = new User
            {
                Username = tb_unameAccess.Text,
                Password = tb_pass.Text
            };


            var cfirm = new AccessController();

            if(user.Username != "" && user.Lastname != "")
            {
                var result = cfirm.ConfirmAccess(user);

                if (result != true)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }else
            {
                return false;
            }
           
              

        }
        #endregion

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
