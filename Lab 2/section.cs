// Ahmad Saeed
// 2018-CS-1
using System;
using System.Collections.Generic;

namespace cSharp {
    class Section {
        public List<Student> StudentList;
        public Section() {
            StudentList = new List<Student>();
        }
        public void AddStudent(Student std) {
            StudentList.Add(std);
        }
        public void ListofStudents() {
            Console.WriteLine("List of All Students:");
            foreach (var student in StudentList) {
                student.tostring();
            }
        }
        public void ListofSuspendedStudents() {
            Console.WriteLine("List of Suspended Students:");
            foreach (var student in StudentList) {
                if (student.getCGPA() < 2.0)
                    student.tostring();
            }
        }

    }
}