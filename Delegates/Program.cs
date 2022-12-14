internal class Program
{
    private static void Main(string[] args)
    {
        IDataLoader dataLoader = new MessageGenerator();

        MessageService messageService = new MessageService(dataLoader);

        // Till Uppgift 1.
        messageService.OnMessageAdded = PrintMessageSent;

        messageService.AddMessage(new Message("Ang. hundfrisyren", "Jag önskar en helpermanentning av Fido, inte rakning. Hoppas mitt meddelande når dig i tid.", "Lasse på macken", "Sax&Koppel AB"));

        // 2. Avkommentera denna inför uppgift 2 i MessageService.
        messageService.ProcessMessages(FilterBadWords);

        foreach (var message in messageService.GetMessages(msg => msg.From == "Krister"))
        {
            Console.WriteLine(message);
        }

        foreach (var message in messageService.GetMessages(msg => msg.From == "Krister" && msg.To == "Gustav"))
        {
            Console.WriteLine(message);
        }
    }

    // #1B - Skriv en metod som OnMessageAdded kan referera till. Låt metoden skriva ut vem som skickat ett meddelande till vem.
    public static void PrintMessageSent(Message msg)
    {
        Console.WriteLine($"{msg.From} sent a message to {msg.To}");
    }

    // Till uppgift 2:
    public static int FilterBadWords(Message msg)
    {
        string badWord = "järnspikars";
        int count = msg.Body.Split(new string[] { badWord }, StringSplitOptions.None).Length - 1;
        msg.Body = msg.Body.Replace(badWord, "****");
        return count;
    }
}