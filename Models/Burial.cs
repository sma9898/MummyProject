using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MummyProject.Models
{
    public partial class Burial
    {
        public long BurialId { get; set; }
        public string BurialLocationNs { get; set; }
        public string BurialLocationEw { get; set; }
        public long? LowPairNs { get; set; }
        public byte[] HighPairNs { get; set; }
        public long? LowPairEw { get; set; }
        public long? HighPairEw { get; set; }
        public string BurialSubplot { get; set; }
        public double? BurialDepth { get; set; }
        public double? SouthToHead { get; set; }
        public double? SouthToFeet { get; set; }
        public double? EastToHead { get; set; }
        public double? EastToFeet { get; set; }
        public string GenderGe { get; set; }
        public long? AgeEstimate { get; set; }
        public double? LengthOfRemains { get; set; }
        public long? BurialNumber { get; set; }
        public long? SampleNumber { get; set; }
        public double? GeFunctionTotal { get; set; }
        public string GenderBodyCol { get; set; }
        public double? BasilarSuture { get; set; }
        public double? VentralArc { get; set; }
        public double? SubpubicAngle { get; set; }
        public double? SciaticNotch { get; set; }
        public double? PubicBone { get; set; }
        public double? PreaurSulcus { get; set; }
        public double? MedialIpRamus { get; set; }
        public double? DorsalPitting { get; set; }
        public double? ForemanMagnum { get; set; }
        public double? FemurHead { get; set; }
        public double? HumerusHead { get; set; }
        public string Osteophytosis { get; set; }
        public string PubicSymphysis { get; set; }
        public double? BoneLength { get; set; }
        public double? MedialClavicle { get; set; }
        public double? IlacCrest { get; set; }
        public double? FemurDiameter { get; set; }
        public double? Humerus { get; set; }
        public double? FemurLength { get; set; }
        public double? HumerusLength { get; set; }
        public double? TibiaLength { get; set; }
        public double? Robust { get; set; }
        public double? SupraorbitalRidges { get; set; }
        public double? OrbitEdge { get; set; }
        public double? ParietalBossing { get; set; }
        public double? Gonian { get; set; }
        public double? NuchalCrest { get; set; }
        public double? ZygomaticCrest { get; set; }
        public string CranialSuture { get; set; }
        public double? MaximumCranialLength { get; set; }
        public double? MaximumCranialBreadth { get; set; }
        public double? BasionBregmaHeight { get; set; }
        public double? BasionNasion { get; set; }
        public double? BasionProsthionLength { get; set; }
        public double? BizygomaticDiameter { get; set; }
        public double? NasionProsthion { get; set; }
        public double? MaximumNasalBreadth { get; set; }
        public double? InterorbitalBreadth { get; set; }
        public string ArtifactDescription { get; set; }
        public string HairColor { get; set; }
        public string PresevationIndex { get; set; }
        public long? HairTaken { get; set; }
        public long? SoftTissueTaken { get; set; }
        public long? BoneTaken { get; set; }
        public long? ToothTaken { get; set; }
        public long? TextileTaken { get; set; }
        public string DescriptionOfTaken { get; set; }
        public long? ArtifactFound { get; set; }
        public double? EstimateLivingStature { get; set; }
        public string ToothAttrition { get; set; }
        public string ToothEruption { get; set; }
        public string PathologyAnomolies { get; set; }
        public long? EpiphysealUnion { get; set; }
        public long? YearFound { get; set; }
        public string MonthFound { get; set; }
        public long? DayFound { get; set; }
        public string HeadDirection { get; set; }
        public long? WrappingCode { get; set; }
        public long? AgeCode { get; set; }
        public string SexMethod { get; set; }
        public string AgeMethod { get; set; }
        public long? PhotoId { get; set; }
        public string Rack { get; set; }
        public string Shelf { get; set; }
        public string FieldNotes { get; set; }
    }
}
