using DataAccess.Abstract;
using DataAccess.Concrete.Repository;
using DataAccess.GenericRepository;
using DataAccess;
using WebAPI.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSignalR();

builder.Services.AddCors(options => options.AddDefaultPolicy(policy =>
                                        policy.AllowAnyMethod()
                                              .AllowAnyHeader()
                                              .AllowCredentials()
                                              .SetIsOriginAllowed(origin => true)
                        ));
builder.Services.AddControllers();

builder.Services.AddDataAccessServices(builder.Configuration);
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseCors();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapHub<MyHub>("/myhub");
});

app.MapControllers();

app.Run();
