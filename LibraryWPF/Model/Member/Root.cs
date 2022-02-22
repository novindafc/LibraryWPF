using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryWPF.Model.Member
{
    public class Root
    {
        public object contentType { get; set; }
        public object serializerSettings { get; set; }
        public object statusCode { get; set; }
        public Value value { get; set; }
    }
}
