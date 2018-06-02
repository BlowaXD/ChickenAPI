using ChickenAPI.Enums.Game.Entity;

namespace ChickenAPI.Data.AccessLayer
{
    public interface INpcMonsterAlgorithmService
    {
        /// <summary>
        /// Returns the MaxHp based on basic algorithm + special races stats
        /// </summary>
        /// <param name="type"></param>
        /// <param name="level"></param>
        /// <param name="isMonster"></param>
        /// <returns></returns>
        int GetHpMax(NpcMonsterRaceType type, byte level, bool isMonster);
        int GetMpMax(NpcMonsterRaceType type, byte level, bool isMonster);
    }
}