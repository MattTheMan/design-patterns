///////////////////////////////////////////////////////////////////////////////
// MIT License (see root directory for LICENSE file)
// Copyright (c) 2017 MattTheMan
///////////////////////////////////////////////////////////////////////////////

namespace DataMapper
{
    public class Price
    {
        public string BaseCurrency { get; set; }
        public string Currency { get; set; }
        public double Amount { get; set; }

        // Store all price strings here.
        public const string BTC = "BTC";
        public const string ETH = "ETH";
        public const string USD = "USD";
        public const string EUR = "EUR";
    }
}
