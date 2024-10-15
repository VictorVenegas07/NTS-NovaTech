using NovaTech.Api.NovaTech.Domain.Entities.CCTVClass.ResolucionClass;
using NovaTech.Api.NovaTech.Domain.Entities.CCTVClass;

namespace NovaTech.Api.NovaTech.Domain.Patterns.Builder.CCTVBuilders;

public class CCTVBuilder : ICCTVBuilder
{
    private string _id;
    private string _nombre;
    private string _tipo;
    private string _direccionIp;
    private string _numeroSerie;
    private string _fabricante;
    private Resolucion _resolucion;
    private Almacenamiento _almacenamiento;

    public ICCTVBuilder SetId(string id)
    {
        _id = id;
        return this;
    }

    public ICCTVBuilder SetNombre(string nombre)
    {
        _nombre = nombre;
        return this;
    }

    public ICCTVBuilder SetTipo(string tipo)
    {
        _tipo = tipo;
        return this;
    }

    public ICCTVBuilder SetDireccionIp(string direccionIp)
    {
        _direccionIp = direccionIp;
        return this;
    }

    public ICCTVBuilder SetNumeroSerie(string numeroSerie)
    {
        _numeroSerie = numeroSerie;
        return this;
    }

    public ICCTVBuilder SetFabricante(string fabricante)
    {
        _fabricante = fabricante;
        return this;
    }

    public ICCTVBuilder SetResolucion(Resolucion resolucion)
    {
        _resolucion = resolucion;
        return this;
    }

    public ICCTVBuilder SetAlmacenamiento(Almacenamiento almacenamiento)
    {
        _almacenamiento = almacenamiento;
        return this;
    }

    public CCTV Build()
    {
        return new CCTV(_id, _nombre, _tipo, _direccionIp, _numeroSerie, _fabricante, _resolucion, _almacenamiento);
    }
}
