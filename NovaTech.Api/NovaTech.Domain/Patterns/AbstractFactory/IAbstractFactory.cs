using NovaTech.Api.Models.Request;
using NovaTech.Api.NovaTech.Domain.Entities.CCTVClass;
using NovaTech.Api.NovaTech.Domain.Entities.CCTVClass.ResolucionClass;
using NovaTech.Api.NovaTech.Domain.Entities.PMVClass.ConexionClass;
using NovaTech.Api.NovaTech.Domain.Entities.PMVClass.DimensionClass;

namespace NovaTech.Api.NovaTech.Domain.Patterns.AbstractFactory
{
    public interface IAbstractFactory
    {
        Resolucion CreateResolutionBuilder(ResolutionRequest request);
        Almacenamiento CreateStorageBuilder(storageRequest request);
        Conexion CreateConnectionBuilder(ConnectionRequest request);
        Dimension CreateDimensionBuilder(DimensionRequest request);
    }
}
