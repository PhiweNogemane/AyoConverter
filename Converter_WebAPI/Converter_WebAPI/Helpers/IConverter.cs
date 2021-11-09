using Converter_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Converter_WebAPI.Helpers
{
    interface IConverter 
    {
         DatabaseContext DatabaseContext { get; set; }
         UnitDetails unitDetails { get; set; }

        double ConvertMetricToImperial(double value);
        double ConvertImperialToMetric(double value);
    }
}
