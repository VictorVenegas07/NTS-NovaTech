namespace NovaTech.Api.Models.Request
{
    public class DimensionRequest
    {
        public int AnchoPanel { get; set; } // Ancho del panel en píxeles
        public int AltoPanel { get; set; }  // Alto del panel en píxeles
        public string? RelacionAspecto { get; set; }
        public double? Peso { get; set; }
        public string? TipoMaterial { get; set; }
        public double? TamanoPantalla { get; set; }
        public double? Espesor { get; set; }
        public double? AnguloVision { get; set; }
    }
}
