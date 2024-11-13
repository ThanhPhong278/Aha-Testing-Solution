using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon_Admin.Utils
{
    public class JsonReader
    {
        public static JObject GetConfiguration()
        {
            var jsonPath = $"Config/EnvironmentTesting.json";
            var jsonText = File.ReadAllText(jsonPath);
            return JObject.Parse(jsonText);
        }
    }
}
