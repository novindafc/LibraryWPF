using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryWPF.Model.BookLog
{
    public class Datum
    {
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public int bookId { get; set; }
        public object book { get; set; }
        public int memberId { get; set; }
        public object member { get; set; }
        public string status { get; set; }
        public int id { get; set; }
    }
}
