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
    public partial class Manage_Students : Form
    {
        public Manage_Students()
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
            new Main_Form().Show();
            this.Hide();
        }
    }
}
