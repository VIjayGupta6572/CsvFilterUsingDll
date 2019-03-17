using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Csvhelper;
using System.Threading.Tasks;

namespace csvparsing
{
    class Program
    {
        static void Main(string[] args)
        {
            HelperMethodInDll employee = new HelperMethodInDll();
            int flag = 1;
            while (flag == 1)
            {
                Console.WriteLine("select your filter based option\n");
                Console.WriteLine("1. Location\n2. Gender\n3. Dob\n4.Exit\n");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 4)
                    flag = 0;
                employee.EmployeeDetails(choice);


            }
            Console.WriteLine("enter any key to exit the program\n");
            Console.ReadLine();
        }

        
        
    }
}
