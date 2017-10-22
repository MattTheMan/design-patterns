///////////////////////////////////////////////////////////////////////////////
// MIT License (see root directory for LICENSE file)
// Copyright (c) 2017 MattTheMan
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Text.RegularExpressions;

namespace DataMapper
{
    /// <summary>
    /// PriceMapper is a DataMapper class. It is responsible for retrieving data from the
    /// datasource (CoinbaseRestService) and returning it as a domain object (Price).
    /// </summary>
    public static class PriceMapper
    {
        public static Price GetPrice(string baseCurrency, string currency)
        {
            string urlParameters = $"prices/{baseCurrency}-{currency}/spot";
            string json = CoinbaseRestService.GetData(urlParameters);
            double amount = ParseAmount(json);

            return new Price()
            {
                BaseCurrency = baseCurrency,
                Currency = currency,
                Amount = amount
            };
        }

        private static double ParseAmount(string json)
        {
            Regex regex = new Regex(AMOUNT_REGEX);
            Match match = regex.Match(json);

            if (match.Success)
            {
                string amountString = match.Groups[0].Value.Split(':')[1].Trim('"');

                if (double.TryParse(amountString, out double amount))
                {
                    return amount;
                }
            }

            throw new Exception("Could not parse currency amount.");
        }

        private const string AMOUNT_REGEX = "\"amount\":\".*\\d\"";
    }
}
