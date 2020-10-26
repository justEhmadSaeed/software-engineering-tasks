using System;

namespace cSharp {
    class Task {
        static void Main(string[] args) {
            Console.WriteLine("Student 1");
            Student std1 = new Student("Ehmad Saeed", "2018-CS-1");
            std1.display();

            Console.WriteLine("Student 2");
            Student std2 = new Student();
            std2.Input();
            std2.display();
        }
    }
}