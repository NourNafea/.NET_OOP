namespace refreshment
{
    class Program
    {
        public interface INoiseMaker
        {
            string MakeNoise();
        }
        public class Cat : INoiseMaker
        {
            public string MakeNoise()
            {
                return "Meaw";
            }
        }
        public class Dog : INoiseMaker
        {
            public string MakeNoise()
            {
                return "Howhow";
            }
        }
        
        public static void Main()
        {
            List<INoiseMaker> noiseMakers = new List<INoiseMaker>()
            {
                new Cat(),
                new Dog()
            };
            foreach (var VARIABLE in noiseMakers)
            {
                Console.WriteLine(VARIABLE.MakeNoise());
            }

        }
    }
}
