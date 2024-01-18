using System.Diagnostics;

internal class Program
{
    static void Main()
    {
        DictionaryExercises();
        ListExercises();
        QueueExercises();
        StackExercises();
    }

    private static void DictionaryExercises()
    {
        // Dictionary<int, string> myDictionary = new Dictionary<int, string>();

        //1. Lägg till tre olika entries i dictionaryn, med Add()-metoden.
        //Key kan representera ett ID och Value kan representera ett namn.

        //2. Loopa igenom dictionaryn och skriv ut alla entries med ID och namn på varje rad

        //3. Skriv ut antalet entries i dictionaryn i stil med "Det finns total X antal personer i dictionaryn"

        //4. Låt användaren skriva in ett ID och ta bort det entry som har det ID:t. Se till att hantera
        //fallet då ID:t inte finns i dictionaryn.

        // COLLECTIONS01: Dictionary - Frekvensräknare
        //Skapa en metod som tar emot en lång sträng (tänk en längre text) och använder en dictionary 
        //för att räkna antalet förekomster av varje ord. Metoden skall returnera dictionaryn.
    }

    private static void ListExercises()
    {
        //COLLECTIONS02: Effektivitet i Listhantering
        //Skapa en int-array med minst längden 10000000.
        //Använd dig av Stopwatch-klassen för att undersöka skillnaden i effektivitet mellan metoden Add och 
        //AddRange när du lägger till alla ints i arrayen till en lista. Se exempel nedan med stopWatch.

        StopWatchExample();
    }

    private static void QueueExercises()
    {
        // COLLECTIONS04: Biljettkösimulator
        // 1.Skapa en kö:
        // Använd Queue<string> för att representera en kö av personer som väntar på att köpa biljetter.
        // 2.Lägg till personer i kön: 
        // Använd Encue() för att lägga till personer(namn) i kön. Varje person som läggs till i kön representerar en ny kund som anländer till biljettkassan.
        // 3.Hantera kön:
        // Skapa en loop där du successivt “släpper in” personer från kön(d.v.s., ta bort dem från början av kön med Dequeue()).Varje iteration av loopen ska representera en person som köper en biljett och lämnar kön. Använd Console.WriteLine för att skriva ut vilken person som köper biljett.
        // 4.Efter varje iteration, visa en lista över personer som fortfarande väntar i kön.

    }

    private static void StackExercises()
    {
        //1. Skapa en Stack<string> och lägg till tre strängar med Push() 

        //2. Skriv ut alla element i stacken med en foreach-loop


        //3. Ta bort det översta elementet i stacken med Pop()


        //4. Skriv ut alla element igen och observera skillnaden

    }

    private static void StopWatchExample()
    {
        //Skapa ett stopwatchobjekt
        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();

        //Här kan du lägga kod du vill mäta hur lång tid den tar
        //Exempel:
        Thread.Sleep(100);

        stopwatch.Stop();
        Console.WriteLine($"Tid som gått: {stopwatch.ElapsedMilliseconds} ms");


        //Använd restart för att nollställa och starta stopwatchen igen
        stopwatch.Restart();

        //Här kan du mäta mer kod! Exempel:
        Thread.Sleep(200);

        stopwatch.Stop();
        Console.WriteLine($"Tid som gått: {stopwatch.ElapsedMilliseconds} ms");
    }
}