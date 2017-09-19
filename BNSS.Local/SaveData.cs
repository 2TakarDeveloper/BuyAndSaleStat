using System.IO;
using BNSS.Globals;
using Newtonsoft.Json;

namespace BNSS.Local
{
    public static class SaveData
    {
        public static void SaveLocalData()
        {
            using (StreamWriter file = File.CreateText(StaticVariables.LocalDatapath))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, StaticVariables.SpreadSheet);
            }
        }

        public static void SaveSettings()
        {
            var usersettings = new UsersettingsSaveData
            {
                RowColor1 = UserSettings.RowColor1,
                RowColor2 = UserSettings.RowColor2,
                Enabled = UserSettings.Enabled
            };

            File.WriteAllText(StaticVariables.LocalSettingsPath, Encryption.Encrypt(JsonConvert.SerializeObject(usersettings)));
        }

        


    }
}
