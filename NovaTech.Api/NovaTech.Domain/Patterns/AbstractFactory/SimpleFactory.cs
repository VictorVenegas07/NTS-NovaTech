using NovaTech.Api.NovaTech.Domain.Patterns.AbstractFactory;

namespace NovaTech.Api.NovaTech.Domain.Patterns.AbstractFactory
{
    public class SimpleFactory
    {
        public static IAbstractFactory crearFabrica(string tipo)
        {

            switch (tipo.Trim())
            {
                case "hikvision":
                    return new hikvisionFactory();
                case "sony":
                    return new SonnyFactory();

                default: throw new InvalidDataException("Opcion invalida");
            }

        }
    }
}
