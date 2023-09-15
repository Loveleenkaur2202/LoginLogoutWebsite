using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PrjConCsExercise2
{
    internal class Exercises2
    {
        public static void TestFor3Loops()
        {
            string course;
            Int16 Students;
            Single grade, max = -1, min = 101, avg, sum = 0; ;

            Console.WriteLine("\tLASALLLE COLLEGE");
            Console.WriteLine("\tStudent Evaluation");
            Console.WriteLine("\t-------------------");

            do
            {
                Console.Write("Enter the course: ");
                course = Console.ReadLine();
            } while (course == "");

            do
            {
                Console.Write("Enter the number of students(Max 25): ");
                Students = Convert.ToInt16(Console.ReadLine());
            } while (Students <= 2 || Students >= 25  );

            for (Int16 counter = 1; counter <= 4; counter++)
            {
                do
                {
                    Console.Write("Enter grade " + counter + ": ");
                    grade = Convert.ToSingle(Console.ReadLine());
                } while (grade < 0 || grade > 100);
                sum = sum + grade;

                if (grade > max) { max = grade; }
                if (grade < min) { min = grade; }
            }
            avg = sum / 4;
           
            Console.WriteLine("Class average is " + avg);
            Console.WriteLine("The best grade is " + max);
            Console.WriteLine("The worst grade is " + min);
        }
    }
}
