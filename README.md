BAKGRUND
Ett litet företag i restaurangbranschen kontaktar dig för att utveckla ett litet
personalregister. De har endast två krav:

1. Registret skall kunna ta emot och lagra anställda med namn och lön. (via inmatning
   i konsolen, inget krav på persistent lagring)

2. Programmet skall kunna skriva ut registret i en konsol.

Uppgift 1
Vilka klasser bör ingå i programmet?

Svar: Vi behöver klasserna Employee och EmployeeRegistry.

Uppgift 2
Vilka attribut och metoder bör ingå i dessa klasser?

Svar: Employee-klassen har attributen Name och Wage med tillhörande get & set-metoder. Vi override:ar toString-metoden i Employee-klassen så att den output:ar en kort mening med den anställdes namn och lön.

EmployeeRegistry-klassen har en List av Employee utan set- eller getmetoder. Den har en metod AddEmployee(string name, int wage) för att lägga till anställda och och en metod PrintRegistry som anropar toString() på samtliga Employee i List av Employee.

Uppgift 3
Skriv programmet

Svar: Se Program.cs, Employee.cs samt EmployeeRegistry.cs. Jag tolkade uppgiften som att programmet ska kunna skriva ut personalregistret på kommando via inmatning i konsolen.

FOTNOT: Jag är osäker på vad man normalt laddar upp på Git i ett .Net-projekt. Hade varit fint om den autogenererade en gitignore... Noterade att det tillkom en del filer efter att jag kört programmet, vilka kanske inte borde varit med.
