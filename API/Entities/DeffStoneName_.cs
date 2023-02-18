using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class DeffStoneName_
    {
        public int Id { get; set; }
        public int Code { get; set; } = 0;
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public int StoneTypeCode { get; set; } = 1;
        public bool Enabled { get; set; }
    }
}