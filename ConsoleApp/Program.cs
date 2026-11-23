using ConsoleApp;

//Subjects.Introduction();

Console.WriteLine("Podaj swoje imię:");
string target = Console.ReadLine();
string hello = "Witaj";

string output;

//łączenie string za pomocą operacji + (konkatenacja)
output = hello + ", " + target + "!"; //łączenie stringów prowadzi do powstania nowego stringa, który jest wynikiem połączenia wszystkich stringów
Console.WriteLine(output);

//łączenie stringów za pomocą metody Concat, która przyjmuje dowolną liczbę argumentów typu string i zwraca nowy string będący wynikiem połączenia wszystkich argumentów
output = string.Concat(hello, ", ", target, "!");
Console.WriteLine(output);


Console.WriteLine("Podaj swoje imię:");
string target2 = Console.ReadLine();
string format = "{0}, {1}!";

//formatowanie stringa - wstawianie zmiennych w odpowiednie miejsca w stringu. numeracja zaczyna się od 0
output = string.Format(format, hello, target);
Console.WriteLine(output);
output = string.Format(format, target2, hello);
Console.WriteLine(output);


//łączenie stringów za pomocą interpolacji - wstawianie zmiennych w odpowiednie miejsca w stringu w nawiasach klamrowych
output = $"{hello}, {target}!";
Console.WriteLine(output);

//jeśli nie dodamy $ przed stringiem to nie zadziała
output = "{hello}, {target}!";
Console.WriteLine(output);


//jeśli chcemy wstawić znak { lub } w stringu to musimy go podwoić
//jeśli chcmy wstawić znak " w stringu to musimy go poprzedzić znakiem \ (escape character)
output = $"{{{hello}}}, \"{target}\"!";
Console.WriteLine(output);