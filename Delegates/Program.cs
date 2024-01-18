internal class Program
{
    private static void Main(string[] args)
    {
        MessageService messageService = new MessageService();

        // #1:

        messageService.AddMessage(new Message("Ang. hundfrisyren", "Jag önskar en helpermanentning av Fido, inte rakning. Hoppas mitt meddelande når dig i tid.", "Lasse på macken", "Sax&Koppel AB"));

        // #2: Avkommentera denna inför uppgift 2 i MessageService.
        // messageService.ProcessMessages(FilterBadWords);

        // #3 Se till så att du kan använda GetMessages med ett lambda som avgör vad du ska filtrera på så att du exempelvis
        //bara får meddelanden från Krister eller bara från Gustav 
        foreach (var message in messageService.GetMessages())
        {
            Console.WriteLine(message);
        }
    }

    // #1 - Skriv en metod som OnMessageAdded kan referera till. Låt metoden skriva ut vem som skickat ett meddelande till vem.


    // Till uppgift 2:
    public static int FilterBadWords(Message msg)
    {
        string badWord = "järnspikars";
        int count = msg.Body.Split(new string[] { badWord }, StringSplitOptions.None).Length - 1;
        msg.Body = msg.Body.Replace(badWord, "****");
        return count;
    }
}