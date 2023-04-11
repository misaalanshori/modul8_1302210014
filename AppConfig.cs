using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul8_1302210014
{
    public class AppConfig
    {
        public BankConfig config;

        public const string configFile = @"./bank_transfer_config.json";

        public AppConfig() 
        {
            try
            {
                ReadConfigFile();
                Console.WriteLine("Membaca Config dari JSON");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Membuat Config Default");
                setDefault();
                WriteConfigFile();
            }
        } 

        public BankConfig ReadConfigFile()
        {
            string jsonText  = File.ReadAllText(configFile);
            config = JsonSerializer.Deserialize<BankConfig>(jsonText);
            return config;
        }

        public void setDefault()
        {
            config = new BankConfig("en", 
                new Transfer(25000000, 6500, 15000), 
                new List<string>{"RTO (real-time)", "SKN", "RTGS", "BI FAST"},
                new ConfirmationText("yes", "ya")
                );
        }

        public void WriteConfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            string jsonText = JsonSerializer.Serialize<BankConfig>(config, options);
            File.WriteAllText(configFile, jsonText);
        }
    }
}
