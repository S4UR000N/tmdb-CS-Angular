using Common.Application.Extensions.JsonSerializer;
using Common.Application.Http;
using TMDB.Application;
using TMDB.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddHttpClient();
builder.Services.AddScoped<IHttpServiceProvider, HttpServiceProvider>();
builder.Services.AddApplication();
builder.Services.AddPersistence(builder.Configuration);
builder.Services.AddControllers()
    .AddJsonOptions(
        options => {
            options.JsonSerializerOptions.PropertyNamingPolicy =
            SnakeCaseNamingPolicy.Instance;
        });
;
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

app.UseAuthorization();

app.MapControllers();

app.Run();
