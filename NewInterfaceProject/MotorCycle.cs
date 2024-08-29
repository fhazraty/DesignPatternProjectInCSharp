namespace NewInterfaceProject
{
    public class MotorCycle : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Motor started!!!");
        }

        public void StopEngine()
        {
            Console.WriteLine("Motor stopped!!!");
        }
    }
}
