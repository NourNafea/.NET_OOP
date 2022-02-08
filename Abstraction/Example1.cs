namespace refreshment
{
    class Program
    {
        internal abstract class Animal
        {
            public abstract void MakeSound();
        }
        public class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Meov meov");
            }
        }
        public class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Bark bark");
            }
        }
        
        public static void Main()
        {
            List<Animal> animals = new List<Animal>()
            {
                new Cat(),
                new Dog()
            };
            animals.ForEach(x=>x.MakeSound());
        }
    }
}
