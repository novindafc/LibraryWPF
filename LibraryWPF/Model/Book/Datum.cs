using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryWPF.Model.Book
{
    public class Datum
    {
        public string title { get; set; }
        public string author { get; set; }
        public string position { get; set; }
        public int qty { get; set; }
        public int remains { get; set; }
        public List<object> bookLog { get; set; }
        public int id { get; set; }
    }
}
