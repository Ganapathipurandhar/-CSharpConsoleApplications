using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Author Banoo Aboobaker - 20230228
// PRG521 FA2 - Question2
// LINQ queries

namespace PRG521_FA2_Question2
{
    // Student class
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int[] Grades { get; set; }
    }

    // Course class
    public class Course
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }
    }

    // Main class (Program)
    internal class Program
    {
        static void Main(string[] args)
        {
            // Course list
            List<Course> courses = new List<Course>
            {
                // Math course
                new Course
                {
                    Name = "Math",

                    // list of students in Math course
                    Students = new List<Student> 
                    {
                        new Student 
                        { 
                            Name = "Alice", 
                            Age = 22, 
                            Grades = new int[] { 80, 85, 90 } 
                        },
                        new Student 
                        { 
                            Name = "Bob", 
                            Age = 21, 
                            Grades = new int[] { 75, 80, 85 } 
                        },
                        new Student 
                        { 
                            Name = "Charlie", 
                            Age = 23, 
                            Grades = new int[] { 90, 95, 100 } 
                        }
                    }
                },

                // English course
                new Course
                {
                    Name = "English",

                    // list of students in English course
                    Students = new List<Student> 
                    {
                        new Student 
                        { 
                            Name = "David", 
                            Age = 20, 
                            Grades = new int[] { 85, 90, 95 } 
                        },
                        new Student 
                        { 
                            Name = "Emma", 
                            Age = 22, 
                            Grades = new int[] { 95, 100, 100 } 
                        },
                        new Student 
                        { 
                            Name = "Frank", 
                            Age = 21, 
                            Grades = new int[] { 80, 85, 90 } 
                        }
                    }
                }
            };


            /* LINQ query that retrieves the names of all the students who have at least
             * one grade greater than or equal to 90. */
            var studentNames = courses
                .SelectMany(c => c.Students)
                .Where(s => s.Grades.Any(g => g >= 90))
                .Select(s => s.Name);

            // Display the results
            Console.WriteLine("List of students who have at least one grade greater than " +
                "or equal to 90:");

            foreach (var name in studentNames)
            {
                Console.WriteLine(name);
            }


            /* LINQ query that calculates the average grade of all the students in each course,
             * and returns a list of anonymous objects with the
             * course name and the average grade */
            var courseAvgGrades = courses
                .Select(c => new
                {
                    CourseName = c.Name,
                    AverageGrade = c.Students.Average(s => s.Grades.Average())
                }).ToList();

            // Display the results
            Console.WriteLine();
            Console.WriteLine("\nThe grade average of all the students in each course:");

            foreach (var courseAvgGrade in courseAvgGrades)
            {
                Console.WriteLine("Course Name: {0}", courseAvgGrade.CourseName);
                Console.WriteLine("Average Grade: {0}\n", Math.Round(courseAvgGrade.AverageGrade, 2));
            }


            /* LINQ query that retrieves the names of all the courses
             * where all the students have at least one grade greater than or equal to 80 */
            var coursesNames = courses
                .Where(c => c.Students.All(s => s.Grades.Any(g => g >= 80)))
                .Select(c => c.Name)
                .ToList();

            // Display the results
            Console.WriteLine("\nNames of all the courses where all the students have at least one " +
                "grade greater than or equal to 80:");

            foreach (var courseName in coursesNames)
            {
                Console.WriteLine(courseName);
            }


            /* LINQ query that retrieves the name and age of the student
             * with the highest average grade across all the courses */
            var topStudent = courses
                .SelectMany(c => c.Students)
                .OrderByDescending(s => s.Grades.Average())
                .First();

            // Display the results
            Console.WriteLine();
            Console.WriteLine("\nThe student with the highest average across all the courses:");
            Console.WriteLine($"Name: {topStudent.Name}");
            Console.WriteLine($"Age: {topStudent.Age}");
            Console.WriteLine($"Average: {Math.Round(topStudent.Grades.Average(), 2)}");

            // Wait for the user to enter a key before closing the application
            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}
