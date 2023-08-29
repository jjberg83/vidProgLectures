/*
Hva er en AI modell?
Veldig bredt uttrykk. Før var det regler. Nå er det synonymt med maskinglæring der patterns læres.
Kan også være regresjon (vi har masse tall, og må spå videre fremtid). En annen type er supervised
, dvs vi har svaret (dette er en hund), så får modellen masse tilfeldige bilder, og må finne ut
hva en hund er. 

Svaret er en samling floats (kalles model weights)! 

Simple ML Model
Se skisse

What is a language model?
Essens: Gitt en rekke ord, spå hva neste ord er (basert på vektene).
Sekvensen den genererer kan være tilfeldig, gir ikke alltid rett svar.
Language model hallusination: når en language model genererer noe som ikke finnes eller ikke er sant.
F.eks: fortell meg om Nobelprisvinneren Jørund Berg. ChatGPT vil ikke si: "Jeg vet ikke".
Den vil rett og slett dikte opp en historie. 
Spør om noe som skjedde ETTER training data sin dato, og man kan få hallusination.
Autocomplete er f.eks en language model. 

Slide som viser hvor mye modellene har vokst.
Token. Feeling, feels, feel......Alle har feel til felles. Feel er token som er felles for alle ordene.

Hvordan trenes language models?
Training data er millioner av tekstdokumenter. Noen ord i setningen maskes (skjules), så skal modellen
tippe hva ord som står på den tomme plassen.

Supervised learning.
F.eks
Prompt, et menneske vurderer de forskjellige svarene (labelling), og dette fores inn i reward model som endrer parameterene.


Reinforcement learning, 
begynne å spill sjakk uten å vite noe, og lære via prøving.

Fortsatt et problem at modeller kan svare stygt, rasistisk, sexist osv. Mennesker må ofte inn og rette. 

Codex/Copilot
Codex er det som får Copilot til å fungere.
Github Copilot extension
Deretter må jeg inn og aktivere for studentversjon på https://docs.github.com/en/copilot/quickstart

Start prompts som kommentarer
Begynn å skriv for eksempel class Person
Deretter ser jeg hjulet nede som begynner å spinne.
Copilot er klar over all kode i omgivelsene de er i.

Kodere som kun skriver enkel boilerplate kode, er i trøbbel. Man må gjøre mer enn å skrive entry-level kode.
Man må se på arkitektur, og ta avgjørelser.

Copilot kan bruke kode som benytter seg av GPL kode, som vil si at min kode også må bli GPL (open source).
General public license.


*/