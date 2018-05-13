# Your first plugin

## What is a plugin

A plugin is a class that will be loaded by an instance of [IPluginManager](https://github.com/BlowaXD/ChickenAPI/blob/master/src/ChickenAPI/Plugin/IPluginManager.cs).

Once loaded, it will call `OnLoad()` method.

`OnLoad()` is supposed to initialize everything that is needed by your plugin to work correctly.

Once every plugins are loaded, the PluginManager will call for `OnEnable()` method

`OnEnable()` is supposed to be called once every plugins are fully loaded, it can be used to register Packets for example.

## Let's do it

I've implemented a basic Plugin right here, that will load its configuration from its own configuration path (a bad way, should be improved btw)
Once loaded, it will print "Hello World" depending on whether or not the configuration allows it.

Let's write a basic configuration to setup that

```csharp
namespace HelloWorldNamespace
{
    [DataContract]
    public class HelloWorldPluginConfiguration
    {
        [DataMember(Name = "printHeader")]
        public bool PrintHeader = true;
    }
}
```

```csharp
using ChickenAPI.Plugins;
using ChickenAPI.Utils;

namespace HelloWorldNamespace
{
    public class HelloWorldPlugin : IPlugin
    {
        private HelloWorldPluginConfiguration _configuration;
        private const string ConfigurationPath = "config/HelloWorldPlugin/config.json";
        private const string PluginName = "ChickenAPI-HelloWorld";
        public string Name => PluginName;

        // here we disable the plugin
        public void OnDisable()
        {
            Logger.Log.Info($"[{PluginName}] Disabled !");
        }

        // here we enable the plugin
        public void OnEnable()
        {
            Logger.Log.Info($"[{PluginName}] Enabled !");
        }

        // here we get everything up because the plugin is loaded !
        public void OnLoad()
        {
            ReloadConfig();
            Logger.Log.Info($"[{PluginName}] Loaded, let's do the work !");

            // check the configuration we just loaded so we will print or not "Hello World"
            if (_configuration.PrintHeader)
            {
                Console.WriteLine("Hello World");
            }
        }

        // here we reload the configuration from the configuration Path
        public void ReloadConfig()
        {
            _configuration = ConfigurationHelper.Load<HelloWorldPluginConfiguration>(ConfigurationPath, true); // true says configuration will be created if it does not exist yet
        }

        // here we save the actual in memory configuration
        public void SaveConfig()
        {
            ConfigurationHelper.Save(ConfigurationPath, _configuration);
        }

        // we are saving the default configuration
        public void SaveDefaultConfig()
        {
            ConfigurationHelper.Save(ConfigurationPath, new HelloWorldPluginConfiguration());
        }
    }
}
```

Tutorial by Blowa