using Autofac;
using Autofac.Extensions.DependencyInjection;
using BusinessLayer.AutoMapper;
using BusinessLayer.DependencyResolvers.Autofac;
using CoreLayer.DependencyResolvers;
using CoreLayer.Extensions;
using CoreLayer.Utilities.IoC;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder => {
    builder.RegisterModule(new AutofacBusinessModule());
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(AuthProfile));

builder.Services.AddDependencyResolvers(new ICoreModule[] {
               new CoreModule() });

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(builder => builder.WithOrigins("http://localhost:4205").AllowAnyHeader());

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
