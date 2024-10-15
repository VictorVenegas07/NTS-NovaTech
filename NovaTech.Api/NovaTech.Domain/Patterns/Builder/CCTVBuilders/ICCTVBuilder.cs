using NovaTech.Api.NovaTech.Domain.Entities.CCTVClass.ResolucionClass;
using NovaTech.Api.NovaTech.Domain.Entities.CCTVClass;
using NovaTech.Api.NovaTech.Domain.Entities.Dispostivos;

namespace NovaTech.Api.NovaTech.Domain.Patterns.Builder.CCTVBuilders
{
    public interface ICCTVBuilder
    {
        ICCTVBuilder SetId(string id);
        ICCTVBuilder SetNombre(string nombre);
        ICCTVBuilder SetTipo(string tipo);
        ICCTVBuilder SetDireccionIp(string direccionIp);
        ICCTVBuilder SetNumeroSerie(string numeroSerie);
        ICCTVBuilder SetFabricante(string fabricante);
        ICCTVBuilder SetResolucion(Resolucion resolucion);
        ICCTVBuilder SetAlmacenamiento(Almacenamiento almacenamiento);
        CCTV Build();
    }
}
