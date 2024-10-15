using NovaTech.Api.NovaTech.Domain.Entities.PMVClass.DimensionClass;

namespace NovaTech.Api.NovaTech.Domain.Patterns.Builder.PMVBuilders.DimensionBuilders;

public class DimensionBuilder : IDimensionBuilder
{
    private int _anchoPanel;
    private int _altoPanel;

    private string _relacionAspecto = string.Empty;
    private double _peso;
    private string _tipoMaterial = string.Empty;

    private double _tamanoPantalla;
    private double _espesor;
    private double _anguloVision;

    public IDimensionBuilder SetAnchoPanel(int anchoPanel)
    {
        _anchoPanel = anchoPanel;
        return this;
    }

    public IDimensionBuilder SetAltoPanel(int altoPanel)
    {
        _altoPanel = altoPanel;
        return this;
    }

    public IDimensionBuilder SetHikvisionOptions(string relacionAspecto, double peso, string tipoMaterial)
    {
        _relacionAspecto = relacionAspecto;
        _peso = peso;
        _tipoMaterial = tipoMaterial;
        return this;
    }

    public IDimensionBuilder SetSonnyOptions(double tamanoPantalla, double espesor, double anguloVision)
    {
        _tamanoPantalla = tamanoPantalla;
        _espesor = espesor;
        _anguloVision = anguloVision;
        return this;
    }


    public DimensionHikvision BuildHikvision()
    {
        return new DimensionHikvision
        {
            AnchoPanel = _anchoPanel,
            AltoPanel = _altoPanel,
            RelacionAspecto = _relacionAspecto,
            Peso = _peso,
            TipoMaterial = _tipoMaterial
        };
    }

    public DimensionSonny BuildSonny()
    {
        return new DimensionSonny
        {
            AnchoPanel = _anchoPanel,
            AltoPanel = _altoPanel,
            TamanoPantalla = _tamanoPantalla,
            Espesor = _espesor,
            AnguloVision = _anguloVision
        };
    }
}

