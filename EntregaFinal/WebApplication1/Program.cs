using WebApplication1.BibliotecaContextt;
using WebApplication1.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<BibliotecaContext>();
builder.Services.AddSingleton<EstadosServices>();
builder.Services.AddSingleton<LibrosServices>();
builder.Services.AddSingleton<PrestamosServices>();

var app = builder.Build();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();