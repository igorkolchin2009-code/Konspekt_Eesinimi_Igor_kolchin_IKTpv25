namespace SõneÜlesanne1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Напишите программу, которая
            // запрашивает у пользователя в цикле, какие игры ему нравятся.
            // хранит результаты вопросов в последовательности.
            // если последовательность содержит "Mario Kart" (.Contains()), то саркастически спрашивает, сколько ему лет.

            // если последовательность содержит "GTA 6", то спрашивает, откуда у него машина времени, чтобы Rockstar наконец-то её заполучили.
            // если последовательность содержит "Pong", то говорит: "80-е хотят вернуть стариков, происходит отзыв поколения бумеров".

            // если последовательность пуста, то программа продолжает выполнение.

            // спрашивает пользователя, не нравятся ли ему игры, и позволяет ему ответить "да" или "нет", проверяет ввод пользователя с помощью .ToUpper() или .ToLower().
            // если он отвечает "да", то говорит: "Но почему ты тогда не ввёл это?"

            //Если им это не нравится, скажите: «Извините».
            //Если ответ другой, скажите: «Я не понимаю :/».

            List<string> kasutajaMängud = new List<string>();
            string mängunimi = "";
            Console.WriteLine("Millised mägud sulle meeldivad?");
            while (mängunimi != "ei ole")
            {
                Console.WriteLine("palun sisesta järgimine mäng, kui rohkem ei ole, kirjuta \"ei ole\" ");
                mängunimi = Console.ReadLine();
                if (mängunimi !="ei ole")
                {
                    kasutajaMängud.Add(mängunimi);
                }
            }


            
            if (kasutajaMängud.Contains("mario kart"))
            {
                Console.WriteLine("Miks sa mario kart mängi , ningi 5 oled väi!?");
            }


            if (kasutajaMängud.Contains("gta 6"))
            {
                Console.WriteLine("kust ajamasina said? kuidas rockstar sellega juba valmis sai o_õ");
            }
            if (kasutajaMängud.Contains("pong"))
            {
                Console.WriteLine("80ndad tahavad vanureid tagasi, toimub boomerite recall");
            }
            if (!kasutajaMängud.Any())
            {
                Console.WriteLine("Kas sulle ei meeldi mängud? vasta kas jah või ei");
                string jahvõiei = Console.ReadLine().ToLower();
                if (jahvõiei.Contains("jah"))
                {
                    Console.WriteLine("aga miks siis ei sisestanud?");
                }
                if (jahvõiei.Contains("ei"))
                {
                    Console.WriteLine("kahiu :c");
                }
                else
                {
                    Console.WriteLine("ei saa aru :/");
                }
            }



        }
    }
}
