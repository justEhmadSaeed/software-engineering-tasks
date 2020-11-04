using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMC_Generation_System
{
    public partial class Add_Students : Form
    {
        public Add_Students()
        {
            InitializeComponent();
        }
        private void add_button_Click(object sender, EventArgs e)
        {
            new Add_Students().Show();
            this.Hide();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            new Manage_Students().Show();
            this.Hide();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            back_button_Click(sender, e);
        }
    }
}
