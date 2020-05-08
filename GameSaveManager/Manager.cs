using System.IO;
using System.IO.Compression;

namespace GameSaveManager
{
    static class Manager
    {
        public static string GetBFPath(string target, string name)
        {
            return Path.Combine(Path.GetDirectoryName(target), name);
        }

        public static void Backup(string target, string name)
        {
            ZipFile.CreateFromDirectory(target, GetBFPath(target, name));
        }

        public static void Restore(string target, string name)
        {
            ZipFile.ExtractToDirectory(GetBFPath(target, name), target);
        }
    }
}
