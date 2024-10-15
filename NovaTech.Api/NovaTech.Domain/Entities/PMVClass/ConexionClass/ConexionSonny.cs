namespace NovaTech.Api.NovaTech.Domain.Entities.PMVClass.ConexionClass
{
    public class ConexionSonny : Conexion
    {
        public bool SoportaHDSDI { get; set; }
        public string TipoDeRed { get; set; } = string.Empty;
        public bool CapacidadIntegracion { get; set; }
    }
}
