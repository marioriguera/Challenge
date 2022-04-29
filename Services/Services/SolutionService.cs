
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Challenge.Repositories.Models;
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

        public async Task<InmuebleDto> UpdateInmuebleAsync(InmuebleDto inmuebleDto)
        {
            var inmuebleAct = await _solutionRepository.UpdateInmuebleAsync(_mapper.Map<Inmueble>(inmuebleDto));
            return _mapper.Map<InmuebleDto>(inmuebleAct);
        }

        public async Task<List<InmuebleDto>> AddInmuebleAsync(InmuebleDto inmuebleDto)
        {
            var inmuebles = await _solutionRepository.AddInmuebleAsync(_mapper.Map<Inmueble>(inmuebleDto));
            List<InmuebleDto> inmuebleDtos = inmuebles.Select(x => _mapper.Map<InmuebleDto>(x)).ToList();
            return inmuebleDtos;
        }
    }
}
