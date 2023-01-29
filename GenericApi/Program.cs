using GenericApi;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

// Add services to the container.

services.AddControllers();

services.AddScoped<IShopping<Amazon>, Amazon>();
services.AddScoped<IShopping<Trendyol>, Trendyol>();
services.AddScoped<IShopping<N11>, N11>();
services.AddScoped<IShopping<Ebay>, Ebay>();
services.AddScoped<IShopping<Hepsiburada>, Hepsiburada>();

services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.

if(app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
