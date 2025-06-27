using Azure.Identity;
using Bogus;
using IndieGameZone.API.Extensions;
using IndieGameZone.Application.AIService;
using IndieGameZone.Application.EmailServices;
using IndieGameZone.Application.Extensions;
using IndieGameZone.Application.RecombeeServices;
using IndieGameZone.Domain.Entities;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Identity;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
{
	options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Azure Key Vault
var keyVaultUrl = new Uri(builder.Configuration.GetSection("KeyVaultUrl").Value!);
var azureCredential = new DefaultAzureCredential();
builder.Configuration.AddAzureKeyVault(keyVaultUrl, azureCredential);

builder.Services.ConfigureQuartz();
builder.Services.ConfigureSwaggerForAuthentication();
builder.Services.ConfigureDatabase(builder.Configuration);
builder.Services.ConfigureCors();
builder.Services.ConfigureManager();
builder.Services.ConfigureGlobalException();
builder.Services.ConfigureMapsters();
builder.Services.ConfigureIdentity();
builder.Services.ConfigureJWT(builder.Configuration);
builder.Services.AddAuthorization();
builder.Services.ConfigureFirebase(builder.Configuration);
builder.Services.ConfigureBlobService(builder.Configuration);
builder.Services.AddHttpClient();
builder.Services.AddScoped<IRecombeeService, RecombeeService>();
builder.Services.AddScoped<IPasswordHasher<Users>, PasswordHasher<Users>>();
builder.Services.AddScoped<IAIService, AIService>();
builder.Services.AddScoped<IEmailSender, EmailSender>();
builder.Services.AddScoped<Faker>();
builder.Services.Configure<FormOptions>(options =>
{
	options.MultipartBodyLengthLimit = 300 * 1024 * 1024; // 300MB
});
builder.WebHost.ConfigureKestrel(options =>
{
	// Set max request size to 100 MB (or your desired limit)
	options.Limits.MaxRequestBodySize = 300 * 1024 * 1024; // 300 MB
});
builder.Services.Configure<IISServerOptions>(options =>
{
	options.MaxRequestBodySize = 100 * 1024 * 1024; // 100 MB
});
builder.Services.Configure<DataProtectionTokenProviderOptions>(options =>
{
	options.TokenLifespan = TimeSpan.FromHours(1);
});
//builder.Services.Configure<IdentityOptions>(options =>
//{
//	options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
//	options.Lockout.MaxFailedAccessAttempts = 5;
//	options.Lockout.AllowedForNewUsers = true;
//});
builder.Services.ConfigureApplicationCookie(options =>
{
	options.Cookie.HttpOnly = true;
	options.Cookie.SameSite = SameSiteMode.None;
	options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
});



var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();
app.UseExceptionHandler(opt => { });

app.UseHttpsRedirection();

app.UseRouting();

app.UseCors("CorsPolicy");

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
