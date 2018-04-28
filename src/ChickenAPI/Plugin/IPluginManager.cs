using System.IO;

namespace ChickenAPI.Plugin
{
    public interface IPluginManager
    {
        IPlugin LoadPlugin(FileInfo file);
        IPlugin[] LoadPlugins(DirectoryInfo directory);
    }
}