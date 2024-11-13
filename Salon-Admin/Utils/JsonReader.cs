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
        private readonly JObject _environmentConfig;
        private readonly JObject _loginData;

        public JsonReader()
        {
            _environmentConfig = JObject.Parse(File.ReadAllText("Config/EnvironmentTesting.json"));
            _loginData = JObject.Parse(File.ReadAllText("Data/loginData.json"));
        }

        public string GetEnvironmentConfig(string key)
        {
            return _environmentConfig[key]?.ToString();
        }

        public string GetLoginData(string key)
        {
            return _loginData[key]?.ToString();
        }
    }
}
