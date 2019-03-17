using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csvhelper
{
    public class empdetails
    {
        public string First;
        public string Middle;
        public string Last;
        public string Gender;
        public string Location;
        public DateTime Dob;
        internal static empdetails ParseFromCsv(string line)
        {
            var columns = line.Split(',');
            return new empdetails
            {
                First = columns[2],
                Middle = columns[3],
                Last = columns[4],
                Gender = columns[5],
                Location = columns[31],
                Dob = DateTime.Parse(columns[10])
            };
        }
    }
}
