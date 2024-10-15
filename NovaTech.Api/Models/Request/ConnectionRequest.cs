namespace NovaTech.Api.Models.Request
{
    public class ConnectionRequest
    {
        public string TipoConexion { get; set; } = string.Empty;
        public string ProtocoloComunicacion { get; set; } = string.Empty;
        public bool? SoportaPoE { get; set; }
        public bool? ConexionInalambrica { get; set; }
        public int? NumeroDeCanales { get; set; }
        public bool? SoportaHDSDI { get; set; }
        public string? TipoDeRed { get; set; }
        public bool? CapacidadIntegracion { get; set; }
    }
}
