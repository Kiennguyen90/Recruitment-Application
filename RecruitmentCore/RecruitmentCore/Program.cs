using Microsoft.EntityFrameworkCore;
using Recruitment.Application.Interfaces;
using Recruitment.Application.Services;
using Recruitment.Domain.Interfaces;
using Recruitment.Infrastructure.Data;
using Recruitment.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<RecruitmentDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultRecruitmentConnection"),
        sqlServerOptionsAction: sqlOptions =>
        {
            sqlOptions.EnableRetryOnFailure();
        });
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("MyPolicy", builder =>
    {
        builder.WithOrigins("http://localhost:3000", "http://anotherdomain.com") // Specify the allowed origins
               .AllowAnyHeader() // Allow any headers
               .AllowAnyMethod(); // Allow any HTTP method
    });
});


builder.Services.AddScoped<IJobServices, JobServices>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("MyPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
