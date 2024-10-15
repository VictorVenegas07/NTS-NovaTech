namespace NovaTech.Api.NovaTech.Domain.Entities.CCTVClass.ResolucionClass
{
    public abstract class Resolucion
    {
        public int ResolucionHorizontal { get; set; }
        public int ResolucionVertical { get; set; }
        public double AnguloDeVision { get; set; }
    }
}
