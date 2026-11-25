namespace Inheritance
{
    public class Animal
    {
        public string Name { get; }
        public int Age { get; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Introduce()
        {
            Console.WriteLine($"I am {Name} and I am {Age} years old.");
        }

        //virtual - oznacza, że metoda może być nadpisana w klasach pochodnych
        public virtual void MakeSound()
        {
            Console.WriteLine("...");
        }
    }
}
