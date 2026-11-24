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