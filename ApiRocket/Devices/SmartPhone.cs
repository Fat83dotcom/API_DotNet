namespace ApiRocket.Devices
{
    public class SmartPhone : Device
    {
        public override string? Brand { get; set; }
        public override string? DeviceType { get; set; }
        public bool IsConnected { get; } = IsConnect(true);
    }
}
