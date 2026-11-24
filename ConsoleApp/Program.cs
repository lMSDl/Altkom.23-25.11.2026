using ConsoleApp;


//Subjects.Introduction();
//Subjects.Strings();
//Subjects.Numbers();

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