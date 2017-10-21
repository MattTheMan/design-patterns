///////////////////////////////////////////////////////////////////////////////
// MIT License (see root directory for LICENSE file)
// Copyright (c) 2017 MattTheMan
///////////////////////////////////////////////////////////////////////////////

using System;

namespace Singleton
{
    /// <summary>
    /// The program grabs a setting from the GlobalSettings singleton.
    /// The first call to GlobalSettings.Instance will instantiate the singleton instance.
    /// Subsequent calls will return the already instantiated GlobalSettings instance.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {            
            string someSetting = GlobalSettings.Instance.SomeSetting;
            Console.WriteLine($"The setting: {someSetting}");

            Console.WriteLine("Press any key to exit.");
            Console.Read();
        }
    }
}
