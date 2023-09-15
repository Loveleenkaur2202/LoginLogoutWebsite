using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjConCsExercises
{
    public static class ArrayExercises
    {

        public struct Employee
        {
            public string Name;
            public char Gender;
            public Int16 BirthYear;
        }


        public static void LasalleEvaluation()
        {
            // declare all variables
            Single max, min, sum = 0, avg;
            Int16 nbStud;
            Single[] tabGrades = new Single[25];

            // Display title
            Console.WriteLine("\tLASALLE COLLEGE");
            Console.WriteLine("\t---------------");

            // read and validate the number of students
            Console.Write("Enter number of students : ");
            nbStud = Convert.ToInt16(Console.ReadLine());
            while (nbStud < 2 || nbStud > 25)
            {
                Console.Write("Enter number of students (2-25) : ");
                nbStud = Convert.ToInt16(Console.ReadLine());
            }

            // loop to read and store grades in our array
            for (Int16 I = 0; I < nbStud; I++)
            {
                do
                {
                    Console.Write("   Enter grade " + (I + 1) + ": ");
                    tabGrades[I] = Convert.ToSingle(Console.ReadLine());
                } while (tabGrades[I] < 0 || tabGrades[I] > 100);

            }

            Console.WriteLine("All grades");
            Console.WriteLine("#\t grades");
            // loop to display grades from our array
            //for (Int16 I = 0; I < nbStud; I++)
            //{
            //    Console.WriteLine((I + 1) + "\t" + tabGrades[I]);

            //}

            foreach (Single grade in tabGrades)
            {
                Console.WriteLine(grade);
            }


        }

        public static void TDadministration()
        {
            //variable declarartion
            Int16 nbEmp, minYear;
            Employee[] tabEmps;

            Console.WriteLine("\tTORONTO DOMINION");
            Console.WriteLine("       Employee Management");
            Console.WriteLine("       -------------------");
            do
            {
                Console.Write("Enter the number of employees(Min 1) : ");
                nbEmp = Convert.ToInt16(Console.ReadLine());
            } while (nbEmp < 1);

            // dynamic array creation
            tabEmps = new Employee[nbEmp];

            for (Int16 i = 0; i < nbEmp; i++)
            {
                Console.WriteLine("\nEmployee " + (i + 1));

                Console.Write("  Name : ");
                tabEmps[i].Name = Console.ReadLine();

                Console.Write("  Gender : ");
                tabEmps[i].Gender = Convert.ToChar(Console.ReadLine().ToUpper());

                Console.Write("  Birth Year : ");
                tabEmps[i].BirthYear = Convert.ToInt16(Console.ReadLine());


            }
            minYear = tabEmps[0].BirthYear;
            Console.WriteLine("The Company Employees");
            Console.WriteLine("Employees Names\tBirth Year\tAge");
            for (Int16 i = 0; i < nbEmp; i++)
            {
                string title = (tabEmps[i].Gender == 'F') ? "Miss" : "Sir";
                Int16 age = Convert.ToInt16(DateTime.Today.Year - tabEmps[i].BirthYear);
                Console.WriteLine(title + " " + tabEmps[i].Name + "\t"
                    + tabEmps[i].BirthYear + "\t" + age);
                //find the lowest year 
                if (tabEmps[i].BirthYear < minYear)
                {
                    minYear = tabEmps[i].BirthYear;
                }
            }
                Console.WriteLine("\nThe oldest Employee");
                for (Int16 i = 0; i < nbEmp; i++)
                {
                    if (tabEmps[i].BirthYear == minYear)
                    {
                       string title = (tabEmps[i].Gender == 'F') ? "Miss" : "Sir";
                       Int16 age = Convert.ToInt16(DateTime.Today.Year - tabEmps[i].BirthYear);
                        Console.WriteLine(title + " " + tabEmps[i].Name + "\t"
                            + tabEmps[i].BirthYear + "\t" + age);
                    }
                }

            }
        }
    
}
