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
    public partial class CustomerTransactions : Form
    {
        public CustomerTransactions()
        {
            InitializeComponent();
        }

        private void CustomerTransactions_Load(object sender, EventArgs e)
        {
            if (PersonID != 0)
            {
                GetTransactions();
            }
        }

        public string Firstname 
        { 
            get
            {
                return lbl_fname.Text;
            } set
            {
                lbl_fname.Text = value;
            }
        }
        public string Lastname
        { 
            get
            {
                return lbl_lname.Text;
            }
            set {
                lbl_lname.Text = value; 
            } 
        }
        public string MobileNo 
        { 
            get {
                return lbl_mobile.Text;
            } set {
                lbl_mobile.Text = value;
            }
        }
        public string TelephoneNo 
        { 
            get {
                return lbl_tel.Text;
            } set {
                lbl_tel.Text = value;          
            } 
        }

        public string HouseNo { get; set; }
        public string Street { get; set; }
        public string Barangay { get; set; }
        public string City { get; set; }


        public int PersonID { get; set; }
        public int AddressID { get; set; }

        public void GetTransactions()
        {
            var tools = new CustomersController();
            var result = tools.GetCusTransactions(PersonID);
            historyGrid.DataSource = result;
        }

        private void historyGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MainserviceForm mainservice = new MainserviceForm();
            mainservice.ScheduleID =this.historyGrid.CurrentRow.Cells[0].Value.ToString();
            mainservice.ServiceDate = Convert.ToDateTime(this.historyGrid.CurrentRow.Cells[1].Value.ToString());
            mainservice.ServiceType = this.historyGrid.CurrentRow.Cells[2].Value.ToString();
            mainservice.firstname = this.historyGrid.CurrentRow.Cells[3].Value.ToString();
            mainservice.lastname = this.historyGrid.CurrentRow.Cells[4].Value.ToString();
            mainservice.Quantity = this.historyGrid.CurrentRow.Cells[5].Value.ToString();
            mainservice.Brand = this.historyGrid.CurrentRow.Cells[6].Value.ToString();
           
            mainservice.Actype = this.historyGrid.CurrentRow.Cells[7].Value.ToString();
            mainservice.MobleNo = this.historyGrid.CurrentRow.Cells[8].Value.ToString();
            mainservice.TelephoneNo = this.historyGrid.CurrentRow.Cells[9].Value.ToString();
            mainservice.HouseNo = this.historyGrid.CurrentRow.Cells[10].Value.ToString();
            mainservice.Street = this.historyGrid.CurrentRow.Cells[11].Value.ToString();
            mainservice.Barangay = this.historyGrid.CurrentRow.Cells[12].Value.ToString();
            mainservice.City = this.historyGrid.CurrentRow.Cells[13].Value.ToString();
            mainservice.ServiceStatus = this.historyGrid.CurrentRow.Cells[14].Value.ToString();
            mainservice.ServiceTime = this.historyGrid.CurrentRow.Cells[15].Value.ToString();    
            mainservice.CustomerID = this.historyGrid.CurrentRow.Cells[16].Value.ToString();
            mainservice.DispatchID = this.historyGrid.CurrentRow.Cells[17].Value.ToString();
            mainservice.TimeIn = this.historyGrid.CurrentRow.Cells[18].Value.ToString();
            mainservice.TimeOut = this.historyGrid.CurrentRow.Cells[19].Value.ToString();
            mainservice.Team = this.historyGrid.CurrentRow.Cells[20].Value.ToString();
            mainservice.DispatchDate = this.historyGrid.CurrentRow.Cells[21].Value.ToString();
            // mainservice.AddressID = Convert.ToInt32(this.historyGrid.CurrentRow.Cells[11].Value.ToString());
            mainservice.HideSave();
            mainservice.Show();
        }

        private void btn_newtransaction_Click(object sender, EventArgs e)
        {
            MainserviceForm mainservice = new MainserviceForm();
            mainservice.firstname = lbl_fname.Text;
            mainservice.lastname = lbl_lname.Text;
            mainservice.MobleNo = lbl_mobile.Text;
            mainservice.TelephoneNo = lbl_tel.Text;
            mainservice.HouseNo = HouseNo;
            mainservice.Street = Street;
            mainservice.Barangay = Barangay;
            mainservice.City = City;
            mainservice.AddressID = AddressID.ToString();
            mainservice.CustomerID = PersonID.ToString(); // customerID

          //  this.Close();
            mainservice.Show();
        }

        private void cmb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tools = new ServicesController();
            var result = tools.FilterCustomerTransStatus(cmb_filter.Text, PersonID.ToString());
            historyGrid.DataSource = result;
        }
    }
}
