namespace NovaTech.Api.NovaTech.Domain.Entities.PMVClass.ConexionClass
{
    public class ConexionHikvision : Conexion
    {
        public bool SoportaPoE { get; set; }
        public bool ConexionInalambrica { get; set; }
        public int NumeroDeCanales { get; set; }
    }
}
