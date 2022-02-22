using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryWPF.Model.Member
{
    public class Datum
    {
        public string name { get; set; }
        public string gender { get; set; }
        public string phone { get; set; }
        public string occupation { get; set; }
        public string email { get; set; }
        public List<object> bookLog { get; set; }
        public int id { get; set; }
    }
}
