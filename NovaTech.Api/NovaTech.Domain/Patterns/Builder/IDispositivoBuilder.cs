using NovaTech.Api.NovaTech.Domain.Entities.CCTVClass.ResolucionClass;
using NovaTech.Api.NovaTech.Domain.Entities.CCTVClass;
using NovaTech.Api.NovaTech.Domain.Entities.Dispostivos;
using NovaTech.Api.NovaTech.Domain.Entities.PMVClass.ConexionClass;
using NovaTech.Api.NovaTech.Domain.Entities.PMVClass.DimensionClass;

namespace NovaTech.Api.NovaTech.Domain.Patterns.Builder
{
    public interface IDispositivoBuilder
    {
        IDispositivoBuilder SetId(string id);
        IDispositivoBuilder SetNombre(string nombre);
        IDispositivoBuilder SetTipo(string tipo);
        IDispositivoBuilder SetDireccionIp(string direccionIp);
        IDispositivoBuilder SetNumeroSerie(string numeroSerie);
        IDispositivoBuilder SetFabricante(string fabricante);
        IDispositivoBuilder SetDimension(Dimension dimension);
        IDispositivoBuilder SetConexion(Conexion conexion);
        IDispositivoBuilder SetResolucion(Resolucion resolucion);
        IDispositivoBuilder SetAlmacenamiento(Almacenamiento almacenamiento);
        Dispositivo Build();
    }
}
