using Microsoft.EntityFrameworkCore;
using Project2Repository;
using Project2Repository.Implementation;
using Project2Repository.Interfaces;
using Project2Ruleset.Implementation;
using Project2Ruleset.Interface;

var builder = WebApplication.CreateBuilder(args);

var configurationBuilder = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true);

var configuration = configurationBuilder.Build();


// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddSingleton<IConfiguration>(configuration);

builder.Services.AddScoped<IUpdateEntryRepository, UpdateEntryRepository>();
builder.Services.AddScoped<IUpdateEntryRuleset, UpdateEntryRuleset>();

builder.Services.AddScoped<ITextUpdatesRepository, TextUpdatesRepository>();
builder.Services.AddScoped<ITextUpdatesRuleset, TextUpdatesRuleset>();

builder.Services.AddScoped<IBinaryUpdatesRepository, BinaryUpdatesRepository>();
builder.Services.AddScoped<IBinaryUpdatesRuleset, BinaryUpdatesRuleset>();

builder.Services.AddDbContext<Project2DbContext>(options => options.UseSqlServer(configuration.GetConnectionString("InfoStorage")));

builder.Services.AddEndpointsApiExplorer();



builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(b =>
    {
        b.WithOrigins("http://localhost").AllowAnyHeader().AllowAnyMethod();
    });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseRouting();
app.UseCors();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.UseHttpsRedirection();

app.Run();
