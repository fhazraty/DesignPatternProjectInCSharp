namespace NewInterfaceProject
{
    public class Car : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Start Engine car!!");
        }

        public void StopEngine()
        {
            Console.WriteLine("Stop Engine car!!");
        }
    }
}
