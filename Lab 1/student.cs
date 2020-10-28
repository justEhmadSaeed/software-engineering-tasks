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
        private DateTime p_dob;
        public DateTime dob {
            get => p_dob;
            set {
                while (value.Year < 1991 || value.Year > 2004) {
                    Console.WriteLine("Date of birth should be less than 1st January 2005 and greater than 31st December 1990:");
                    value = Convert.ToDateTime(Console.ReadLine());
                }
                p_dob = value;
            }
        }
        private double p_cgpa;
        public double cgpa {
            get => p_cgpa;
            set {
                while (value < 0.0 || value > 4.0) {
                    Console.WriteLine("CGPA must be between 0 & 4");
                    string temp = Console.ReadLine();
                    double gpa;
                    if (Double.TryParse(temp, out gpa))
                        value = gpa;
                }
                p_cgpa = value;
            }
        }
        private string nic;
        public string cnic {
            get => nic;
            set {
                bool valid = false;
                do {
                    if (value.Length == 13)
                        for (int i = 0; i < value.Length; i++) {
                            if (!char.IsDigit(value[i])) {
                                valid = false;
                                break;
                            }
                            valid = true;
                        }

                    if (!valid) {
                        Console.WriteLine("CNIC must be a 13 Digits number.");
                        value = Console.ReadLine();
                    }
                } while (!valid);
                nic = value;
            }
        }
        public string[] hobbies;

        // Default Constructor with no parameters
        public Student() {
            this.studentName = "NaN";
            this.reg_no = "2018-CS-000";
            this.dob = new DateTime(2000, 1, 11);
            this.cgpa = 0;
            this.cnic = "0000000000000";
            this.hobbies = new string[1];
            hobbies[0] = "NaN";
        }
        // Constructor with two parameters
        public Student(string name, string reg_no) {
            studentName = name;
            this.reg_no = reg_no;
            dob = new DateTime(2000, 1, 11);
            cgpa = 0;
            cnic = "0000000000000";
            hobbies = new string[1];
            hobbies[0] = "NaN";
        }
        // Destructor
        ~Student() {
            Console.WriteLine("​Destructor Called.");
        }
        public void Input() {

            Console.WriteLine("Enter Student Name: ");
            this.studentName = Console.ReadLine();

            Console.WriteLine("Registration Number: Format(2018-CS-12) ");
            this.reg_no = Console.ReadLine();

            string temp;
            Console.WriteLine("CGPA: ");
            temp = Console.ReadLine();
            double gpa;
            if (Double.TryParse(temp, out gpa))
                cgpa = gpa;
            else
                cgpa = -1;

            Console.WriteLine("Date of Birth:(DD-MM-YYYY) ");
            this.dob = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("CNIC:(13 Digits only) ");
            this.cnic = Console.ReadLine();

            Console.WriteLine("Number of Hobbies: ");
            int count = Convert.ToInt16(Console.ReadLine());

            hobbies = new string[count];

            for (int j = 0; j < count; j++) {
                Console.WriteLine("Hobby #" + (j + 1).ToString());
                hobbies[j] = Console.ReadLine();
            }
        }
        public string GetAge() {
            int[] monthDays = {
                31, // January
                28, // February
                31, // March
                30, // April
                31, // May
                30, // June
                31, // July
                31, // August
                30, // September
                31, // October
                30, // November
                31 // December
            };
            int current_year = DateTime.Now.Year;
            int current_month = DateTime.Now.Month;
            int current_day = DateTime.Now.Day;
            if (dob.Day > current_day) {
                current_month--;
                current_day += monthDays[dob.Month - 1];
            }
            if (dob.Month > current_month) {
                current_year--;
                current_month += 12;
            }
            current_day -= dob.Day;
            current_month -= dob.Month;
            current_year -= dob.Year;
            return current_year + " Years " + current_month + " months and " + current_day + " days";
        }

        public string GetStatus() {
            if (cgpa < 2.0)
                return "Suspended";
            else if (cgpa >= 2.0 && cgpa < 2.5)
                return "Below Average";
            else if (cgpa >= 2.5 && cgpa < 3.3)
                return "Average";
            else if (cgpa >= 3.3 && cgpa < 3.5)
                return "Status is Below Good";
            else
                return "Excellent";
        }
        public int NumberOfWordsInName() {
            int words = 1;
            for (int i = 0; i < studentName.Length - 1; i++) {
                if (studentName[i] == ' ' && char.IsLetter(studentName[i + 1]))
                    words++;
            }
            return words;
        }
        public string GetGender() {
            if (cnic[12] % 2 == 0)
                return "FEMALE";
            else
                return "MALE";
        }
        public void display() {
            Console.WriteLine("Name: " + studentName + " (Contains " + NumberOfWordsInName() + " words)");
            Console.WriteLine("Registration Number: " + reg_no);
            Console.WriteLine("CGPA: " + cgpa + " " + GetStatus());
            Console.WriteLine("Date of Birth: " + dob.ToString("MMMM dd yyyy") + " (Age is " + GetAge() + ")");
            Console.WriteLine("CNIC " + cnic);
            Console.WriteLine("Gender: " + GetGender());
            Console.WriteLine("Hobbies:");
            for (int i = 0; i < hobbies.Length; i++) {
                Console.WriteLine(hobbies[i] + ", ");
            }
        }
    }
}