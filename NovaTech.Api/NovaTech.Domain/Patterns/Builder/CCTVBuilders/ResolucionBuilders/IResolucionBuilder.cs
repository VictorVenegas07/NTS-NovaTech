using NovaTech.Api.NovaTech.Domain.Entities.CCTVClass.ResolucionClass;

namespace NovaTech.Api.NovaTech.Domain.Patterns.Builder.CCTVBuilders.ResolucionBuilders
{
    public interface IResolucionBuilder
    {
        IResolucionBuilder SetResolucionHorizontal(int valor);
        IResolucionBuilder SetResolucionVertical(int valor);
        IResolucionBuilder SetAnguloDeVision(double valor);
        IResolucionBuilder SetCompresion(string valor);
        IResolucionBuilder SetSensibilidadALuz(double valor);
        IResolucionBuilder SetTecnologiaDeImagen(string valor);
        IResolucionBuilder SetEstabilizacionDeImagen(string valor);
        ResolucionHikvision BuildHikvision();
        ResolucionSonny BuildSonny();
    }
}
