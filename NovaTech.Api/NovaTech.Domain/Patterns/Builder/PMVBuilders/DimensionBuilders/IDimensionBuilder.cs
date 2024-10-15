using NovaTech.Api.NovaTech.Domain.Entities.PMVClass.DimensionClass;

namespace NovaTech.Api.NovaTech.Domain.Patterns.Builder.PMVBuilders.DimensionBuilders
{
    public interface IDimensionBuilder
    {
        IDimensionBuilder SetAnchoPanel(int anchoPanel);
        IDimensionBuilder SetAltoPanel(int altoPanel);
        IDimensionBuilder SetHikvisionOptions(string relacionAspecto, double peso, string tipoMaterial);
        IDimensionBuilder SetSonnyOptions(double tamanoPantalla, double espesor, double anguloVision);
        DimensionHikvision BuildHikvision();
        DimensionSonny BuildSonny();
    }
}
