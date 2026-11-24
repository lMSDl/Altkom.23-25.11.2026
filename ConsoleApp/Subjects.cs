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

        public static void Arrays()
        {
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



            array[0] = 31;
            array[1] = 2;
            array[2] = 15;
            Console.WriteLine($"{array[0]} {array[1]} {array[2]}");

            //Array - klasa statyczna, która zawiera metody do pracy z tablicami
            Array.Sort(array); //sortowanie tablicy rosnąco
            Console.WriteLine($"{array[0]} {array[1]} {array[2]}");

            Array.Reverse(array); //odwracanie tablicy
            Console.WriteLine($"{array[0]} {array[1]} {array[2]}");

            Array.Fill(array, -1); //wypełnianie tablicy wartością -1
            Console.WriteLine($"{array[0]} {array[1]} {array[2]}");

            Array.Fill(array, default); //wypełnianie tablicy wartością domyślną (0)
            Console.WriteLine($"{array[0]} {array[1]} {array[2]}");

            //zmiana rozmiaru tablicy
            //zmiana rozmiaru tablicy jest możliwa, jendak nie zalecana, ze względu na wydajność
            //ref - słowo kluczowe, które pozwala na przekazywanie referencji do zmiennej - jest potrzebne, aby funckcja mogła przepiąć adres tablicy na nową tablicę o większym rozmiarze
            Array.Resize(ref array, 5); //zmiana rozmiaru tablicy na 5
            array[4] = 20;
            array[3] = 25;
            Console.WriteLine($"{array[0]} {array[1]} {array[2]} {array[3]} {array[4]}");
        }

        public static void Split()
        {



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
        }

        public static void Lists()
        {

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
        }

        public static void IfElse()
        {
            Console.WriteLine("Podaj bok kwadratu:");
            string input = Console.ReadLine();

            int side;
            //int.TryParse - próbuje przekonwertować stringa na int'a
            //jeżeli się uda to zwraca true i przypisuje wartość do zmiennej out (w naszym przypadku side)
            //jeżeli się nie uda to zwraca false i zmienna out ma wartość domyślną
            //parametr out nie musi być zainicjalizowany przed wywołaniem metody i jest nazywany "parametrem wyjściowym"
            bool success = int.TryParse(input, out side);

            //if (!success)
            //if (success == false)
            if (success != true)
            {
                Console.WriteLine("Nieprawidłowa wartość");
            }
            else
            {

                //instrukcje warunkow - if, else
                //If sprawdza warunek w nawiasie (wynikiem operacji musi być bool) i jeśli jest prawdziwy to wykonuje blok kodu w klamrach
                //klamry + kod między klamrami to tak zwany "blok kodu" lub ciało funkcji / instukcji
                if (side > 0)
                {
                    int area = side * side;
                    Console.WriteLine($"Pole kwadratu o boku {side} wynosi: {area}");
                }
                //jeśli poprzedni warunek nie został spełniony to sprawdzamy kolejny warunek
                //else if - sprawdza kolejny warunek, jeśli poprzedni nie został spełniony i może występować wiele razy
                else if (side == 0)
                {
                    Console.WriteLine("Kwadrat nie istnieje");
                }
                //else - wykonuje blok kodu w przypadku, gdy nie wykona się żaden if
                else
                {
                    Console.WriteLine("Bok kwadratu nie może być ujemy");
                }
                //jeżeli używany else, to tylko jeden blok kodu zostanie wykonany i sprawdzanie warunków zakończy się w przypadku wejścia w któryś z bloków


                //jeżeli nie używany else, to każdy if będzie traktowany osobno i warunek będzie sprawdzany niezależnie
                //wniosek: else jest "łącznikiem" między kolejnymi if'ami
                if (side > 0)
                {
                    Console.WriteLine($"Kwadrat ma bok większ niż 0");
                }

                if (side > 5)
                {
                    Console.WriteLine($"Kwadrat ma bok większ niż 5");
                }


            }

            bool result;
            result = side == 0; // == - porównanie
            result = side != 0; // != - różne od / nierówność
            result = !(side == 0); // ! - negacja - odwrócenie wartości logicznej
            result = side > 0; // > - większe od
            result = side < 0; // < - mniejsze od
            result = side >= 0; // >= - większe lub równe
            result = side <= 0; // <= - mniejsze lub równe

            result = side == 0 || side > 0; // || - lub logiczne (OR) - sprawdza czy przynajmniej jeden warunek jest prawdziwy
            result = side < 10 && side >= 0; // && - i logiczne (AND) - sprawdza czy oba warunki są prawdziwe
        }

        public static void Switch()
        {

            string[] inputs = new string[3];
            Console.WriteLine("Podaj wartość A:");
            inputs[0] = Console.ReadLine();
            Console.WriteLine("Podaj wartość B:");
            inputs[1] = Console.ReadLine();
            Console.WriteLine("Podaj znak operacji:");
            inputs[2] = Console.ReadLine();

            float[] values = new float[2];
            bool[] canParse = new bool[2];

            canParse[0] = float.TryParse(inputs[0], out values[0]);
            canParse[1] = float.TryParse(inputs[1], out values[1]);

            if (!canParse[0] || !canParse[1])
            {
                Console.WriteLine("Nieprawidłowe wartości");
            }
            else
            {
                double result = 0;

                //switch - instrukcja warunkowa, która sprawdza wartość zmiennej (inputs[2]) i wykonuje odpowiedni blok kodu
                //case - blok kodu, który zostanie wykonany, jeżeli zmienna w switchu będzie miała wartość podaną w case
                //default - blok kodu, który zostanie wykonany, jeżeli żaden z case'ów nie będzie spełniony (odpowiednik else)
                //break - kończy działanie bloku kodu w case. Każdy case MUSI kończyć się break
                //wiele case'ów może prowadzić do jednego bloku kodu, ale nie można mieć dwóch takich samych case'ów
                switch (inputs[2])
                {
                    case "+":
                        result = values[0] + values[1];
                        break;
                    case "-":
                        result = values[0] - values[1];
                        break;
                    case "*":
                        result = values[0] * values[1];
                        break;
                    case "/":
                        result = values[0] / values[1];
                        break;
                    case "sqrt":
                        result = Math.Sqrt(values[0]);
                        break;
                    case "^":
                    case "pow":
                        result = Math.Pow(values[0], values[1]);
                        break;
                    case "log":
                        result = Math.Log(values[0], values[1]);
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowy znak operacji");
                        return; //kończy działanie metody, w której się znajdujemy
                }

                /*if (inputs[2] == "+")
                {
                    result = values[0] + values[1];
                }
                else if (inputs[2] == "-")
                {
                    result = values[0] - values[1];
                }
                else if (inputs[2] == "*")
                {
                    result = values[0] * values[1];
                }
                else if (inputs[2] == "/")
                {
                    result = values[0] / values[1];
                }
                else if (inputs[2] == "sqrt")
                {
                    result = Math.Sqrt(values[0]);
                }
                else if (inputs[2] == "^" || inputs[2] == "pow")
                {
                    result = Math.Pow(values[0], values[1]);
                }
                else if (inputs[2] == "log")
                {
                    result = Math.Log(values[0], values[1]);
                }
                else
                {
                    Console.WriteLine("Nieprawidłowy znak operacji");
                    return; //kończy działanie metody, w której się znajdujemy
                }*/


                Console.WriteLine($"Wynik: {result}");
            }


        }

        public static void While()
        {

            bool isRunning = true;


            //while - pętla która trwa gdy jej parametr jest true, parametr jest sprawdzany przed każdym wejściem do ciała pętli
            // jeśli przy pierwszym wejściu parametr będzie false, to pętla się nigdy nie wykona
            while (isRunning)
            //while(true) // pętla nieskończona
            {
                Console.Clear();
                Console.WriteLine("1. Introduction\n2. Strings\n3. Numbers\n4. Casting\n5. Arrays\n6. Lists\n7. If-Else\n8. Switch\n9. Exit");
                Console.WriteLine("Wybierz opcję (1-9):");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Subjects.Introduction();
                        break;
                    case "2":
                        Subjects.Strings();
                        break;
                    case "3":
                        Subjects.Numbers();
                        break;
                    case "4":
                        Subjects.Casting();
                        break;
                    case "5":
                        Subjects.Arrays();
                        break;
                    case "6":
                        Subjects.Split();
                        break;
                    case "7":
                        Subjects.IfElse();
                        break;
                    case "8":
                        Subjects.Switch();
                        break;
                    case "9":
                        //ustawiamy parametr pętli na false, aby zakończyć jej działanie
                        isRunning = false;
                        break;
                    //alternatywnie można użyć return; aby zakończyć działanie programu
                    //return;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór. Proszę spróbować ponownie.");
                        break;
                }

                Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować...");
                Console.ReadKey();
            }
        }

        public static void DoWhile()
        {

            bool isRunning;
            int counter = 0;

            //do-while - sprawdza warunek po wykonaniu ciała - zapewnia, że zostanie ono wykonane co najmniej raz
            //pozwala to wyeliminować inicjalizację zminnych sterujących pętą przed wejściem do pętli
            do
            {
                isRunning = true; // Inicjalizacja zmiennej sterującej pętlą
                Console.Clear();
                Console.WriteLine("1. Introduction\n2. Strings\n3. Numbers\n4. Casting\n5. Arrays\n6. Lists\n7. If-Else\n8. Switch\n9. Exit");
                Console.WriteLine("Wybierz opcję (1-9):");

                counter = counter + 1; // Zwiększenie licznika przy każdym przebiegu pętli
                                       //counter += 1; // Alternatywna forma zwiększenia licznika
                                       //counter++; // Jeszcze inna forma zwiększenia licznika

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Subjects.Introduction();
                        break;
                    case "2":
                        Subjects.Strings();
                        break;
                    case "3":
                        Subjects.Numbers();
                        break;
                    case "4":
                        Subjects.Casting();
                        break;
                    case "5":
                        Subjects.Arrays();
                        break;
                    case "6":
                        Subjects.Split();
                        break;
                    case "7":
                        Subjects.IfElse();
                        break;
                    case "8":
                        Subjects.Switch();
                        break;
                    case "9":
                        //ustawiamy parametr pętli na false, aby zakończyć jej działanie
                        isRunning = false;
                        break;
                    //alternatywnie można użyć return; aby zakończyć działanie programu
                    //return;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór. Proszę spróbować ponownie.");
                        break;
                }

                Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować...");
                Console.ReadKey();
            } while (isRunning && counter < 3);
        }

        public static void For()
        {
            //for(I; II; IV )
            //   { III; }

            //I - inicjalizacja pętli - wykonuje się tylko raz na początku
            //II - warunek kontynuacji pętli - wykonuje się przed każdym wykonaniem ciała
            //III - ciało pętli
            //IV - akcja po wykonaniu ciała - najczęściej inkrementacja licznika

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---");

            int value = 5;

            for (; value > 0; value--)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("---");


            value = 0;

            for (; value < 5;)
            {
                Console.WriteLine(value++); //pobranie wartości i inkrementacja
            }
            Console.WriteLine("---");

            value = 0;

            for (; value < 5;)
            {
                Console.WriteLine(++value); //inkrementacja i pobranie wartości
            }

            //przykład nieskończonej pętli for
            /*for(; ; )
            {
                   Console.WriteLine("Infinite loop");
            }*/



            Console.WriteLine("Napisz coś:");

            string? input = Console.ReadLine();
            string[] splitterInput = input.Split();

            for (int i = 0; i < splitterInput.Length; i++)
            {
                Console.WriteLine($"Element {i}: {splitterInput[i]}");
            }

            for (int i = 0; i < splitterInput.Length; i += 2)
            {
                Console.WriteLine($"Element {i}: {splitterInput[i]}");
            }
        }

        public static void Foreach()
        {



            Console.WriteLine("Napisz coś:");
            string? input = Console.ReadLine();
            string[] splitterInput = input.Split();


            //foreach zastępuje poniższy sposób iteracji po tablicy
            for (int i = 0; i < splitterInput.Length; i++)
            {
                string word = splitterInput[i];

                /*if(Random.Shared.Next(1, 10) % 2 == 0)
                {
                    i--;
                }*/
                Console.WriteLine($"Element: {word}");
            }


            //foreach - pozwala przejsc po wszystkich elementach tablicy
            foreach (string word in splitterInput)
            {
                Console.WriteLine($"Element: {word}");
            }


            //za pomocą for mamy dostęp do indeksu elementu
            //i możemy zmieniać jego wartość w tablicy
            for (int i = 0; i < splitterInput.Length; i++)
            {
                if (splitterInput[i] == "ala")
                    splitterInput[i] = "kot";

                Console.WriteLine(splitterInput[i]);
            }

            //foreach - pozwala wykonać jakąś operację na każdym elemencie tablicy
            //jednak za jego pomocą nie możemy zmieniać elementów tablicy
            foreach (string word in splitterInput)
            {
                Console.WriteLine(word);
            }
        }
    }


}
