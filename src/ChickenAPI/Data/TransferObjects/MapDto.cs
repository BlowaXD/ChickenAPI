namespace ChickenAPI.Data.TransferObjects
{
    public class MapDto
    {
        public short Id { get; set; }
        public string Name { get; set; }
        public bool AllowShop { get; set; }
        public bool AllowPvp { get; set; }
        public int Music { get; set; }
        public short Height { get; set; }
        public short Width { get; set; }
        public byte[] Grid { get; set; }
    }
}