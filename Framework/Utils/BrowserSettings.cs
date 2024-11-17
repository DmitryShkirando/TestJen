//using Aquality.Selenium.Configurations.WebDriverSettings;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static HarmonyLib.Code;

//namespace NUnitSpecFlow.Framework.Utils
//{
//    public class BrowserSettings
//    {
//        public string BrowserName { get; set; }
//        public bool IsRemote { get; set; }
//        public string RemoteConnectionUrl { get; set; }
//        public bool IsElementHighlightEnabled { get; set; }
//        public string Url2 { get; set; }
//        public DriverSettings DriverSettings { get; set; }
//        public Timeouts Timeouts { get; set; }
//        public Retry Retry { get; set; }
//        public Logger Logger { get; set; }
//        public ElementCache ElementCache { get; set; }
//        public Visualization Visualization { get; set; }

//    }
//    public class DriverSettings
//    {
//        public Dictionary<string, DriverConfig> Drivers { get; set; }
//    }

//    public class DriverConfig
//    {
//        public string WebDriverVersion { get; set; }
//        public bool EnableVNC { get; set; }
//        public Dictionary<string, string> Options { get; set; }
//        // Добавьте остальные параметры как вам нужно
//    }

//    public class Timeouts
//    {
//        public int TimeoutImplicit { get; set; }
//        public int TimeoutCondition { get; set; }
//        // Добавьте остальные таймауты
//    }

//    public class Retry
//    {
//        public int Number { get; set; }
//        public int PollingInterval { get; set; }
//    }

//    public class Logger
//    {
//        public string Language { get; set; }
//        public bool LogPageSource { get; set; }
//    }

//    public class ElementCache
//    {
//        public bool IsEnabled { get; set; }
//    }

//    public class Visualization
//    {
//        public double DefaultThreshold { get; set; }
//        // Добавьте остальные параметры визуализации
//    }
//}
