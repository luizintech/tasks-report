using Microsoft.AspNetCore.Mvc;
using TasksReportManager.Application.Dtos.Messages;
using TasksReportManager.Application.Dtos.Activities;
using TasksReportManager.EFPersistence.Repositories;
using TasksReportManager.Application.Dtos.ActivityTasks;
using TasksReportManager.EntitiesModel;

namespace TasksReportManager.API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ActivityTaskController
    : ControllerBase
  {

    private readonly ILogger<ActivityTaskController> _logger;
    private readonly ActivityTaskRepository _repository;
    private readonly ActivityRepository _activityRepository;
    private readonly TaskTypeRepository _taskTypeRepository;

    public ActivityTaskController(ILogger<ActivityTaskController> logger,
      ActivityTaskRepository activityTaskRepository,
      ActivityRepository activityRepository,
      TaskTypeRepository taskTypeRepository)
    {
      _logger = logger;
      _repository = activityTaskRepository;
      _activityRepository = activityRepository;
      _taskTypeRepository = taskTypeRepository;
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
    public async Task<IActionResult> PostAsync([FromBody] ActivityTaskEditDto entry)
    {
      var result = new ResultDto();

      try
      {
        var entity = entry.ToEntityModel();
        await RetrieveTableRelationsToStore(entity);

        await this._repository.AddAsync(entity);
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
    public async Task<IActionResult> PutAsync([FromRoute]int id, [FromBody] ActivityTaskEditDto entry)
    {
      var result = new ResultDto();

      try
      {
        var entity = await this._repository.GetByIdAsync(id);
        if (entity == null)
          return NotFound();

        var entityUpdate = entry.FillModel(entity);
        await RetrieveTableRelationsToStore(entityUpdate);

        await this._repository.UpdateAsync(entityUpdate);
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

    private async Task RetrieveTableRelationsToStore(ActivityTask entity)
    {
      entity.TaskType = await this._taskTypeRepository.GetByIdAsync(entity.TaskTypeId);
      entity.Activity = await this._activityRepository.GetByIdAsync(entity.ActivityId);
    }
  }
}
