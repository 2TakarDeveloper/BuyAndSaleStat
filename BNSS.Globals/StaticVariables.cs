using System;
using BNSS.Entity;

namespace BNSS.Globals
{
    public static class StaticVariables
    {
        public static SpreadSheet SpreadSheet { get; set; }
        public static readonly string LocalDatapath = AppDomain.CurrentDomain.BaseDirectory + @"\memory.json";
        public static readonly string LocalSettingsPath = AppDomain.CurrentDomain.BaseDirectory + @"\settings.json";
    
    }
}
