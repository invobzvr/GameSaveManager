using GameSaveManager.Model;
using Newtonsoft.Json.Linq;
using System.IO;

namespace GameSaveManager
{
    static class Storage
    {
        private static readonly string STORAGE_PATH = "storage.json";
        private static JObject json;

        private static void Check()
        {
            if (json == null)
            {
                json = File.Exists(STORAGE_PATH) ? JObject.Parse(File.ReadAllText(STORAGE_PATH)) : new JObject();
            }
        }

        private static JObject Find(string target, GameSave gs)
        {
            foreach (JObject gsj in (JArray)json[target])
            {
                if (gsj.Value<string>("Time") == gs.Time)
                {
                    return gsj;
                }
            }
            return null;
        }

        public static void Save()
        {
            File.WriteAllText(STORAGE_PATH, json.ToString());
        }

        public static GameSave[] GetList(string target)
        {
            Check();
            if (json[target] == null)
            {
                json[target] = new JArray();
            }
            return (json[target] as JArray).ToObject<GameSave[]>();
        }

        public static bool Add(string target, GameSave gs)
        {
            (json[target] as JArray).Add(JObject.FromObject(gs));
            Save();
            return true;
        }

        public static bool Update(string target, GameSave gs)
        {
            JObject gsj = Find(target, gs);
            gsj.Replace(JObject.FromObject(gs));
            Save();
            if (gsj.Value<string>("Name") != gs.Name)
            {
                File.Move(Manager.GetBFPath(target, gsj.Value<string>("Name")), Manager.GetBFPath(target, gs.Name));
            }
            return true;
        }

        public static bool Remove(string target, GameSave gs)
        {
            Find(target, gs)?.Remove();
            Save();
            File.Delete(Manager.GetBFPath(target, gs.Name));
            return true;
        }
    }
}