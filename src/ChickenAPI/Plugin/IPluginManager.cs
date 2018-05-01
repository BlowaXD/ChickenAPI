using System.IO;

namespace ChickenAPI.Plugin
{
    public interface IPluginManager
    {
        DirectoryInfo GetPluginDirectory();
        DirectoryInfo GetConfigDirectory();
        IPlugin LoadPlugin(FileInfo file);
        IPlugin[] LoadPlugins(DirectoryInfo directory);
    }
}