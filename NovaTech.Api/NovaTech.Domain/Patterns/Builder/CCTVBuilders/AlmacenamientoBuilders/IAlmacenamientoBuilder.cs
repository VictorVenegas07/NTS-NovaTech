using NovaTech.Api.NovaTech.Domain.Entities.CCTVClass;
using NovaTech.Api.NovaTech.Domain.Entities.CCTVClass.AlmacenamientoClass;

namespace NovaTech.Api.NovaTech.Domain.Patterns.Builder.CCTVBuilders.AlmacenamientoBuilders
{
    public interface IAlmacenamientoBuilder
    {

        IAlmacenamientoBuilder SetCapacidadAlmacenamiento(int valor);
        IAlmacenamientoBuilder SetSoportaAlmacenamientoEnNube(bool valor);
        IAlmacenamientoBuilder SetFormatoVideo(string valor);
        IAlmacenamientoBuilder SetTieneAudio(bool valor);
        IAlmacenamientoBuilder SetFrameRate(double valor);
        IAlmacenamientoBuilder SetTipoConexion(string valor);
        IAlmacenamientoBuilder SetProtocoloTransmision(string valor);
        IAlmacenamientoBuilder SetSoportaRAID(bool valor);
        IAlmacenamientoBuilder SetCifradoDatos(bool valor);
        IAlmacenamientoBuilder SetDurabilidadDisco(double valor);
        AlmacenamientoHikvision BuildHikvision();
        AlmacenamientoSonny BuildSonny();
    }
}
