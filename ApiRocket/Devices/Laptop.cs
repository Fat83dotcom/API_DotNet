namespace ApiRocket.Devices
{
    public class Laptop : Device
    {
        public override string? Brand { get; set; }
        public override string? DeviceType { get; set; }
        public readonly bool isConnected = IsConnect(true);
    }
}
