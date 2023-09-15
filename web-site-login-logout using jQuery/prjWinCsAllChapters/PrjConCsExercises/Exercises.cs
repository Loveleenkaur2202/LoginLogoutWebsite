using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PrjConCsExercises
{
    public static class Exercises
    {
        
        
        public static void TestFor3Loops()
        {
            //variables declaration

            string name, title ;
            char gender ;
            Single grade, max=-1, min=101, avg, sum=0;
            
            Console.WriteLine("\tLASALLLE COLLEGE");
            Console.WriteLine("\t----------------");

            do
            {
                Console.Write("Enter your name : ");
                name = Console.ReadLine();
            } while (name == "");

            Console.Write("Select your gender :");
            gender = Convert.ToChar(Console.ReadLine());

            while(gender != 'm' && gender != 'M' && gender !='f' && gender != 'F')
            {
                Console.Write("Error, select m/f: ");
                gender = Convert.ToChar(Console.ReadLine());
            }

            Console.WriteLine("Now, we will read 4 grades:");
            for (Int16 counter = 1; counter <= 4; counter++) 
            {
                do {
                    Console.Write("Enter grade " + counter + ": ");
                    grade = Convert.ToSingle(Console.ReadLine());
                } while (grade<0 || grade>100);
                sum = sum + grade;
                
                if(grade> max){max = grade;}
                if (grade < min){ min = grade;}
            }
            avg = sum / 4;
            title = (gender == 'f' || gender == 'F') ? "Miss " : "Sir ";
            Console.WriteLine(title + name + ",");
            Console.WriteLine("Your average is " + avg);
            Console.WriteLine("Your best grade is " + max);
            Console.WriteLine("Your worst grade is " + min);






        }
    }
}
