using ApiRocket.Devices;
using Microsoft.AspNetCore.Mvc;

namespace ApiRocket.Controllers
{
    public class DeviceController : ApiBaseController
    {
        [HttpGet]
        public IActionResult Get()
        {
            IList<Device> devices = [];
            Laptop lap1 = new()
            {
                Brand = "Apple",
                DeviceType = "Laptop"
            };
            SmartPhone phone = new()
            {
                Brand = "Xiaomi",
                DeviceType = "SmartPhone"
            };
            
            devices.Add(lap1);
            devices.Add(phone);
            return Ok(devices);
        }
    }
}
