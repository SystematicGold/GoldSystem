using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Categories
    {
        public long Id { get; set; }
        public long Code { get; set; } = 0;
        public long AnotherCode { get; set; } = 0;
        public long AnotherCode2 { get; set; } = 0;
        public string BarCode { get; set; }
        public string Name { get; set; }
        public string Kart { get; set; }
        public float Weight { get; set; } = 0;
        public float MakingCharge { get; set; } = 0;
        public float Cost { get; set; } = 0;
        public float CostPerGram { get; set; } = 0;
        public string MadeIn { get; set; }
        public int? NumberOfPieces { get; set; } = 0;
        public byte[] PhotoOrFile { get; set; }
        public int Supplier { get; set; }
        public string Ramz { get; set; }
        public int? NumberPiece { get; set; } = 0;
        public int? UserCode { get; set; } = 0;
        public DateTime? DateAdd { get; set; } = new DateTime();
    }
}