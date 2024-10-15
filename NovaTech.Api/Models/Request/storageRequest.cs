namespace NovaTech.Api.Models.Request
{
    public class storageRequest
    {
        public int CapacidadAlmacenamiento { get; set; }
        public bool SoportaAlmacenamientoEnNube { get; set; }
        public string FormatoVideo { get; set; } = string.Empty;
        public bool TieneAudio { get; set; }
        public double FrameRate { get; set; }
        public string TipoConexion { get; set; } = string.Empty;
        public string ProtocoloTransmision { get; set; } = string.Empty;
        public bool SoportaRAID { get; set; }
        public bool CifradoDatos { get; set; }
        public double DurabilidadDisco { get; set; }
         public bool SoportaNAS { get; set; }
        public string CompresionEspecifica { get; set; }
        public string InterfazAlmacenamiento { get; set; }
    }
}
