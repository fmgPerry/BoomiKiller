using BoomiKillerAPI.Areas.GW_PC.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoomiKillerAPI.Areas.GW_PC.Models
{
    
    public class PolicyCoverableItem
    {
        //private static string fmgapi_undefined = "fmgapi_undefined";
        public PolicyCoverableItem(PC_DevInt.PolicyCoverableSummary item)
        {
            CoverableSubType = new TypeCodeSummary(item.CoverableSubType);
            Excess = MapExcess(item.Excess);
            FixedID = item.FixedId;
            ID = item.ID;
            LocationID = item.LocationID;
            PolicyWording = new TypeCodeSummary(item.PolicyWording);

            // Buildings
            MapBuildingAreas(item.BuildingAreas);
            DomesticUnitYear = item.DomesticUnitYear;
            SICalculationModel = item.SICalculationModel;
            
            // Contents
            ContentKeptIn = new TypeCodeSummary(item.ContentKeptIn);
            ContentsSubType = item.ContentsSubType;

            // Vehicles
            MainDriver = item.MainDriver;
            SetMaxMin((item.Plate));
            
        }

        private void SetMaxMin(string plate)
        {
            if (plate != null)
            {
                var rb = FVRC.GetRedbookband(plate);
                Min = rb.Min;
                Max = rb.Max;
            }
        }

        private void MapBuildingAreas(PC_DevInt.BuildingArea[] buildingAreas)
        {
            if (buildingAreas != null)
            {
                BuildingAreas = new List<BuildingArea>();
                var ba = new BuildingArea();

                foreach (var buildingArea in buildingAreas)
                {
                    ba.Area = buildingArea.Area;
                    ba.BelongsToID = buildingArea.BelongsToID;
                    ba.ID = buildingArea.ID;
                    ba.IsDomesticUnit = buildingArea.IsDomesticUnit;
                    ba.Type = new TypeCodeSummary(buildingArea.Type);
                    ba.Year = buildingArea.Year;

                    BuildingAreas.Add(ba);
                }
            }
        }

        public PolicyCoverableItem(PC_DevInt.PolicyCoverableItem item)
        {
            
            BaseCover = MapBaseCover(item.BaseCover);
            CoverableSubType = new TypeCodeSummary(item.CoverableSubType);
            EffectiveDate = item.EffectiveDate;
            FixedID = item.FixedID;
            ID = item.ID;            
            ImposedTerms = MapImposedTerms(item.ImposedTerms);
            LocationID = item.LocationID;
            Location = MapLocation(item.LocationID);
            OptionalCovers = MapOptionalCovers(item.OptionalCovers);
            PolicyWording = new TypeCodeSummary(item.PolicyWording);

            // if vehicle
            VehicleType = new TypeCodeSummary(item.VehicleType);
            AccessoriesAndModifications = MapAccessoriesAndModifications(item.AccessoriesAndModifications);
            MainDriver = item.MainDriver;
            NamedDrivers = MapNamedDrivers(item.NamedDrivers);
            Make = item.Make;
            Model = item.Model;
            ModelType = item.ModelType;            
            Plate = item.Plate;            
            Year = item.Year;
            
        }

        private PolicyLocationSummary MapLocation(string locationID)
        {
            var l = new PolicyLocationSummary();
            l.ID = locationID;
            return l;
        }

        private List<OptionalCover> MapOptionalCovers(PC_DevInt.OptionalCover[] optionalCovers)
        {
            var ocs = new List<OptionalCover>();

            if (optionalCovers.Count() > 0)
            {
                foreach (var optionalCover in optionalCovers)
                {
                    var oc = new OptionalCover();
                    oc.ID = optionalCover.ID;
                    if (oc.ID != Constants.fmgapi_undefined)
                    {
                        oc.Code = optionalCover?.Code;
                        oc.CoverTaken = optionalCover.CoverTaken;
                        oc.DisplayName = optionalCover?.DisplayName;
                    }
                    ocs.Add(oc);
                }
            }
            else
            {
                var oc = new OptionalCover();
                oc.Code = Constants.fmgapi_undefined;
                ocs.Add(oc);
            }

            return ocs;
        }

        private List<NamedDriver> MapNamedDrivers(string[] namedDrivers)
        {
            var nds = new List<NamedDriver>();

            if (namedDrivers.Count() > 0)
            {
                foreach(var namedDriver in namedDrivers)
                {
                    var nd = new NamedDriver();
                    nd.ID = namedDriver;
                    nds.Add(nd);
                }
            }
            else
            {
                var nd = new NamedDriver();
                nd.ID = Constants.fmgapi_undefined;
                nds.Add(nd);
            }

            return nds;
        }

        private List<ImposedTerm> MapImposedTerms(PC_DevInt.PolicyCoverableCondExcl[] imposedTerms)
        {
            var its = new List<ImposedTerm>();

            if(imposedTerms.Count() > 0)
            {
                foreach(var imposedTerm in imposedTerms)
                {
                    var it = new ImposedTerm();
                    it.ID = imposedTerm?.ID;
                    if (it.ID != Constants.fmgapi_undefined)
                    {
                        it.Code = imposedTerm?.Code;
                        it.DisplayName = imposedTerm?.DisplayName;
                        it.Text = imposedTerm?.Text;
                    }
                    its.Add(it);
                }
            }
            else
            {
                var it = new ImposedTerm();
                it.ID = Constants.fmgapi_undefined;
                its.Add(it);
            }

            return its;
        }

        private BaseCover MapBaseCover(PC_DevInt.BaseCover baseCover)
        {
            var bc = new BaseCover();
            bc.BasisOfSettlement = baseCover?.BasisOfSettlement;
            bc.Excess = MapExcess(baseCover.Excess);
            //bc.ExcessTypes = baseCover.ExcessTypes;
            bc.InsuredEvent = new TypeCodeSummary(baseCover.InsuredEvent);            
            bc.NaturalDisasterIncluded = baseCover.NaturalDisasterIncluded;
            bc.SumInsured = baseCover?.SumInsured;
            
            return bc;
        }

        private TermValue MapExcess(PC_DevInt.TermValue excess)
        {
            var tv = new TermValue();
            tv.Format = excess.Format;
            tv.Value = excess.Value;

            return tv;
        }

        private List<AccessoryAndModification> MapAccessoriesAndModifications(PC_DevInt.AccessoryModification[] accessoriesAndModifications)
        {
            var accessoriesModifications = new List<AccessoryAndModification>();
            if (accessoriesAndModifications.Count() > 0)
            {
                foreach(var aam in accessoriesAndModifications)
                {
                    var am = new AccessoryAndModification();
                    am.ID = aam?.ID;
                    if (am.ID != Constants.fmgapi_undefined)
                    {
                        am.Details = aam?.Details;
                        am.Type.Code = aam?.Type?.Code;
                        am.Type.DisplayName = aam?.Type?.DisplayName;
                        am.Value = aam?.Value;
                    }

                    accessoriesModifications.Add(am);
                }
            }
            else
            {
                var am = new AccessoryAndModification();
                am.ID = Constants.fmgapi_undefined;
                accessoriesModifications.Add(am);
            }
            return accessoriesModifications;
        }

        
        
        public TypeCodeSummary CoverableSubType { get; set; }
        public string ID { get; set; }
        public string FixedID { get; set; }
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string ModelType { get; set; }
        public string Plate { get; set; }
        public string MainDriver { get; set; }
        public List<NamedDriver> NamedDrivers { get; set; }
        public string LocationID { get; set; }
        public PolicyLocationSummary Location { get; set; }
        public TypeCodeSummary PolicyWording { get; set; }        
        public List<AccessoryAndModification> AccessoriesAndModifications { get; set; }
        public List<ImposedTerm> ImposedTerms { get; set; }
        public BaseCover BaseCover { get; set; }
        public List<OptionalCover> OptionalCovers { get; set; }
        public string EffectiveDate { get; set; }
        public List<BuildingArea> BuildingAreas { get; set; }
        public string TotalArea { get; set; }
        public bool? IsRural { get; set; }
        public TypeCodeSummary OccupancyType { get; set; }
        public bool? LetPremises { get; set; }
        public List<InterestedParty> InterestedParties { get; set; }
        public string SICalculationModel { get; set; }
        public string CalculatedReplacement { get; set; }
        public string DomesticUnitYear { get; set; }
        public bool? Rewired { get; set; }
        public bool? Reroofed { get; set; }
        //public List<SpecifiedItem> SpecifiedItems { get; set; }
        public bool? Flatting { get; set; }
        public TypeCodeSummary ContentKeptIn { get; set; }
        public TypeCodeSummary ContentHomeSize { get; set; }
        public string ContentsSubType { get; set; }
        //public ContentSIAdvice ContentSIAdvice { get; set; }
        public TypeCodeSummary IndemnityPeriod { get; set; }
        public string MaintenancePeriod { get; set; }
        public string NumberOfVehicles { get; set; }
        public TypeCodeSummary VehicleType { get; set; }

        public TermValue Excess { get; set; }

        public string Band { get; set; }
        public string Max { get; set; }
        public string Min { get; set; }
        public string Median { get; set; }
        public string MyProperty { get; set; }

        // to add
        //public bool? BlockSumInsuredIncreaseOnRenewals { get; set; }
        //public string ConstructionMaterials { get; set; }
        //public bool? HiredVehicle { get; set; }
        //public string LimitPerVehicle { get; set; }
        //public string OutSourcedProvider { get; set; }
        //public TypeCodeSummary PolicyTypeCode { get; set; }
        //public TypeCodeSummary RiskType { get; set; }
        //public TypeCodeSummary TransitType { get; set; }

    }
}