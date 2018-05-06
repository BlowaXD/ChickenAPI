using ChickenAPI.Enums;

namespace ChickenAPI.DAL.Interfaces
{
    public interface ILanguageService
    {
        string GetLanguage(string key, RegionType type);
    }
}