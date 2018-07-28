using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kapital_bank.forms;
using Kapital_bank.classes;
using Kapital_bank.DataAccessLayer;

namespace Kapital_bank.forms
{
    public partial class Customer_Login : Form
    {
        public Customer_Login()
        {
            InitializeComponent();
        }


        private void cus_logbtn_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < Customer.ishci.Length; i++)
            //{
            //    if (Customer.ishci[i].Name == Cus_name.Text && Customer.ishci[i].SurName == Cus_sname.Text && Customer.ishci[i].Maas.ToString() == cus_salary.Text)
            //    {
            //        Customer_info cus_info = new Customer_info();
            //        cus_info.cus_data.Rows.Add();
            //        cus_info.cus_data.Rows[i].Cells[0].Value = Customer.ishci[i].Name;
            //        cus_info.cus_data.Rows[i].Cells[1].Value = Customer.ishci[i].SurName;
            //        cus_info.cus_data.Rows[i].Cells[2].Value = Customer.ishci[i].Maas;
            //        cus_info.cus_data.Rows[i].Cells[3].Value = Customer.ishci[i].Maas * 10;

            //    }
            //    else
            //    {
            //        this.Refresh();
            //    }
            ////    this.Hide();
            ////    Choice choice = new Choice();
            ////    choice.Show();
            ////}

            //Customer newCustomer = new Customer() { Name = Cus_name.Text, SurName = Cus_sname.Text, Maas = Convert.ToInt32(cus_salary.Text) };
            //Customer.ishci[5] = newCustomer;

            //if (Cus_name.Text!=null&& Cus_sname.Text!=null&& cus_salary.Text!=null)
            //{
            //   Customer[] customers = { new Customer { Name=Cus_name.Text, Surname=Cus_sname.Text,Salary=Convert.ToInt32( cus_salary.Text)} };
            //    Customer.isci = customers[100];
            //}

            Customer customer = new Customer()
            {
                Name = Cus_name.Text,
                Surname = Cus_sname.Text,
                Salary = Convert.ToInt32(cus_salary.Text)
            };


            Database.Customer.Add(customer);
           
        }
    }
}
