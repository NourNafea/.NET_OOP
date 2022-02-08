public class Animal
{
    public string Name { get; set; }
}
public interface INoiseMaker
{
    string MakeNoise();
}
//Note that in C#, the base class name must come before the interface names
public class Cat : Animal, INoiseMaker
{
    public Cat()
    {
        Name = "Cat";
    }
    public string MakeNoise()
    {
        return "Nyan";
    }
}
