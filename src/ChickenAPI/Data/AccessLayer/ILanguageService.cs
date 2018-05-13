using ChickenAPI.Enums;

namespace ChickenAPI.Data.AccessLayer
{
    public interface ILanguageService
    {
        /// <summary>
        /// Will return the string by its Key & Region
        /// </summary>
        /// <param name="key"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        string GetLanguage(string key, RegionType type);
    }
}