namespace NovaTech.Api.Models.Request
{
    public class ResolutionRequest
    {
        public int ResolucionHorizontal { get; set; }
        public int ResolucionVertical { get; set; }
        public double AnguloDeVision { get; set; }
        public string? Compresion { get; set; }
        public double? SensibilidadALuz { get; set; }
        public string? TecnologiaDeImagen { get; set; }
        public string? EstabilizacionDeImagen { get; set; }
    }
}
