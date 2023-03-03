using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace InventoryManager
{
    public class Serializer
    {
        private readonly string dbPath = "LaptopManager.json";
        public Serializer() { }

        public void Save(object data)
        {
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(dbPath, json);
        }


        public object Load() {
            if (!File.Exists(dbPath)) {
                File.Create(dbPath).Close();
                return "";
            }
               
            string json = File.ReadAllText(dbPath);
            return JsonConvert.DeserializeObject<Dictionary<string,Laptop>>(json);
        }

    }
}
