namespace Practic3
{
    public class SecondClass
    {
        Singleton single = Singleton.Instance;

        public string GetName()
        {
            return single.getName;
        }
    }
}
