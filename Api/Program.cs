using Application.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IBracoService, BracoService>();
builder.Services.AddSingleton<ICabecaService, CabecaService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors(builder => builder.WithOrigins("http://localhost:5173").AllowAnyHeader().AllowAnyMethod());

app.MapControllers();

app.Run();
