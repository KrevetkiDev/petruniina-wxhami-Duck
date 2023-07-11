public class Dog
{
    public string Name;
    public bool IsMen;
    public int Age;


    public Dog(string name, bool isMen, int age)
    {
        Name = name;
        IsMen = isMen;
        Age = age;

    }

    
    public void Say()
    {
        Console.WriteLine("Гав");
        Console.WriteLine("Гав");

    }
}