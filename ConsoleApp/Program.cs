using ConsoleApp;


//Subjects.Introduction();
//Subjects.Strings();
//Subjects.Numbers();
//Subjects.Casting();
//Subjects.Arrays();
//Subjects.Split();



//tworzmy nowa listę stringów. Lista po initializacji jest pusta
//lista wykorzystuje parametry generyczne, czyli możemy określić typ danych, które będą w tej liście
List<string> listOfStrings = new List<string>();

//Inne sposoby inicjalizacji listy
//List<string> listOfStrings = new(); //skrócony sposób inicjalizacji bez potrzeby podawania typów (typ określany jest na podstawie deklaracji)
//List<string> listOfStrings = []; // utworzenie pustej listy stringów z zastosowaniem inicjalizatora kolekcji


Console.WriteLine("Liczba elementów na liście: " + listOfStrings.Count);

//dodajemy elementy do listy co spowoduje zwiększenie jej rozmiaru
listOfStrings.Add("Ala");
listOfStrings.Add("ma");
listOfStrings.Add("kota");

Console.WriteLine("Liczba elementów na liście: " + listOfStrings.Count);

//indekser działa podobnie jak w tablicach
Console.WriteLine(listOfStrings[0]);

listOfStrings[0] = "Marysia";
Console.WriteLine(listOfStrings[0]);


listOfStrings.Insert(2, "burego");//dodanie elementu na wskazaną pozycję - pozostałe elementy są przesuwane


Console.WriteLine("Liczba elementów na liście: " + listOfStrings.Count);
Console.WriteLine($"{listOfStrings[0]} {listOfStrings[1]} {listOfStrings[2]} {listOfStrings[3]}");


listOfStrings.Insert(0, "!");
listOfStrings.Insert(3, "!");
listOfStrings.Add("!");

Console.WriteLine("Liczba elementów na liście: " + listOfStrings.Count);

//usuwanie elementu z listy z wykorzystaniem indeksu
listOfStrings.RemoveAt(3);


//usuwanie elementu z listy z wykorzystaniem wartości
listOfStrings.Remove("burego");

//jeśli jest kilka takich samych elementów to usunięty zostanie tylko pierwszy
listOfStrings.Remove("!");

Console.WriteLine("Liczba elementów na liście: " + listOfStrings.Count);


int indexOfCat = listOfStrings.IndexOf("kota"); //zwraca indeks pierwszego wystąpienia elementu na liście

Console.WriteLine(listOfStrings[indexOfCat]);

//jeśli nie ma takiego elementu to zwraca -1
indexOfCat = listOfStrings.IndexOf("kot");
Console.WriteLine(indexOfCat);