///////////////////////////////////////////////////////////////////////////////
// MIT License (see root directory for LICENSE file)
// Copyright (c) 2017 MattTheMan
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Timers;

namespace DataMapper
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Timer set to update price every 10 seconds.
            double intervalInMilliseconds = 10000;
            Timer timer = new Timer(intervalInMilliseconds);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

            Console.WriteLine("Press any key to exit.");
            Console.Read();
        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Price price = PriceMapper.GetPrice(Price.ETH, Price.USD);
            Console.WriteLine($"{price.BaseCurrency} price = {price.Amount} {price.Currency}");
        }
    }
}
