class Sample
{
    static void Main()
    {
        Device device = new Device();

        device.deviceID = 1001;
        device.deviceName = "mobile";
        device.cost = 30000;

        System.Console.WriteLine("DeviceID:" + device.deviceID);
        System.Console.WriteLine("Device name:" + device.deviceName);
        System.Console.WriteLine("Cost:" + device.cost);

        System.Console.ReadKey();
    }
}