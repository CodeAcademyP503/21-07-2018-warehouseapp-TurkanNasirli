using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kapital_bank.classes;
using Kapital_bank.forms;

namespace Kapital_bank.forms
{
    public partial class Worker_Login : Form
    {
        public Worker_Login()
        {
            InitializeComponent();
        }

        public void work_login_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Workers.worker.Length; i++)
            {
           
                if (Workers.worker[i].Name==work_name.Text&& Workers.worker[i].Surname == work_sname.Text&& Workers.worker[i].Card.ToString() == vesiqe_no.Text&& Workers.worker[i].Position.ToString() == positions.Text)
                {
                    Workers_info workers_İnfo = new Workers_info();
                    workers_İnfo.workers_data.Rows.Add();
                    workers_İnfo.workers_data.Rows[i].Cells[0].Value = Workers.worker[i].Name;
                    workers_İnfo.workers_data.Rows[i].Cells[1].Value = Workers.worker[i].Surname;
                    workers_İnfo.workers_data.Rows[i].Cells[2].Value = Workers.worker[i].Card;
                    workers_İnfo.workers_data.Rows[i].Cells[3].Value = Workers.worker[i].Probation;
                    workers_İnfo.workers_data.Rows[i].Cells[4].Value = Workers.worker[i].Position;

                }
                else
                {
                    this.Hide();
                    Choice choice = new Choice();
                    choice.Show();
                }
            }
        }
    }
}
