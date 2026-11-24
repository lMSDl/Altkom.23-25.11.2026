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

        public static void Numbers()
        {

            string sa = "11";
            string sb = "4";
            string sc = sa + sb; //łączenie stringów za pomocą operacji + (konkatenacja) - wynik będzie "114" ponieważ 11 i 4 są traktowane jako tekst
            Console.WriteLine(sc);

            //int - typ całkowity 32-bitowy, czyli liczby całkowite
            //long - typ całkowity 64-bitowy, czyli liczby całkowite o większym zakresie
            int a = 11;
            int b = 4;

            // w przeciwieńśtwie do konkatenacji stringów, operacje na liczbach całkowitych (int) będą wykonywane matematycznie
            int c = a + b;
            Console.WriteLine($"{a} + {b} = {c}");
            c = a - b;
            Console.WriteLine($"{a} - {b} = {c}");
            c = a * b;
            Console.WriteLine($"{a} * {b} = {c}");
            c = a / b; //dzielenie całkowite, czyli wynik jest ucinany do liczby całkowitej (nie zaokrąglany!)
            Console.WriteLine($"{a} / {b} = {c}");
            c = a % b; //modulo - reszta z dzielenia
            Console.WriteLine($"{a} % {b} = {c}");

            //łączenie stringów i liczb całkowitych (int) za pomocą operacji + (konkatenacja) - wynik będzie "2114" ponieważ 2, 11 i 4 są traktowane jako tekst
            Console.WriteLine($"2 + {sa} + {b} = {2 + sa + b}");
            //kolejność ma znaczenie - najpierw sumowanie liczb całkowitych (int), a potem konkatenacja stringów
            Console.WriteLine($"2 + {a} + {sb} = {2 + a + sb}");

            //float - typ zmiennoprzecinkowy 32-bitowy, czyli liczby z częścią dziesiętną (z przecinkiem)
            //double - typ zmiennoprzecinkowy 64-bitowy, czyli liczby z częścią dziesiętną, ale o większej precyzji
            float fa = 11;
            float fb = 4.0f;

            float fc = fa + fb;
            Console.WriteLine($"{fa} + {fb} = {fc}");
            fc = fa - fb;
            Console.WriteLine($"{fa} - {fb} = {fc}");
            fc = fa * fb;
            Console.WriteLine($"{fa} * {fb} = {fc}");
            fc = fa / fb; //dzielenie zmiennoprzecinkowe, czyli wynik jest z częścią dziesiętną
            Console.WriteLine($"{fa} / {fb} = {fc}");


            fc = a / b; //fc = 2
            Console.WriteLine($"{a} / {b} = {fc}");

            fc = a / fb; //fc = 2.75
            Console.WriteLine($"{a} / {fb} = {fc}");

            //aby wymusić wykonanie operacji dzielenia na floatach, musimy przynajmniej jedną z liczb "przekonwertować" na float
            //możemy tego dokonać korzystając z faktu, że wynik operacji między dwoma typami jest typu o większej prezycji oraz z kolejności działań
            fc = 1f * a / b;//fc = 2,75
            Console.WriteLine($"{a} / {b} = {fc}");

            //lub przez rzutowanie jednej z liczb na float (czyli potraktowanie zmiennej jako inny typ)
            //w tym przypadku zmienna a jest rzutowana na float, więc wynik operacji będzie typu float
            fc = (float)a / b;
            Console.WriteLine($"{a} / {b} = {fc}");


            //koljeność działań zgodna z matematyką
            c = a + a * a;
            Console.WriteLine($"{a} + {a} * {a} = {c}"); //kolejność działań - najpierw mnożenie, potem dodawanie
            c = (a + a) * a;
            Console.WriteLine($"({a} + {a}) * {a} = {c}");


            Console.WriteLine($"byte min:{byte.MinValue} max: {byte.MaxValue}");
            Console.WriteLine($"ushot min:{ushort.MinValue} max: {ushort.MaxValue}");
            Console.WriteLine($"uint min:{uint.MinValue} max: {uint.MaxValue}");
            Console.WriteLine($"ulong min:{ulong.MinValue} max: {ulong.MaxValue}");

            Console.WriteLine($"short min:{short.MinValue} max: {short.MaxValue}");
            Console.WriteLine($"int min:{int.MinValue} max: {int.MaxValue}");
            Console.WriteLine($"long min:{long.MinValue} max: {long.MaxValue}");


            Console.WriteLine($"float min:{float.MinValue} max: {float.MaxValue}");
            Console.WriteLine($"double min:{double.MinValue} max: {double.MaxValue}");
            Console.WriteLine($"decimal min:{decimal.MinValue} max: {decimal.MaxValue}");

            Console.WriteLine((float)long.MaxValue);
            Console.WriteLine((double)long.MaxValue);
            Console.WriteLine((decimal)long.MaxValue);
            Console.WriteLine(decimal.MaxValue / 10m - 0.1m);

            Console.WriteLine(5 / 3.3f); //f - float
            Console.WriteLine(5 / 3.3d); //d - double (domyślnie jeśli nie podamy sufiksu np. 3.3)
            Console.WriteLine(5 / 3.3m); //m - decimal

            //Math - klasa statyczna, która zawiera metody matematyczne i stałe jak np. PI
            double result = Math.Pow(3, 5f);

            //domyślne zachowanie funkcji zaokrąglającej powoduje zaokrąglanie do wartości parzystej - Banker's Rounding
            Console.WriteLine(Math.Round(2.5));
            Console.WriteLine(Math.Round(3.5));

            //Conventional Rounding
            Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero));
            Console.WriteLine(Math.Round(3.5, MidpointRounding.AwayFromZero));

            Console.WriteLine(Math.Round(3.52250, 3));
            Console.WriteLine(Math.Round(3.52250, 3, MidpointRounding.AwayFromZero));



            Console.WriteLine("Podaj pierwszy bok prostokąta:");
            string sizeA = Console.ReadLine();
            Console.WriteLine("Podaj drugi bok prostokąta:");
            string sizeB = Console.ReadLine();


            float floatSizeA = float.Parse(sizeA); //konwersja string na float
            float floatSizeB = float.Parse(sizeB);
            Console.WriteLine($"Pole prostokąta to {floatSizeA * floatSizeB}");

            int intSizeA = int.Parse(sizeA);
            int intSizeB = int.Parse(sizeB);
            Console.WriteLine($"Pole prostokąta to {intSizeA * intSizeB}");


            float number = 9.12345f;
            double roundedNumber = Math.Round(number, 2);

            string roundedNumberString = roundedNumber.ToString(); //formatowanie liczby zmiennoprzecinkowej do stringa z dwoma miejscami po przecinku
            Console.WriteLine(roundedNumberString);

            //metoda ToString() - konwertuje liczbę na stringa i przyjmuje jako argument format
            //formaty:
            //f - format liczby zmiennoprzecinkowej
            //0 - placeholder dla cyfry, jeśli liczba jest mniejsza niż 1 to zostanie dodane 0 przed przecinkiem
            //# - opcjonalny placeholder dla cyfry, jeśli liczba jest mniejsza niż 1 to nie zostanie dodane 0 przed przecinkiem
            //. - separator dziesiętny
            //, - separator tysięcy


            Console.WriteLine(number.ToString("f3"));   //liczba z trzema miejscami po przecinku
            Console.WriteLine(number.ToString("f2"));   //liczba z dwoma miejscami po przecinku

            Console.WriteLine(number.ToString("0.00"));
            Console.WriteLine(number.ToString("00.00"));

            Console.WriteLine(number.ToString("0.00#######"));
            Console.WriteLine(number.ToString("0.000000000"));

            number = 123123123;
            Console.WriteLine(number.ToString("### ### ###")); //separatorem jest spacja
            Console.WriteLine(number.ToString("###,###,###")); //separatorem jest ustawienie z kultury (np. przecinek w USA, spacja w Polsce)

            //to samo można zrobić z interpolacją stringów
            Console.WriteLine($"{number:f2}");
            Console.WriteLine($"{number:0.00}");
            Console.WriteLine($"{2:0.00}");
            Console.WriteLine($"{number:0.##}");
            Console.WriteLine($"{2:0.##}");
            Console.WriteLine($"{2:0.0#}");

            number = 1f / 3;
            Console.WriteLine(number.ToString("0#.00")); //liczba z zerem wiodącym i dwoma miejscami po przecinku (twardymni)
            Console.WriteLine($"{number:0#.##}"); //liczba z zerem wiodącym i dwoma miejscami po przecinku (miękkimni)
        }

        public static void Casting()
        {
            int intValue = 5;
            long longValue = intValue;

            Console.WriteLine(longValue);


            //błąd kompilacji, ponieważ zakres intValue jest mniejszy niż longValue
            //intValue = longValue;

            intValue = (int)longValue; // rzutowanie jawne, pozwala nam na przypisanie wartości long do int
            Console.WriteLine(intValue);


            longValue = 345678908765434567L; // L na końcu oznacza, że to jest long

            intValue = (int)longValue;
            Console.WriteLine(longValue);
            Console.WriteLine(intValue);

            Console.WriteLine("---");
            Console.WriteLine(int.MaxValue);
            longValue = int.MaxValue + 1L;
            intValue = (int)longValue;
            Console.WriteLine(longValue);
            Console.WriteLine(intValue);

            Console.WriteLine("---");
            longValue = (long)int.MaxValue + int.MaxValue + 2;
            intValue = (int)longValue;
            Console.WriteLine(longValue);
            Console.WriteLine(intValue);


            Console.WriteLine("---");
            float floatValue = 4.5f;
            double doubleValue = floatValue;
            Console.WriteLine(doubleValue);

            doubleValue = 0.33333333333333;
            floatValue = (float)doubleValue;
            Console.WriteLine(doubleValue);
            Console.WriteLine(floatValue);

            doubleValue = double.MaxValue;
            floatValue = (float)doubleValue;
            Console.WriteLine(doubleValue);
            Console.WriteLine(floatValue);


            float a = 3.3333333f;

            a = (float)Math.Pow(a, 2);
            Console.WriteLine(a);
        }
    }
}
