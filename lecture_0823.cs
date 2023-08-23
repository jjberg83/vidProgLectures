Console.WriteLine("Hello, World!");

var s = new Student("001", "John");
var t = new Teacher("Jane");
// s = t; vil føre til error, siden de er to forskjellige subclasses
// spiller ingen rolle om de har samme parent.

Console.WriteLine(s);
Console.WriteLine(t);

var people = new List<Person>();
people.Add(s);
people.Add(t);

/*
I foreach loopen under har man mange instanser av Person klassen, som enten
kan få tildelt student eller teacher subclassen. I linjen med defensive cast:
hvis man er kommet over en teacher i aktuell iterasjon, vil denne returnere null.
Hvis ikke, blir den iallefall ikke null, og man vil gå inn i if en.
I explicit cast linjen sier vi "jeg VET at dette er en student".
Betyr ikke nødvendigvis at vi har rett. Viktig med følgende syntaks:
((Student)person).Alt inni den ytterste parentesen, må kjøres før dotten.

*/
foreach (var person in people)
{
    var student = person as Student; //defensive cast
    if (student != null)
    {
        // student.StudentId = "1";
        ((Student)person).StudentId = "1"; //explicit cast
    }
    Console.WriteLine(person);
}

public class Student : Person
{
    public Student(string studentId, string name) : base(name)
    {
        StudentId = studentId;
    }

    public string StudentId { get; set; } = "0";
    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Id: {StudentId}";
    }
}

public class Teacher : Person
{
    public Teacher(string name) : base(name)
    {
    }
}
public class Person
{
    // ? under sier at denne propertien KAN være Null, og vi vil derfor ikke få feilmeldinger om den er det.
    // public string? Name { get; set; } = "";
    public string Name { get; set; } = "";
    public int Age { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    // Alle klasser og objekter har sin egen ToString Metode
    // ved å bruke override som nedenfor, kan jeg skape min egen
    // variant av hva som skjer når jeg putter en instans av klassen
    // person inn i Console.WriteLine()
    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }

    
    public record Address(string Street, string PostalNo, string PostalPlace);
    public record PhoneNumber(string CountryCode, string Number);
}

// ANDRE NOTATER OG DISKRESJONER
/*
Fragmentering av disk er når filer deles opp og lagres på forskjellige plasser på harddisk.
Defragmentering er det motsatte, når alt samles sammen, er veldig bra for reading speeds.

String initialiserer seg som null (derfor reference type), men oppfører seg som valuetype.

Hadde jeg brukt denne...
public string? Name { get; set; } = "";
Kunne jeg fått problemer med følgende sjekk
if (p.Name.Length == 0)       
fordi jeg prøver å sjekke lengden på noe som KAN være null

if (p.Name?.Length == 0)   ?. syntaksen sjekker først om den er null, i så fall returnerer den null
Man får altså ingen error her 

if (p.Name!.Length == 0) !. syntaksen sier, "Jeg vet hva jeg gjør, så bare gjør som jeg sier for faen"
, selv om errors fortsatt kan skje

p.Name ??= "John";        
betyr: IF name is null, set it to John

var yourName =  p.Name ?? "Empty"
betyr: returnn p.Name, but if it is null, return alt etter ??
Kalles null coalescing operator

Records er kjappe måter å lage lightweight klasser
Det er det samme som å skape en klasse med properties med getters og setters
pluss en konstruktør. De krever at man legger inn verdier for properties i selve
skapelsen (de kan ikke endres etterpå, de er immutable, som kan være en fordel
når man ikke VIL at de skal kunne forandre seg.).Records er såkalte value objects.
En annen greie med records vs klasser, er at records har automatisk overskrevet sin 
egen ToString() metode (den som kjøres på objektet når man putter det inn i Console.WriteLine).
Derfor får man forskjell når man skriver
Console.WriteLine(enKlasseInstants)
Console.WriteLine(enRecordInstants)

get 
init 
set
Man kan kun ha en init, eller en set. Init står for initialize, og gjør objekter immutable.
Når man setter verdier for fields/properties i skapelsen av instansen, vil de forbli sånn
til dommedag. Man kan ikke endre dem. Set er jo det som gjør at man kan endre dem, men 
bruker man den kan man ikke bruke init samtidig. 

Konstrutører er nyttige fordi det kan settes krav til at noen argumenter må legges
inn når man skaper en instant.
Man kan lage 2 konstruktører for en klasse slik:

    public Person(string name)
    {
        Name = name;
    }

    public Person(string firstName, string lastName)
    {
        Name = $"{firstName} {lastName}";
    }

Her sier man at enten har personen bare et langt navn som en parameter,
eller så har de et klart definert førstenavn, og et klart definert andre navn.

var address2 = new Address("Street", "0028", "Place");
Så lenge man kun skal lagre postnummeret her, kan man like greit beholde det som en 
string. Kun gjør det om til et tall hvis man skal gjøre matematiske operasjoner på det. 

Når det gjelder inheritance, må child instanser ha konstruktører hvis parent har det, slik:
public class Student : Person
{
    public Student(string studentId, string name) : base(name)
    {
        StudentId = studentId;
    }


Console.WriteLine(p1 == p2); 
Console.WriteLine(address1 == address2);
NÅr man sammenligner p1 og p2 (fra Person klassen, sammenlikner adressen), og de vil bli false 
fordi det er 2 forskjellige instanser med to forskjellige adresser.
Når man sammenlikner 2 records, sammenliknes fieldsene deres. Så selv om de to forskjellige
instansene har ulike adresser, vil dette bli true hvis de har like verdier i fieldsene.
Er vel derfor de er value objects. 

Kommandoer på Terminal

dotnet add package <Pakken>
Han viste spectre.console, en pakke som gjør at man kan gjør kule, visuelle ting i konsollen,
som å lage en bar som fylles opp jo nærmere man kommer slutten av timen.

En fordel med lambdas er visst at man kan få tilgang til ting utenfor funksjonens scope.
*/