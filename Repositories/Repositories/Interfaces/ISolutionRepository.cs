using System.Collections.Generic;
using System.Threading.Tasks;
using Challenge.Repositories.Models;

namespace Challenge.Repositories.Repositories.Interfaces
{
    public interface ISolutionRepository
    {
        Task<List<Inmueble>> GetInmueblesAsync();
        Task<Inmueble> UpdateInmuebleAsync(Inmueble inmueble);
        Task<List<Inmueble>> AddInmuebleAsync(Inmueble inmueble);
    }
}