using System;

namespace Ispit_Zadatak_3
{
    class Program
    {
        static void Main(string[] args)
        {
            

            
            Teacher teacher = new Teacher(456, "Luka", "English", 4.6);
            Student student = new Student(789, "Hrvoje", 3, new int[] { 5, 4, 3, 5, 5 });

            
            Console.WriteLine(teacher.ToString());
            Console.WriteLine(student.ToString());

            Console.WriteLine('\n');

            Console.WriteLine(teacher.GetGrade());
            Console.WriteLine(student.GetGrade());

            Console.WriteLine('\n');

            Console.WriteLine(teacher.IsOutstanding());
            Console.WriteLine(student.IsOutstanding());

        }
    }
}
