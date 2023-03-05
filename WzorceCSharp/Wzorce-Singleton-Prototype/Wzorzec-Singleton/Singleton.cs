namespace Wzorce_Singleton_Prototype.Wzorzec_Singleton;
public class Singleton
{
    private static Singleton _instance;
    public int Number { get; set; }

    private Singleton()
    {

    }
    public static Singleton GetInstance(int n)
    {
        if(_instance == null)
        { 
            _instance = new Singleton();
            _instance.Number = n;

            Console.WriteLine($"Objekt został utworzony z wartoscią {n}");
        }
        return _instance;
    }
}
