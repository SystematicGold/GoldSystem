using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class DeffStoneName
    {
        public int Id { get; set; }
        public int Code { get; set; } = 0;
        public string Name { get; set; }
        
    }
}