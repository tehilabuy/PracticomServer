using AutoMapper;
using Comoon.DTOs;
using Repositories.Entities;
using Repositories.Interfaces;
using Repositories.Repositories;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<UserDTO> AddAsync(string UserName, string UserFamilyName, string UserId, DateTime UserBirthday, string HMO, string Gender, List<ChildDTO> ChildrenOfParent)
        {
            return _mapper.Map<UserDTO>(await _userRepository.AddAsync(UserName, UserFamilyName, UserId, UserBirthday, HMO, Gender, _mapper.Map <List< Child >> (ChildrenOfParent)));
        }

        public async Task DeleteAsync(string UserId)
        {
            await _userRepository.DeleteAsync(UserId);
        }

        public async Task<List<UserDTO>> GetAllAsync()
        {
            return _mapper.Map<List<UserDTO>>(await _userRepository.GetAllAsync());
        }

        public async Task<UserDTO> GetByIdAsync(string UserId)
        {
            return _mapper.Map<UserDTO>(await _userRepository.GetByIdAsync(UserId));
        }

        public async Task<UserDTO> UpdateAsync(UserDTO user)
        {
            return _mapper.Map<UserDTO>(await _userRepository.UpdateAsync(_mapper.Map<User>(user)));
        }
    }
}
