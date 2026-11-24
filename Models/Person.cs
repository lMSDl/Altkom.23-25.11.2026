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
}


//}
