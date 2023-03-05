using System.Xml.Linq;
using Wzorce_Singleton_Prototype.Prototype;
using Wzorce_Singleton_Prototype.Wzorzec_Singleton;

class Program
{
    public static void Main()
    {



        // Prototype
        Console.WriteLine("-- Protytype --");

        var obj1 = new Person("Jakub", 18, new Address { City = "Bielsko-Biała", Street = "Pocztowa" });

        var obj2 = (Person)obj1.Clone();
        var obj3 = obj1.ShallowCopy();

        Console.WriteLine("Before modifying obj1:");
        Console.WriteLine($"obj1: {obj1}");
        Console.WriteLine($"obj2: {obj2}");
        Console.WriteLine($"obj3: {obj3}");

        obj1.Name = "Igor";
        obj1.Age = 18;
        obj1.Address.City = "Warszawa";
        obj1.Address.Street = "Andersena";

        Console.WriteLine("After modifying obj1:");
        Console.WriteLine($"obj1: {obj1}");
        Console.WriteLine($"obj2: {obj2}"); // deep clone
        Console.WriteLine($"obj3: {obj3}"); // shallow clone

        Console.WriteLine($"obj1.Address.GetHashCode(): {obj1.Address.GetHashCode()}");
        Console.WriteLine($"obj2.Address.GetHashCode(): {obj2.Address.GetHashCode()}");
        Console.WriteLine($"obj3.Address.GetHashCode(): {obj3.Address.GetHashCode()}");


        //po zmianie wartości pól Name i Age w obiekcie obj1, obj2 i obj3
        //nadal mają wartości oryginalne, co oznacza, że klonowanie działa poprawnie.
        //Natomiast po zmianie obiektu Address w obiekcie obj1, wartości w obj2 pozostają bez zmian


        //Console.WriteLine("-- Singleton --");
        
        //Singleton

        var instance1 = Singleton.GetInstance(10);

        Console.WriteLine($"instance1 - {instance1.Number}");

        var instance2 = Singleton.GetInstance(1);

        Console.WriteLine($"instance2 - {instance2.Number}");

        Console.WriteLine($"obj1==obj2 -> {instance1 == instance2}");

        //var instance3 = new Singleton(); // nie dostepny

    }
}

    public interface ICloneable
    {
        object Clone();
    }
