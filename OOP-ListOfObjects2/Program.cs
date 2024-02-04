using System;
using System.Collections.Generic;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Students> students = new List<Students>();

         

            students.Add(new Students("Jun"));
            students.Add(new Students("Jb"));
            students.Add(new Students("Josh"));

            foreach (Students student in students)
            {
                Console.WriteLine(student);
            }

            Console.ReadKey();
        }
    }

    class Students
    {
        string name;

        public Students(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return name;
        }
    }
}