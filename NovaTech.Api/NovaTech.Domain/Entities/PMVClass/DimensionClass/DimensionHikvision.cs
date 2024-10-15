namespace NovaTech.Api.NovaTech.Domain.Entities.PMVClass.DimensionClass
{
    public class DimensionHikvision : Dimension
    {
        public string RelacionAspecto { get; set; } = string.Empty;
        public double Peso { get; set; }
        public string TipoMaterial { get; set; } = string.Empty;
    }
}
