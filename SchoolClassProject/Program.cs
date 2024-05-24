using SchoolClassProject;

Class aOsztaly = new Class
{
    SchoolYear = 9,
    Id = "a",
    MonthlyPaid = 7000,
    Students = 30,
};
Class bOsztaly = new Class
{
    SchoolYear = 9,
    Id = "b",
    MonthlyPaid = 6000,
    Students = 30,
};

Console.WriteLine(aOsztaly.ToString());
Console.WriteLine(bOsztaly.ToString());
Console.WriteLine();

if (aOsztaly.EqualTo(bOsztaly))
    Console.WriteLine("Két osztály adatai megegyeznek.");
else
    Console.WriteLine("Két osztály adatai nem egyeznek meg.");

if (aOsztaly.IsMorePaid(bOsztaly))
    Console.WriteLine($"{aOsztaly.SchoolYear}.{aOsztaly.Id} osztály {aOsztaly.MonthlyPaid-bOsztaly.MonthlyPaid}-tal többet fizet, mint a {bOsztaly.SchoolYear}.{bOsztaly.Id} osztály.");
else if (aOsztaly.IsMorePaid(bOsztaly))
    Console.WriteLine($"{bOsztaly.SchoolYear}.{bOsztaly.Id} osztály {bOsztaly.MonthlyPaid - aOsztaly.MonthlyPaid}-tal többet fizet, mint a {aOsztaly.SchoolYear}.{aOsztaly.Id} osztály.");
else
    Console.WriteLine($"Mind a két osztály ugyanannyit fizet.");

if (aOsztaly.MostPaydSchoolClass(bOsztaly))
    Console.WriteLine($"{aOsztaly.SchoolYear}.{aOsztaly.Id} osztály fizet a legtöbbet tanulónként osztálypénzt.");
else if (aOsztaly.MostPaydSchoolClass(bOsztaly))
    Console.WriteLine($"{bOsztaly.SchoolYear}.{bOsztaly.Id} osztály fizet a legtöbbet tanulónként osztálypénzt.");
else if (aOsztaly.MonthlyPaid == 0 || bOsztaly.MonthlyPaid == 0)
    Console.WriteLine($"Valamelyik osztályban nem fizettek osztálypénzt.");
else
    Console.WriteLine($"Mind két osztályban ugyan annyi osztálypénzt fizetnek a tanulók havonta.");
Console.WriteLine();

Console.WriteLine("Az osztályok 10 hónapnyi osztálypénze:");
Console.WriteLine($"A {aOsztaly.SchoolYear}.{aOsztaly.Id} osztály osztálypénze: {aOsztaly.MonthlyPaid*30*10} Ft");
Console.WriteLine($"A {bOsztaly.SchoolYear}.{bOsztaly.Id} osztály osztálypénze: {bOsztaly.MonthlyPaid*30*10} Ft");