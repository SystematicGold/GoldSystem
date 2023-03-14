using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class DeffCustomer_
    {
        public int Id { get; set; }
        public string CID { get; set; }
        public string PassPortNo { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string Address { get; set; }
        public string Nationality { get; set; }
        public string Phone { get; set; }
        public byte[] CIDFront { get; set; }
        public byte[] CIDBack { get; set; }
        public byte[] MIDFront { get; set; }
        public byte[] MIDBack { get; set; }
        public byte[] PassportFront { get; set; }
        public byte[] PassportBack { get; set; }
        public byte[] DLicenseFront { get; set; }
        public byte[] DLicenseBack { get; set; }
        public byte[] DSignatureFront { get; set; }
        public byte[] DSignatureBack { get; set; }

    }
}