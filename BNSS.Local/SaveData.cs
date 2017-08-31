using System;
using System.IO;
using BNSS.Globals;
using Newtonsoft.Json;

namespace BNSS.Local
{
    public static class SaveData
    {
        public static void SaveLocalData(string path)
        {
            using (StreamWriter file = File.CreateText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, StaticVariables.SpreadSheet);
            }
        }


        public static void SaveSettings()
        {

            //using (StreamWriter file = File.CreateText(AppDomain.CurrentDomain.BaseDirectory + @"\settings.json"))
            //{
            UsersettingsSaveData usersettings = new UsersettingsSaveData();
            usersettings.RowColor1 = UserSettings.RowColor1;
            usersettings.RowColor2 = UserSettings.RowColor2;
            usersettings.Enabled = UserSettings.Enabled;
            //JsonSerializer serializer = new JsonSerializer();
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\settings.json", Encryption.Encrypt(JsonConvert.SerializeObject(usersettings)));
            //serializer.Serialize(file, usersettings);
            //}

        }

       




    }
}
