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

for(int i = 0; i < splitterInput.Length; i++)
{
    Console.WriteLine($"Element {i}: {splitterInput[i]}");
}

for (int i = 0; i < splitterInput.Length; i += 2)
{
    Console.WriteLine($"Element {i}: {splitterInput[i]}");
}