using IndustrialMachinepark.Shared.Entities;

namespace IndustrialMachinepark.Services
{
    public interface IMachineparkClient
    {
        Task<IEnumerable<Machine>> GetAsync();
        Task<IEnumerable<Machine>> GetJsonAsync<Machine>();
    }
}