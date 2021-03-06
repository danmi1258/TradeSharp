//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TradeSharp.Linq
{
    using System;
    using System.Collections.Generic;
    
    public partial class SUBSCRIPTION_SIGNAL
    {
        public int Service { get; set; }
        public int User { get; set; }
        public Nullable<bool> ShouldReceiveEmail { get; set; }
        public Nullable<bool> AutoTrade { get; set; }
        public Nullable<double> MaxLeverage { get; set; }
        public Nullable<double> PercentLeverage { get; set; }
        public Nullable<bool> HedgingOrdersEnabled { get; set; }
        public Nullable<int> FixedVolume { get; set; }
        public Nullable<int> MinVolume { get; set; }
        public Nullable<int> MaxVolume { get; set; }
        public Nullable<int> VolumeRound { get; set; }
        public Nullable<int> StepVolume { get; set; }
        public Nullable<int> TargetAccount { get; set; }
    
        public virtual ACCOUNT ACCOUNT { get; set; }
        public virtual SUBSCRIPTION SUBSCRIPTION { get; set; }
    }
}
