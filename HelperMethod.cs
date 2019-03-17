using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using System.Threading.Tasks;

namespace Csvhelper
{
    public class HelperMethodInDll
    {
        public void EmployeeDetails(int choice1)
        {
            var Employees = ProcessFile(@"C:\test.csv");
            switch (choice1)
            {
                case 1:
                    Console.WriteLine("enter the location\n");
                    string location = Console.ReadLine();
                    var query = Employees.Where(e => e.Location == location)
                                    .Select(e => e);
                    foreach (var name in query)
                    {
                        string date = String.Format("{0:MM/dd/yyyy}", name.Dob);
                        Console.WriteLine($"Name : {name.First} {name.Middle} {name.Last}, Gender : {name.Gender}, Location : {name.Location} Dob : {date}");
                    }
                    break;
                case 2:
                    Console.WriteLine("enter the Gender as F or M\n");
                    string Gender = Console.ReadLine();
                    var query2 = Employees.Where(e => e.Gender == Gender)
                                    .Select(e => e);
                    foreach (var name in query2)
                    {
                        string date = String.Format("{0:MM/dd/yyyy}", name.Dob);
                        Console.WriteLine($"Name : {name.First} {name.Middle} {name.Last}, Gender : {name.Gender}, Location : {name.Location} Dob : {date}");
                    }
                    break;
                case 3:
                    Console.WriteLine("enter the Dob after which you want to see the data in mm/dd/yyyy format\n");
                    DateTime GivenDob = DateTime.Parse(Console.ReadLine());
                    var query3 = Employees.Where(e => e.Dob > GivenDob)
                                       .Select(e => e);
                    foreach (var name in query3)
                    {
                        string date = String.Format("{0:MM/dd/yyyy}", name.Dob);
                        Console.WriteLine($"Name : {name.First} {name.Middle} {name.Last}, Gender : {name.Gender}, Location : {name.Location} Dob : {date}");
                    }
                    break;
            
            }
        }
        private static List<empdetails> ProcessFile(string path)
        {
            return
                File.ReadAllLines(path)
                    .Skip(1)
                    .Where(line => line.Length > 1)
                    .Select(empdetails.ParseFromCsv)
                    .ToList();
        }
    }
}
