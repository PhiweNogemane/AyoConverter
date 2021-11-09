using Converter_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Converter_WebAPI.Helpers
{
    public class TempritureConverter : IConverter
    {


        public TempritureConverter()
        {
            DatabaseContext = new DatabaseContext();
            unitDetails = new UnitDetails();
            DatabaseContext.GetUnitDetailsByID(3);
        }

        public DatabaseContext DatabaseContext { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public UnitDetails unitDetails { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //Convert Celsius To Fahrenheit

        public double ConvertMetricToImperial(double value)
        {
            double newValue;
            newValue = (value * unitDetails.ConversionRate) + 32;
            return newValue;
        }
        //Convert Fahrenheit To Celsius
        public double ConvertImperialToMetric(double value)
        {
            double newValue;
            newValue = (value - 32) / unitDetails.ConversionRate;
            return newValue;
        }
    }
}



