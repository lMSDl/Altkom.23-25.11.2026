namespace Inheritance
{
    public class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }

        public void Purr()
        {
            Console.WriteLine($"{Name} is purring.");
        }
    }
}
