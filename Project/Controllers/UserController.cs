using _1_UI.Models;
using AutoMapper;
using Comoon.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using System.Reflection;

namespace _1_UI.Controllers
{
    [Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IUserService _UserService;
    public UserController(IUserService userService, IMapper mapper)
    {

        _UserService = userService;
        _mapper = mapper;
    }
    [HttpGet]
    public async Task<List<UserDTO>> Get()
    {
        return await _UserService.GetAllAsync();
    }
    [HttpGet("{id}")]
    public async Task<UserDTO> Get(string  id)
    {
        return await _UserService.GetByIdAsync(id);
    }
    [HttpPut]
    public async Task<UserDTO> Update([FromBody] UserModel model)
    {
            return await _UserService.UpdateAsync(new UserDTO() { UserName = model.UserName, UserFamilyName = model.UserFamilyName, UserId = model.UserId, UserBirthday = model.UserBirthday, HMO = model.HMO, Gender = model.Gender, ChildrenOfParent = model.ChildrenOfParent }) ;
    }
    [HttpPost]
    public async Task<UserDTO> Post([FromBody] UserModel model)
    {
        UserDTO p = await _UserService.AddAsync(model.UserName, model.UserFamilyName, model.UserId,model.UserBirthday,model.HMO,model.Gender,model.ChildrenOfParent);
        return p;
    }
}
}
