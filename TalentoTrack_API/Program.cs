using Microsoft.EntityFrameworkCore;
using TalentoTrack.Common.Repositories;
using TalentoTrack.Common.Services;
using TalentoTrack.Dao.DB;
using TalentoTrack.Dao.Repositories;
using TalentoTrack.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IAccountService,AccountService >();
builder.Services.AddTransient<IAccountRepository, AccountRepository>();



builder.Services.AddDbContext<TalentoTrack_DbContext>(options=>
options.UseSqlServer(builder.Configuration["ConnectionStrings:DefaultConnection"])
);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
