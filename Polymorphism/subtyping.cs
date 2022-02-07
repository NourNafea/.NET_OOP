namespace refreshment
{
    class Program
    {
        public interface Car{
            void refuel();
        }
        public class NormalCar : Car
        {
            public void refuel()
            {
                Console.WriteLine("Refueling with petrol");
            }
        }
        public class ElectricCar : Car
        {
            public void refuel()
            {
                Console.WriteLine("Charging battery");
            }
        }
        
        public static void Main()
        {
            List<Car> cars = new List<Car>(){
                new NormalCar(),
                new ElectricCar()
            };
            cars.ForEach(x => x.refuel());
        }
    }
}
