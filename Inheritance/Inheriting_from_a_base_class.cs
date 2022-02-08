public class Animal
{
    public string Name { get; set; }
    // Methods and attributes common to all animals public void Eat(Object dinner)
    public void Eat(Object dinner)
    {
      // ...
    }
    public void Stare()
    {
      // ...
    }
    public void Roll()
    {
      // ...
    }
}
public class Cat : Animal
{
    public Cat()
    {
      Name = "Cat";
    }
    // Methods for scratching furniture and ignoring owner
    public void Scratch(Object furniture)
    {
     // ...
    } 
}
