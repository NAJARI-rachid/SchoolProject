using DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "SchoolAPI V1");//standard de ou est ce qu'on peut retrouver swagger
                options.RoutePrefix = "swagger";
            });

}
Console.Writeline("Swagger is running on /swagger");
//app.UseAuthorization();
app.MapControllers();
app.Run();