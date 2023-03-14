using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    [Keyless]
    public class DeffCustomerPhone_
    {
        public string CID { get; set; }
        public string Phone { get; set; }
        public bool Active { get; set; }
    }
}