/*
Her følger eksempel på encapsulation inni klasser:

class Person {
    public string FirstName;

    private string _lastName;
    public string LastName {
        get {
            return _lastName;
        }
        set {
            _lastName = value.Trim();
        }
    }

    public int Age { get; private set;}

    public void SetAge(int age) {
         Age = age;
    }
}

På linje 12 og 13 trimmer han vekk white space. Dette er funsjonalitet
som skjer skjult for brukeren. 

Hver gang en funksjon kalles, får man en ny stack tildelt. Når funksjonen
er ferdig, ødelegges stacker, og derfor også alle dens lokale variabler.

Garbage collectior kvitter seg med objekter på HEAPen som ikke lenger
blir pekt på av noen variabler på STACKen.

Reference types får ikke default verdier, men bruker man ikke new i skapelsen
, får man en null pointer (altså har man en variabel på stack, som ikke peker
til noe på HEAP enda, fordi man ikke har tildelt plass til det på HEAP).

Person otherPerson;       Her har man glemt å initialisere
otherPerson.FirstName = "Jane";

var persons = new List<Person>()
<  > kalles generics
Les dette som Liste som inneholde Person instanser

Kan også brukes på funksjoner, eller klasser, som under (T er norm for Type):
class Container<T> {
    public T Value { get; set; }
}

var c = new Container<int>();
c.Value = 42;

var cs = new Container<string>();
cs.Value = "Hello";

var cp = new Container<Person>();
cp.Value = new Person() { FirstName = "John" };

Poenget er at klassen kan ta imot forskjellige typer, alt etter hva man setter det til 
inni < > boksen.

Helt nederst har vi syntaksen på hvorfor strings er reference types, men oppfører
seg som value types.

*/