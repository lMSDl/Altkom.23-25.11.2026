using ConsoleApp;


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



Console.WriteLine("Podaj liczby rozdzielając je spacją:");
string input = Console.ReadLine();


List<int> ints = new List<int>();

string[] splittedInput = input.Split();
foreach (string number in splittedInput)
{
    //int result;
    if (int.TryParse(number, out int result)) //deklaracja podczas przekazywania parametru wyjściowego
    {
        ints.Add(result);
    }
}


int accumulator = 0;
for (int counter = 0; counter < ints.Count; counter++)
{
    int value = ints[counter];

    if (value % 2 != 0)
    {
        continue; //przerywa aktualną iterację i przeskakuje do następnej iteracji pętli
    }

    accumulator += value;

    if (accumulator >= 100)
    {
        Console.WriteLine($"Wykorzystano {counter + 1} wartości by osiągnąć wynik 100");
        break; //przerywa działanie pętli
    }
}