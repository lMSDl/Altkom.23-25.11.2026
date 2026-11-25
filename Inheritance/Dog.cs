namespace Inheritance
{
    // : Aminal - oznacza, że klasa Dog dziedziczy po klasie Animal (Dog jest podtypem Animal)
    public class Dog : Animal
    {
        //base - odwołanie do konstruktora klasy bazowej (Animal) - wywołujemy konstruktor klasy bazowej z parametrami name i age
        public Dog(string name, int age) : base(name, age)
        {
        }

        //override - oznacza, że metoda nadpisuje metodę z klasy bazowej (Animal)
        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }


        public void Fetch()
        {
            Console.WriteLine($"{Name} fetches the ball!");
        }
    }
}
