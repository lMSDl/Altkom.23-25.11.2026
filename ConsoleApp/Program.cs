using ConsoleApp;


//Subjects.Introduction();
//Subjects.Strings();
//Subjects.Numbers();
//Subjects.Casting();
//Subjects.Arrays();
//Subjects.Split();


Console.WriteLine("Podaj bok kwadratu:");
string input = Console.ReadLine();

int side = int.Parse(input);

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

if(side > 5)
{
    Console.WriteLine($"Kwadrat ma bok większ niż 5");
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

