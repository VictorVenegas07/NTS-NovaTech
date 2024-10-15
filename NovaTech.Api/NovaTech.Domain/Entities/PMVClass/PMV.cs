using NovaTech.Api.NovaTech.Domain.Entities.Dispostivos;
using NovaTech.Api.NovaTech.Domain.Entities.PMVClass.ConexionClass;
using NovaTech.Api.NovaTech.Domain.Entities.PMVClass.DimensionClass;


namespace NovaTech.Api.NovaTech.Domain.Entities.PMVClass
{
    public class PMV : Dispositivo
    {
        public PMV(string id, string nombre, string tipo, string direccionIp, string numeroSerie, string fabricante, Dimension dimension, Conexion conexion) : base(id, nombre, tipo, direccionIp, numeroSerie, fabricante)
        {
            Dimension = dimension;
            Conexion = conexion;
        }

        public Dimension Dimension { get; set; }
        public Conexion Conexion { get; set; }
        public override void ActualizarEstado()
        {
            throw new NotImplementedException();
        }

        public override void Reiniciar()
        {
            throw new NotImplementedException();

        }
    }
}
