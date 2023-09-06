/*
Software is a constrained form of literature that communicates concepts
from programmer to programmer, which is also executable by machines.

Fordel med interfaces i forhold til klasser og inheritance, er at en klasse
kan IMPLEMENTERE flere interfaces.
Les: "Klassen kan act as this interface, or this interface etc"

DI er del av et større konsept, kalt Inversion of Control. 
Når man har kontroll, styrer man showet og programflowen fra Main.
Når man har IOC, tar en tredjepart (framework) over, og har kontroll over lifecyclen (og alt annet)
til elementene jeg trenger. 

3 basic lifecycles of dependency (dette blir essensielt når man driver med concurrency)
- Singleton er et pattern der man kun kan ha EN instans i minnet (singleton deles mellom alle threads, derfor risky å bruke i multithreaded environments)
- Transient er et pattern som gir ny instans hver gang den blir etterspurt
- Scoped oppfører seg som begge de over. De er transients, men i sitt scope, er de singleton (man får samme instans). Scopet i en 
   web app er som regel en HTTP request. HTTP request oppfører seg som enkle threads, og har samme scope. Scope bør være default 
   i web apper.

Thread: multiple paths of executions that APPEAR to run at the same time.
Han kommer inn på forskjellen mellom concurrency (scheduler switcher for EN cpu)
og parallelism (hver thread per cpu).

DIP - dependency iversion principle
Har noe med detaljer vs abstractions å gjøre.

DI og interface eks:

EmailSender(IEmailClient client) 
{
    client.Send(email)
}

Man lager 2 implementasjoner, en Fake som logger til konsollen, og en ekte, som faktisk sender emailen. 

FakeEmailClient : IEmailClient
SMTPEmailClient : IEmailClient
TredjepartsEmailClient : IEmailClient

I utviklingsfasen bruker sier man i serviceContainer at IEmailClient skal implementeres med FakeEmailClient.
I produskjon skifter man til SMTPEMailClient. I andre situasjoner bruker man TredjePartsEmailClient. Man trenger 
ikke skifte noen kode noen andre plasser enn i container. 

I stedet for å lagre hver email man sender i en database, kan man gjøre følgende:
(dette kalles decorator pattern)
Legg merke til at man wrapper en IEmailClient inni en annen IEmailClient

EmailLogger(IEmailClient c ) : IEmailClient
{
    Send(noe)
        // Log Email
        c.Send(noe)
        // Log Success/Failure
}

Single responsibility principle (SRP)
Hver kode bør gjøre kun EN ting.

Tilsvarer UNIX prinsippet om å la en kodeblokk gjøre EN ting, og gjøre den knallbra.

Coupling (man bør ha low og weak coupling). 

Containeren (new ServiceCollection()) sørger for at alle interfaces og klasser blir brukt
og opprettholdt på rett måte. Vi trenger ikke gjøre denne sjekken selv. 

AddLogging() inni containeren, gir meg mange loggemuligheter. 

GetRequiredService (gir meg exception muligheter hvis metoden returnerer null fordi noe ikke finnes.)

UnitTests tester små kodesnutter i koden min.
I unit testen av barService lager han en falsk fooService (som gjør noe enkelt), fordi han vil teste
om barService virker i isolasjon. barService får nemlig fooService injected som en paramter i constructoren.
Man lager en fake, fordi man antar at fooService virker som den skal. Dette er mulig med bruk av interfaces.

Test Driven Development
red green konsept: man lager enkel test, skriver den simpleste koden man kan for å få den til å virke,
og så bygger man opp funksjonen mer komplekts, slik at test feiler (rød), så fikser jeg (grønn).
Gjør de minste justeringene mulig før jeg tester.

Prime number triks (man trenger bare teste opp til kvadratroten av tallet).
*/