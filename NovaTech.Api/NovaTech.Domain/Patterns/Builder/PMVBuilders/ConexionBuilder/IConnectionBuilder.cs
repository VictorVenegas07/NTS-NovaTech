using NovaTech.Api.NovaTech.Domain.Entities.PMVClass.ConexionClass;

namespace NovaTech.Api.NovaTech.Domain.Patterns.Builder.PMVBuilders.ConexionBuilder
{
    public interface IConnectionBuilder
    {
        IConnectionBuilder SetTipoConexion(string tipoConexion);
        IConnectionBuilder SetProtocoloComunicacion(string protocoloComunicacion);
        IConnectionBuilder SetHikvisionOptions(bool soportaPoE, bool conexionInalambrica, int numeroDeCanales);
        IConnectionBuilder SetSonnyOptions(bool soportaHDSDI, string tipoDeRed, bool capacidadIntegracion);
        ConexionHikvision BuildHikvision();
        ConexionSonny BuildSonny();
    }
}
