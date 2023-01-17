internal class Program
{
    // INTRO TILL ASYNKRON PROGRAMMERING
    // 1: Konvertera DoTask() till en asynkron metod, så att du kan...
    // 2: Se till så att du kan starta både "Ladda ner fil" och "Genomför tung beräkning" samtidigt, 
    //    så att "Tryck för att avsluta programmet" kommer upp innan någon av dem är klara.
    // 3. Gör så att "Tryck för att avsluta programmet" visas först när båda uppgifterna är klara.
    // 4. Använd Task.Run() för att köra igång en task innan de två första är klara. Vänta på alla innan "Tryck för att avsluta" visas
    // 5. Extra klurig: Se till att få ett returvärde från den Task som körs med Task.Run() i form av en sträng. Skriv ut den strängen
    //    när tasken är klar (alltså inte inne i den metod som körs av Task.Run).

    // DEL TVÅ
    // 1. Gör en liten enkel meny. Med 'A' skall en ny Task startas och vi ska sen återgå till menyn, så att vi kan trycka på 'A' igen för
    //    att starta en ny Task oavsett om den första är klar eller inte. Tänk på att du inte kan använda Console.ReadKey eller ReadLine för detta
    //    då de metoderna gör att hela programmet pausar fram till du trycker något, utan du måste använda  if (Console.KeyAvailable) tillsammans med
    //    ConsoleKey key = Console.ReadKey(true).Key; istället.
    // 3. Tasken skall returnera en sträng, tex "Returvärde från task klar kl 15:32:15" Detta returvärde skall skrivas ut.
    // 4. När användaren trycker 'C' skall samtliga pågående Tasks avbrytas.
    // 5. Högst upp skall totala antalet pågående tasks skrivas ut
    // 6. Extra klurig: Skriv ut hur långt varje Task har kommit med hjälp av ett progress-objekt.



    private static void Main(string[] args)
    {
        Console.WriteLine("-----WELCOME------");

        DoTask("Ladda ner fil");
        DoTask("Genomför en tung beräkning");

        Console.WriteLine("\n <Tryck för att avsluta programmet> \n");
        Console.ReadKey();
    }

    static void DoTask(string taskName)
    {
        Console.WriteLine("STARTAR: " + taskName);
        Thread.Sleep(new Random().Next(1000, 5000));
        Console.WriteLine("KLAR: " + taskName);
    }
}