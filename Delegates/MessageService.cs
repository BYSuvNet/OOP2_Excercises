class MessageService
{
    List<Message> messages;

    // Extra: Skapa en klass som implementerar interfacet IDataLoader. Skicka in det objektet i denna konstruktor. Låt objektet 
    // fylla på 'message'-listan istället för att göra som här ovan (Ta alltså bort alla de objekten och låt listan vara tom från början.)
    public MessageService(IDataLoader dataLoader)
    {
        messages = dataLoader.GetMessages();
    }

    // #1A. Lägg till en delegat som tar ett message-object som input, men inget returvärde. Kalla delegaten för OnMessageAdded
    public Action<Message> OnMessageAdded;

    public void AddMessage(Message msg)
    {
        messages.Add(msg);

        //Kalla på OnMessageAdded-delegaten här.
        OnMessageAdded?.Invoke(msg);
    }



    // #2 Skriv klart metoden ProcessMessages så att den kan ta emot och köra metoden FilterBadWords som skickas in från Main-metoden, på samtliga 
    // meddelanden i listan. Returvärdet skall läggas till den publika propertyn MessagesProcessed.

    public int MessagesProcessed { get; set; }

    public void ProcessMessages(Func<Message, int> filter)
    {
        foreach (var item in messages)
        {
            MessagesProcessed += filter(item);
        }
    }

    // #3. Låt GetMessage ta en delegat som input. Delegatens uppgift skall vara att välja ut vilka Message-objekt 
    // ur listan 'messages' som skall läggas i tmpListan. Den skall alltså användas som ett sorts filter, så att metoden
    // kan returnera listor med olika typer av innehåll beroende på vad vi filtrerar på.
    public List<Message> GetMessages(Predicate<Message> filter = null)
    {
        //filter = msg => msg.From == "Krister";

        List<Message> tmpList = new();

        foreach (var msg in messages)
        {
            if (filter == null || filter(msg))
            {
                tmpList.Add(msg);
            }
        }

        return tmpList;
    }

}

class Message
{
    public int Id { get; set; }
    public DateTime SentAt { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
    public string From { get; set; }
    public string To { get; set; }

    public Message(string subject, string body, string from, string to)
    {
        Id = new Random().Next(0, 99999999);
        SentAt = DateTime.Now;
        Subject = subject;
        Body = body;
        From = from;
        To = to;
    }

    public override string ToString()
    {
        return Id + $": From:{From} to {To}. Subject: {Subject}. \n {Body}";
    }
}