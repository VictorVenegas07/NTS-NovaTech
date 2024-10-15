using NovaTech.Api.NovaTech.Domain.Entities.CCTVClass.AlmacenamientoClass;
using NovaTech.Api.NovaTech.Domain.Entities.CCTVClass.ResolucionClass;
using NovaTech.Api.NovaTech.Domain.Entities.Dispostivos;

namespace NovaTech.Api.NovaTech.Domain.Entities.CCTVClass;

public class CCTV : Dispositivo
{
    public CCTV(string id, string nombre, string tipo, string direccionIp, string numeroSerie, string fabricante, Resolucion resolucion, Almacenamiento almacenamiento) : base(id, nombre, tipo, direccionIp, numeroSerie, fabricante)
    {
        Resolucion = resolucion;
        Almacenamiento = almacenamiento;
    }

    public Resolucion Resolucion { get; set; }
    public Almacenamiento Almacenamiento { get; set; }
    public override void ActualizarEstado()
    {
        throw new NotImplementedException();
    }

    public override void Reiniciar()
    {
        throw new NotImplementedException();
    }
}
