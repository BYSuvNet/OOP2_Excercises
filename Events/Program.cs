// Hjälp: https://www.tutorialsteacher.com/csharp/csharp-event

// Denna uppgift handlar om att skapa DoorSensor-klassen
// Denna klass har som syfte att lyssna på en påhittad dörrsensor som säger till när en dörr öppnas eller stängs.
// Vi kommer att simulera detta antingen genom 
// Start-metoden kan ha en while-loop som antingen lyssnar på tangentbordstryckning för att öppna/stänga dörr, 
// eller en slumvis vald tid den väntar och sen slumpar en ändring (Thread.Sleep(randomVärde))

internal class Program
{
    private static void Main(string[] args)
    {
        DoorSensor doorSensor = new DoorSensor();

        // Registrera metoden 'DoorStateChanged' på doorSensors event
        doorSensor.DoorStateChanged += DoorStateChanged;
        doorSensor.DoorStateChanged += StartAlarm;

        doorSensor.Start();
    }

    private static void DoorStateChanged(object sender, bool doorState)
    {
        Console.WriteLine("doorState: " + doorState);
    }

    static int doorOpenedCount = 0;

    //En metod som låtsas köra igång ett larm tredje gången en dörr öppnas
    private static void StartAlarm(object sender, bool doorState)
    {
        if (doorState) doorOpenedCount++;

        if (doorOpenedCount == 3 && !doorState)
        {
            doorOpenedCount = 0;
            Console.WriteLine("BEEEP BEEEP BEEEEP BEEEEP!");
        }
    }
}