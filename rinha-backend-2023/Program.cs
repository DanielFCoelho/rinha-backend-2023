using Microsoft.EntityFrameworkCore;
using rinha_backend_2023.Capabilities.Persistence;
using rinha_backend_2023.Pessoas.Add.Services;
using rinha_backend_2023.Pessoas.Endpoints.AddPessoas;
using rinha_backend_2023.Pessoas.Endpoints.GetPessoas;
using rinha_backend_2023.Pessoas.Services;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IAddPessoasService, AddPessoasService>();
builder.Services.AddScoped<IGetPessoasService, GetPessoasService>();

builder.Services.AddDbContext<RinhaDBContext>(k =>
    k.UseNpgsql("Host=localhost;Database=rinha-2023;Username=rinha;Password=eu1234",
    k =>
    {
        k.EnableRetryOnFailure();
    }));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapPost("/pessoas", AddPessoas.AddPessoasAsync)
    .Produces(StatusCodes.Status201Created)
    .Produces(StatusCodes.Status422UnprocessableEntity)
    .Produces(StatusCodes.Status400BadRequest);

app.MapGet("/pessoas/{id}", GetPessoas.GetPessoaByIdAsync)
    .Produces(StatusCodes.Status200OK)
    .Produces(StatusCodes.Status404NotFound)
    .Produces(StatusCodes.Status400BadRequest);

app.MapGet("/pessoas", GetPessoas.GetPessoasByTermsAsync)
    .Produces(StatusCodes.Status200OK)
    .Produces(StatusCodes.Status404NotFound)
    .Produces(StatusCodes.Status400BadRequest);

app.MapGet("/contagem-pessoas", GetPessoas.GetTotalPessoasAsync)
    .Produces(StatusCodes.Status200OK);

app.Run();


