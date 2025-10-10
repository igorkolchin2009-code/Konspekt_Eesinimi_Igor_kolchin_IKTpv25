
Console.WriteLine("Hello, World!");
Console.WriteLine("Tere kasutaja, mis on simu nimi");
string nimi = Console.ReadLine();

if (nimi == null)
{
    Console.WriteLine("kasutaja ei sisetanud oma nime");
}
else if (nimi != "")
{
    Console.WriteLine("Tere " + nimi + "!");
}
else
{
    Console.WriteLine("kasutaja ei sisetanud oma nime");
}
Console.WriteLine(nimi + ", mis on sinu vanus?: ");
int kasutajavanus = int.Parse(Console.ReadLine());


if (kasutajavanus > 0)
{
   if (kasutajavanus < 1)
    {
        Console.WriteLine("saa olla negativse vanusega");
    }
    else
    {
        Console.WriteLine("tana nime ta vanuse");
    }
}



Console.WriteLine("praegust temperatuuri komakohaga arvuna");
double temp = double.Parse(Console.ReadLine());
if (temp < 0)
{
    Console.WriteLine("põrgu jäätus");
}
else if (temp < 10 && temp > 1)
{
    Console.WriteLine("päris külm on");
}
else if (temp < 20 && temp > 11)
{
    Console.WriteLine("notmaalne ilm");
}
else if (temp < 30 && temp > 21)
{
    Console.WriteLine("kas läheb grillimiseks?");
}
else if (temp < 40 && temp > 31)
{
    Console.WriteLine("Appi, Globbalne soojebemine");
}



Console.WriteLine("Kas sa tahab vaarikat, maasikat või apelsini");
string favouriteColur = Console.ReadLine();
if (favouriteColur == "vaarikat")
{
    Console.BackgroundColor = ConsoleColor.Magenta;
    Console.WriteLine("näe, vaarikas!");
}
if (favouriteColur == "maasikat")
{
    Console.BackgroundColor = ConsoleColor.Red;
    Console.WriteLine("maasikaski on");
}
if (favouriteColur == "apelsini")
{
    Console.WriteLine("apelsini mul kahjuks ei ole :(");
}