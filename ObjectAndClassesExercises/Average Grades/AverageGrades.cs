using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Grades
{
    class AverageGrades
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                Student name = new Student();
                name.Name = input[0];
                name.Grades = new List <double>();
                for (int j = 1; j < input.Count(); j++)
                {
                  name.Grades.Add(double.Parse(input[j]));
                }
                students.Add(name);  
            }
            foreach (Student student in students
                .Where(student=>student.AverageGrades>=5.00)
                .OrderBy(student=>student.Name)
                .ThenByDescending(s=>s.AverageGrades))
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrades:F2}");
            }
            
        }
    }
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrades
        {
            get
             {
                return Grades.Average();
             }
        }
    }
}
