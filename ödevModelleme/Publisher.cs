using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtphnModel
{
    internal class Publisher :Entity
    {
        public string name { get; set; } = " ";
        public List<Book> books { get; set; }

    }
}
