using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtphnModel
{
    public enum EmploymentType
    {
        fullTime,
        partTime
    }
    internal class Employee : Person
    {
        public string position { get; set; } = " ";
        public List<Book> managedBooks { get; set; }

        private decimal salary { get; set; }
        private int monthlyWorkingHours { get; set; }

        private int monthlyOvertime { get; set; }
        private EmploymentType employmentType { get; set; }
    }
}
