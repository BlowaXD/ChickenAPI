using ChickenAPI.Game.Maps;

namespace ChickenAPI.Managers
{
    public interface IMapManager
    {
        IMapLayer GetBaseMapLayer(IMap map);
        IMapLayer GenerateMapLayer(IMap map);
    }
}