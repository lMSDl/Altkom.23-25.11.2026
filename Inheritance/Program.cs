using Inheritance;

Dog dog = new Dog("Rex", 5);
Cat cat = new Cat("Luna", 3);
dog.Introduce();
dog.MakeSound();
dog.Fetch();
cat.Introduce();
cat.MakeSound();
cat.Purr();

Animal unknown = new Animal("Unknown", 0);
unknown.Introduce();
unknown.MakeSound();

Console.WriteLine("----");

Animal[] animals = new Animal[3];
animals[0] = dog;
animals[1] = cat;
animals[2] = unknown;

foreach (Animal animal in animals)
{
    animal.Introduce();
    animal.MakeSound();
    //metody Fetch() i Purr() nie są dostępne w klasie Animal, więc musimy rzutować obiekt na odpowiedni typ
    //animal.Fetch();
    //animal.Purr();

    //możemy użyć operatora is do sprawdzenia typu obiektu i rzutowania go na odpowiedni typ
    //generalnie nie jest to najlepsze rozwiązanie, są lepsze sposoby na osiągnięcie tego samego efektu, np. użycie polimorfizmu
    if (animal is Dog d)
    {
        d.Fetch();
    }
    else if(animal is Cat c)
    {
        c.Purr();
    }
}