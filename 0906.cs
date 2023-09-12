/*
Galls law
Basically. Start enkelt, og bygg på etterhvert. Aldri start stort.

Software er aldri perfekt. Feil vil oppstå. Poenget er å få det til å fungere.
Som øyet vårt (blindspot).

Relatert til Single Responsibility Principle og Kiss.

Eksempel der han jobbet for et kredittkort selskap, som hadde en massiv funksjon
som gjorde all slags mulige sjekker inni samme funksjon. De lagde mange små funksjoner
som testet kun EN enkelt ting, og samlet dem i en ServiceCollection (de delte alle samme
IValidator<Person>). Så kjørte de alle testene samtidig, og det var lettere å se hva 
som skjedde, og fikse det som var gale hvis man fikk feil.

Metaprogramming (i C# har det med reflection å gjøre).
var types = AppDomain greiene
Activator.CreateInstance lager en ny instans av noe, når man ikke helt vet HVA det er.
Alt her blir gjort automatisk av ServiceCollection, så var nok bare for å vise
kraften i det. 

Moq er et framework som lager dummies av ting, for eksempel en email service.
dotnet add package moq. Slik at man slipper å lage fakeEmailService. 

ARCHITECTURE

I software kan man gjøre om togets arkitektur mens toget kjører. 
Iallefall hvis man har gjort hjemmeleksen først, det vil tenkt på arkitektur fra 
begynenlsen av, og Galls law. Software er "mullable" eller "mallable" (tror jeg han kalte det).

Cohesion
Om man klarer å samle kode som hører sammen. Man ønsker high cohesion, og low coupling.

Yakshaming
Jeg skal fikse lyspære, men mangler noe verktøy, går i garasjen, trenger nytt, skal 
kjøre bilen for å kjøpe, bilen virker ikke, så jeg prøver å fikse bilen. Slik er det 
i software.

Law of entropy i fysikk
Hvis systemer får være, går de mot kaos. For at orden skal opprettholdes, må man
legge inn innsats, ellers går det mot kaos.

I software blir programmer mer og mer komplekse (eksponentielt) etter som tiden går. Men man 
gjøre grep som reduserer kompleksiteten, ved å håndtere hvordan de forskjellige delene snakker sammen.
*/