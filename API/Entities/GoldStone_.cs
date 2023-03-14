using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class GoldStone_
    {
        public long Id { get; set; }
        public long StoneTypeCode { get; set; } = 0;
        public long StoneNameCode { get; set; } = 0;
        public long StoneWeight { get; set; }
        public int StoneWeightType { get; set; } = 0;
        public string StoneColor { get; set; }
        public string StoneClarity { get; set; }
        public string StoneCut { get; set; }
        public string StoneCountryOfOrigin { get; set; }
        public double StonePrice { get; set; }
        public byte[] StonePhoto { get; set; }
        public byte[] StoneDocument { get; set; }
        public string CodeItem { get; set; }
        public int UserCode { get; set; }
        public bool Enabled { get; set; }
        
    }
}