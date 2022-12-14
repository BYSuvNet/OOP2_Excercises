class MessageGenerator : IDataLoader
{
    public List<Message> GetMessages()
    {
        return new List<Message>(){  new Message("Hej!", "Ska vi gå på bio?", "Gustav", "Krister"),
                                     new Message("Re: Hej!", "Ja järnspikars vad kul! Jag vill se avataar!", "Krister", "Gustav"),
                                     new Message("Re: Re: Hej!", "Jasså? Jag vill hellre se Avataar 2", "Gustav", "Krister"),
                                     new Message("Re: Re: Re: Hej!", "Meeeeeh sluta dryga dig", "Krister", "Gustav") };
    }
}