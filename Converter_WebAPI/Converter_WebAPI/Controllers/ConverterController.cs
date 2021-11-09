using Converter_WebAPI.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace Converter_WebAPI.Controllers
{
    public class ConverterController : ApiController
    {
        public double ConvertToMetric(double valueToConvert, int ConversionTypeID)
        {
            IConverter converter;
            double newValue=0;

            switch (ConversionTypeID)
            {
                case 1:
                    converter = new LenghtConverter();
                    newValue = converter.ConvertImperialToMetric(valueToConvert);
                    break;
                case 2:
                    converter = new MassConverter();
                    newValue = converter.ConvertImperialToMetric(valueToConvert);
                    break;
                case 3:
                    converter = new TempritureConverter();
                    newValue = converter.ConvertImperialToMetric(valueToConvert);
                    break;

            }
            return newValue;
        }

        public double RevertToImperial(double valueToConvert, int ConversionTypeID)
        {
            IConverter converter;
            double newValue = 0;

            switch (ConversionTypeID)
            {
                case 1:
                    converter = new LenghtConverter();
                    newValue = converter.ConvertMetricToImperial(valueToConvert);
                    break;
                case 2:
                    converter = new MassConverter();
                    newValue = converter.ConvertMetricToImperial(valueToConvert);
                    break;
                case 3:
                    converter = new TempritureConverter();
                    newValue = converter.ConvertMetricToImperial(valueToConvert);
                    break;

            }
            return newValue;    
        }
    }
}
