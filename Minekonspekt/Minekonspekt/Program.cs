using System.ComponentModel.Design;
using System.Diagnostics;

namespace Minekonspekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //Muutajad, matemaatilised tehted, if esle if esle:

            //1. tuvasta sisu võrdluses tühja strinhiga, string andmetüüp
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

            //2.tuvasta arvuvagemik, võrdluses piirväärtustega, int/double/flout andmetüüp
            Console.WriteLine(nimi + ", mis on sinu vanus?: ");
            int kasutajavanus = int.Parse(Console.ReadLine());

            //2.1 mitu tingimust pesastatud if-ide abil
            //if (kasutajavanus > 0)
            //{
            //   if (kasutajavanus < 18)
            //    {
            //        Console.WriteLine("kahjuks energiajooki sulle ei müüda, oled Monsterist ilma 😒");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Saad osta Monsterit, Yeppie");
            //    }
            //}

            //2.2 mitu tingimust ühe ifi sees kasutades loogilist tehet "and", välitides pesastamist
            if (kasutajavanus > 0 && kasutajavanus < 18)
            {
                Console.WriteLine("kahjuks energiajooki sulle ei müüda, oled Monsterist ilma 😒");
            }
            else
            {
                Console.WriteLine("Saad osta Monsterit, Yeppie");
            }
            //2.3 mitu vahemikku, if-elseif abil, doble/flout
            Console.WriteLine("sisesta oma piku ka , palun," + nimi + ":");
            double pikkus = double.Parse(Console.ReadLine());
            if (pikkus < 1.00d)
            {
                Console.WriteLine("oled jutsu");
            }
            else if (pikkus <1.25d && pikkus > 1.00d)
            {
                Console.WriteLine("oled paaegu allmeetrimees");
            }
            else if (pikkus <1.50d && pikkus >1.25d)
            {
                Console.WriteLine("Oioi, päkapikk enam ei ilegi" + nimi + "!");
            }
            else if (pikkus < 1.750d && pikkus > 1.5d)
            {
                Console.WriteLine("Oioi enamasti standardpikkuses, kui mitte just natuke lühike");
            }
            else if (pikkus < 2.00d && pikkus > 1.75d)
            {
                Console.WriteLine("Pikk kolge, vaata et sa pead vastu uksepiita ära ei löö");
            }
            else if (pikkus > 2.00d)
            {
                Console.WriteLine("Täielik tulnukas, pildev välja näevad?");
            }
            else
            {
                Console.WriteLine("pikkust ei tunta");
            }



        }

    } 
}

// + liitmine
Console.WriteLine("Tere. Sisesta esimene arv");
int arv1 = int.Parse(Console.ReadLine());
Console.WriteLine("Tere. Sisesta teine arv");
int arv2 = int.Parse(Console.ReadLine());
Console.WriteLine("Sisesta tehtemärk: / * + -");
string tehteyyp = Console.ReadLine();

int tulemus = 0;
if (tehteyyp == "+")
{
    tulemus = arv1 + arv2;

}
if (tehteyyp == "-")
{
    tulemus = arv1 - arv2;

}
if (tehteyyp == "/")
{
    tulemus = arv1 / arv2;

}
if (tehteyyp == "*")
{
    tulemus = arv1 * arv2;

}

Console.WriteLine(tulemus);