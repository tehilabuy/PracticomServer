using AutoMapper;
using Comoon.DTOs;
using Repositories.Entities;
using Repositories.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;


namespace Services.Services
{
    public class ChildService : IChildService
    {
        private readonly IChildRepository _childRepository;
        private readonly IMapper _mapper;
        public ChildService(IChildRepository childRepository, IMapper mapper)
        {
            _childRepository = childRepository;
            _mapper = mapper;
        }
        public async Task<ChildDTO> AddAsync(string NameOfChild, string IdOfChild, DateTime BirthdayOfChild )
        {
            return _mapper.Map<ChildDTO>(await _childRepository.AddAsync(NameOfChild, IdOfChild, BirthdayOfChild));
        }

        public async Task DeleteAsync(string ChildId)
        {
            await _childRepository.DeleteAsync(ChildId);
        }

        public async Task<List<ChildDTO>> GetAllAsync()
        {
            return _mapper.Map<List<ChildDTO>>(await _childRepository.GetAllAsync());
        }

        public async Task<ChildDTO> GetByIdAsync(string ChildId)
        {
            return _mapper.Map<ChildDTO>(await _childRepository.GetByIdAsync(ChildId));
        }

        public async Task<ChildDTO> UpdateAsync(ChildDTO child)
        {
            return _mapper.Map<ChildDTO>(await _childRepository.UpdateAsync(_mapper.Map<Child>(child)));
        }
    }
}
