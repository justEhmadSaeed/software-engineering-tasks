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
    public partial class Add_Courses : Form
    {
        public Add_Courses()
        {
            InitializeComponent();
        }


        private void back_button_Click(object sender, EventArgs e)
        {
            new Add_Students().Show();
            this.Hide();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            back_button_Click(sender, e);
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            string course_id = id_box.Text;
            string course_title = name_box.Text;
            string credit_hrs = creditHrs_box.Text;
            string semester = semester_box.Text;
            string marks = marks_box.Text;
            string errorMsg = "";
            int errorCount = 0;
            Regex r = new Regex(@"^[0-9][0-9]?$|^100$");
            if (course_id.Length < 2 || course_id.Length > 8 || !char.IsLetter(course_id[0]))
            {
                errorCount++;
                errorMsg += errorCount.ToString() + ". Kindly Enter Valid Course ID.";
            }
            if (course_title.Length >= 10 && course_title.Length <= 35)
            {
                for (int i = 0; i < course_title.Length; i++)
                {
                    if (!(char.IsLetter(course_title[i]) || course_title[i] == ' '))
                    {
                        errorCount++;
                        errorMsg += Environment.NewLine + errorCount.ToString() + ". Coures title must contain only letters.";
                        break;
                    }
                }
            }
            else
            {
                errorCount++;
                errorMsg += Environment.NewLine + errorCount.ToString() + ". Length of course title should be from 10 to 35.";
            }
            if (credit_hrs.Length < 1)
            {
                errorCount++;
                errorMsg += Environment.NewLine + errorCount.ToString() + ". Please Select Credit Hours.";
            }
            if (semester.Length < 1)
            {
                errorCount++;
                errorMsg += Environment.NewLine + errorCount.ToString() + ". Please Select Semester.";
            }
            if (!r.IsMatch(marks))
            {
                errorCount++;
                errorMsg += Environment.NewLine + errorCount.ToString() + ". Marks should be between 0 and 100.";
            }
            if (errorCount > 0)
            {
                MessageBox.Show(errorMsg);
            }else
            {
                MessageBox.Show("✔Course added successfully.");
            }
        }
    }
}
