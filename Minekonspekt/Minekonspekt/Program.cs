using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.InteropServices;

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
            else if (tehteyyp == "-")
            {
                tulemus = arv1 - arv2;

            }
            else if (tehteyyp == "/")
            {
                tulemus = arv1 / arv2;

            }
            else if (tehteyyp == "*")
            {
                tulemus = arv1 * arv2;

            }
            else if (tehteyyp == "*")
            {
                tulemus = (int)Math.Pow(arv1, arv2);

            }
            else
            {
                Console.WriteLine("Palun siseta teha, mida kalkulaator oskab");
            }
            if (tulemus != 0)
            {
                Console.WriteLine(tulemus);
            }
            else
            {
                Console.WriteLine("Tulemus on 0, või üritasid teha tehat, mida kalkulaatot ei tunne");
            }

            //4 parool, if string andmetüüp
            Console.WriteLine("Proogrami edasi tõõks siseta palun paarool");
            string password = Console.ReadLine();

            if ( password == "simsalabin")
            {
                Console.WriteLine("Parrol on õige aarete lages avaneb");
            }
            else if (password == "saatana" || password == "1234")
            {
                 Console.WriteLine("Parool on subimatu, palun mingi muu");
            }
            else
            {
                Console.WriteLine("Parool on vale, proovi uuesti");
            }

            //5 värvituvastus
            Console.WriteLine("Milline värv sille kõige rohkem meeldib");
            string favouriteColur = Console.ReadLine();
            if (favouriteColur == "panane") 
            {
                Console.BackgroundColor = ConsoleColor.Red;

            }
            if (favouriteColur == "oranz") 
            {
                Console.WriteLine("Kahjuks oranzo ei ole");
            }
            if (favouriteColur == "kollane") 
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
            }

            if (favouriteColur == "rohaline") 
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.WriteLine("Värvi ei tunne");
            }
            Console.WriteLine("Värv muudetud!");

            
            //# Калькулятор грузчика - Напишите программу, которая:
            //# - Спрашивает пользователя, хочет ли он измерить картонную коробку или бочку для масла.
            //# - в зависимости от ввода пользователя, спрашивает:
            //# - - для бочки:
            //# - - - знает ли пользователь радиус дна (r) или диаметр дна (d):
            //# - - - высота бочки
            //# - - - толщина крышки (толщина крышки вычитается из высоты бочки, так как крышка занимает некоторое место внутри бочки)
            //# - - - Вычисляет объем бочки, боковую площадь бочки, общую площадь бочки
            //# - - для коробки:...
            //# - - - Является ли коробка кубом или прямоугольным параллелепипедом
            //# - - - - если это куб, спрашивает пользователя только о длине стороны
            //# - - - - если это прямоугольный параллелепипед, спрашивает пользователя:
            //# - - - - длину самой длинной стороны, 
            //# - - - - длину самой короткой стороны и
            //# - - - - - высота коробки
            //# - - вычисляет общую площадь коробки, объем и самую длинную сквозную линию (d)

            Console.WriteLine("Küsib kasutajalt kas ta tahab ära mõõta pappkasti või õlitünni.");
            string Kolijakalkulaato = Console.ReadLine();


            if (Kolijakalkulaato == "tünni")
            {
                Console.WriteLine("kas sa tead tüüni raadiust R või läbimõõtu D");
                string rvõid = Console.ReadLine();
                Console.WriteLine("mis on selle raadius/läbimõõte? meetrirtes");
                double kasutajamõõt = double.Parse(Console.ReadLine());
                Console.WriteLine("Kui kõtge on su tünni? meetriss");
                double kõrgus = double.Parse(Console.ReadLine());

                Console.WriteLine("Kui paks on su tünni? meetriss");
                double kaanepaks = double.Parse(Console.ReadLine());

                double Sp = 0;
                if (rvõid == "R")
                {
                    Sp = Math.PI * (kasutajamõõt * kasutajamõõt);
                }
                else if (rvõid =="D")
                {
                    kasutajamõõt = kasutajamõõt / 2;
                    Sp = Math.PI * (kasutajamõõt * kasutajamõõt) / 2;
                }    
                double V = 0;
                kõrgus = kõrgus - kaanepaks;
                V = Sp * kõrgus;
                //Tünni ruumalu on olemas. arvutame küjepindala
                kõrgus += kaanepaks;
                double Sk = 2 * Math.PI * kasutajamõõt *kõrgus;
                //Tünni küljepindala on olemas. arvutame tünni kogupindala
                double S = Sp + Sk;
                Console.WriteLine($"sinu tüün mahutab {V}\nTünni küljindala on{Sk}\nTünni kogupindala on{S}");
            }

            else if (Kolijakalkulaato == "kasti")
            {
                Console.WriteLine("Kas kast on kuubiku kujuline või risttahuka kujuline.");
            }




            Console.WriteLine("hapukapsas");
            // "Console"    -> on moodul C# mida me adresserime, Console aitab teha tegevusi käsurel
            // .            -> näitab, et meil on vaja adresserida mingisugust funktsiooni või meetodit
            //              mooduli "Console" seest.
            // "Writeline"  -> Funktsioon mida me parasjagu kasutame.
            // ()           -> sulupaar mis omab funktsiooni tööks vajalikku infot
            // []           -> tähistab massiive
            // {}           -> koodiplokk, tavaliselt kas pärast (if, else if) tingimust, namespacei või funktsiooni kirjeldus
            // "hapukapsas" -> parameeter mis antakse funksioonile WriteLine töötlemiseks kaasa.
            //           -> Tanne aitab arendajal aru, kuskohas millise kodiploki sees kood asub, see on vajalik ka kompilaatorile samal eesmärgil.
            // ;            -> kõik koodilused lõppevad kammentaari
            // //           -> tähistab üherealist kommentaari
            // /**/         -> tähistab mitmeralist kommntaari või kommentaariregiooni

            int muutuja = 3;
            // int          -> on muutaja nime ess olev anmetüübi kirjeldus mis näitab ära, millist tüüpi andmed selle muutuja sees on.
            // "muutaja"    -> in nimetus, ehk muutuja, mis hoiab endas mingeid andmed, inimloetava sõnaga, ja mille abil ssab neid addressertida koodi sees.
            // =            -> üksik võrdusmärk omistab muutaja sisse vastava väärtuse mis asub teiselpool võrdusmärki.
            // 3            -> muutujale omistatav väärtus.

            /* Võimalikud andmetüübi mida vaja võid minna: */
            int a = 1; // int on täisarv
            decimal b = 2.1M; // decimal on kümendsüstemis olev komakohaga arv
            float c = 3.9f; // flout on 32-bitine komakoga arv
            double d = 5.6d; // double on 64-bitine komakohaga arv
            char c1 = 'a'; // üksainus täht või tähemark mis tähistatakse ülakomadga ''
            string s = "tekst"; //tähtedest koosnev sõna või tekst, tähistatakse jutumärkidega ""
            var x = "aba";  // var on ebamäärase andmetüübiga kohalik muutuja
            var y = 123;    // ta bõib omada endas teisi andmetüüpe
            const int z = 9; // konstant-tüüpi muutujaid ei saa muuta, nende sisu on read-only

            //põhilised matemaatilised tehted
            int liitmine = 1 + 1; // liitmine, kaks arvu liidetakse kokku
            int lahutamine = 1 - 1; // lahutamine, kus esimeset arvust lahutatakse maha teine
            double korrutamine = 1 * 2; // kottutanine, kus teine arv korrutatakse esimese arvu kordi.
            double jagamine = 1 / 2; //jagamine. esimene arv jagatakse teise arvuga.
            double astendamine = Math.Pow(2, 2); // astendamine, esimene arv astendatakse teisega
            double juurimine = Math.Sqrt(2); // ruutjuur, parammetrina juuritav arv

            //muutuja nimed
            int arv = 0;
            string sõne = "abc";
            //string string = "abx"; //kaitstud sõna kasutada ei saa

            //muutuja nimeks ei sobi järgnevad sõnad:
            // abstract, as, base, bool, break, byte, case,
            //cath, char, checked, class, clount, continue, decimal,
            //defual, delegate, do, double, else, enum, event,
            //explicit, extren, false, finally, fixed, flout, for
            //foreach, goto, if, implicit, in, int, interface, internal
            //is, lock, long, namespace, new, null, object, operatot,
            //out, override, params, private, protected, public, readonly,
            //ref, return, sbyte, sealed, short, sizeof, stackalloc,
            //static, string, struct, switch, this, throw, try, typeof,
            //unit, ulong, unchecked, unsafe, unshort, using, virtual,
            //void, volatile, while.

            //3kalkulaator ifi ja elsififega
            Console.WriteLine("Tere. Sisesta esimene arv");
            //Adresserime moodulit "Console", punkti abil übil utleme, et kasutame funktsiooni WriteleLine selle jaoks et öelda kasutajale sõnum mis asub funktsioono nime järel sulgude vahel ümbritsetuna jutumärkidega. Kasutajale esitav sõnum on "Tere. Siseta esimene arv".

            int arv1 = int.Parse(Console.ReadLine());
            //instantsiseerime muutja nimega "arv1", ning selle ette anname andmetüübiks "int", see ütleb ära, et sin muutujas on täsarvud sees. Omistame muutujale võrdismärgi abil väärtuse, mille saame kasutajalt. Selle jaoks, adresseerime uuesti "Console" moodulit Aga seekord on funktsiooni nimi "Readline". Selleks, et käsureapealt tulev arv programmile tekstina ei näe välja, küsime int mooduli seest omakorda funktsiooni "Parse", ning paneme ReadLine funktsiooni Parse() sulgude vahel.

            Console.WriteLine("Tere. Sisesta teine arv");

            //Adresserime moodulit "Console", punkti abil übil utleme, et kasutame funktsiooni WriteleLine selle jaoks et öelda kasutajale sõnum mis asub funktsioono nime järel sulgude vahel ümbritsetuna jutumärkidega. Kasutajale esitav sõnum on "Tere. Siseta esimene arv".
            
            int arv2 = int.Parse(Console.ReadLine());

            //instantsiseerime muutja nimega "arv1", ning selle ette anname andmetüübiks "int", see ütleb ära, et sin muutujas on täsarvud sees. Omistame muutujale võrdismärgi abil väärtuse, mille saame kasutajalt.Selle jaoks, adresseerime uuesti "Console" moodulit Aga seekord on funktsiooni nimi "Readline".Selleks, et käsureapealt tulev arv programmile tekstina ei näe välja, küsime int mooduli seest omakorda funktsiooni "Parse", ning paneme ReadLine funktsiooni Parse() sulgude vahel.
            
            Console.WriteLine("Sisesta tehtemärk: / * + -");
            //Adresserime moodulit "Console" koos "WritleLine" funktsiooniga, et esitada kasutajale küsimuse "Sisesta tehtemärk : / * + -". Punkti abil saame moodulist Comsole, funktsiooni Writline, ning sulgude vahel ongi kasutajale esitav tekst. Tekst ise on ka ümbristetud jutumärkidega. Lause lõppeb lauselõpumärgiga ";".
            string tehteyyp = Console.ReadLine();
            //instantsieerime muutuja nimega "tegtetyyp", mille ette kirjutane andmetüübiks "string".
            //Omistame võrdusmärgi abil, sellesse muutjasse kasutajalt sisendi mille saame kasutade "Console" moodulis oleva Readline() funktsiooni abil Lause lõpped lauselõpumärgiga ";".Lause lõppeb lauselõpumärgiga ";".


            int tulemus = 0;
            // instantsireerime muutuja nimega "tulemus", andmetüübiga int, ning omistame talle algse väärtuse võrdusmärgi võrdusmärgi abil, milleks on 0. Lause lõppeb lauselõpumärgiga ";".

            if (tehteyyp == "+")
                //teeme tingimuslase if, ning selle tingimuse määrame ära sulgudega, mille vahel on võrdsuskontroll. Kontrollime kas muutuja "TEHTETYYP" omad andmeid samal kujul nagu võtdusmärkidest teist pool olev tekst "+". Siin lause ei lõppe, kuna tegu ei ole koodiga mis midagi kindlat vell ära teeb.
            {
                tulemus = arv1 + arv2;

            }
            //peale tingimust on kodiplokk {} sulgude vahel, mis sialdab endas ühit koodirida.
            //selles lauses omistame muutujale "tulemus" võrdusmärgi abil liitmistehte tulemuse, kus liidame kooku muutuja "arv1" ja muutuja "arv2" sisu. Lause lõppeb lauselõpumärgiga ";".
            else if (tehteyyp == "-")
                //teeme sekundaarse tingimuslause "else if", ning määrame tema tingimuse ära sulgudaga.
                //Sulgude vahel on võrdsuskontroll. Kontrollime kas muutuja "tehtetyyp" onmad andmeid samal kujul nagu võrdusmärkifest teisel pool olev tekst "-" kui eelnev tingimus ei täitunud. Lause siin ei lõppe, vaid tingimusele järgneb koodiplokk.

            {
                tulemus = arv1 - arv2;

            }
            //peale tingimust on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte koodirida. selles lause omistame muutujale "tulemus" võrdusmärgi abil lahutustehte tulemuse, kus lahutame muutuja "arv" sees olevast väärtusest maha "arv2" muutujas oleva väärtuse. //peale tingimust on kodiplokk {} sulgude vahel, mis sialdab endas ühit koodirida.
            //selles lauses omistame muutujale "tulemus" võrdusmärgi abil liitmistehte tulemuse, kus liidame kooku muutuja "arv1" ja muutuja "arv2" sisu. Lause lõppeb lauselõpumärgiga ";". 
            else if (tehteyyp == "/")
                //teeme sekundrase tingimuslause "else if", ning määrassme tema tingimuse ära sulgudega.
                //Sulgude vahel on võrdsuskontroll. kontrollime kas muutuja "tehtetyyp" omab andmeid samal kujal nagu võrdusmärkidest teisel pool olev tekst "/" kui eelnev tingimus ei täitunud. Lause siin ei lõppe, vaid tingimusele järgneb koodiplokk.
            {
                tulemus = arv1 / arv2;

            }
            //peale tingimust on kodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte koodirida. selles lauses omistame muutujale "tulemus" võrdusmärgi abil korrutustehte tulemus, kus jagame mutujas "arv1" olev väärtuse, muutujas "arv2" oleva jagajaga. Lause lõppeb lauselõpumärgiga ";". 
            else if (tehteyyp == "*")
            //teeme sekundaarse tingimuslause "else if", ning määrame tema tingimuse ära silgudega.
            //Sulgude vahel kujul nagu võrdsuskontrill. Kontrollime kas muutuja "tehtetyyp" omad andmeid samal kujul nagu võrdusmärkidest teisel pool olev tekst "*" kui eelnev tingimus ei täitunud. Lause lõppeb lauselõpumärgiga ";". 
            {
                tulemus = arv1 * arv2;

            }
            //peale tingimust on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte koodirida. selles lause omistame muutujale "tulemus" võrdusmärgi abil korrutustehte tulemuse, kus korrutame muutujas "arv2" ilev vääärtuse muutujas "arv1" oleva väärtuse kordi. Lause lõppeb lauselõpumärgiga ";".
            else if (tehteyyp == "^")
            //teeme sekundaarse tingimuslause "else if", ning määrame tema tingimuse ära sulgudega.
            //Sulgude vahel om võrdsuskontroll, kontrollime kas muutuja "tehtetyyp" omad andmeid samal kujul nagu võrdusmärkidest teisel poool olev tekst "^" kui eelnev tingimus ei täitunud. Lause lõppeb lauselõpumärgiga ";". 
            {
                tulemus = (int)Math.Pow(arv1, arv2);

            }
            //peale tingimust on kodiplook {} loogeliste vahel, mis sisaldab endas ühte koodirida. Selles lause omistatakse võrdusmärgi abil muutujasse "tulemus" Mmille saame "Math moodulist pärineva funktsiooni "Pow()" abil. Math.pow() võtab parametritena sisse muutjad "arv1" ja "arv2". Esimene pareneter on astedatav, teine paremeeter on astendaja. Funktsiooni Math.Pow() ess on kiirteusendus (int), kuna muutuja "tulemus" andmetüüp on täisar. Math.Pow() väljund teisendatakse nii täisarvuks.
            //Lause lõppeb lauselõpumärgiga ";". 
            else
            //peale kõiki järeltingimusi on meil tingimuslause osa "else" mida täidetakse kõikide muude tingimuslause osade mittetäitmisel. Siin araldi tingimust välja ei kirjutada ning sellest tulenevalt ei ole ka sulge. Jargneb ainult koodiplokk.
            {
                Console.WriteLine("Palun siseta teha, mida kalkulaator oskab");
            }
            //peale "else" on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte koodrida. Selles koodireas kasutame moodulist "Console" punkti abil funktsioomi "WritLine" et öelda kasutajale "Palun siseta teha teha, mida kalkulaator tuvastada oskav". Koodirida lõppeb lauselõpumärgiga ";". 
            if (tulemus != 0)
            {
                Console.WriteLine(tulemus);
                //Kasutame moodulist "Console" punkti abil funktsiooni "Writlene" et kuvada kasutajale tehte tulemus. Selle jaoks on Writlene funktsioonus paremeetrina pandud muutuja "tilemus" ilma tekstiks teisendamate. Lause lõppeb lauselõpumärgiga ";". 
            }
            else
            {
                Console.WriteLine("Tulemus on 0, või üritasid teha tehat, mida kalkulaatot ei tunne");
            }











        }   


    } 
}

