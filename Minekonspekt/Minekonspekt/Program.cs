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
            //Console.WriteLine("Tere kasutaja, mis on simu nimi");
            //string nimi = Console.ReadLine();

            //if (nimi == null)
            //{
            //    Console.WriteLine("kasutaja ei sisetanud oma nime");
            //}
            //else if (nimi != "")
            //{
            //    Console.WriteLine("Tere " + nimi + "!");
            //}
            //else
            //{
            //    Console.WriteLine("kasutaja ei sisetanud oma nime");
            //}

            //2.tuvasta arvuvagemik, võrdluses piirväärtustega, int/double/flout andmetüüp
            //Console.WriteLine(nimi + ", mis on sinu vanus?: ");
            //int kasutajavanus = int.Parse(Console.ReadLine());

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
            //if (kasutajavanus > 0 && kasutajavanus < 18)
            //{
            //    Console.WriteLine("kahjuks energiajooki sulle ei müüda, oled Monsterist ilma 😒");
            //}
            //else
            //{
            //    Console.WriteLine("Saad osta Monsterit, Yeppie");
            //}
            ////2.3 mitu vahemikku, if-elseif abil, doble/flout
            //Console.WriteLine("sisesta oma piku ka , palun," + nimi + ":");
            //double pikkus = double.Parse(Console.ReadLine());
            //if (pikkus < 1.00d)
            //{
            //    Console.WriteLine("oled jutsu");
            //}
            //else if (pikkus <1.25d && pikkus > 1.00d)
            //{
            //    Console.WriteLine("oled paaegu allmeetrimees");
            //}
            //else if (pikkus <1.50d && pikkus >1.25d)
            //{
            //    Console.WriteLine("Oioi, päkapikk enam ei ilegi" + nimi + "!");
            //}
            //else if (pikkus < 1.750d && pikkus > 1.5d)
            //{
            //    Console.WriteLine("Oioi enamasti standardpikkuses, kui mitte just natuke lühike");
            //}
            //else if (pikkus < 2.00d && pikkus > 1.75d)
            //{
            //    Console.WriteLine("Pikk kolge, vaata et sa pead vastu uksepiita ära ei löö");
            //}
            //else if (pikkus > 2.00d)
            //{
            //    Console.WriteLine("Täielik tulnukas, pildev välja näevad?");
            //}
            //else
            //{
            //    Console.WriteLine("pikkust ei tunta");
            //}
            //Console.WriteLine("Tere. Sisesta esimene arv");
            //int arv1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Tere. Sisesta teine arv");
            //int arv2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Sisesta tehtemärk: / * + -");
            //string tehteyyp = Console.ReadLine();

            //int tulemus = 0;
            //if (tehteyyp == "+")
            //{
            //    tulemus = arv1 + arv2;

            //}
            //else if (tehteyyp == "-")
            //{
            //    tulemus = arv1 - arv2;

            //}
            //else if (tehteyyp == "/")
            //{
            //    tulemus = arv1 / arv2;

            //}
            //else if (tehteyyp == "*")
            //{
            //    tulemus = arv1 * arv2;

            //}
            //else if (tehteyyp == "*")
            //{
            //    tulemus = (int)Math.Pow(arv1, arv2);

            //}
            //else
            //{
            //    Console.WriteLine("Palun siseta teha, mida kalkulaator oskab");
            //}
            //if (tulemus != 0)
            //{
            //    Console.WriteLine(tulemus);
            //}
            //else
            //{
            //    Console.WriteLine("Tulemus on 0, või üritasid teha tehat, mida kalkulaatot ei tunne");
            //}

            ////4 parool, if string andmetüüp
            //Console.WriteLine("Proogrami edasi tõõks siseta palun paarool");
            //string password = Console.ReadLine();

            //if ( password == "simsalabin")
            //{
            //    Console.WriteLine("Parrol on õige aarete lages avaneb");
            //}
            //else if (password == "saatana" || password == "1234")
            //{
            //     Console.WriteLine("Parool on subimatu, palun mingi muu");
            //}
            //else
            //{
            //    Console.WriteLine("Parool on vale, proovi uuesti");
            //}

            ////5 värvituvastus
            //Console.WriteLine("Milline värv sille kõige rohkem meeldib");
            //string favouriteColur = Console.ReadLine();
            //if (favouriteColur == "panane") 
            //{
            //    Console.BackgroundColor = ConsoleColor.Red;

            //}
            //if (favouriteColur == "oranz") 
            //{
            //    Console.WriteLine("Kahjuks oranzo ei ole");
            //}
            //if (favouriteColur == "kollane") 
            //{
            //    Console.BackgroundColor = ConsoleColor.Yellow;
            //}

            //if (favouriteColur == "rohaline") 
            //{
            //    Console.BackgroundColor = ConsoleColor.Green;
            //}
            //else
            //{
            //    Console.WriteLine("Värvi ei tunne");
            //}
            //Console.WriteLine("Värv muudetud!");


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

            //Console.WriteLine("Küsib kasutajalt kas ta tahab ära mõõta pappkasti või õlitünni.");
            //string Kolijakalkulaato = Console.ReadLine();


            //if (Kolijakalkulaato == "tünni")
            //{
            //    Console.WriteLine("kas sa tead tüüni raadiust R või läbimõõtu D");
            //    string rvõid = Console.ReadLine();
            //    Console.WriteLine("mis on selle raadius/läbimõõte? meetrirtes");
            //    double kasutajamõõt = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Kui kõtge on su tünni? meetriss");
            //    double kõrgus = double.Parse(Console.ReadLine());

            //    Console.WriteLine("Kui paks on su tünni? meetriss");
            //    double kaanepaks = double.Parse(Console.ReadLine());

            //    double Sp = 0;
            //    if (rvõid == "R")
            //    {
            //        Sp = Math.PI * (kasutajamõõt * kasutajamõõt);
            //    }
            //    else if (rvõid =="D")
            //    {
            //        kasutajamõõt = kasutajamõõt / 2;
            //        Sp = Math.PI * (kasutajamõõt * kasutajamõõt) / 2;
            //    }    
            //    double V = 0;
            //    kõrgus = kõrgus - kaanepaks;
            //    V = Sp * kõrgus;
            //    //Tünni ruumalu on olemas. arvutame küjepindala
            //    kõrgus += kaanepaks;
            //    double Sk = 2 * Math.PI * kasutajamõõt *kõrgus;
            //    //Tünni küljepindala on olemas. arvutame tünni kogupindala
            //    double S = Sp + Sk;
            //    Console.WriteLine($"sinu tüün mahutab {V}\nTünni küljindala on{Sk}\nTünni kogupindala on{S}");
            //}

            //else if (Kolijakalkulaato == "kasti")
            //{
            //    Console.WriteLine("Kas kast on kuubiku kujuline või risttahuka kujuline.");
            //}




            //Console.WriteLine("hapukapsas");
            //// "Console"    -> on moodul C# mida me adresserime, Console aitab teha tegevusi käsurel
            //// .            -> näitab, et meil on vaja adresserida mingisugust funktsiooni või meetodit
            ////              mooduli "Console" seest.
            //// "Writeline"  -> Funktsioon mida me parasjagu kasutame.
            //// ()           -> sulupaar mis omab funktsiooni tööks vajalikku infot
            //// []           -> tähistab massiive
            //// {}           -> koodiplokk, tavaliselt kas pärast (if, else if) tingimust, namespacei või funktsiooni kirjeldus
            //// "hapukapsas" -> parameeter mis antakse funksioonile WriteLine töötlemiseks kaasa.
            ////           -> Tanne aitab arendajal aru, kuskohas millise kodiploki sees kood asub, see on vajalik ka kompilaatorile samal eesmärgil.
            //// ;            -> kõik koodilused lõppevad kammentaari
            //// //           -> tähistab üherealist kommentaari
            //// /**/         -> tähistab mitmeralist kommntaari või kommentaariregiooni

            //int muutuja = 3;
            //// int          -> on muutaja nime ess olev anmetüübi kirjeldus mis näitab ära, millist tüüpi andmed selle muutuja sees on.
            //// "muutaja"    -> in nimetus, ehk muutuja, mis hoiab endas mingeid andmed, inimloetava sõnaga, ja mille abil ssab neid addressertida koodi sees.
            //// =            -> üksik võrdusmärk omistab muutaja sisse vastava väärtuse mis asub teiselpool võrdusmärki.
            //// 3            -> muutujale omistatav väärtus.

            ///* Võimalikud andmetüübi mida vaja võid minna: */
            //int a = 1; // int on täisarv
            //decimal b = 2.1M; // decimal on kümendsüstemis olev komakohaga arv
            //float c = 3.9f; // flout on 32-bitine komakoga arv
            //double d = 5.6d; // double on 64-bitine komakohaga arv
            //char c1 = 'a'; // üksainus täht või tähemark mis tähistatakse ülakomadga ''
            //string s = "tekst"; //tähtedest koosnev sõna või tekst, tähistatakse jutumärkidega ""
            //var x = "aba";  // var on ebamäärase andmetüübiga kohalik muutuja
            //var y = 123;    // ta bõib omada endas teisi andmetüüpe
            //const int z = 9; // konstant-tüüpi muutujaid ei saa muuta, nende sisu on read-only

            /* Võimalikud komposiitandmetüübid */
            // 1. massiiv:
            // [] -> Massiiv on kompossitandmetüüp, mille sees olla mitmeid samat tüüpi lihtandmeid. Massiivi tähistatakse Kantsulgudega.
            //      Massive saab olla ükskõik millist lihtandmetüüpi massiive.
            //      Massiivi tekitamisel tuleb ära õelda kui pikk või kui suur see massiiv on.
            //      Massiiv ei pea olema koostatud ainult Lihtandmetüüpidest, vaid massiive saab olla ka tehtud teistest komposiitandmetüüpidest
            //      Sealhulgas massiiv ise.
            // Esimene tekitusviis:
            int[] arvuMassiv = new int[3];  // andmetüüp int väljendab et tegu täisarvutüüpi andmega ja kantsuled väljendava et ühtlasi on
                                            // tegu ka massiiviga.muutuja nimeks on "arvuMassiiv" ja võrdusmärgi abil on omistatud muutujasse
                                            // uus tühi massiiv kasutades kaitstud sõna "new", millele järgneb selle massiivi andmetüübi ja
                                            // pikkuse sätestus "int [3]". See täghendab et siin massiivis on 3 elementi, mis on täisarvud.
            // Teine tekitusviis:
            int[] arvuMassiiv2 = [1,2,3];   // teine massivi tektitusviis kus järjendi pikkuse sätestamise aemel, pannakse elemendid kohe 
                                            // järjendit omava muutuja sisse, järjendi pikkust sätestama ei pea, kuna pikkuse tuletab kompilaator
                                            //sinna sisse pandud elementide koguse järgi.
            
            // -- massivi sisemised meetodid:
            int hasThisMany = arvuMassiv.Length;    // massiivi meetod "Length" mille me saame kasutusele võtta punkti abil, loendab kokku 
                                                    // mitu elementi, adresseeritav massiiv omab, omistatakse ainult järjendi pikkus, mitte
                                                    // järjendi sees olevaid elemente.
                                                    //2. Loend:
                                                    // List<T> ->   Loend on komposii andmetüüp, mille sees saab olla mitmeid samat tüüpi liht ja komposiitandmeid. Loend-tüüpi andmeid tähistatakse
                                                    // täiendava andmetüübikirjeldusega "List" mille järel noolsulgudesse <> asetatakse mis tüüpi andmed seal loendis on.
                                                    // Loendi tekitamisel, erinevalt massivist. ei pea ütlev kui pikk loend on.Loedisse saab dünaamiliselt elemente juurde lisada,
                                                    // ehk tema pikkus ei ole fikseeritud. Sarnasekt massiiviga saab temas hoida ka temas hoid ka teisi loendeid.
            // Esumee tekitusviis:
            List<int> arvuNimekiri = new List<int>();   // Andmetüübi kirjeldis "List<>" näitab et tegu on loendiga. Listi noolsulgude <> vehel on loendis
                                                        //olevate andmete andmetüüp. Antud juhul on andmetüübiks "int" mis tähistab täisarve. Muutuja enda 
                                                        //nimeks on "arvuNimekiri". Omistame sellesse muutujasse kaitstud sõna "new" abil uue tühja
                                                        //täisarvuloendi sätestusega "List<int>()".
            //Teine tekitusviis:
            List<int> arvuNimekiri2 = new List<int>() {1,2,3};  //Teine loendi tekitusviis. Andmetübi kirjeldus "List<>" näitab et tegu on loendiga, Listi
                                                                //noolsulgude vahel on loendis olevate elementide andmetüüp. Antud juhul on andmetüübiks "int"
                                                                //mis tähistab täisarve. Muutuja enda nimeks on "arvuNimekiri2". Omistame selle muutujasse
                                                                //kaitstud sõna "new" abil uue täisarvuloendi, aga seekord, peale sätestust "List<int>()" saame
                                                                //instantsieerimise hetkel talle kaasa anda ka esimesi elemente. Antud juhul on need elemendid
                                                                //"1", "2" ja "3". Elemendid sisestatakse nimekirja loogeliste sulgude vahel. Enam ei ole tegu
                                                                // tühja nimekirjaga, vaid loendiga kus kolm elementi juba sees.
            // kolmas tekivusviis:
            List<int> arvuNimekiri3 = new List<int>(3);  //Kolmas loendi tekitusviis. Andmetüübi kirjeldus "List<>" näitab et tegu on loendiga, Listi noolsulgude
                                                        //vahel on loendis olevate elementide andmetüüp. Antud juhul on andmetüübiks "int" mis tähistab täisarve.
                                                        //Muutuja enda nimeks on "arvuNimekiri3". Omistame sellesse muutujasse kaitstund sõna "new" abul uue
                                                        //täisarvuloendi, aga tavaliste sulgude vahele paneme arvu "3". Sarnaselt massiiviga ütleb see, et 
                                                        //Loend on 3 elemendi suurune. Loend ise ja tema elemendid on tühjad, aga seal on 3 elementi. Arv "3"
                                                        //on parameeter mida Listi konstruktor pikkuse määramiseks kasutab. Nimekiri säilitab oma omaduse muuta
                                                        //pikkust elementide lisamise-eemaldamisega, aga vajadusel saab nii, anda talle pikkuse.
            int aa = 9001;
            // -- Loendi sissemised meetodid:
            arvuNimekiri.Add(99);   //Loendi meetod "add()" lisab anne punkti olevale jarvendile uue element, elenent mida lisatakse an Add meetide sulge
                                    //vahel. Elementi sasab lisab lisab otse (antud juhul täisarv "99")
            arvuNimekiri.Add(aa);   //või muutujana.
            int loendipikkus = arvuNimekiri3.Count();  //Loendi meetod "Count()" loeb kokku mitu elementi järjendis on, meetod tagastab täisarvu mis vastab
                                                       //elementide kogusele.
            bool KasSeeArvOn = arvuNimekiri3.Count(3);  //Loendi meetod "Contains()" otsib kogu järjendi seest elementi, mis vastab sulgude vahel olevale 
                                                        //parameetrile. Meetod tagastab kas "true" või "false" - on leitud või ei ole. Tegemist on 
                                                        //põhimõtteliselt foreach tsükliga, mis otsib kindlat vastet, töötades läbi kogu loendi.
            arvuNimekiri3.Remove(4);    // Loendi meetod "Rwmove()" eemaldab enne olevast loendist. kindlal asukohal oleva elemendi. Sulgude vahel on parameetriks
                                        //eemaldatava elemndi asukahajärjekorranumber.

            ////põhilised matemaatilised tehted
            //int liitmine = 1 + 1; // liitmine, kaks arvu liidetakse kokku
            //int lahutamine = 1 - 1; // lahutamine, kus esimeset arvust lahutatakse maha teine
            //double korrutamine = 1 * 2; // kottutanine, kus teine arv korrutatakse esimese arvu kordi.
            //double jagamine = 1 / 2; //jagamine. esimene arv jagatakse teise arvuga.
            //double astendamine = Math.Pow(2, 2); // astendamine, esimene arv astendatakse teisega
            //double juurimine = Math.Sqrt(2); // ruutjuur, parammetrina juuritav arv

            ////muutuja nimed
            //int arv = 0;
            //string sõne = "abc";
            ////string string = "abx"; //kaitstud sõna kasutada ei saa

            ////muutuja nimeks ei sobi järgnevad sõnad:
            //// abstract, as, base, bool, break, byte, case,
            ////cath, char, checked, class, clount, continue, decimal,
            ////defual, delegate, do, double, else, enum, event,
            ////explicit, extren, false, finally, fixed, flout, for
            ////foreach, goto, if, implicit, in, int, interface, internal
            ////is, lock, long, namespace, new, null, object, operatot,
            ////out, override, params, private, protected, public, readonly,
            ////ref, return, sbyte, sealed, short, sizeof, stackalloc,
            ////static, string, struct, switch, this, throw, try, typeof,
            ////unit, ulong, unchecked, unsafe, unshort, using, virtual,
            ////void, volatile, while.

            ////3kalkulaator ifi ja elsififega
            //Console.WriteLine("Tere. Sisesta esimene arv");
            ////Adresserime moodulit "Console", punkti abil übil utleme, et kasutame funktsiooni WriteleLine selle jaoks et öelda kasutajale sõnum mis asub funktsioono nime järel sulgude vahel ümbritsetuna jutumärkidega. Kasutajale esitav sõnum on "Tere. Siseta esimene arv".

            //int arv1 = int.Parse(Console.ReadLine());
            ////instantsiseerime muutja nimega "arv1", ning selle ette anname andmetüübiks "int", see ütleb ära, et sin muutujas on täsarvud sees. Omistame muutujale võrdismärgi abil väärtuse, mille saame kasutajalt. Selle jaoks, adresseerime uuesti "Console" moodulit Aga seekord on funktsiooni nimi "Readline". Selleks, et käsureapealt tulev arv programmile tekstina ei näe välja, küsime int mooduli seest omakorda funktsiooni "Parse", ning paneme ReadLine funktsiooni Parse() sulgude vahel.

            //Console.WriteLine("Tere. Sisesta teine arv");

            ////Adresserime moodulit "Console", punkti abil übil utleme, et kasutame funktsiooni WriteleLine selle jaoks et öelda kasutajale sõnum mis asub funktsioono nime järel sulgude vahel ümbritsetuna jutumärkidega. Kasutajale esitav sõnum on "Tere. Siseta esimene arv".

            //int arv2 = int.Parse(Console.ReadLine());

            ////instantsiseerime muutja nimega "arv1", ning selle ette anname andmetüübiks "int", see ütleb ära, et sin muutujas on täsarvud sees. Omistame muutujale võrdismärgi abil väärtuse, mille saame kasutajalt.Selle jaoks, adresseerime uuesti "Console" moodulit Aga seekord on funktsiooni nimi "Readline".Selleks, et käsureapealt tulev arv programmile tekstina ei näe välja, küsime int mooduli seest omakorda funktsiooni "Parse", ning paneme ReadLine funktsiooni Parse() sulgude vahel.

            //Console.WriteLine("Sisesta tehtemärk: / * + -");
            ////Adresserime moodulit "Console" koos "WritleLine" funktsiooniga, et esitada kasutajale küsimuse "Sisesta tehtemärk : / * + -". Punkti abil saame moodulist Comsole, funktsiooni Writline, ning sulgude vahel ongi kasutajale esitav tekst. Tekst ise on ka ümbristetud jutumärkidega. Lause lõppeb lauselõpumärgiga ";".
            //string tehteyyp = Console.ReadLine();
            ////instantsieerime muutuja nimega "tegtetyyp", mille ette kirjutane andmetüübiks "string".
            ////Omistame võrdusmärgi abil, sellesse muutjasse kasutajalt sisendi mille saame kasutade "Console" moodulis oleva Readline() funktsiooni abil Lause lõpped lauselõpumärgiga ";".Lause lõppeb lauselõpumärgiga ";".


            //int tulemus = 0;
            //// instantsireerime muutuja nimega "tulemus", andmetüübiga int, ning omistame talle algse väärtuse võrdusmärgi võrdusmärgi abil, milleks on 0. Lause lõppeb lauselõpumärgiga ";".

            //if (tehteyyp == "+")
            //    //teeme tingimuslase if, ning selle tingimuse määrame ära sulgudega, mille vahel on võrdsuskontroll. Kontrollime kas muutuja "TEHTETYYP" omad andmeid samal kujul nagu võtdusmärkidest teist pool olev tekst "+". Siin lause ei lõppe, kuna tegu ei ole koodiga mis midagi kindlat vell ära teeb.
            //{
            //    tulemus = arv1 + arv2;

            //}
            ////peale tingimust on kodiplokk {} sulgude vahel, mis sialdab endas ühit koodirida.
            ////selles lauses omistame muutujale "tulemus" võrdusmärgi abil liitmistehte tulemuse, kus liidame kooku muutuja "arv1" ja muutuja "arv2" sisu. Lause lõppeb lauselõpumärgiga ";".
            //else if (tehteyyp == "-")
            //    //teeme sekundaarse tingimuslause "else if", ning määrame tema tingimuse ära sulgudaga.
            //    //Sulgude vahel on võrdsuskontroll. Kontrollime kas muutuja "tehtetyyp" onmad andmeid samal kujul nagu võrdusmärkifest teisel pool olev tekst "-" kui eelnev tingimus ei täitunud. Lause siin ei lõppe, vaid tingimusele järgneb koodiplokk.

            //{
            //    tulemus = arv1 - arv2;

            //}
            ////peale tingimust on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte koodirida. selles lause omistame muutujale "tulemus" võrdusmärgi abil lahutustehte tulemuse, kus lahutame muutuja "arv" sees olevast väärtusest maha "arv2" muutujas oleva väärtuse. //peale tingimust on kodiplokk {} sulgude vahel, mis sialdab endas ühit koodirida.
            ////selles lauses omistame muutujale "tulemus" võrdusmärgi abil liitmistehte tulemuse, kus liidame kooku muutuja "arv1" ja muutuja "arv2" sisu. Lause lõppeb lauselõpumärgiga ";". 
            //else if (tehteyyp == "/")
            //    //teeme sekundrase tingimuslause "else if", ning määrassme tema tingimuse ära sulgudega.
            //    //Sulgude vahel on võrdsuskontroll. kontrollime kas muutuja "tehtetyyp" omab andmeid samal kujal nagu võrdusmärkidest teisel pool olev tekst "/" kui eelnev tingimus ei täitunud. Lause siin ei lõppe, vaid tingimusele järgneb koodiplokk.
            //{
            //    tulemus = arv1 / arv2;

            //}
            ////peale tingimust on kodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte koodirida. selles lauses omistame muutujale "tulemus" võrdusmärgi abil korrutustehte tulemus, kus jagame mutujas "arv1" olev väärtuse, muutujas "arv2" oleva jagajaga. Lause lõppeb lauselõpumärgiga ";". 
            //else if (tehteyyp == "*")
            ////teeme sekundaarse tingimuslause "else if", ning määrame tema tingimuse ära silgudega.
            ////Sulgude vahel kujul nagu võrdsuskontrill. Kontrollime kas muutuja "tehtetyyp" omad andmeid samal kujul nagu võrdusmärkidest teisel pool olev tekst "*" kui eelnev tingimus ei täitunud. Lause lõppeb lauselõpumärgiga ";". 
            //{
            //    tulemus = arv1 * arv2;

            //}
            ////peale tingimust on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte koodirida. selles lause omistame muutujale "tulemus" võrdusmärgi abil korrutustehte tulemuse, kus korrutame muutujas "arv2" ilev vääärtuse muutujas "arv1" oleva väärtuse kordi. Lause lõppeb lauselõpumärgiga ";".
            //else if (tehteyyp == "^")
            ////teeme sekundaarse tingimuslause "else if", ning määrame tema tingimuse ära sulgudega.
            ////Sulgude vahel om võrdsuskontroll, kontrollime kas muutuja "tehtetyyp" omad andmeid samal kujul nagu võrdusmärkidest teisel poool olev tekst "^" kui eelnev tingimus ei täitunud. Lause lõppeb lauselõpumärgiga ";". 
            //{
            //    tulemus = (int)Math.Pow(arv1, arv2);

            //}
            ////peale tingimust on kodiplook {} loogeliste vahel, mis sisaldab endas ühte koodirida. Selles lause omistatakse võrdusmärgi abil muutujasse "tulemus" Mmille saame "Math moodulist pärineva funktsiooni "Pow()" abil. Math.pow() võtab parametritena sisse muutjad "arv1" ja "arv2". Esimene pareneter on astedatav, teine paremeeter on astendaja. Funktsiooni Math.Pow() ess on kiirteusendus (int), kuna muutuja "tulemus" andmetüüp on täisar. Math.Pow() väljund teisendatakse nii täisarvuks.
            ////Lause lõppeb lauselõpumärgiga ";". 
            //else
            ////peale kõiki järeltingimusi on meil tingimuslause osa "else" mida täidetakse kõikide muude tingimuslause osade mittetäitmisel. Siin araldi tingimust välja ei kirjutada ning sellest tulenevalt ei ole ka sulge. Jargneb ainult koodiplokk.
            //{
            //    Console.WriteLine("Palun siseta teha, mida kalkulaator oskab");
            //}
            ////peale "else" on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte koodrida. Selles koodireas kasutame moodulist "Console" punkti abil funktsioomi "WritLine" et öelda kasutajale "Palun siseta teha teha, mida kalkulaator tuvastada oskav". Koodirida lõppeb lauselõpumärgiga ";". 
            //if (tulemus != 0)
            //{
            //    Console.WriteLine(tulemus);
            //    //Kasutame moodulist "Console" punkti abil funktsiooni "Writlene" et kuvada kasutajale tehte tulemus. Selle jaoks on Writlene funktsioonus paremeetrina pandud muutuja "tilemus" ilma tekstiks teisendamate. Lause lõppeb lauselõpumärgiga ";". 
            //}
            //else
            //{
            //    Console.WriteLine("Tulemus on 0, või üritasid teha tehat, mida kalkulaatot ei tunne");
            //}

            Console.WriteLine("Sisesta ostusumaa");
            double ostusmaa = double.Parse(Console.ReadLine());
            if (ostusmaa >100)
            {
                Console.WriteLine("Saad 20% allahindlust!!!!!!!!!!!!!!!!");
            }
            else if(ostusmaa < 101 && ostusmaa > 50) 
            {
                Console.WriteLine("Saad 10% allagindlust. c: yay");
            }
            else if (ostusmaa < 51 && ostusmaa > 20)
            {
                Console.WriteLine("5% allahindlust.");
            }
            else if (ostusmaa < 21 && ostusmaa > 0)
            {
                Console.WriteLine("allahindlust ei saa");
            }
            else
            {
                Console.WriteLine("sisestatud on vogane arv");
            }
            //string kasutajanimi = "";
            //do
            //{
            //    console.writeline("palun sisesta oma kasutajanimi: ");
            //    kasutajanimi = console.readline();
            //} while (kasutajanimi != "user1");
            //if (kasutajanimi == "user1")
            //{
            //    int ruudusuurus = 0;

            //    do
            //    {
            //        console.writeline("kui suurt ruutu saada tahab?");
            //        ruudusuurus = int.parse(console.readline());
            //    } while (ruudusuurus < 0 || ruudusuurus > 20);

            //    char reakujund = '▒';
            //    string üksrida = "";
            //    int tsüklimuutuja = ruudusuurus;

            //    do
            //    {
            //        üksrida = üksrida + "_" + reakujund;
            //        tsüklimuutuja = tsüklimuutuja - 1;
            //    } while (tsüklimuutuja != 0);

            //    tsüklimuutuja = ruudusuurus;

            //    do
            //    {
            //        console.writeline(üksrida);
            //        tsüklimuutuja -= 1;
            //    } while (tsüklimuutuja != 0);

            //    console.writeline($"palun, siin on sinu ruut, suurega {ruudusuurus}x{ruudusuurus}");

            //}

            /* tingimuslause osad */
            if (true) { } // kaistud sõna if kutsub esile tingimuslause, mille tingimus on sulgude vahel, ning millele järgneb koodiplokk tingimuse täitumisel teostatava koodiga

            else if (true) { } // kaistud sõnad "else" ja "if" (else if) kutsuvad esile sekundaarse tingimuslause, mille tingimus on samamoodi sulgude vahel, ning millele pepab ellbena alat kas "if" või teine "else uf". Tingimuse täiumisel ja eelneva tingimuse mittetätumuse, teostakse kodiploki sees olev kood.

            else { } //kaitstud sõna "else" kutsub esile järelitingimuse, mille peab eelnemakas "if" või "else if", ning mille koodiploki sisu täidetakse kõikide teiste "if" ja "else if" tingimuste läbikukkumisel.

            int option = 3; //----

            switch (option) //"switch on kaitsud sõna altetnaatiivse tingimuskontrolli jaoks mida saab ef else-if asemel kasutada. Sulgude vahel käib muutuja nime, mille põhjal tingimuslik ümberlülitus toimub, Siin sulgede vahel ei ole tingimus ise, vaid kõigest kontrollitav muutuja, või omakorda sulgude vahel muu tingimus. pärast lülitusvalikut tuleb koodiplikk.
            {
                case 1: //koodiploki sees on erinevad juhtumid, juhtumit sätestatakse kaitsud sõna "case" abil. antud juhul kontrollitakse,
                        //kas muutujas "option" on väärtus 1, millele järgned koolon":" väljendades tingimuse täitumisel tehtava
                        //kooditegevuse algust
                    break;
                //Kui tegevis on tehtud, väljutakse mitte ainult juhtumist vaid kogu käesoleva case-tingimusikust kaistud sõnaga "break". peale breaki on läuselõpumärk ";".
                case 2:
                    //Juhtumeid võib olla mitmeid, antud juhul on neid kolm kindlalt.
                    break;
                case 3:
                    Console.WriteLine(option); //tehtav kooditegevus.
                    break;
                default:    //Default juhtumit täidetakse siis, kui ülejäänud juhtumid ei kirjelda muutujas "option" olevat seisu.
                    break;  // ka defailt lõppeb sõnaga break.
            }

            /* sõne tööriistab ja muud tekstiga seotut */
            string alfa = "a\nb";           // \n -> tekitab ühe sõne sisse reamurde, sõne kus on sees üks "\n", omab kahte rida.
            string beta = $"a {alfa} b";    // $  -> lubab kasutade muutjaid loogeliste sulgudega otse teksti sees. On vatiant formateeritud stringist.
            
            //* Loogilised tehad *//

            // & -> "and" loogiline teha, mida kasutatakse tingimuste kirjeldamisel, ning mis annab positiibse vastuse (true) juhul kui mõlemaö poll "&&" märki olevad tingimuste on täidetud. Kui üks neist ei ole, siis abbab negatiivse vastuse (false).

            // || -> "or"! loogiline tege, mida kasutatakse tingimuste kirjeldamisel, ning mis annab positiivse vastuse(true) siis kui vähemalt üks tingimus on täidetud.Negatiivne vastus(false) tagastatakse siis, kui kõik tingimused on täitmata.
            // !  -> "not" loogiline tehe, mida kasutatakse tingimuse tulemuse inverteerimiseks. Tulemus, mis muidu tagastaks(true), hüüumärgi abil tagastab(false), ja vastupidi tulemus mis muidu tagastaks(false), hüüumärgi abil tagastab(true)

            /* Võrdlusoperaatorid */

            // == -> "on võrdne". Võrdusmärkide ühel pool olev objekt peab vastama täpselt oma olemuselt võrdusmärkide teise pool oleva
            //      objektiga.ei ole sama nagu üks võrdusmärk, üks võrdusmärk omistab, kaks võrdleb.
            // != -> "ei ole võrdne". Võrdusmärgi ühel pool olev objekt *EI TOHI* olla samal kujul nagu võrdusmärgi teisel pool olev objekt
            //       Ta võib olla ükskõik mis mulle kujul, aga mitte võrreldava objektiga samal kujul. Võrdlusoperrator on kombanatsionon " on võrdnu operaatorist, ja loogilisest tehtest "not".
            //  > -> "on suurem kui". Märgist vasakul pool olev objekt peaks olema suurem, kui paremal pool olev objekt.
            //  < -> "on väiksem kui". Märgist vasakul pool olev objekt peaks olema väiksem, kui paremal pool olev objekt.
            //  >= -> "suuremvõrdne".Märgist vasakul pool olev objekt peaks olema vähemalt võrdne või suurem kui parempoolne objekt.
            //  Võrdlusoperaator on kombinatsioon "on võrdne" ja "on suurem kui" operaatoritest.
            //  <= -> "väiksemvõrdne". Мärgist vasakul pool olev objekt peaks olena vähemalt võrdne või väilsem kui parempoolne objekt.
            //        Võrdlusoperaator on kombinatsioon "on võrdne" ja "on väiksem kui" operaatoritest. 

            /* omistusoperaatorid ja kiirtehted */

            int thing = 1;  // = -> üksik võrdusmärk omistab muutuja sisse väärtuse, mida saab kasutada läbi muutuja nime.
            thing += 1;     // += -> võrdusmärk mille ees on pluss, automaatselt liidab muutujale otsa võrdusmärgi teisel pool oleva arvu.
                            //       asendab tehet "thing = tháng + 1". on kombinatsioon matemaatilisest tehtest "+" ja omistamisest "=".
            thing -= 1;     // -= ->võrdusmärk mille ees on miinus, automaatselt lauhtab muutujale maha võrdusmärgi teisel pool oleva arvu.
                            //       asendab tehet "thing = tháng - 1". on kombinatsioon matemaatilisest tehtest "-" ja omistamisest "=".
            thing *= 2;     // *= -> võrdusmärk mille ees on korrutusmärk "*", automaatselt korrutab muutuja sisu, võrdusmärgi teisel pool oleva arvu kordi.asendab tehet "thing = thing * 2".on kombinatsioon matemaatilisest tehtest "*" ja omistamisest "=".
            thing /= 2;     // = -> võrdusmärk mille ees on jagamismärk "/", automaatselt jagab muutuja sisu võrdusmärgi teisel pool oleva arvu osadeks. asendab tehet "thing = thing / 2".on kombinatsioon matemaatilisest tehtest "/" ja omistamisest "=".
            thing++;        // ++ -> on spetsiifiliselt ühe juurde liitmiseks kiirtehe.
            thing--;        // -- -> on spetsiifiliselt ühe maha lahutamiseks kiirtehe.    

            /* Tsüklid */
            // 1. do-while
            int dew = 0;
            do // "do" on kaitstud sõna, mis do-while tsüklit. Pärast seda on kodiplokk {} ning ütleb et seda koodi
            {
                dew++;
            } while (dew !=5); //niikaua kuni while järel olevate sulgude vahel tingimus ei täitu, käivitatakse eelnev kood uuesti.

            // 2. while
            int i = 1;      //tsüklimuutuja mis aitab järge pidada while tsükli toimisel
            while (i < 5)   //"while" on kaitstud sõna mis alustab while tsükli varianti, ilma "do"-ta, ning vajab alati välist tsüklimuutujat. antud juhul on selleks i. Tsükli tingimus, mis peale "while" sõna on, asub sulgude vahel, siin kontrollitaksegi tsükli tööd, läbi kindla tingimuse kasutades tsüklimuutujat. antud juhul tsükkel töötab niikaua, kuni i on väiksem kui 5. kui i on sama suur nagu 5, siis tsükkel katkeb.
            {
                //koodiplokk kus midagi tehakse
                i++;        //ning seejärel muudetakse tsüklimuutuja "i" olekut. antud juhul liidetakse 1 juurde kiirtehtega "++".
            }
            //3. For
            int kogus = 6;  // muutuja mida tsükkel kasutab oma töö tegemiseks - teisisönu, töödeldav materjal
            for (int k = 0; k < kogus; k++) //  kaitstud sõnaa "for" alustab for-tsüklit, pärast mida on sulud, mille vahel on kõik tsükli
                                            //  töö jaoks vajalik olemas. Esimene parameeter, tekitab tsükli töö jaoks kohaliku muutuja
                                            //  "int k = 0;" mida tsükli ENDA töö juhtimiseks.Teine parameeter on tingimuslause, mis kontrollib
                                            //  tingimuse täitumist "k < kogus;" ning mille täitumisel tsükli töö jätkub, aga mille
                                            //  mitte-täitumisel tsükkel katkeb. Kolmas parameeter on tsüklimuutuja inkrementeerimine kiirtehtega
                                            // "k++". Pane tähele, et iga sulgude vahel oleva osa järel (välja arvatud viimase) on
                                            // lauselõpumärk. Tsükli tööd kontrolliv tingimuslause koosneb kolmest reast, mitte ühest
                                            // nagu "while" või "do-while" puhul.
            {                               // sulgudele järgneb, loogeliste sulgude vahel ole koodiplook {}
                Console.WriteLine(k);       //täätlustegevus tsükli sees. on muutuja "k" hetkearvu väljakuvamine.
            }
            //4. foreach
            int[] arvuLoend = { 3, 67, 420, 69, 42 }; // massiv mida foreach kasutab või töötle mingil kujul
            foreach (var arvInLoend in arvuLoend)   // kaitstud sõna forach algustab foreach tsükli. Pärast mida on sulud, mille vahel tekitatakse
                                                    //ajutine muutine muutuja andmetüübiga "var" töödeldava andmekogumi ühisikelemendi jaoks. süntaksis olev
                                                    //kaitstud sõna "in" väljendab et tsükkel käib selle loendi elementide kohta, ning var "arvInLoend" 
                                                    //muutuja hoiab endas just peale sõna "in" oleva andmekogumi elementi. Tsüklil ei ole nähtasvat 
                                                    //tsüklimuutujat ega tingimust, tsükkel toimib niikaua kuni elemente jätkub, ehk tsükli töö käib
                                                    //iga ühsiku elemendi kohta endmekogumis individuaalselt. Tsüklil ei ole vaja tsüklimuutujat , kuna talle on
                                                    //sisse ehitatud vaikimisi elemendi järjestuse jälgimine.Niipalju kui andmeid loendis on, ongi see 
                                                    //mis ütleb ära, mitu korda tsükkel käivitatakse. Nii palju kui andmeid loendis on, ongi see
                                                    // mis ütleb ära, mitu korda tsükkel käivitakse.
            {                                       //peale sulge, on koodiplokk {} kus tehakse mingi tegevus
                Console.WriteLine(arvInLoend);      //Antud juhul kuvatakse välja ajutine muutuja, mille sees on loendi, hetkel tsüklis olev element.
            }
        }
    } 
}

