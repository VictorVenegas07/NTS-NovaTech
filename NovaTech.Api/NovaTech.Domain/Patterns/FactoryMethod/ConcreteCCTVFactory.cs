using NovaTech.Api.Models.Request;
using NovaTech.Api.NovaTech.Domain.Entities.Dispostivos;
using NovaTech.Api.NovaTech.Domain.Patterns.AbstractFactory;
using NovaTech.Api.NovaTech.Domain.Patterns.Builder.CCTVBuilders;

namespace NovaTech.Api.NovaTech.Domain.Patterns.FactoryMethod
{
    public class ConcreteCCTVFactory : CreatorDevice
    {
        ICCTVBuilder _ICCTVBuilder;
        public ConcreteCCTVFactory()
        {
           _ICCTVBuilder = new CCTVBuilder();
        }
        public override Dispositivo CreateDevice(DeviceRequest request)
        {
            Factory = SimpleFactory.crearFabrica(request.Fabricante);
            return _ICCTVBuilder
                .SetId(Guid.NewGuid().ToString())
                .SetNombre(request.Nombre)
                .SetTipo(request.Tipo)
                .SetDireccionIp(request.DireccionIp)
                .SetNumeroSerie(request.NumeroSerie)
                .SetFabricante(request.Fabricante)
                .SetResolucion(Factory.CreateResolutionBuilder(request.Resolucion!))
                .SetAlmacenamiento(Factory.CreateStorageBuilder(request.Almacenamiento!))
                .Build();
        }
    }
}
