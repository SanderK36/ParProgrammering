namespace Chatbot
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Chatbot bot = null;
            while (true)
            {
                Console.WriteLine("Chatbot Lager");
                Console.WriteLine("1. Lag en ny chatbot");
                Console.WriteLine("2. Snakk med chatbot");
                Console.WriteLine("3. Avslutt");
                Console.Write("Velg et alternativ: ");
                string valg = Console.ReadLine();


                switch (valg)
                {
                    case "1":
                        Console.WriteLine("Gi botten et navn");
                        string navn = Console.ReadLine();
                        bot = new Chatbot(navn);

                        Console.WriteLine("skriv inn svar");
                        while (true)
                        {
                            Console.WriteLine("svar:");
                            string svar = Console.ReadLine();
                            if (svar.ToLower() == "ferdig") break;
                            if(!string.IsNullOrWhiteSpace(svar))
                                bot.Svar.Add(svar);
                        }
                        break;

                    case "2":
                        if (bot == null)
                        {
                            Console.WriteLine("Ingen chatbot å prate med");
                        }
                        else
                        {
                            Console.WriteLine($"du prater med {bot.Navn}");
                            while (true)
                            {
                                Console.Write("Du:");
                                string melding = Console.ReadLine();
                                if(melding.ToLower() == "ferdig") break;
                                Console.WriteLine($"{bot.Navn}: {bot.TilfeldigSvar()} ");
                            }
                        }
                        break;


                    case "3":
                        Console.WriteLine("Avslutter programmet...");
                        return;

                    default:
                        Console.WriteLine("Ugyldig valg, prøv igjen.");
                        break;
                }
            } 
        } 
    }
}