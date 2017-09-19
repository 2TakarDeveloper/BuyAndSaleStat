
using System.IO;

using BNSS.Globals;

namespace BNSS.Export
{
    public class Memory
    {
        public static void ExportAsJson(string path)
        {
            File.Copy(StaticVariables.LocalDatapath, path, true);
        }

        public static void ImportFromJson(string path)
        {
            File.Copy(path,StaticVariables.LocalDatapath, true);
        }

    }
}
