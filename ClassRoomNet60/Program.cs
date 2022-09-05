// See https://aka.ms/new-console-template for more information
using ClassRoomNet60;

Console.WriteLine("Hello, World!");


List<Studerende> studerendeList = new List<Studerende>();
studerendeList.Add(new Studerende("Marcus", 10, 19));
studerendeList.Add(new Studerende("Cecilie", 3, 31));

KlasseRum klasseRum1 = new KlasseRum();
klasseRum1.KlasseNavn = "3B";
klasseRum1.Klasseliste = studerendeList;
klasseRum1.SemesterStart = DateTime.Parse("01-09-2022");



Console.WriteLine(klasseRum1.KlasseNavn);
foreach (Studerende stud in klasseRum1.Klasseliste)
{
    Console.WriteLine(stud);
}
Console.WriteLine(klasseRum1.SemesterStart);

Service service = new Service();
Console.WriteLine(service.Årstid(klasseRum1.Klasseliste.Find(k => k.Navn == "Cecilie").Fødelsmåned)); 