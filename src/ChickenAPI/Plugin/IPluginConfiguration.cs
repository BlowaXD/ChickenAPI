using System.Globalization;
using System.IO;

namespace ChickenAPI.Plugin
{
    public interface IPluginConfiguration
    {
        void Load(FileInfo file);
        void Load(string filePath);

        void Save(FileInfo file);
        void Save(string filePath);
    }
}