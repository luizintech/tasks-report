using Microsoft.AspNetCore.Mvc;
using TasksReportManager.Application.Dtos.Messages;
using TasksReportManager.Application.Dtos.TaskTypes;
using TasksReportManager.EFPersistence.Repositories;

namespace TasksReportManager.API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class TaskTypeController
    : ControllerBase
  {

    private readonly ILogger<TaskTypeController> _logger;
    private readonly TaskTypeRepository _repository;

    public TaskTypeController(ILogger<TaskTypeController> logger,
      TaskTypeRepository taskTypeRepository)
    {
      _logger = logger;
      _repository = taskTypeRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAsync()
    {
      return Ok(await this._repository.GetAllAsync());
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetByIdAsync(int id)
    {
      return Ok(await this._repository.GetByIdAsync(id));
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] TaskTypeEditDto entry)
    {
      var result = new ResultDto();

      try
      {
        await this._repository.AddAsync(entry.ToEntityModel());
        result.Success = true;
        return Ok(result);
      }
      catch (Exception ex)
      {
        _logger.LogError(ex.ToString());
        return StatusCode(500, ex.ToString());
      }
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> PutAsync([FromRoute]int id, [FromBody] TaskTypeEditDto entry)
    {
      var result = new ResultDto();

      try
      {
        var entity = await this._repository.GetByIdAsync(id);
        if (entity == null)
          return NotFound();

        await this._repository.UpdateAsync(entry.FillModel(entity));
        result.Success = true;
        return Ok(result);
      }
      catch (Exception ex)
      {
        _logger.LogError(ex.ToString());
        return StatusCode(500, ex.ToString());
      }
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteByIdAsync([FromRoute] int id)
    {
      var result = new ResultDto();

      try
      {
        var entity = await this._repository.GetByIdAsync(id);
        if (entity == null)
          return NotFound();

        entity.DeletedAt = DateTime.Now;
        await this._repository.UpdateAsync(entity);
        result.Success = true;
        return Ok(result);
      }
      catch (Exception ex)
      {
        _logger.LogError(ex.ToString());
        return StatusCode(500, ex.ToString());
      }
    }
  }
}
