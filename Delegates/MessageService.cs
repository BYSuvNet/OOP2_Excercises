class MessageService
{
    List<Message> messages = new(){ new Message("Hej!", "Ska vi gå på bio?", "Gustav", "Krister"),
                                     new Message("Re: Hej!", "Ja järnspikars vad kul! Jag vill se avataar!", "Krister", "Gustav"),
                                     new Message("Re: Re: Hej!", "Jasså? Jag vill hellre se Avataar 2", "Gustav", "Krister"),
                                     new Message("Re: Re: Re: Hej!", "Meeeeeh sluta dryga dig", "Gustav", "Krister") };

    // Extra: Skapa en klass som implementerar interfacet IDataLoader. Skicka in det objektet i denna konstruktor. Låt objektet 
    // fylla på 'message'-listan istället för att göra som här ovan (Ta alltså bort alla de objekten och låt listan vara tom från början.)
    // public MessageService(IDataLoader dataLoader)
    // {
    //     messages = dataLoader.GetMessages();
    // }

    // #1A. Lägg till en delegat som tar ett message-object som input, men inget returvärde. Kalla delegaten för OnMessageAdded

    public void AddMessage(Message msg)
    {
        messages.Add(msg);
        //Kalla på OnMessageAdded-delegaten här.
    }

    // #2 Skriv klart metoden ProcessMessages så att den kan ta emot och köra metoden FilterBadWords som skickas in från Main-metoden, på samtliga 
    // meddelanden i listan. Returvärdet skall läggas till den publika propertyn MessagesProcessed.

    public int MessagesProcessed { get; set; }

    public void ProcessMessages()
    {

    }

    // #3. Låt GetMessage ta en delegat som input. Delegatens uppgift skall vara att välja ut vilka Message-objekt 
    // ur listan 'messages' som skall läggas i tmpListan. Den skall alltså användas som ett sorts filter, så att metoden
    // kan returnera listor med olika typer av innehåll beroende på vad vi filtrerar på.
    public List<Message> GetMessages()
    {
        List<Message> tmpList = new();

        foreach (var msg in messages)
        {
            tmpList.Add(msg);
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
        From = from;
        To = to;
    }
}