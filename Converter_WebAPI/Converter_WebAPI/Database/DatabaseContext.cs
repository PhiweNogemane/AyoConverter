using Converter_WebAPI.Database;
using Converter_WebAPI.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Converter_WebAPI.Helpers
{
    public class DatabaseContext
    { 
        public UnitDetails GetUnitDetailsByID(int id)
        {
            UnitDetails unitDetails = new UnitDetails();

            DynamicParameters dataParams = new DynamicParameters();
            dataParams.Add("@UnitId", id);
            unitDetails = DapperConnecter.ExecuteReturnScalar<UnitDetails>("sp_GetUnitByID", dataParams);
            return unitDetails;

        }
    }
}
