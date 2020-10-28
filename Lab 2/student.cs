using System;

namespace cSharp {
    public class Student {
        private string name;
        public string studentName {
            get => name;
            set {
                bool valid = false;
                do {
                    for (int i = 0; i < value.Length; i++) {
                        if (char.IsLetter(value[i]) || value[i] == ' ')
                            valid = true;
                        else {
                            valid = false;
                            break;
                        }
                    }
                    if (!valid) {
                        Console.WriteLine("Name must contain only letters.");
                        value = Console.ReadLine();
                    }
                } while (!valid);
                name = value;
            }
        }
        private string reg;
        public string reg_no {
            get => reg;
            set {
                bool valid = false;
                do {
                    if (value.Length > 8) {

                        for (int i = 0; i < value.Length; i++) {
                            if (i < 4)
                                if (!char.IsDigit(value[i])) {
                                    valid = false;
                                    break;
                                }
                            else
                                valid = true;

                            if (i > 4 && i <= 6)
                                if (!char.IsLetter(value[i])) {
                                    valid = false;
                                    break;
                                }
                            else
                                valid = true;
                            if (i > 7)
                                if (!char.IsDigit(value[i])) {
                                    valid = false;
                                    break;
                                }
                            else
                                valid = true;
                        }
                        if (value[4] != '-' || value[7] != '-')
                            valid = false;
                    }

                    if (!valid) {
                        Console.WriteLine("Registration Number must be valid (2018-CS-123).");
                        value = Console.ReadLine();
                    }
                } while (!valid);
                reg = value;
            }
        }
        private string deg;
        public string degree {
            get => deg;
            set {
                while (!(value == "MS" || value == "BS" || value == "BE")) {
                    Console.WriteLine("Degree should be MS, BS or BE");
                    value = Console.ReadLine();
                }
                deg = value;
            }
        }
        public List<CourseResult> courses;
        // Default Constructor with no parameters
        public Student() {
            this.studentName = "Ehmad Saeed";
            this.reg_no = "2018-CS-1";
            this.degree = "BS";
            courses = new List<CourseResult>();

        }
        // Destructor
        ~Student() {
            Console.WriteLine("​Destructor Called.");
        }
        public int getSemesters() {
            int[] semesters = new int[8];
            // for (int i = 0; i < semesters.Length; i++) {
            //     semesters[co]
            // }
            foreach (var course in courses)
                semesters[course.semester]++;

            int count = 0;
            for (int i = 0; i < semesters.Length; i++) {
                if (semesters[i] != 0)
                    count++;
            }
            return count;
        }
        public void tostring() {
            Console.WriteLine("Name: " + studentName);
            Console.WriteLine("Registration Number: " + reg_no);
            Console.WriteLine("Degree: " + degree);
        }
    }
}