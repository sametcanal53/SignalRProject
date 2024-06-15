using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.BaseControllerRequest;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController : ControllerBase
    {

    }

    public class GenericController<T, TModel> : GenericController
        where T : class
    {
        private readonly IGenericService<T> _service;
        private readonly IMapper _mapper;

        public GenericController(IGenericService<T> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public virtual IActionResult GetList(bool? includedPassive = false) => Ok(_mapper.Map<List<TModel>>(_service.GetList(includedPassive)));

        [HttpGet("{id}")]
        public virtual IActionResult Get(int id) => Ok(_mapper.Map<TModel>(_service.GetById(id)));

        [HttpGet("Count")]
        public virtual IActionResult GetCount(bool? isActive) => Ok(_service.GetCount(isActive));

        [HttpPatch("ChangeState")]
        public virtual IActionResult ChangeState(ChangeStateDtoRequest request) => Ok(_mapper.Map<TModel>(_service.ChangeState(request.Id, request.State)));

    }

    public class GenericController<T, TModel, TCreateDto> : GenericController<T, TModel>
        where T : class
        where TModel : class
        where TCreateDto : class
    {
        private readonly IGenericService<T> _service;
        private readonly IMapper _mapper;

        public GenericController(IGenericService<T> service, IMapper mapper) : base(service, mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpPost]
        public virtual IActionResult Create(TCreateDto createDto) => Ok(_mapper.Map<TModel>(_service.Add(_mapper.Map<T>(createDto))));

        [HttpDelete("{id}")]
        public virtual IActionResult Delete(int id) => Ok(_mapper.Map<TModel>(_service.Delete(_service.GetById(id))));
    }


    public class GenericController<T, TModel, TCreateDto, TUpdateDto> : GenericController<T, TModel, TCreateDto>
        where T : class
        where TModel : class
        where TCreateDto : class
        where TUpdateDto : class
    {
        private readonly IGenericService<T> _service;
        private readonly IMapper _mapper;

        public GenericController(IGenericService<T> service, IMapper mapper) : base(service, mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpPatch]
        public virtual IActionResult Update(TUpdateDto updateDto) => Ok(_mapper.Map<TModel>(_service.Update(_mapper.Map<T>(updateDto))));
    }
}
