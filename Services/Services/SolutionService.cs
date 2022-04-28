
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Challenge.Repositories.Repositories.Interfaces;
using Challenge.Services.DTOs;
using Challenge.Services.Services.Interfaces;

namespace Challenge.Services.Services
{
    public class SolutionService : ISolutionService
    {
        private readonly IMapper _mapper;
        private readonly ISolutionRepository _solutionRepository;

        public SolutionService(IMapper mapper, ISolutionRepository solutionRepository)
        {
            _mapper = mapper;
            _solutionRepository = solutionRepository;
        }

        public async Task<List<InmuebleDto>> GetInmueblesAsync()
        {
            var inmuebles = await _solutionRepository.GetInmueblesAsync();
            List<InmuebleDto> inmuebleDtos = inmuebles.Select(x => _mapper.Map<InmuebleDto>(x)).ToList();
            return inmuebleDtos;
        }
    }
}
