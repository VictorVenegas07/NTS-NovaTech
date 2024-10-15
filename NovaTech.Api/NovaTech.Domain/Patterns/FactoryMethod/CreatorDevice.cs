using NovaTech.Api.Models.Request;
using NovaTech.Api.NovaTech.Domain.Entities.Dispostivos;
using NovaTech.Api.NovaTech.Domain.Patterns.AbstractFactory;

namespace NovaTech.Api.NovaTech.Domain.Patterns.FactoryMethod
{
    public abstract class CreatorDevice
    {

        public IAbstractFactory? Factory;
        public abstract Dispositivo CreateDevice(DeviceRequest request);
    }
}
