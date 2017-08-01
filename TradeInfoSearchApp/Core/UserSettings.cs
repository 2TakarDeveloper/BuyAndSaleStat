
using System;
using System.IO;
using DocumentFormat.OpenXml.Spreadsheet;
using Newtonsoft.Json;
using TradeInfoSearchApp.Classes;
using Color = System.Drawing.Color;


namespace TradeInfoSearchApp.Core
{
    public static class UserSettings
    {
        public static Color RowColor1= Color.BlueViolet;
        public static Color RowColor2= Color.CornflowerBlue;

        public static void SaveSettings()
        {
            
                using (StreamWriter file = File.CreateText(AppDomain.CurrentDomain.BaseDirectory + @"\settings.json"))
                {
                    UsersettingsSaveData usersettings= new UsersettingsSaveData();
                    usersettings.RowColor1 = RowColor1;
                    usersettings.RowColor2 = RowColor2;
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, usersettings);
                }
            
        }

        public static void LoadSettings()
        {
            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\settings.json")) return;
            using (StreamReader file = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + @"\settings.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                UsersettingsSaveData usersettings = (UsersettingsSaveData)serializer.Deserialize(file, typeof(UsersettingsSaveData));
                RowColor1 = usersettings.RowColor1;
                RowColor2 = usersettings.RowColor2;
            }

        }
    }






    public class UsersettingsSaveData
    {
        public  Color RowColor1 { get; set; }
        public  Color RowColor2 { get; set; }
    }

}
