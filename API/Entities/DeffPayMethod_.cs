using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class DeffPayMethod_
    {
        public long Id { get; set; }
        public long Code { get; set; }
        public string PayMethodAr { get; set; }
        public string PayMethodEn { get; set; }
        public bool Enabled { get; set; }
    }
}