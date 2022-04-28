using System.Collections.Generic;
using System.Threading.Tasks;
using Challenge.Services.DTOs;

namespace Challenge.Services.Services.Interfaces
{
    public interface ISolutionService
    {
         Task<List<InmuebleDto>> GetInmueblesAsync();
    }
}