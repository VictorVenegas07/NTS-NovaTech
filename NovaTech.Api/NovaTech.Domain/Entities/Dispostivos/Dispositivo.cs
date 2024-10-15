namespace NovaTech.Api.NovaTech.Domain.Entities.Dispostivos;

public abstract class Dispositivo
{
    protected Dispositivo(string id, string nombre, string tipo, string direccionIp, string numeroSerie, string fabricante)
    {
        Id = id;
        Nombre = nombre;
        Tipo = tipo;
        DireccionIp = direccionIp;
        NumeroSerie = numeroSerie;
        Fabricante = fabricante;
    }

    public string Id { get; set; }
    public string Nombre { get; set; }
    public string Tipo { get; set; }
    public string DireccionIp { get; set; }
    public string NumeroSerie { get; set; }
    public string Fabricante { get; set; }

    public abstract void Reiniciar();
    public abstract void ActualizarEstado();
}

