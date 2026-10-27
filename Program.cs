using Tp_Programacion3.Services;
using Tp_Programacion3.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IProductoService, ProductoService>(); //Registra el servicio ProductoService para que pueda ser inyectado en los controladores. Esto permite que el controlador ProductosController pueda utilizar los métodos definidos en IProductoService.

builder.Services.AddScoped<IProductoRepository, ProductoRepository>();// Registra el Repository: cuando pidan IProductoRepository, dar un ProductoRepository
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
