using Autofac;

namespace ChickenAPI.Utils
{
    public class Container
    {
        public static ContainerBuilder Builder = new ContainerBuilder();

        public static void Initialize()
        {
            Instance = Builder.Build();
        }

        public static IContainer Instance { get; private set; }
    }
}