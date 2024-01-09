using Microsoft.AspNetCore.Mvc.Formatters;
using SpaceAgencyado.DAO;
using SpaceAgencyado.Interface;

namespace SpaceAgencyado
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddControllers(options =>
            {
                options.OutputFormatters.Add(new XmlSerializerOutputFormatter());
            });
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IAgencyDA, AgencyDAL>();

            

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("client-allowed", policy =>
                {
                    policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()
                    ;
                });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();
            app.UseCors("client-allowed");


            app.MapControllers();

            app.Run();
          
        }
    }
}