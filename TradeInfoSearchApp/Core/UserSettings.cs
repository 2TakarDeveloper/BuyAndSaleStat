
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using Newtonsoft.Json;
using TradeInfoSearchApp.Classes;
using Color = System.Drawing.Color;


namespace TradeInfoSearchApp.Core
{
    public static class UserSettings
    {
        public static Color RowColor1= Color.Blue;
        public static Color RowColor2= Color.OrangeRed;
        public static bool Enabled;


        public static void SaveSettings()
        {
            
                //using (StreamWriter file = File.CreateText(AppDomain.CurrentDomain.BaseDirectory + @"\settings.json"))
                //{
                    UsersettingsSaveData usersettings= new UsersettingsSaveData();
                    usersettings.RowColor1 = RowColor1;
                    usersettings.RowColor2 = RowColor2;
                    usersettings.Enabled = Enabled;
                    //JsonSerializer serializer = new JsonSerializer();
                    File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\settings.json", Encrypt(JsonConvert.SerializeObject(usersettings)));
                    //serializer.Serialize(file, usersettings);
                //}
            
        }

        public static void LoadSettings()
        {
            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\settings.json")) return;
            //using (StreamReader file = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + @"\settings.json"))
            //{
                //JsonSerializer serializer = new JsonSerializer();
                string json = Decrypt(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\settings.json"));
                // UsersettingsSaveData usersettings = (UsersettingsSaveData)serializer.Deserialize(file, typeof(UsersettingsSaveData));

                UsersettingsSaveData usersettings = JsonConvert.DeserializeObject<UsersettingsSaveData>(json);
                RowColor1 = usersettings.RowColor1;
                RowColor2 = usersettings.RowColor2;
                Enabled = usersettings.Enabled;
            //}

        }



        public static string Encrypt(string clearText)
        {
            string EncryptionKey = "abc123";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }
        public static string Decrypt(string cipherText)
        {
            string EncryptionKey = "abc123";
            cipherText = cipherText.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }



    }






    public class UsersettingsSaveData
    {
        public  Color RowColor1 { get; set; }
        public  Color RowColor2 { get; set; }
        public bool Enabled { get; set; }
    }

}
