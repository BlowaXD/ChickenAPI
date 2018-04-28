namespace ChickenAPI.Accounts
{
    /// <summary>
    /// Account basic groups
    /// </summary>
    public enum AuthorityType
    {
        Banned = -100,
        Muted = -10,
        User = 0,
        Support = 80,
        GameMaster = 100,
        Administrator = 1000,
    }
}