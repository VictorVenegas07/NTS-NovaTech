namespace NovaTech.Api.Models.Request
{
    public class DeviceRequest
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string DireccionIp { get; set; }
        public string NumeroSerie { get; set; }
        public string Fabricante { get; set; }

        public DimensionRequest? Dimension { get; set; }
        public ResolutionRequest? Resolucion { get; set; }
        public storageRequest? Almacenamiento { get; set; }
        public ConnectionRequest? Conexion { get; set; }
    }
}
