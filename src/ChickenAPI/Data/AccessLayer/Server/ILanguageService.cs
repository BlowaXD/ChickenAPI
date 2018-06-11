using ChickenAPI.Data.Language;
using ChickenAPI.Enums;

namespace ChickenAPI.Data.AccessLayer.Server
{
    public interface ILanguageService
    {
        /// <summary>
        ///     Will return the string by its Key & Region
        /// Used for plugins mainly
        /// </summary>
        /// <param name="key"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        string GetLanguage(string key, RegionType type);

        /// <summary>
        /// Will return the string by its key & region
        /// Used for ChickenAPI mainly
        /// </summary>
        /// <param name="key"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        string GetLanguage(LanguageKeys key, RegionType type);
    }
}