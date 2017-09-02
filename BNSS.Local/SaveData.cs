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

        public static void SaveSettings(string path)
        {
            var usersettings = new UsersettingsSaveData
            {
                RowColor1 = UserSettings.RowColor1,
                RowColor2 = UserSettings.RowColor2,
                Enabled = UserSettings.Enabled
            };

            File.WriteAllText(path, Encryption.Encrypt(JsonConvert.SerializeObject(usersettings)));
        }
    }
}
