using AutoMapper;
using Domain;
using Microsoft.AspNetCore.Mvc;
using WebApp_AutoMapper.ViewModel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/teams",
(
    [FromServices] IMapper _mapper
) =>
{
    return TypedResults.Ok(
        _mapper.Map<ICollection<Team>>(new FakerRepository().GetTeams())
    );
});

app.Run();
