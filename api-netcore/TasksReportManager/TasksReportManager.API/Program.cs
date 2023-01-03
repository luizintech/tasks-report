using Microsoft.EntityFrameworkCore;
using TasksReportManager.API.Infra;
using TasksReportManager.EFPersistence.DbContexts;

namespace TasksReportManager.API
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var builder = WebApplication.CreateBuilder(args);

      // Add services to the container.
      builder.Services.AddDbContext<TaskReportDbContext>(options =>
      {
        options.UseSqlServer(builder.Configuration.GetConnectionString("TaskReportSqlServer"));
      });

      builder.Services.AddRepositoriesScope();

      builder.Services.AddControllers();
      // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
      builder.Services.AddEndpointsApiExplorer();
      builder.Services.AddSwaggerGen();

      var app = builder.Build();

      // Configure the HTTP request pipeline.
      if (app.Environment.IsDevelopment())
      {
        app.UseSwagger();
        app.UseSwaggerUI();
      }

      app.UseHttpsRedirection();

      app.UseAuthorization();


      app.MapControllers();

      app.Run();
    }
  }
}
