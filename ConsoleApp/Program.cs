using ConsoleApp;


//Subjects.Introduction();
//Subjects.Strings();
//Subjects.Numbers();
//Subjects.Casting();
//Subjects.Arrays();
//Subjects.Split();
//Subjects.IfElse();
//Subjects.Switch();


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