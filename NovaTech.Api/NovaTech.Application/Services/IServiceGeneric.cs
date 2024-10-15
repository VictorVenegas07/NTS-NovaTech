using NovaTech.Api.NovaTech.Domain.Entities.Dispostivos;

namespace NovaTech.Api.NovaTech.Application.Services
{
    public interface IServiceGeneric
    {
        IEnumerable<Dispositivo> GetAll();
        Dispositivo GetById(string id);
        void Add(Dispositivo entity);
        void Update(Dispositivo entity);
        void Delete(string id);
        IEnumerable<Dispositivo> Find(Func<Dispositivo, bool> predicate);
    }
}
