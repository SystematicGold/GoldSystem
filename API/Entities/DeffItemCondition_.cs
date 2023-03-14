using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class DeffItemCondition_
    {
        public long Id { get; set; }
        public long Code { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public bool Enabled { get; set; }
    }
}