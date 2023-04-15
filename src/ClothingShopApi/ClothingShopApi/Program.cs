using ClothingShopApi.Abstract.Interfaces;
using ClothingShopApi.Abstract.Models;
using ClothingShopApi.Database;
using ClothingShopApi.Database.UnitOfWork;
using ClothingShopApi.Database.UnitOfWork.Repositories;

var builder = WebApplication.CreateBuilder(args);

var settings = new AppSettings();
builder.Configuration.Bind(nameof(AppSettings), settings);
builder.Services.AddSingleton(settings);

builder.Services.ConfigureDatabase();
builder.Services.AddScoped<IBrandRepository, BrandRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IClothingRepository, ClothingRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});
builder.Services.AddHealthChecks();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();
app.UseCors();
app.UseHealthChecks("/healthcheck");

app.UseSwagger();
app.UseSwaggerUI();

//app.UseAuthentication();
//app.UseAuthorization();

app.MapControllers();

app.Run();
