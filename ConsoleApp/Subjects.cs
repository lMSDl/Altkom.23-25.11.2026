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
    }
}
