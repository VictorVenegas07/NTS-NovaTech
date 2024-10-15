using NovaTech.Api.NovaTech.Domain.Entities.CCTVClass.ResolucionClass;

namespace NovaTech.Api.NovaTech.Domain.Patterns.Builder.CCTVBuilders.ResolucionBuilders
{
    public class ResolucionBuilder : IResolucionBuilder
    {
        private int _resolucionHorizontal;
        private int _resolucionVertical;
        private double _anguloDeVision;
        private string _compresion = string.Empty;
        private double? _sensibilidadALuz;
        private string _tecnologiaDeImagen = string.Empty;
        private string _estabilizacionDeImagen = string.Empty;

        public IResolucionBuilder SetResolucionHorizontal(int valor)
        {
            _resolucionHorizontal = valor;
            return this;
        }

        public IResolucionBuilder SetResolucionVertical(int valor)
        {
            _resolucionVertical = valor;
            return this;
        }

        public IResolucionBuilder SetAnguloDeVision(double valor)
        {
            _anguloDeVision = valor;
            return this;
        }

        public IResolucionBuilder SetCompresion(string valor)
        {
            _compresion = valor;
            return this;
        }

        public IResolucionBuilder SetSensibilidadALuz(double valor)
        {
            _sensibilidadALuz = valor;
            return this;
        }

        public IResolucionBuilder SetTecnologiaDeImagen(string valor)
        {
            _tecnologiaDeImagen = valor;
            return this;
        }

        public IResolucionBuilder SetEstabilizacionDeImagen(string valor)
        {
            _estabilizacionDeImagen = valor;
            return this;
        }

        public ResolucionHikvision BuildHikvision()
        {
            return new ResolucionHikvision
            {
                ResolucionHorizontal = _resolucionHorizontal,
                ResolucionVertical = _resolucionVertical,
                AnguloDeVision = _anguloDeVision,
                Compresion = _compresion,
                SensibilidadALuz = _sensibilidadALuz ?? 0
            };
        }

        public ResolucionSonny BuildSonny()
        {
            return new ResolucionSonny
            {
                ResolucionHorizontal = _resolucionHorizontal,
                ResolucionVertical = _resolucionVertical,
                AnguloDeVision = _anguloDeVision,
                TecnologiaDeImagen = _tecnologiaDeImagen,
                EstabilizacionDeImagen = _estabilizacionDeImagen
            };
        }
    }
}
