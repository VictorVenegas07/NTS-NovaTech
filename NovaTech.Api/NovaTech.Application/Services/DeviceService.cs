using NovaTech.Api.NovaTech.Domain.Entities.Dispostivos;
using System.Text.Json;

namespace NovaTech.Api.NovaTech.Application.Services
{
    public class DeviceService : IServiceGeneric
    {
        private readonly string _filePath;
        public DeviceService()
        {
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            _filePath = Path.Combine(projectDirectory, $"{nameof(Dispositivo)}.json");
        }
        public void Add(Dispositivo entity)
        {
            var dispositivos = GetAll().ToList();
            dispositivos.Add(entity);
            SaveToFile(dispositivos);
        }

        
        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Dispositivo> Find(Func<Dispositivo, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Dispositivo> GetAll()
        {
            if (!File.Exists(_filePath))
            {
                return new List<Dispositivo>();
            }

            var json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Dispositivo>>(json) ?? new List<Dispositivo>();
        }

        public Dispositivo GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(Dispositivo entity)
        {
            throw new NotImplementedException();
        }
        private void SaveToFile(IEnumerable<Dispositivo> dispositivos)
        {
            var json = JsonSerializer.Serialize(dispositivos, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }
    }
}
