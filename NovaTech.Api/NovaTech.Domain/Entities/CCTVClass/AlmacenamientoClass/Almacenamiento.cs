namespace NovaTech.Api.NovaTech.Domain.Entities.CCTVClass
{
    public abstract class Almacenamiento
    {
        public int CapacidadAlmacenamiento { get; set; }
        public bool SoportaAlmacenamientoEnNube { get; set; }
        public string FormatoVideo { get; set; } = string.Empty;
        public bool TieneAudio { get; set; }
        public double FrameRate { get; set; }
        public string TipoConexion { get; set; } = string.Empty;
        public string ProtocoloTransmision { get; set; } = string.Empty;
    }
}
