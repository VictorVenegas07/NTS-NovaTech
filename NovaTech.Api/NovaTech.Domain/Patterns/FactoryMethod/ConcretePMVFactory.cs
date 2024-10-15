using NovaTech.Api.Models.Request;
using NovaTech.Api.NovaTech.Domain.Entities.Dispostivos;
using NovaTech.Api.NovaTech.Domain.Patterns.AbstractFactory;
using NovaTech.Api.NovaTech.Domain.Patterns.Builder.PMV;
using NovaTech.Api.NovaTech.Domain.Patterns.Builder.PMVBuilders;

namespace NovaTech.Api.NovaTech.Domain.Patterns.FactoryMethod
{
    public class ConcretePMVFactory : CreatorDevice
    {
        IPMVBuilder _PMVBuilder;
        public ConcretePMVFactory()
        {
            _PMVBuilder = new PMVBuilder();
        }
        public override Dispositivo CreateDevice(DeviceRequest request)
        {
            Factory = SimpleFactory.crearFabrica(request.Fabricante);
            return _PMVBuilder.
                SetId(Guid.NewGuid().ToString())
                .SetNombre(request.Nombre)
                .SetTipo(request.Tipo)
                .SetDireccionIp(request.DireccionIp)
                .SetNumeroSerie(request.NumeroSerie)
                .SetFabricante(request.Fabricante)
                .SetDimension(Factory.CreateDimensionBuilder(request.Dimension!))
                .SetConexion(Factory.CreateConnectionBuilder(request.Conexion!))
                .Build();
        }
    }
}
