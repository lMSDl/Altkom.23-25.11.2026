//namespace - przestrzeń nazw, która grupuje klasy i inne typy; można powiedzieć jak folder w systemie plików
//namespace zaciągamy używając "using"
namespace Models; // namespace ograniczają klamry, jednak jeśli zastosujemy średnik (;), to namespace stosowany jest do końca pliku
//{


//public - modyfikator dostępu - oznacza, że z klasy można korzystać wszędzie
//internal - modyfikator dostępu - oznacza, że z klasy można korzystać tylko w projekcie "rodzimym"
//brak modyfikatora dostępu oznacza zastosowanie modyfikatora o najwyższym poziomie ochrony (w przypadku klasy to internal)

//class - szablon opisujący zachowania/metody i cechy/stany obiektów (instancji klas), które są wytwarzane na jej podstawie

// <modyfikator dostępu> class <nazwaKlasy>
//pełna nazwa klasy to <namespace>.<nazwa>
public class Person
{
    //pole klasy (field) - to zmienna, która przechowuje stan obiektu
    //private - oznacza dostęp tylko dla elementów danej klasy (inne dostępne: public/internal/protected)
    //pola zazwyczaj są prywatne ze względu na hermetyzację, a dostęp realizowany jest przez metody dostępowe (getter i setter)
    //private string name; //nazwy pól zaczynamy od małej litery
    //string typ zmiennej, który przechowuje tekst (ciąg znaków)
    private string _name; //jednak zalecane jest by prywatne pola zaczynały się od podkreślenia, aby odróżnić je od parametrów metod i zmiennych lokalnych


    //getter - do pobierania wartości pola - metoda nie przyjmuje parametrów, a zwraca wartość pola
    //nazwa zwyczajowa to Get + nazwa pola
    //string - typ zwracany przez metodę, musi być zgodny z typem pola
    public string GetName()
    {
        //instukcja zwracająca wynik działania metody - obowiązkowy gdy zadeklarowaliśmy, że klasa coś zwraca (jest inna niż void)
        return _name; //zwracamy wartość pola _name
    }

    //setter - do ustawiania wartości pola - metoda przyjmuje parametr, który zostaje wpisany w odpowiednie pole (można dodać kod "obróbki danych")
    public void SetName(string name)
    {
        //_name = name; //przypisujemy wartość parametru name do pola _name
        //this.name = name; //jeśli pole nazywa się tak samo jak parametr metody, to musimy użyć this aby je rozróżnić (this.name oznacza pole klasy, a name oznacza parametr metody)
        _name = name.ToUpper(); //przykład "obróbki danych": przypisujemy wartość parametru name do pola _name, ale najpierw zamieniamy ją na wielkie litery
    }

    //Property - właściwość - pole z automatycznym generowaniem getterów i setterów

    //auto-property - właściwość automatyczna - pole jest generowane automatycznie przez kompilator
    //jest możliwość ograniczenia modyfikatora dostępu dla getter lub setter (osobno)
    public string LastName { /*private*/ get;  set; }


    private int _age; //backfield do full-property - pozwala na dodatkowy kod w setterze i getterze

    //full-property - właściwość pełna - pole jest tworzone przez programistę, a getter i setter są jawne i można je modyfikować
    public int Age
    {
        get
        {
            return _age; //zwracamy wartość pola _age
        }

        set
        {
            if (value < 0)
                _age = 0;
            else
                _age = value; //value - domyślna nazwa parametru w setterze property
        }
    }


    public long PESEL

    {
        get
        {
            return field; //field - domyślna nazwa pola w full-property
        }

        set
        {
            field = value; //value - domyślna nazwa parametru w setterze property
        }

    }

    //<modyfikator dostępu> <typ zwracany> <nazwa metody>()
    //metody mogą zwracać rezultat swojej pracy (typ zwracany), mogą przyjmować parametry (argumenty)
    public string GenerateBio()
    {
        string bio = $"Name: {GetName()}, Last Name: {LastName}, Age: {Age}";
        return bio;
    }

    //metody void nie zwracają niczego, a ich zadaniem jest wykonanie jakiejś operacji na składnikach klasy
    public void ChangeNamesToTitleCase()
    {
        // _name = _name.Substring(0, 1).ToUpper() + _name.Substring(1).ToLower();
        // LastName = LastName.Substring(0, 1).ToUpper() + LastName.Substring(1).ToLower();


        _name = ToTitleCase(_name);
        LastName = ToTitleCase(LastName);
    }

    //metody prywatne są dostępne tylko w obrębie danej klasy
    //prywatne metody są wykorzystywane do realizacji zadań pomocniczych i uniknięcia powtórzeń kodu
    private string ToTitleCase(string text)
    {
        return text.Substring(0, 1).ToUpper() + text.Substring(1).ToLower();
    }
}


//}
