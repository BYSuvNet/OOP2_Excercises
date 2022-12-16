internal class Program
{
    private static void Main(string[] args)
    {
        DoorSensor doorSensor = new DoorSensor();

        // Registrera metoden 'DoorStateChanged' på doorSensors event

        // Start-metoden kan ha en while-loop som antingen lyssnar på tangentbordstryckning för att öppna/stänga dörr, 
        // eller en slumvis vald tid den väntar och sen slumpar en ändring (Thread.Sleep(randomVärde))

        doorSensor.Start();
    }

    private static void DoorStateChanged()
    {
        //Skriv ut vilken state dörren har här, samt när det hände
    }
}