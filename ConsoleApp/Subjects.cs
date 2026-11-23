namespace ConsoleApp
{
    public class Subjects
    {
        public static void Introduction()
        {
            //w C# instrukcje kończymy średnikiem
            //odwołujemy się do konsoli w celu wywołania funkcjonalności wypisania pojedynczej linii tekstu, który jest przekazany jako parametr wewnątrz nawiasów
            //kropka jest operatorem dostępu, który pozwala na dostęp do członów Console
            //metoda - zachowanie, które w zapisie zawsze związane jest z nawiasami
            Console.WriteLine("Hello, World!"); //wypisuje tekst na konsole i na końcu dodaje znak nowej linii (stawia "enter")

            Console.Write("Hello"); //wypisuje tekst na konsole bez dodawania znaku nowej linii (nie stawia "enter")
            Console.Write(", ");
            Console.WriteLine("World!");

            //Console.ReadLine(); //wstrzymuje działanie programu do momentu wciśnięcia klawisza "enter" przez użytkownika

            //deklaracja zmiennej o typie string (ciąg/łańcuch znaków) i nazwie helloVariable
            string helloVariable;

            //Console.WriteLine(helloVariable); //wypisuje wartość zmiennej helloVariable na konsolę, ale ponieważ nie została ona zainicjalizowana, to spowoduje błąd kompilacji

            //inicjalizacja zmiennej - pierwsze przypisanie wartości za pomocą operatora przypisania (=)
            helloVariable = "Hi";

            //przekazujemy naszą zmienną jako parametr funkcji
            Console.WriteLine(helloVariable); //wypisuje wartość zmiennej helloVariable na konsolę, czyli "Hi"

            //zmiana wartości zmiennej helloVariable na wartość wprowadzoną przez użytkownika w konsoli
            helloVariable = Console.ReadLine(); //przypisuje do zmiennej helloVariable wartość wprowadzoną przez użytkownika w konsoli
            Console.WriteLine(helloVariable);

            //deklaracja z inicjalizacją jako pojedyncza instrukcja
            string target = "Tom";
            Console.WriteLine(target);
        }

        public static void Strings()
        {

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

            string stringValue = "ala ma kota";
            int length = stringValue.Length; //długość stringa, czyli liczba znaków w stringu

            stringValue = $"Długość dotychczasowej zawartości stringa wynosi {length} znaków.";
            Console.WriteLine(stringValue);

            //length trzyma wartość pierwszego przypisania mimo, że stringValue został zmieniony, ponieważ length jest typu int, a nie string. int jest typem wartościowym, więc po przypisaniu wartości do length, length trzyma kopię wartości, a nie referencję do stringValue. Dlatego length nie zmienia się po zmianie stringValue.
            //dopiero odkomentowanie poniższej linii spowoduje, że length będzie trzymał aktualną długość stringValue
            //length = stringValue.Length;
            stringValue = $"Długość dotychczasowej zawartości stringa wynosi {length} znaków.";
            Console.WriteLine(stringValue);


            string stringValue2 = stringValue.Replace("dotychczasowej", "aktualnej");
            Console.WriteLine(stringValue2);

            //funkcja Replace jest case sensitive, czyli rozróżnia wielkość liter
            stringValue2 = stringValue.Replace("DotyChczAsowej", "aktualnej");
            Console.WriteLine(stringValue2);

            stringValue2 = stringValue.Replace("DotyChczAsowej", "aktualnej", StringComparison.InvariantCultureIgnoreCase); //CurrentCultureIgnoreCase - porównanie bez uwzględniania wielkości liter
            Console.WriteLine(stringValue2);

            stringValue2 = stringValue.Substring(3); //Substring - metoda, która zwraca część stringa od podanego indeksu do końca stringa
            Console.WriteLine(stringValue2);

            stringValue2 = stringValue.Substring(3, 10); //drugi parametr to liczba znaków, które mają zostać zwrócone, czyli od indeksu 3 zwróci 10 znaków
            Console.WriteLine(stringValue2);

            stringValue2 = stringValue.Substring(3, stringValue.Length - 5 - 3); //odejmujemy 3 znaki od początku i 5 znaków od końca, aby zwrócić część stringa
            Console.WriteLine(stringValue2);


            string firstString = "ala ma kota";
            string secondString = "Ala ma kota";

            bool areEqual; //zmienna typu bool (prawda/fałsz) - przechowuje wartość logiczną

            areEqual = firstString == secondString; //porównanie stringów za pomocą operatora porównania ==, który porównuje wartości stringów
            Console.WriteLine("Porównanie stringów \"ala ma kota\" i \"Ala ma kota\" za pomocą operatora ==: " + areEqual);

            areEqual = firstString.Equals(secondString); //porównanie stringów za pomocą metody Equals, która porównuje wartości stringów
            Console.WriteLine("Porównanie stringów \"ala ma kota\" i \"Ala ma kota\" za pomocą metody Equals: " + areEqual);

            areEqual = string.Equals(firstString, secondString); //metoda string.Equals potrafi obsłużyć wartości null, więc nie spowoduje błędu w przypadku, gdyby któryś ze stringów był null
            Console.WriteLine("Porównanie stringów \"ala ma kota\" i \"Ala ma kota\" za pomocą metody string.Equals: " + areEqual);

            //porównanie za pomocą metody string.Equals z parametrem StringComparison.OrdinalIgnoreCase - porównanie bez rozróżniania wielkości liter
            areEqual = firstString.Equals(secondString, StringComparison.InvariantCultureIgnoreCase);
            Console.WriteLine("Porównanie stringów \"ala ma kota\" i \"Ala ma kota\" za pomocą metody Equals z parametrem StringComparison.InvariantCultureIgnoreCase: " + areEqual);

            string name = Console.ReadLine();
            Console.WriteLine($"*{name}*");
            Console.WriteLine($"*{name.Trim()}*");
            Console.WriteLine($"*{name.TrimEnd()}*");
            Console.WriteLine($"*{name.TrimStart()}*");

            //możemy też sparametryzować, które znaki mają być usunięte
            Console.WriteLine($"*{name.Trim('a')}*"); //pojedynczy znak zaposujemy w apostrofach, a ciąg znaków w cudzysłowach


            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.ToUpper()); //metoda ToLower i ToUpper - zmieniają wielkość liter w stringu

            areEqual = firstString.ToLower() == secondString.ToLower();
            Console.WriteLine("Porównanie stringów \"ala ma kota\" i \"Ala ma kota\" za pomocą operatora == po zamianie na małe litery: " + areEqual);
        }
    }
}
