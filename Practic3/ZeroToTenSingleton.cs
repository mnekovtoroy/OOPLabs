namespace Practic3
{
    public class ZeroToTenSingleton
    {
        protected static int name = 0;

        protected ZeroToTenSingleton()
        {
            //Console.WriteLine("Singleton has been planted");
        }

        private sealed class SingletonCreator
        {
            private static readonly ZeroToTenSingleton instance = new ZeroToTenSingleton();
            public static ZeroToTenSingleton Instance { get { return instance; } }
        }

        public static string getName { get { return name.ToString(); } }

        public static ZeroToTenSingleton Instance 
        {
            get
            {
                var s = SingletonCreator.Instance;
                //Console.WriteLine(name);
                name++;
                return s;
            }
        }
    }
}
