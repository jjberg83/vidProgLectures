/*
git checkout <SHA>
Nå blir head detached (head viser hvor du er)

git checkout master

git branch

git checkout -b <navn>

git-graph.ps1 --oneline

(mens vi er inne på master branch)
git merge <some-branch>
(får merge conflict,
går inn i fil i vscode og sjekker konflikten)

git checkout <branch>
git diff master (sjekker forskjellene mellom master og <branch>)

git reset --soft/hard HEAD~1 (from head, minus one)

git commit --amend

clone with ssh
cd .\.ssh\       (windows)
cat .\id_rsa.pub (kopier)
Gå inn på Github>>settings>

git remote (får origin)
git remote -v (får to linjer med fetch og push)

git remode add <navn> <link>
git remote (får labs og origin)
git remote -v

git fetch -p

git branch -r

git checkout -b <navnekonvensjon under>
feature/what feature Im working on
bug/what bug Im working on 
etc

Pull request på Github.com er basically det samme som en merge

##################
INTERFACE
##################

Gjør at man kan arve fra to foreldre slik jeg forsto det.
Se på det mer som requirements/en kontrakt for hva "childs" bør ha.

dotnet restore (ordner packages og dependencies)

Klasse recap
kan sette required på properties
public required string firstName {get;set}
eventuelt bruke constructors
public Person(string firstName, string lastName) {
    this.firstName = firstName;
    this.lastName = lastName;
}

Les følgende syntaks slik
class Student : Person (hvis person er en interface)
sett properties i student slik som under, og send de Person vil ha over der

##################
DEPENDENCY INJECTION
##################

Henger veldig sammen med INterfaces

GJør at koden for eksemepl i program.cs ikke trenger å endres mye.
Endrer man interfacen man slenger inn i en variabel, endres mye av det 
som skjer under. 

MIcrosoft Extension Dependency Injection (installer)
Får <itemGroup> noe
Prøv 
using Microsoft.Extension.DependencyInjection;
var services = new ServiceCollection();
services.add..... (Singleton/Transient osv)
services.AddSingleton<IDataStore, InMemoryStore>();
var provider = services.BuildServiceProvider();
mulig noen av navnene er variabler og klasser han har laget.

AddSingleton gjør at man henvender seg til samme instans hver gang,
ikke at en ny blir skapt hver gang.

Kul type sjekk
if (p is person)
*/