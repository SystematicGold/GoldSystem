using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class GoldStock
    {
        public long Id { get; set; }
        public long Code { get; set; } = 0;
        public long AnotherCode { get; set; } = 0;
        public long AnotherCode2 { get; set; } = 0;
        public string BarCode { get; set; }
        public string Name { get; set; }
        public string Karat { get; set; }
        public double GoldWeight { get; set; } = 0;
        public double MakingCharge { get; set; } = 0;
        public double Cost { get; set; } = 0;
        public double CostPerGram { get; set; } = 0;
        public double CostForSeller { get; set; } = 0;
        public string CountryOfOrigin { get; set; }
        public int? NumberOfPieces { get; set; } = 0;
        public byte[] Photo { get; set; }
        public byte[] Document { get; set; }
        public int Supplier { get; set; }
        public string Symbol { get; set; }
        public int? Condition { get; set; } = 1;
        public int? NumberOfPiece { get; set; } = 1;
        public int? UserCode { get; set; } = 0;
        public DateTime? DateAdd { get; set; } = new DateTime();
        public DateTime? DateOfManufacture { get; set; } = new DateTime();
        public int? TaxExempt { get; set; } = 0;
    }
}