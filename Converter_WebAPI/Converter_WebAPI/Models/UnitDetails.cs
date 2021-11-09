using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Converter_WebAPI.Models
{
    public class UnitDetails
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public double ConversionRate { get; set; }
    }
}
