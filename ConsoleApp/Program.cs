using ConsoleApp;
using Models;

//Subjects.Introduction();
//Subjects.Strings();
//Subjects.Numbers();
//Subjects.Casting();
//Subjects.Arrays();
//Subjects.Split();
//Subjects.IfElse();
//Subjects.Switch();
//Subjects.While();
//Subjects.DoWhile();
//Subjects.For();
//Subjects.Foreach();
//Subjects.JumpStatemensts();


//Person to nasza klasa zdefiniowana w Models/Person.cs
//używamy using Models, aby uniknąć wpisywania pełnej nazwy przestrzeni nazw za każdym razem
Person person = new Person();

Console.WriteLine(person.GetType().Name);
Console.WriteLine(person.GetType().Namespace);
Console.WriteLine(person.GetType().FullName);

person.SetName("Jan");
Console.WriteLine(person.GetName());

person.LastName = "Kowalski";
Console.WriteLine(person.LastName);

person.Age = 65;
Console.WriteLine(person.Age);

Console.WriteLine(person.GenerateBio());


//person.LastName = person.ToTitleCase("NoWAk");

Console.WriteLine(person.GenerateBio());

person.ChangeNamesToTitleCase();
Console.WriteLine(person.GenerateBio());