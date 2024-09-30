using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

void Main()
{
	var builder = WebApplication.CreateBuilder(args);
	
	// Add services to the container.
	
	builder.Services.AddControllers();
	// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
	builder.Services.AddEndpointsApiExplorer();
	builder.Services.AddSwaggerGen();
	
	var app = builder.Build();
	builder.Services.AddDbContext<MyofficeACPDContext>(options => {
	    options.UseSqlServer(builder.Configuration.GetConnectionString("BackendExamHub"));
	});
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

// You can define other methods, fields, classes and namespaces here
