using NovaTech.Api.NovaTech.Domain.Entities.Dispostivos;
using NovaTech.Api.NovaTech.Domain.Entities.PMVClass.ConexionClass;
using NovaTech.Api.NovaTech.Domain.Entities.PMVClass.DimensionClass;

namespace NovaTech.Api.NovaTech.Domain.Patterns.Builder.PMVBuilders
{
    public interface IPMVBuilder
    {
        IPMVBuilder SetId(string id);
        IPMVBuilder SetNombre(string nombre);
        IPMVBuilder SetTipo(string tipo);
        IPMVBuilder SetDireccionIp(string direccionIp);
        IPMVBuilder SetNumeroSerie(string numeroSerie);
        IPMVBuilder SetFabricante(string fabricante);
        IPMVBuilder SetDimension(Dimension dimension);
        IPMVBuilder SetConexion(Conexion conexion);
        Dispositivo Build();
    }
}
