using _1_UI.Models;
using AutoMapper;
using Comoon.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace _1_UI.Controllers
{
    [Route("api/[controller]")]
[ApiController]
public class ChildController : ControllerBase
{
        private readonly IMapper _mapper;
        private readonly IChildService _childService;
        public ChildController(IChildService permissionService, IMapper mapper)
        {

            _childService = permissionService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<List<ChildDTO>> Get()
        {
            return await _childService.GetAllAsync();
        }
        [HttpGet("{id}")]
        public async Task<ChildDTO> Get(string  id)
        {
            return await _childService.GetByIdAsync(id);
        }
        [HttpPut]
        public async Task<ChildDTO> Update([FromBody] ChildModel model)
        {
            return await _childService.UpdateAsync(new ChildDTO() { NameOfChild = model.NameOfChild, BirthdayOfChild = model.BirthdayOfChild, IdOfChild = model.IdOfChild });
        }
        [HttpPost]
        public async Task<ChildDTO> Post([FromBody] ChildModel model)
        {
            ChildDTO p = await _childService.AddAsync(model.NameOfChild, model.IdOfChild, model.BirthdayOfChild);
            return p;
        }
    }
}
