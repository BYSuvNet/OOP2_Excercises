class DoorSensor
{
    public event EventHandler<bool> DoorStateChanged;

    public void Start()
    {
        bool isDoorOpen = false;

        while (true)
        {
            isDoorOpen = !isDoorOpen;
            Thread.Sleep(1000);
            DoorStateChanged?.Invoke(this, isDoorOpen);
        }
    }
}