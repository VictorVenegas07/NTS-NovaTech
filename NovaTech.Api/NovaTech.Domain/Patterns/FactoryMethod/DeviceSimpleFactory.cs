using NovaTech.Api.Models.Request;

namespace NovaTech.Api.NovaTech.Domain.Patterns.FactoryMethod
{
    public class DeviceSimpleFactory
    {
        public static CreatorDevice CrearFabrica(string tipo)
        {

            switch (tipo.ToUpper())
            {
                case "Dispositivo":
                    return new ConcreteCCTVFactory();
                case "PMV":
                    return new ConcretePMVFactory();
                default: throw new InvalidDataException("Opcion invalida");
            }

        }
    }
}
