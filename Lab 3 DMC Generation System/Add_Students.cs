using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


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
            new Add_Courses().Show();
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

        private void save_button_Click(object sender, EventArgs e)
        {
            string name = name_box.Text;
            string reg_no = reg_no_box.Text;
            string degree = degree_box.Text;

            Regex r = new Regex(@"^[a-zA-Z]+$");
            string errorMsg = "";
            int errorCount = 0;

            if (!r.IsMatch(name))
            {
                errorCount++;
                errorMsg += errorCount.ToString() + ". Name should contains only letters.";
            }
            bool validReg = false;
            if (reg_no.Length > 8)
            {
                for (int i = 0; i < reg_no.Length; i++)
                {
                    if (i < 4)
                        if (!char.IsDigit(reg_no[i]))
                        {
                            validReg = false;
                            break;
                        }
                        else
                            validReg = true;

                    if (i > 4 && i <= 6)
                        if (!char.IsLetter(reg_no[i]))
                        {
                            validReg = false;
                            break;
                        }
                        else
                            validReg = true;
                    if (i > 7)
                        if (!char.IsDigit(reg_no[i]))
                        {
                            validReg = false;
                            break;
                        }
                        else
                            validReg = true;
                }
                
                if (reg_no[4] != '-' || reg_no[7] != '-')
                    validReg = false;

                if (!validReg)
                {
                    errorCount++;
                    errorMsg += Environment.NewLine + errorCount.ToString() + ". Enter a valid Registration Number i.e 2018-CS-1";
                }
            }
            else
            {
                errorCount++;
                errorMsg += Environment.NewLine + errorCount.ToString() + ". Enter a valid Registration Number i.e 2018-CS-1";
            }
            if (degree.Length < 1)
            {
                errorCount++;
                errorMsg += Environment.NewLine + errorCount.ToString() + ". Please choose a degree option.";
            }
            if (errorCount > 0)
                MessageBox.Show(errorMsg);
            else
                MessageBox.Show("Student added successfully.");


        }
    }
}
