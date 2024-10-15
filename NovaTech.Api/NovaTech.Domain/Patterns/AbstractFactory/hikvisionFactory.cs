using NovaTech.Api.Models.Request;
using NovaTech.Api.NovaTech.Domain.Entities.CCTVClass;
using NovaTech.Api.NovaTech.Domain.Entities.CCTVClass.ResolucionClass;
using NovaTech.Api.NovaTech.Domain.Entities.PMVClass.ConexionClass;
using NovaTech.Api.NovaTech.Domain.Entities.PMVClass.DimensionClass;
using NovaTech.Api.NovaTech.Domain.Patterns.Builder.CCTVBuilders.ResolucionBuilders;
using NovaTech.Api.NovaTech.Domain.Patterns.Builder.CCTVBuilders.AlmacenamientoBuilders;
using NovaTech.Api.NovaTech.Domain.Patterns.Builder.PMVBuilders.ConexionBuilder;
using NovaTech.Api.NovaTech.Domain.Patterns.Builder.PMVBuilders.DimensionBuilders;

namespace NovaTech.Api.NovaTech.Domain.Patterns.AbstractFactory
{
    public class hikvisionFactory : IAbstractFactory
    {
        public Almacenamiento CreateStorageBuilder(storageRequest request)
        {
            IAlmacenamientoBuilder almacenamientoBuilder = new AlmacenamientoBuilder();
            return almacenamientoBuilder
                .SetCapacidadAlmacenamiento(request.CapacidadAlmacenamiento)
                .SetSoportaAlmacenamientoEnNube(request.SoportaAlmacenamientoEnNube)
                .SetFormatoVideo(request.FormatoVideo)
                .SetTieneAudio(request.TieneAudio)
                .SetFrameRate(request.FrameRate)
                .SetTipoConexion(request.TipoConexion)
                .SetProtocoloTransmision(request.ProtocoloTransmision)
                .BuildHikvision();

        }

        public Resolucion CreateResolutionBuilder(ResolutionRequest request)
        {
            IResolucionBuilder resolucionBuilder = new ResolucionBuilder();
            return resolucionBuilder
                .SetResolucionHorizontal(request.ResolucionHorizontal)
                .SetResolucionVertical(request.ResolucionVertical)
                .SetAnguloDeVision(request.AnguloDeVision)
                .SetCompresion(request.Compresion!)
                .SetSensibilidadALuz(request.SensibilidadALuz!.Value)
                .BuildHikvision();
        }

        public Conexion CreateConnectionBuilder(ConnectionRequest request)
        {
            IConnectionBuilder connectionBuilder = new ConnectionBuilder();

            return connectionBuilder
                .SetTipoConexion(request.TipoConexion)
                .SetProtocoloComunicacion(request.ProtocoloComunicacion)
                .SetHikvisionOptions(request.SoportaPoE ?? false, request.ConexionInalambrica ?? false, request.NumeroDeCanales ?? 0)
                .BuildHikvision();
        }

        public Dimension CreateDimensionBuilder(DimensionRequest request)
        {
            IDimensionBuilder dimensionBuilder = new DimensionBuilder();
            return dimensionBuilder
                 .SetAnchoPanel(request.AnchoPanel)
                 .SetAltoPanel(request.AltoPanel)
                 .SetHikvisionOptions(request.RelacionAspecto ?? string.Empty, request.Peso ?? 0, request.TipoMaterial ?? string.Empty)
                 .BuildHikvision();

        }
    }
}
