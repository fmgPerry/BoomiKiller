using Newtonsoft.Json;
using System;
using System.Linq;
using BoomiKillerAPI.Areas.GW_PC.Models;

namespace BoomiKillerAPI.Areas.GW_PC
{
    public partial class RegistrationLookupResponse
    {
        public RegistrationLookupResponse()
        {
            var vehicleJson = @"{""PerformanceFactor"":0.7,""GrossLadenWeight"":""2720"",""MaintenanceFactor"":0,""DateCreated"":""2021-09-29T00:45:07.0639228+00:00"",""FullDesc"":""Toyota:Highlander:2013:V6  LIMITED  AWD"",""Make"":""Toyota"",""TheftFactor"":0.2,""UsageType"":""LC"",""FuelType"":""Petrol"",""RecommendedMax"":""30800"",""Variant"":""V6  LIMITED  AWD"",""RecommendedMin"":""15600"",""VehicleUWRequired"":false,""UsageBodyStyleDesc"":""Wagon"",""Year"":""2013"",""UserId"":""root"",""CCRating"":""3456"",""Classification"":""A2"",""Model"":""Highlander"",""EngineType"":""Petrol"",""VIN"":""JTEES41A602224968"",""InductionType"":""Aspirated"",""Power"":""201""}";
            var vehicle = JsonConvert.DeserializeObject<Result>(vehicleJson);
            var result = new Result();

            result.Make = vehicle?.Make;
            result.Model = vehicle?.Model;
            result.Year = vehicle?.Year;
            result.Variant = vehicle?.Variant;
            result.CCRating = vehicle?.CCRating;
            result.InductionType = vehicle.InductionType;
            result.FuelType = vehicle?.FuelType;
            result.Power = vehicle?.Power;
            result.EngineType = vehicle.EngineType;
            result.PerformanceFactor = vehicle.PerformanceFactor;
            result.MaintenanceFactor = vehicle.MaintenanceFactor;
            result.TheftFactor = vehicle.TheftFactor;
            result.Classification = vehicle.Classification;
            result.DateCreated = DateTime.Now.ToString("s"); // "s" - ISO8601
            result.UserId = vehicle.UserId;
            result.FullDesc = vehicle.FullDesc;
            result.GrossLadenWeight = vehicle?.GrossLadenWeight;
            result.UsageBodyStyleDesc = vehicle?.UsageBodyStyleDesc;
            result.VehicleUWRequired = vehicle.VehicleUWRequired;
            result.UsageType = vehicle?.UsageType;
            result.VIN = vehicle?.VIN;
            result.Registration = vehicle?.Registration;
            result.RecommendedMin = vehicle.RecommendedMin;
            result.RecommendedMax = vehicle.RecommendedMax;

            Result = result;
            ResultFound = true;

        }
        public RegistrationLookupResponse(NZTAResponse nztaResult)
        {
            var vehicle = nztaResult?.Body?.InquireVehicleDetailsResponse?.InquireVehicleDetailsResult?.ResponseBody?.ResponseDetail?.Vehicle;

            if (vehicle == null)
            {
                ResultFound = false;
            }
            else
            {
                var result = new Result();
                result.Make = vehicle?.Make;
                result.Model = vehicle?.Model;
                result.Year = vehicle?.YearOfManufacture;
                result.Variant = vehicle?.SubModel;
                result.CCRating = vehicle?.CCRating;
                result.InductionType = GetInductionType(vehicle);
                result.FuelType = vehicle?.FuelType.Code;
                result.Power = vehicle?.Power;
                result.EngineType = GetEngineType(vehicle);
                result.PerformanceFactor = GetPerformanceFactor(vehicle);
                result.MaintenanceFactor = GetMaintenanceFactor(vehicle);
                result.TheftFactor = GetTheftFactor(vehicle);
                result.Classification = GetClassification(vehicle);
                result.DateCreated = DateTime.Now.ToString("s"); // "s" - ISO8601
                result.UserId = "BOOMI_USER";
                result.FullDesc = GetFullDesc(vehicle);
                result.GrossLadenWeight = vehicle?.GrossVehicleMass;
                result.UsageBodyStyleDesc = vehicle?.BodyStyle.Description;
                result.VehicleUWRequired = GetVehicleUWRequired(vehicle);
                result.UsageType = vehicle?.VehicleUsages.FirstOrDefault().VehicleUsageCode.Description;
                result.VIN = vehicle?.VIN;
                result.Registration = vehicle.Plates.FirstOrDefault().PlateNumber;


                var recommendedSumInsured = GetRecommendedSumInsured(vehicle);
                result.RecommendedMin = recommendedSumInsured.RecommendedMin;
                result.RecommendedMax = recommendedSumInsured.RecommendedMax;

                Result = result;
                ResultFound = true;
            }
        }
        private string GetFullDesc(Vehicle vehicle)
        {
            return $@"{vehicle?.YearOfManufacture}{vehicle?.Make}{vehicle?.Model}{vehicle?.SubModel}";
        }

        #region Items within have been set to defaults
        private string GetEngineType(Vehicle vehicle)
        {
            return vehicle?.FuelType.Description;
        }

        private string GetInductionType(Vehicle vehicle)
        {
            return vehicle?.FuelType.Description;
        }
        private bool GetVehicleUWRequired(Vehicle vehicle)
        {
            return false;
        }
        private RecommendedSumInsured GetRecommendedSumInsured(Vehicle vehicle)
        {
            return new RecommendedSumInsured()
            {
                RecommendedMin = 10000,
                RecommendedMax = 20000
            };
        }


        private string GetClassification(Vehicle vehicle)
        {
            return "A2";
        }

        private decimal GetTheftFactor(Vehicle vehicle)
        {
            return 0.2M;
        }

        private decimal GetMaintenanceFactor(Vehicle vehicle)
        {
            return 0;
        }

        private decimal GetPerformanceFactor(Vehicle vehicle)
        {
            return 0.7M;
        }

        #endregion
    }
}