using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WaterBill.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public int FamilyOfNumber { get; set; }
        public int LastMonth { get; set; }
        public int ThisMonth { get; set; }
        public int WaterNumBer { get; set; }
        public float Price { get; set; }
    }
}