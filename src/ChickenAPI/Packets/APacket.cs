namespace ChickenAPI.Packets
{
    public abstract class APacket
    {
        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public string OriginalContent { get; set; }

        public string OriginalHeader { get; set; }

        #endregion
    }
}