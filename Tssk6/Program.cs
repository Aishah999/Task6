namespace CarApp;
class Program
{
    public enum CarType
    {
        Sedan,
        Sportscars,
        Coupe,

    }
    public class Car
    {
        private static int _idCounter = 0;
        public int Id { get; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public CarType Type { get; set; }
        public Car(string brand, string model, CarType type)
        {
            Id = ++_idCounter;
            Brand = brand;
            Model = model;
            Type = type;
        }
        public override string ToString()
        {
            return $"Id:{Id},Brand:{Brand},Model:{Model},Type:{Type}";
        }
    }
    class Car1
    {
        static void Main(string[]args)
        {
            Car car1 = new Car("BMW", "F10", CarType.Sportscars);
            Car car2 = new Car("Mercedes", "E200", CarType.Sedan);
            Console.WriteLine(car1);
            Console.WriteLine(car2);
        }
    }
        


    
     
       
    


    

    
}

