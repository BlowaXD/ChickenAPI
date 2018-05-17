using System;
using ChickenAPI.Plugins;
using ChickenAPI.Utils;

namespace ChickenAPI.HelloWorldPlugin
{
    public class HelloWorldPlugin : IPlugin
    {
        private HelloWorldPluginConfiguration _configuration;
        private const string ConfigurationPath = "config/HelloWorldPlugin/config.json";
        private const string PluginName = "ChickenAPI-HelloWorld";
        public string Name => PluginName;

        private static readonly Logger Logger = Logger.GetLogger<HelloWorldPlugin>();

        public void OnDisable()
        {
            Logger?.Info($"[{PluginName}] Disabled !");
        }

        public void OnEnable()
        {
            Logger?.Info($"[{PluginName}] Enabled !");
        }

        public void OnLoad()
        {
            ReloadConfig();
            Logger?.Info($"[{PluginName}] Loaded, let's do the work !");
            if (_configuration.PrintHeader)
            {
                Console.WriteLine("Hello World");
            }
        }

        public void ReloadConfig()
        {
            _configuration = ConfigurationHelper.Load<HelloWorldPluginConfiguration>(ConfigurationPath, true);
        }

        public void SaveConfig()
        {
            ConfigurationHelper.Save(ConfigurationPath, _configuration);
        }

        public void SaveDefaultConfig()
        {
            ConfigurationHelper.Save(ConfigurationPath, new HelloWorldPluginConfiguration());
        }
    }
}