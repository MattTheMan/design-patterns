///////////////////////////////////////////////////////////////////////////////
// MIT License (see root directory for LICENSE file)
// Copyright (c) 2017 MattTheMan
///////////////////////////////////////////////////////////////////////////////

using System;

namespace Singleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Grab our setting from the global settings singleton.
            // This first call will instantiate the singleton instance.
            // Subsequent calls will return the already instantiated instance.
            string someSetting = GlobalSettings.Instance.SomeSetting;
            Console.WriteLine($"The setting: {someSetting}");

            Console.WriteLine("Press any key to exit.");
            Console.Read();
        }
    }
}
