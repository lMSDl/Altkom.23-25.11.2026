using ConsoleApp;


//Subjects.Introduction();
//Subjects.Strings();


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