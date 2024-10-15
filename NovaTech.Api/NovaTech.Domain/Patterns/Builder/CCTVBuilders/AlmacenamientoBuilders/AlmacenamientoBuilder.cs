using NovaTech.Api.NovaTech.Domain.Entities.CCTVClass.AlmacenamientoClass;

namespace NovaTech.Api.NovaTech.Domain.Patterns.Builder.CCTVBuilders.AlmacenamientoBuilders
{
    public class AlmacenamientoBuilder : IAlmacenamientoBuilder
    {
        private int _capacidadAlmacenamiento;
        private bool _soportaAlmacenamientoEnNube;
        private string _formatoVideo = string.Empty;
        private bool _tieneAudio;
        private double _frameRate;
        private string _tipoConexion = string.Empty;
        private string _protocoloTransmision = string.Empty;
        private bool _soportaRAID;
        private bool _cifradoDatos;
        private double _durabilidadDisco;

        public IAlmacenamientoBuilder SetCapacidadAlmacenamiento(int valor)
        {
            _capacidadAlmacenamiento = valor;
            return this;
        }

        public IAlmacenamientoBuilder SetSoportaAlmacenamientoEnNube(bool valor)
        {
            _soportaAlmacenamientoEnNube = valor;
            return this;
        }

        public IAlmacenamientoBuilder SetFormatoVideo(string valor)
        {
            _formatoVideo = valor;
            return this;
        }

        public IAlmacenamientoBuilder SetTieneAudio(bool valor)
        {
            _tieneAudio = valor;
            return this;
        }

        public IAlmacenamientoBuilder SetFrameRate(double valor)
        {
            _frameRate = valor;
            return this;
        }

        public IAlmacenamientoBuilder SetTipoConexion(string valor)
        {
            _tipoConexion = valor;
            return this;
        }

        public IAlmacenamientoBuilder SetProtocoloTransmision(string valor)
        {
            _protocoloTransmision = valor;
            return this;
        }


        public IAlmacenamientoBuilder SetSoportaRAID(bool valor)
        {
            _soportaRAID = valor;
            return this;
        }

        public IAlmacenamientoBuilder SetCifradoDatos(bool valor)
        {
            _cifradoDatos = valor;
            return this;
        }

        public IAlmacenamientoBuilder SetDurabilidadDisco(double valor)
        {
            _durabilidadDisco = valor;
            return this;
        }

        public AlmacenamientoHikvision BuildHikvision()
        {
            return new AlmacenamientoHikvision
            {
                CapacidadAlmacenamiento = _capacidadAlmacenamiento,
                SoportaAlmacenamientoEnNube = _soportaAlmacenamientoEnNube,
                FormatoVideo = _formatoVideo,
                TieneAudio = _tieneAudio,
                FrameRate = _frameRate,
                TipoConexion = _tipoConexion,
                ProtocoloTransmision = _protocoloTransmision
            };
        }

        public AlmacenamientoSonny BuildSonny()
        {
            return new AlmacenamientoSonny
            {
                CapacidadAlmacenamiento = _capacidadAlmacenamiento,
                SoportaAlmacenamientoEnNube = _soportaAlmacenamientoEnNube,
                FormatoVideo = _formatoVideo,
                TieneAudio = _tieneAudio,
                FrameRate = _frameRate,
                TipoConexion = _tipoConexion,
                ProtocoloTransmision = _protocoloTransmision
            };
        }
    }
}
