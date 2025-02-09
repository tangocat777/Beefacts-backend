using BeeFacts.Behavior;
using BeeFacts.Data;
using BeeFacts.Repository;
using BeeFacts.Singletons;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContextPool<BeeFactContext>(opt =>
    opt.UseNpgsql(builder.Configuration.GetConnectionString("BeeFactsContext")));
builder.Services.AddScoped<IBeeFactsService, BeeFactsService>();
builder.Services.AddScoped<IBeeFactRepository, BeeFactRepository>();
builder.Services.AddSingleton<IBeeFactSingleton, BeeFactSingleton>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(builder => {
    builder.AllowAnyOrigin();
    builder.AllowAnyMethod();
    builder.AllowAnyHeader();
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
