using ConsoleApp;


//Subjects.Introduction();
//Subjects.Strings();
//Subjects.Numbers();
//Subjects.Casting();



int a = 5;
int b = 10;
int c = 15;


//deklaracja tablicy przechowującej dane typu int
//[] - oznacza tablicę
int[] array;

//inicjalizacja tablicy o rozmiarze 3
//new - słowo kluczowe do tworzenia nowych obiektów
//tablica jest wypełniona domyślnymi wartościami, czyli dla int jest to 0
array = new int[3];


//odwołujemy się do elementów tablicy za pomocą indeksów
//indeksy zaczynają się od 0, więc pierwszy element ma indeks 0
Console.WriteLine(array[0]);
Console.WriteLine(array[1]);
Console.WriteLine(array[array.Length - 1]); //wyświetlamy ostatni element tablicy (pod indeksem: długość-1)

//odwołując się do indeksu, który nie istnieje, otrzymamy błąd
//Console.WriteLine(array[4]);

//zmiana wartości elementu tablicy
array[0] = 1;
array[1] = b;
array[2] = c;

b = 7; //modyfikujemy zmienną b, ale nie zmienia to wartości w tablicy, ponieważ tablica przyjmuje wartość b, a nie odniesienie do zmiennej b
Console.WriteLine(array[0]);
Console.WriteLine(array[1]);
Console.WriteLine(array[2]);
Console.WriteLine(b);


Console.WriteLine($"Tablica ma rozmiar {array.Length}");


string text = "Hello, World!"; //string jest tablicą znaków (char)
Console.WriteLine(text[4]);


string[] inputs = new string[2];
Console.WriteLine("Podaj pierwszy bok prostokąta:");
inputs[0] = Console.ReadLine();
Console.WriteLine("Podaj drugi bok prostokąta:");
inputs[1] = Console.ReadLine();


float[] sides = new float[inputs.Length];
sides[0] = float.Parse(inputs[0]);
sides[1] = float.Parse(inputs[1]);


Console.WriteLine($"Pole prostokąta to {sides[0] * sides[1]}");