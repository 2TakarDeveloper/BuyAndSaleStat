using System;
using System.IO;
using BNSS.Entity;
using BNSS.Globals;
using Newtonsoft.Json;

namespace BNSS.Local
{
    public static class LoadData
    {
        public static void LoadLocalData()
        {
            if (File.Exists(StaticVariables.LocalDatapath))
            {
                using (StreamReader file = File.OpenText(StaticVariables.LocalDatapath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    StaticVariables.SpreadSheet = (SpreadSheet)serializer.Deserialize(file, typeof(SpreadSheet));
                }
            }
        }


        public static void LoadSettings()
        {
            if (!File.Exists(StaticVariables.LocalSettingsPath)) return;
        
            string json = Encryption.Decrypt(File.ReadAllText(StaticVariables.LocalSettingsPath));
           
            UsersettingsSaveData usersettings = JsonConvert.DeserializeObject<UsersettingsSaveData>(json);
            UserSettings.RowColor1 = usersettings.RowColor1;
            UserSettings.RowColor2 = usersettings.RowColor2;
            UserSettings.Enabled = usersettings.Enabled;
           

        }



    }
}
