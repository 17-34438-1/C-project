using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankMain
{
    public partial class ManagerTransection : Form
    {
        public ManagerTransection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loan_Manager_Palel lmp = new Loan_Manager_Palel();
            this.Visible = false;
            lmp.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Visible = false;
            h.Visible = true;
        }
    }
}
