using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Book
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string ImageAddress { get; set; }
        public string Translator { get; set; }
        public string Writer { get; set; }
        public decimal Price { get; set; }



    }
}
