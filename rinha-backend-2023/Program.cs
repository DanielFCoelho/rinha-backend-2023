using rinha_backend_2023.Pessoas.Add.Services;
using rinha_backend_2023.Pessoas.Endpoints.AddPessoas;
using rinha_backend_2023.Pessoas.Endpoints.GetPessoas;
using rinha_backend_2023.Pessoas.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IAddPessoasService, AddPessoasService>();
builder.Services.AddScoped<IGetPessoasService, GetPessoasService>();

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

app.Run();

internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}