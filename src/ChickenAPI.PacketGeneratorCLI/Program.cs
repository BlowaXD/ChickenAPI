using System;

namespace ChickenAPI.PacketGeneratorCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            PacketMdGenerator.DoWork(args[0]);
        }
    }
}
