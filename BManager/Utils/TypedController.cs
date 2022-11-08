using AutoMapper;
using BManager.Dtos.Person;
using BManager.Utils.Abstractions;
using Devart.Common;
using Microsoft.AspNetCore.Mvc;

namespace BManager.Utils
{
    public abstract class TypedController<TEntity, TCreateDto, TViewDto, TUpdateDto>
        : ControllerBase
        where TEntity: AuditEntity
        where TCreateDto : class
        where TUpdateDto : class
    {
        protected readonly IRepository<TEntity> _repository;
        protected IMapper _mapper;

        public TypedController(IRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> Get(QueryParams? query)
        {
            return Ok(await _repository.GetAllAsync(query));
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            return Ok(await _repository.GetAsync(id));
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TCreateDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var entity = _mapper.Map<TEntity>(dto);

            try
            {
                await _repository.AddAsync(entity);
                await _repository.SaveAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
            return Ok(await _repository.GetAsync(entity.Id));
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] TUpdateDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var entityInDb = await _repository.GetAsync(id);
            if (entityInDb == null)
                return NotFound();
            var entity = _mapper.Map<TEntity>(dto);
            await _repository.UpdateAsync(entity);
            await _repository.SaveAsync();
            return Ok(_mapper.Map<TViewDto>(entity));
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var entit = await _repository.GetAsync(id);
                if (entit == null)
                    return NotFound();
                await _repository.Delete(entit);
                return Ok();
            }catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}
