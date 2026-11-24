using ConsoleApp;


//Subjects.Introduction();
//Subjects.Strings();
//Subjects.Numbers();
//Subjects.Casting();
//Subjects.Arrays();
//Subjects.Split();




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

