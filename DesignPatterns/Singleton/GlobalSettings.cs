///////////////////////////////////////////////////////////////////////////////
// MIT License (see root directory for LICENSE file)
// Copyright (c) 2017 MattTheMan
///////////////////////////////////////////////////////////////////////////////

using System;

namespace Singleton
{
    /// <summary>
    /// This class is a Global Settings singleton which could be used to access global settings across a project.
    /// 
    /// I'm using C#'s Lazy class to do a lazy load on the singleton. Also, passing isThreadSafe: true to Lazy in
    /// order to ensure that this is thread safe.
    /// 
    /// For some great examples on ways to implement singletons in C# see:
    /// http://csharpindepth.com/Articles/General/Singleton.aspx
    /// </summary>
    public class GlobalSettings
    {
        public static GlobalSettings Instance => _instance.Value;

        private static readonly Lazy<GlobalSettings> _instance = new Lazy<GlobalSettings>(() => new GlobalSettings(), isThreadSafe: true);

        private GlobalSettings()
        {
            // Initilize settings here - could retrieve these from anywhere
            ReadRegistrySettings();            
        }

        private void ReadRegistrySettings()
        {
            // Read in settings from registry here.
            SomeSetting = "mySetting";
        }
        
        public string SomeSetting { get; private set; }
    }
}
