namespace SõneÜlesanne2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> kasutajad = new List<List<string>>();
            kasutajad.Add(new List<string>(){ "usre1", "pasword1"});
            kasutajad.Add(new List<string>(){ "usre2", "pasword2"});

            string kasutajanimi = "";
            Console.WriteLine("palun sisesta oma kasutajanimi");
            kasutajanimi = Console.ReadLine();
            bool doesUsserExist = false;
            string õigeparool = "";

            foreach (var user in kasutajad)
            {
                if (user[0] == kasutajanimi)
                {
                    doesUsserExist = true;
                    õigeparool = user[1];
                }
                if (doesUsserExist == true)
                {
                    string sissestus = "";
                    do
                    {
                        Console.WriteLine("palun sisesta oma parool:");
                        sissestus = Console.ReadLine();
                    } while (sissestus != õigeparool);
                    Console.WriteLine($"Tere tulemust {kasutajanimi}");
                }
                else
                {
                    Console.WriteLine("kasutja ei eksisteeri");
                }
                //Console.WriteLine(user.ToString()+", " +user[0] +", "+user[1]+ "");
            }
        }
    }
}
