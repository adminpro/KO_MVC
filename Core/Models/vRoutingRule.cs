using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class vRoutingRule
    {
        public int RoutingRuleId { get; set; }
        public int SiteId { get; set; }
        public string DestinationCountryIso { get; set; }
        public int PriorityLevel { get; set; }
        public int CarrierId { get; set; }
        public string CarrierName { get; set; }
        public int ServiceLevelId { get; set; }
        public string ServiceLevelName { get; set; }
        public string ServiceLevelCode { get; set; }
        public Nullable<int> ParcelWeightId { get; set; }
        public double DefaultFromWeight { get; set; }
        public double DefaultToWeight { get; set; }
        public string DefaultWeightUnit { get; set; }
        public Nullable<int> ParcelSizeRangeId { get; set; }
        public double FromSizeWidth { get; set; }
        public double FromSizeLength { get; set; }
        public double FromSizeDepth { get; set; }
        public double FromSizeVolume { get; set; }
        public string FromSizeUnit { get; set; }
        public double ToSizeWidth { get; set; }
        public double ToSizeLength { get; set; }
        public double ToSizeDepth { get; set; }
        public double ToSizeVolume { get; set; }
        public string ToSizeUnit { get; set; }
        public Nullable<int> ParcelPriceId { get; set; }
        public float FromPrice { get; set; }
        public float ToPrice { get; set; }
        public string Currency { get; set; }
        public Nullable<int> TimeRangeId { get; set; }
        public string TimeRangeName { get; set; }
        public string FromTime { get; set; }
        public string ToTime { get; set; }
        public Nullable<int> DayId { get; set; }
        public string DaysRuleName { get; set; }
        public Nullable<bool> Monday { get; set; }
        public Nullable<bool> Tuesday { get; set; }
        public Nullable<bool> Wednesday { get; set; }
        public Nullable<bool> Thursday { get; set; }
        public Nullable<bool> Friday { get; set; }
        public Nullable<bool> Saturday { get; set; }
        public Nullable<bool> Sunday { get; set; }
    }
}
