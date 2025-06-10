using Azure.Storage.Blobs;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using IndieGameZone.Application;
using IndieGameZone.Application.BlobService;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Persistence;
using IndieGameZone.Infrastructure.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Quartz;
using Quartz.Simpl;
using System.Text;

namespace IndieGameZone.API.Extensions
{
	public static class ServiceExtensions
	{
		public static void ConfigureDatabase(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<AppDbContext>(options =>
				options.UseSqlServer(configuration.GetSection("DbString").Value));
		}

		public static void ConfigureBlobService(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddSingleton(u => new BlobServiceClient(configuration.GetSection("StorageAccount").Value));
			services.AddSingleton<IBlobService, BlobService>();
		}

		public static void ConfigureIdentity(this IServiceCollection services)
		{
			services.AddIdentity<Users, Roles>(o =>
			{
				o.Password.RequireDigit = false;
				o.Password.RequireLowercase = false;
				o.Password.RequireUppercase = false;
				o.Password.RequireNonAlphanumeric = false;
				o.Password.RequiredLength = 5;
				o.User.RequireUniqueEmail = true;
			})
				.AddEntityFrameworkStores<AppDbContext>()
				.AddDefaultTokenProviders();
		}

		public static void ConfigureCors(this IServiceCollection services) => services.AddCors(options =>
		{
			options.AddPolicy("CorsPolicy", builder =>
				builder.WithOrigins("http://localhost:5173", "https://indie-game-zone.vercel.app", "https://localhost:5173")
				.AllowCredentials()
				.AllowAnyMethod()
				.AllowAnyHeader()
				.WithExposedHeaders("X-Pagination"));
		});

		public static void ConfigureManager(this IServiceCollection services)
		{
			services.AddScoped<IRepositoryManager, RepositoryManager>();
			services.AddScoped<IServiceManager, ServiceManager>();
		}

		public static void ConfigureGlobalException(this IServiceCollection services)
		{
			services.AddProblemDetails();
			services.AddExceptionHandler<GlobalExceptionHandler>();
		}

		public static void ConfigureSwaggerForAuthentication(this IServiceCollection services)
		{
			services.AddSwaggerGen(option =>
			{
				option.AddSecurityDefinition(JwtBearerDefaults.AuthenticationScheme, new Microsoft.OpenApi.Models.OpenApiSecurityScheme()
				{
					Description =
						"JWT Authorization header using the Bearer scheme. \r\n\r\n" +
						"Enter your access token in the text input below.\r\n\r\n" +
						"Example: \"12345abcdef\"",
					Name = "Authorization",
					In = ParameterLocation.Header,
					Scheme = JwtBearerDefaults.AuthenticationScheme,
					Type = SecuritySchemeType.Http,
					BearerFormat = "JWT",
				});
				option.AddSecurityRequirement(new OpenApiSecurityRequirement()
				{
					{
						new OpenApiSecurityScheme()
						{
							Reference = new OpenApiReference()
							{
								Type = ReferenceType.SecurityScheme,
								Id = "Bearer"
							},
							Scheme = "bearer",
							Name = "Bearer",
							In = ParameterLocation.Header
						},
						new List<string>()
					}
				});
			});
		}

		public static void ConfigureJWT(this IServiceCollection services, IConfiguration configuration)
		{
			var jwtSettings = configuration.GetSection("JwtSettings");
			var secretKey = configuration.GetSection("SecretKey").Value;
			if (string.IsNullOrWhiteSpace(secretKey))
				throw new InvalidOperationException("JWT secret key is not configured.");

			services.AddAuthentication(opt =>
			{
				opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
				opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
				opt.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;

			})
			.AddJwtBearer(options =>
			{
				options.TokenValidationParameters = new TokenValidationParameters
				{
					ValidateIssuer = true,
					ValidateAudience = true,
					ValidateLifetime = true,
					ValidateIssuerSigningKey = true,

					ValidIssuer = jwtSettings["validIssuer"],
					ValidAudience = jwtSettings["validAudience"],
					IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
				};
			});
		}

		public static void ConfigureFirebase(this IServiceCollection services, IConfiguration configuration)
		{
			var firebaseJson = configuration.GetSection("FirebaseServiceAccount").Value;

			if (string.IsNullOrWhiteSpace(firebaseJson))
				throw new InvalidOperationException("Firebase service account JSON is missing in Key Vault");

			using var stream = new MemoryStream(Encoding.UTF8.GetBytes(firebaseJson));

			FirebaseApp.Create(new AppOptions
			{
				Credential = GoogleCredential.FromStream(stream)
			});
		}

		public static void ConfigureQuartz(this IServiceCollection services)
		{
			services.AddQuartz(q =>
			{
				q.UseJobFactory<MicrosoftDependencyInjectionJobFactory>();
			});
			services.AddQuartzHostedService(opt =>
			{
				opt.WaitForJobsToComplete = true;
			});
		}
	}
}
