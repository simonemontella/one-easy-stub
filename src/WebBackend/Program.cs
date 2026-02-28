using Microsoft.EntityFrameworkCore;

using WebBackend.Data;
using WebBackend.Endpoints;
using WebBackend.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<OneEasyStubContext>(options =>
	options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IClienteService, ClienteService>();
builder.Services.AddScoped<IOrdineService, OrdineService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment()) {
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapClientiEndpoints();
app.MapOrdiniEndpoints();

app.Run();
