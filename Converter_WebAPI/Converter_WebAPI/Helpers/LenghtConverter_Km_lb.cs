using Converter_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Converter_WebAPI.Helpers
{
    public class LenghtConverter : IConverter
    {
        public DatabaseContext DatabaseContext { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public UnitDetails unitDetails { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public LenghtConverter()
        {
            DatabaseContext = new DatabaseContext();
            unitDetails = new UnitDetails();
            DatabaseContext.GetUnitDetailsByID(1);
        }

        //Convert Miles To Kilometers
        public double ConvertMetricToImperial(double value)
        {
            double newValue;    
            newValue = value  /unitDetails.ConversionRate;
            return newValue;
        }
        // Conver tKilometers To Miles
        public double ConvertImperialToMetric(double value)
        {
            double newValue;
            newValue = value * unitDetails.ConversionRate;
            return newValue;
        }
    }
}
