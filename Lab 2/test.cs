// Ahmad Saeed
// 2018-CS-1
using System;

namespace cSharp {
    class Task {
        static void Main(string[] args) {

            Student std1 = new Student();
            CourseResult[] courses = new CourseResult[6];
            courses[0] = new CourseResult("CS123", "Artificial Intelligence", 3, 89, 5);
            courses[1] = new CourseResult("CS124", "Software Engineering", 3, 89, 5);
            courses[2] = new CourseResult("CS125", "Human Computer Interaction", 3, 74, 5);
            courses[3] = new CourseResult("CS126", "Thoery of Autometa", 3, 89, 4);
            courses[4] = new CourseResult("CS127", "Multivariant Calculus", 3, 69, 4);
            courses[5] = new CourseResult(courses[0]);
            courses[0].course_title = "Algorithm Analysis";
            courses[0].course_id = "CS234";

            for (int i = 0; i < courses.Length; i++) {
                std1.courses.Add(courses[i]);
            }
            Student std2 = new Student();
            std2.courses.Add(new CourseResult("CS098", "Programming Fundamentals", 3, 45, 2));
            std2.studentName = "John Wick";
            std2.reg_no = "2016-CS-9";
            Section cs18 = new Section();
            cs18.AddStudent(std1);
            cs18.AddStudent(std2);
            cs18.ListofStudents();
            cs18.ListofSuspendedStudents();
        }
    }
}