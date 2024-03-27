using FluentValidation;
using FluentValidation.AspNetCore;
using VinciPartern.Aplicacao.Comando.Usuario;
using VinciPartern.Entidade;

WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<DbContexto>();
builder.Services.AddDbContext<DbContexto>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssemblyContaining<ComandoIncluirValidacao>();

WebApplication? app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
