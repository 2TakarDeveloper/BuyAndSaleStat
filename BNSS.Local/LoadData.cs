using System;
using System.IO;
using BNSS.Entity;
using BNSS.Globals;
using Newtonsoft.Json;

namespace BNSS.Local
{
    public static class LoadData
    {
        public static void LoadLocalData(string path)
        {
            if (File.Exists(path))
            {
                using (StreamReader file = File.OpenText(path))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    StaticVariables.SpreadSheet = (SpreadSheet)serializer.Deserialize(file, typeof(SpreadSheet));
                }
            }
        }


        public static void LoadSettings(string path)
        {
            if (!File.Exists(path)) return;
        
            string json = Encryption.Decrypt(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\settings.json"));
           
            UsersettingsSaveData usersettings = JsonConvert.DeserializeObject<UsersettingsSaveData>(json);
            UserSettings.RowColor1 = usersettings.RowColor1;
            UserSettings.RowColor2 = usersettings.RowColor2;
            UserSettings.Enabled = usersettings.Enabled;
           

        }



    }
}
