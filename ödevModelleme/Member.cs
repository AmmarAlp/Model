using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtphnModel
{
    internal class Member : Person
    {
        private string email { get; set; } = " ";
        public List<Book> borrowedBooks { get; set; }

        public DateTime membershipExpirationDate { get; set; }
    }
}
