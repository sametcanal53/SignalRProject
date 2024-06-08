﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstracts;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<T, TService, TGetListModel, TGetModel, TCreateDto, TUpdateDto> : ControllerBase where T : class where TCreateDto : class where TUpdateDto : class where TService : IGenericService<T>
    {
        private readonly TService _service;
        private readonly IMapper _mapper;

        public GenericController(TService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public virtual IActionResult GetAll()
        {
            var result = _mapper.Map<List<TGetListModel>>(_service.GetListAll());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public virtual IActionResult Get(int id)
        {
            var result = _mapper.Map<TGetModel>(_service.GetByID(id));
            return Ok(result);
        }

        [HttpPost]
        public virtual IActionResult Create(TCreateDto dto)
        {
            var result = _service.Add(_mapper.Map<T>(dto));
            return Ok(result);
        }

        [HttpPatch]
        public virtual IActionResult Update(TUpdateDto dto)
        {
            var result = _service.Update(_mapper.Map<T>(dto));
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public virtual IActionResult Delete(int id)
        {
            var entity = _service.GetByID(id);
            var result = _service.Delete(entity);
            return Ok(result);
        }

        [HttpGet("Count")]
        public virtual IActionResult GetCount([FromQuery] bool? isActive) => Ok(_service.GetCount(isActive));

    }
}
