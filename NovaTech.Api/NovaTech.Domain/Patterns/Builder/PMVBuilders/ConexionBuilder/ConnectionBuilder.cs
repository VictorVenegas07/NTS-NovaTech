using NovaTech.Api.NovaTech.Domain.Entities.PMVClass.ConexionClass;

namespace NovaTech.Api.NovaTech.Domain.Patterns.Builder.PMVBuilders.ConexionBuilder
{
    public class ConnectionBuilder : IConnectionBuilder
    {
        private string _tipoConexion = string.Empty;
        private string _protocoloComunicacion = string.Empty;

        private bool _soportaPoE;
        private bool _conexionInalambrica;
        private int _numeroDeCanales;

        private bool _soportaHDSDI;
        private string _tipoDeRed = string.Empty;
        private bool _capacidadIntegracion;

        public IConnectionBuilder SetTipoConexion(string tipoConexion)
        {
            _tipoConexion = tipoConexion;
            return this;
        }

        public IConnectionBuilder SetProtocoloComunicacion(string protocoloComunicacion)
        {
            _protocoloComunicacion = protocoloComunicacion;
            return this;
        }

        public IConnectionBuilder SetHikvisionOptions(bool soportaPoE, bool conexionInalambrica, int numeroDeCanales)
        {
            _soportaPoE = soportaPoE;
            _conexionInalambrica = conexionInalambrica;
            _numeroDeCanales = numeroDeCanales;
            return this;
        }

        public IConnectionBuilder SetSonnyOptions(bool soportaHDSDI, string tipoDeRed, bool capacidadIntegracion)
        {
            _soportaHDSDI = soportaHDSDI;
            _tipoDeRed = tipoDeRed;
            _capacidadIntegracion = capacidadIntegracion;
            return this;
        }


        public ConexionHikvision BuildHikvision()
        {
            return new ConexionHikvision
            {
                TipoConexion = _tipoConexion,
                ProtocoloComunicacion = _protocoloComunicacion,
                SoportaPoE = _soportaPoE,
                ConexionInalambrica = _conexionInalambrica,
                NumeroDeCanales = _numeroDeCanales
            };
        }

        public ConexionSonny BuildSonny()
        {
            return new ConexionSonny
            {
                TipoConexion = _tipoConexion,
                ProtocoloComunicacion = _protocoloComunicacion,
                SoportaHDSDI = _soportaHDSDI,
                TipoDeRed = _tipoDeRed,
                CapacidadIntegracion = _capacidadIntegracion
            };
        }
    }
}
