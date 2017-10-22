///////////////////////////////////////////////////////////////////////////////
// MIT License (see root directory for LICENSE file)
// Copyright (c) 2017 MattTheMan
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Net.Http;

namespace DataMapper
{
    public static class CoinbaseRestService
    {
        private const string URL = "https://api.coinbase.com/v2/";

        public static string GetData(string urlParameters)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(URL);
                return client.GetStringAsync(urlParameters).Result;
            }
        }
    }
}
