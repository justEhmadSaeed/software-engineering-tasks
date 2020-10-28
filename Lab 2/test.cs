using System;

namespace cSharp {
    class Task {
        static void Main(string[] args) {

            Student std1 = new Student();
            std1.tostring();
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
            Console.WriteLine("Number of Semesters: " +  std1.getSemesters());
            Console.WriteLine("Gpa/Semester 4: " +  std1.getSemesterGPA(4));
            Console.WriteLine("Gpa/Semester 5: " +  std1.getSemesterGPA(5));
        }
    }
}