using System;

namespace cSharp {
    public class CourseResult {
        private string cid;

        public string course_id {
            get => cid;
            set {
                while (value.Length < 2 || value.Length > 8 || !char.IsLetter(value[0])) {
                    Console.WriteLine("Kindly enter valid Course ID");
                    value = Console.ReadLine();
                }
                cid = value;
            }
        }
        private string ctitle;
        public string course_title {
            get => ctitle;
            set {
                bool valid = false;
                while (!valid) {
                    if (value.Length >= 10 && value.Length <= 35) {
                        for (int i = 0; i < value.Length; i++) {
                            if (char.IsLetter(value[i]) || value[i] == ' ')
                                valid = true;
                            else {
                                valid = false;
                                break;
                            }
                        }
                    }
                    if (!valid) {
                        Console.WriteLine("Coures title must contain only letters. Length of course title should be from 10 to 35");
                        value = Console.ReadLine();
                    }
                }
                ctitle = value;
            }
        }

        private int cdHr;
        public int credit_hrs {
            get => cdHr;
            set {
                while (value < 1 || value > 3) {
                    Console.WriteLine("Credit Hours values from 1 to 3 are allowed.");
                    string temp = Console.ReadLine();
                    int i;
                    for (i = 0; i < temp.Length; i++)
                        if (!char.IsDigit(temp[i]))
                            break;

                    if (i == temp.Length)
                        value = Convert.ToInt32(temp);
                }
                cdHr = value;
            }
        }
        private int mrks;
        public int marks {
            get => mrks;
            set {
                while (value < 0 || value > 100) {
                    Console.WriteLine("Marks values from 0 to 100 are allowed.");
                    string temp = Console.ReadLine();
                    int i;
                    for (i = 0; i < temp.Length; i++)
                        if (!char.IsDigit(temp[i]))
                            break;

                    if (i == temp.Length)
                        value = Convert.ToInt32(temp);
                }
                mrks = value;
            }
        }
        private int smstr;
        public int semester {
            get => smstr;
            set {
                while (value < 1 || value > 8) {
                    Console.WriteLine("Semester values from 1 to 8 are allowed.");
                    string temp = Console.ReadLine();
                    int i;
                    for (i = 0; i < temp.Length; i++)
                        if (!char.IsDigit(temp[i]))
                            break;

                    if (i == temp.Length)
                        value = Convert.ToInt32(temp);
                }
                smstr = value;
            }
        }
        public CourseResult() {
            this.course_id = "CS123";
            this.course_title = "Software Engineering Lab";
            this.credit_hrs = 3;
            this.marks = 99;
            this.semester = 1;
        }
        public CourseResult(string id, string title, int hrs, int score, int sem) {
            this.course_id = id;
            this.course_title = title;
            this.credit_hrs = hrs;
            this.marks = score;
            this.semester = sem;
        }
        public CourseResult(CourseResult course) {
            this.course_id = course.course_id;
            this.course_title = course.course_title;
            this.credit_hrs = course.credit_hrs;
            this.marks = course.marks;
            this.semester = course.semester;
        }
        public string getGrade() {
            if (marks >= 80)
                return "A";
            else if (marks >= 70)
                return "A-";
            else if (marks >= 65)
                return "B+";
            else if (marks >= 60)
                return "B-";
            else if (marks >= 55)
                return "C+";
            else if (marks >= 50)
                return "C";
            else if (marks >= 40)
                return "D";
            else return "F";
        }
        public double getGradePoints() {
            string grade = getGrade();
            if (grade == "A")
                return 4.0;
            else if (grade == "A-")
                return 3.7;
            else if (grade == "B+")
                return 3.3;
            else if (grade == "B-")
                return 3.0;
            else if (grade == "C+")
                return 2.7;
            else if (grade == "C")
                return 2.3;
            else if (grade == "D")
                return 1.0;
            else return 0;

        }
        public void tostring() {
            Console.WriteLine("Course Title: " + course_title);
            Console.WriteLine("Course ID: " + course_id);
            Console.WriteLine("Semester: " + semester);
            Console.WriteLine("Credit Hours: " + credit_hrs);
            Console.WriteLine("Marks: " + marks);
            Console.WriteLine("Grade: " + getGrade());
            Console.WriteLine("Grade Points: " + getGradePoints());
        }
    }

}