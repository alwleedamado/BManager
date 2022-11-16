using BManager.Utils.Abstractions;

namespace BManager.Utils
{
    public abstract class TypedController<TEntity, TCreateDto, TViewDto, TUpdateDto, TFilter>
        : ControllerBase
        where TEntity: AuditEntity
        where TCreateDto : class
        where TUpdateDto : class
        where TFilter : class
        where TViewDto: class
    {
        protected readonly IRepository<TEntity, TFilter> _repository;
        protected IMapper _mapper;

        public TypedController(IRepository<TEntity, TFilter> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var entities = await _repository.GetAllAsync();
            return Ok(_mapper.Map<TViewDto[]>(entities));
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var entity = await _repository.GetNoTracking(id);
            return Ok(_mapper.Map<TViewDto>(entity));
        }

        [HttpGet("filter")]
        public async Task<IActionResult> GetFilter([FromQuery] QueryParams<TFilter> query)
        {
            var result = await _repository.GetByFilter(query);
            var items = _mapper.Map<List<TViewDto>>(result.Items);
            return Ok(new QueryResult<TViewDto>
            {
                Items = items,
                ErrorMessage = result.ErrorMessage,
                TotalCount = result.TotalCount,
            });
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
            var entity = _mapper.Map(dto, entityInDb);
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
