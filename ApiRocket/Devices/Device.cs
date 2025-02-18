namespace ApiRocket.Devices
{
    public abstract class Device
    {
        public abstract string? Brand { get; set; }
        public abstract string? DeviceType { get; set; }
        protected static bool IsConnect(bool value)
        {
            return value;
        }
    }
}
