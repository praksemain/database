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
    public partial class employees : Form
    {
        public employees()
        {
            InitializeComponent();
        }

        private void employees_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.Left = 0;
            this.Top = 0;
        }
    }
}
