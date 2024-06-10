using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtphnModel
{
    internal class Book : Entity
    {

        public string title { get; set; } = " ";

        public List<Author> authors { get; set; }
        public Publisher publishers { get; set; }
        public List<Category> categories { get; set; }

        public List<Language> languages { get; set; }
        public string inventoryNumber { get; set; } = " ";
        public string isbn { get; set; } = " ";
        public string pageCount {get;set;} = " ";
        public int copyCount {get;set;}




    }
}
