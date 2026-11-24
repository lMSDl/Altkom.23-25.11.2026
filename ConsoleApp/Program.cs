using ConsoleApp;


//Subjects.Introduction();
//Subjects.Strings();
//Subjects.Numbers();
//Subjects.Casting();
//Subjects.Arrays();




Console.WriteLine("Napisz coś:");
string input = Console.ReadLine();

//split - dzieli łańcuch na tablicę stringów, jeśli nie poda się argumentu, domyślnie dzieli po spacji
string[] splittedInput = input.Split();

Console.WriteLine($"Napisałeś {splittedInput.Length} słów");

Console.WriteLine(splittedInput[2]);

Array.Sort(splittedInput);


Console.WriteLine(splittedInput[2]);


//split przyjmuje jako argument string, po którym ma dzielić. Jeśli nie podamy argumentu, domyślnie dzieli po spacji
splittedInput = input.Split("a");

Console.WriteLine($"Napisałeś {splittedInput.Length} słów");