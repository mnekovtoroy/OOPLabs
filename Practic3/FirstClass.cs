namespace Practic3
{
    public class FirstClass
    {
        Singleton single = Singleton.Instance;

        public string GetName()
        {
            return single.getName;
        }
    }
}
