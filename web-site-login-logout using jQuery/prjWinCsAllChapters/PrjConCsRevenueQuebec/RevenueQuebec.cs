using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjConCsRevenueQuebec
{
    public static class RevenueQuebec
    {
        public static void TestFor3Loops()
        {
            string name, title;
            char gender,married;
            Int16 children;
            Single salary,deduction,benefits,netIncome;
            
            Console.WriteLine("\tREVENUE-QUEBEC");
            Console.WriteLine("\t----------------");

            do
            {
                Console.Write("Enter your name : ");
                name = Console.ReadLine();
            } while (name == "");

            Console.Write("Select your gender :");
            gender = Convert.ToChar(Console.ReadLine());

            while (gender != 'm' && gender != 'M' && gender != 'f' && gender != 'F')
            {
                Console.Write("Error, select m/f: ");
                gender = Convert.ToChar(Console.ReadLine());
            }
            Console.Write("Are you married(y/n): ");
            married = Convert.ToChar(Console.ReadLine());
            while (married != 'y' && married != 'Y' && married != 'n' && married != 'N')
            {
                Console.Write("Are you married(y/n): ");
                married = Convert.ToChar(Console.ReadLine());
                
            }
            do
            {
                Console.Write("How many children: ");
                children = Convert.ToInt16(Console.ReadLine());
            } while (children <= 0);
            do
            {
                Console.Write("Enter your annual salary: ");
                salary = Convert.ToSingle(Console.ReadLine());
            } while (salary <= 0);
           
            
            
            Console.Write("Thanks,");
            title = (gender == 'f' || gender == 'F') ? "Miss " : "Sir ";
            Console.WriteLine(title + name + ",");
            Console.WriteLine("Your salary : " );
            Console.WriteLine("Your deductions : " );
            Console.WriteLine("Your benefits : " );
            Console.WriteLine("Your net income is : ");

        }
    }
}
