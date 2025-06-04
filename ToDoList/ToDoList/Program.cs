namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>();
            while (true)
            {
                Console.WriteLine("1: Legg til oppgave, 2: Slett oppgave, 3: sjekk oppgaver, 4: Avslutt");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Clear();
                    Console.Write("Tittel:");
                    string title = Console.ReadLine();
                    Console.Write("Beskrivelse: ");
                    string description = Console.ReadLine();
                    tasks.Add(new Task(title, description));
                    Console.Clear();
                }

                else if (choice == "2")
                {
                    Console.Clear();
                    for (int i = 0; i < tasks.Count; i++)
                        Console.WriteLine($"{i + 1}: {tasks[i].Title}");
                    Console.Write("Velg hva du vil slette: ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    if(index >= 0 && index < tasks.Count)
                        tasks.RemoveAt(index);
                }
                else if (choice == "3")
                {
                    Console.Clear();
                    for (int i = 0; i < tasks.Count; i++)
                    {
                        Console.WriteLine("Hvilken vil du sjekke?");
                        Console.WriteLine($"{i + 1}: {tasks[i].Title}");
                        int index = int.Parse(Console.ReadLine()) - 1;
                        if(index >= 0 && index < tasks.Count)
                            Console.Clear();
                        Console.WriteLine($"Tittel: {tasks[index].Title}\nBeskrivelse {tasks[index].Description}");
                        Console.WriteLine("");
                    }
                }
                else if (choice == "4")
                {
                    break;
                }
            }
        }
    }
}
