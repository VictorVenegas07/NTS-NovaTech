using NovaTech.Api.NovaTech.Domain.Entities.CCTVClass;
using NovaTech.Api.NovaTech.Domain.Entities.CCTVClass.ResolucionClass;
using NovaTech.Api.NovaTech.Domain.Entities.Dispostivos;
using Pmv = NovaTech.Api.NovaTech.Domain.Entities.PMVClass.PMV;
using NovaTech.Api.NovaTech.Domain.Entities.PMVClass.ConexionClass;
using NovaTech.Api.NovaTech.Domain.Entities.PMVClass.DimensionClass;
using NovaTech.Api.NovaTech.Domain.Patterns.Builder.PMVBuilders;

namespace NovaTech.Api.NovaTech.Domain.Patterns.Builder.PMV
{
    public class PMVBuilder : IPMVBuilder
    {
        private string _id;
        private string _nombre;
        private string _tipo;
        private string _direccionIp;
        private string _numeroSerie;
        private string _fabricante;
        private Dimension _dimension;
        private Conexion _conexion;

        public IPMVBuilder SetId(string id)
        {
            _id = id;
            return this;
        }

        public IPMVBuilder SetNombre(string nombre)
        {
            _nombre = nombre;
            return this;
        }

        public IPMVBuilder SetTipo(string tipo)
        {
            _tipo = tipo;
            return this;
        }

        public IPMVBuilder SetDireccionIp(string direccionIp)
        {
            _direccionIp = direccionIp;
            return this;
        }

        public IPMVBuilder SetNumeroSerie(string numeroSerie)
        {
            _numeroSerie = numeroSerie;
            return this;
        }

        public IPMVBuilder SetFabricante(string fabricante)
        {
            _fabricante = fabricante;
            return this;
        }

        public IPMVBuilder SetDimension(Dimension dimension)
        {
            _dimension = dimension;
            return this;
        }

        public IPMVBuilder SetConexion(Conexion conexion)
        {
            _conexion = conexion;
            return this;
        }

        public Dispositivo Build()
        {
            return new Pmv(_id, _nombre, _tipo, _direccionIp, _numeroSerie, _fabricante, _dimension, _conexion);
        }
    }
}
