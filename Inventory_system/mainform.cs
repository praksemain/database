using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_system
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void darbiniekiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms["employees"] as employees != null)  //if form is opened
            {
                //error
                MessageBox.Show("Darbinieku saraksts ir atvērts!");          
            }
            else
            {
                //open
                employees emply = new employees();
                emply.MdiParent = this;
                emply.Show();
            }
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["customers"] as customers != null)  //if form is opened
            {
                //error
                MessageBox.Show("Pircēju saraksts ir atvērts!");
            }
            else
            {
                //open
                customers emply = new customers();
                emply.MdiParent = this;
                emply.Show();               
            }
        }
    }
}
