namespace Wzorce_Singleton_Prototype.Prototype;


public class Address
{
	public string Street { get; set; }
	public string City { get; set; }

	public override string ToString()
	{
		return $"{City}, {Street}";
	}
}

public class Person : ICloneable
{
	public string Name;
	public int Age;
	public Address Address { get; set; }

	public Person(string name,int age, Address address)
	{
		(Name, Age,Address) = (name, age,address);
	}

	public object Clone()
    {
        // Głębokie klonowanie - tworzymy nowy obiekt i kopiujemy wartości z obiektu oryginalnego,
        // ale również klonujemy pola referencyjne, a więc tworzymy nowe obiekty Address
        return new Person(Name,Age,new Address { City=Address.City,Street=Address.Street});
	}
	public Person ShallowCopy()
    {

        // Płytkie klonowanie - tworzymy nowy obiekt i kopiujemy wartości z obiektu oryginalnego,
        // ale kopiujemy jedynie referencję do obiektu Address, a nie klonujemy go
        return (Person) MemberwiseClone();
    }
    public override string ToString()
	{
		return $"{Name}, {Age}, {Address}";
    }
}


