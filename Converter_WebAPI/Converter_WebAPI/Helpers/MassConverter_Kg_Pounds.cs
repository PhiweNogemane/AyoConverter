using Converter_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Converter_WebAPI.Helpers
{
    public class MassConverter : IConverter
    {
        public DatabaseContext DatabaseContext { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public UnitDetails unitDetails { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public MassConverter()
        {
            DatabaseContext = new DatabaseContext();
            unitDetails = new UnitDetails();
            DatabaseContext.GetUnitDetailsByID(2);
        }
        // ConvertPounds To Kilograms
        public double ConvertMetricToImperial(double value)
        {
            double newValue;
            newValue = value / unitDetails.ConversionRate;
            return newValue;

        }

        // Convert Imperial To Metric
        public double ConvertImperialToMetric(double value)
        {
            double newValue;
            newValue = value * unitDetails.ConversionRate;
            return newValue;

        } 
    }
}
