// See https://aka.ms/new-console-template for more information
using ClassRoomNet60;

Console.WriteLine("Hello, World!");
Service service = new Service();

List<Studerende> studerendeList = new List<Studerende>();
studerendeList.Add(new Studerende("Marcus", 10, 19));
studerendeList.Add(new Studerende("Cecilie", 3, 31));
studerendeList.Add(new Studerende("welpson", 14, 31));

KlasseRum klasseRum1 = new KlasseRum();
klasseRum1.KlasseNavn = "3B";
klasseRum1.Klasseliste = studerendeList;
klasseRum1.SemesterStart = DateTime.Parse("01-09-2022");



//Console.WriteLine(klasseRum1.KlasseNavn);
//foreach (Studerende stud in klasseRum1.Klasseliste)
//{
//    Console.WriteLine(stud);
//}
//Console.WriteLine(klasseRum1.SemesterStart);

//Console.WriteLine(service.Årstid(klasseRum1.Klasseliste.Find(k => k.Navn == "Cecilie").Fødelsmåned)); 


//try
//{
//    service.HvilkenÅrstid(klasseRum1);
//}
//catch (ArgumentOutOfRangeException e)
//{
//    Console.WriteLine(e.ParamName);
//}
service.HvilkenÅrstid(klasseRum1);