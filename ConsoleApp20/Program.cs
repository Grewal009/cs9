// See https://aka.ms/new-console-template for more information

//Oppgave: Organ transplant!
// Det har vært en akutt ulykke og Bernt ligger på sykehuset.
// 
// Han trenger en ny Nyre!
// 
// Heldigvis har fetteren hans Kåre to sunne Nyrer, og det er utført tester som tilsier at Kåre kan gi bort en av nyrene til Bernt og det vil være en høy suksessrate for overlevelse!
// 
// Hjelp Bernt med å overleve!
// 
// Finn ut hva vi kan lage som objekter, og hva man kan lage som metoder i dette tilfellet.
// 
// Lag gjerne Consoll.WriteLine() - statements i koden slik at man ser hva som skjer!

using ConsoleApp20;

Person bernt = new Person("Berent", 2 , "need kidney transplant");
Person kåre = new Person("Kåre", 2 , "fit to donate kidney");

bernt.ShowStatus();
kåre.ShowStatus();

Hospital hospital = new Hospital();
hospital.TransplantKidney(kåre,bernt);