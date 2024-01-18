class DoorSensor
{
    //Lägg till ett event till denna klass
    //Se till att köra eventet vid rätt tillfälle med rätt argument

    public void Start()
    {
        bool isDoorOpen = false;

        while (true)
        {
            isDoorOpen = !isDoorOpen;
            Thread.Sleep(1000);
        }
    }
}