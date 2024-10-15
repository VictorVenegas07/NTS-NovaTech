using Microsoft.AspNetCore.Mvc;
using NovaTech.Api.Models.Request;
using NovaTech.Api.NovaTech.Application.Services;
using NovaTech.Api.NovaTech.Domain.Entities.Dispostivos;
using NovaTech.Api.NovaTech.Domain.Patterns.FactoryMethod;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NovaTech.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceController : ControllerBase
    {
        private CreatorDevice? creatorDevice;
        private readonly IServiceGeneric _service;

        public DeviceController(IServiceGeneric service)
        {
            _service = service;
        }

        [HttpPost]
        public ActionResult<Dispositivo> Post([FromBody] DeviceRequest request)
        {
            creatorDevice = DeviceSimpleFactory.CrearFabrica(request.Tipo);
            var response = creatorDevice.CreateDevice(request);
            _service.Add(response);
            return Ok(response);
        }

    }
}
