namespace NovaTech.Api.NovaTech.Domain.Entities.CCTVClass.AlmacenamientoClass
{
    public class AlmacenamientoHikvision : Almacenamiento
    {
        public bool SoportaRAID { get; set; }
        public bool CifradoDatos { get; set; }
        public double DurabilidadDisco { get; set; } // en horas
    }
}
