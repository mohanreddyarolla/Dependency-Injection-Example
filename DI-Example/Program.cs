    using DI_Example.Contracts;
    using DI_Example.Controllers;
    using DI_Example.Services;

    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.

    builder.Services.AddControllers();

    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    builder.Services.AddTransient<ITransientService, TransientService>();

    // Scoped service registration
    builder.Services.AddScoped<IScopedService, ScopedService>();

    // Singleton service registration
    builder.Services.AddSingleton<ISingletonService, SingletonService>();

    builder.Services.AddTransient<ITask1, Task1>();
    builder.Services.AddTransient<ITask2, Task2>();

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
