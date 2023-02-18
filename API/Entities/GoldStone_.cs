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
        public long CategoryCode { get; set; } = 0;
        public long StoneCode { get; set; } = 0;
        public long Weight { get; set; }
        public int WeightType { get; set; } = 0;
        public string Color { get; set; }
        public string Clarity { get; set; }
        public string Cut { get; set; }
        public string CountryOfOrigin { get; set; }
        public double Price { get; set; }
        public byte[] Photo { get; set; }
        public byte[] Document { get; set; }
        public int UserCode { get; set; }
        
    }
}