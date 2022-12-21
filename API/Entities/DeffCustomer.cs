using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class DeffCustomer
    {
        public int Id { get; set; }
        public string CIDNo { get; set; }
        public string PassPortNo { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Nationality { get; set; }
        public byte[] CIDImageFront { get; set; }
        public byte[] CIDImageBack { get; set; }

    }
}