using AirlineCoreLibrary.Utility;
using AirlinesMessageProcessor;

var builder = Host.CreateApplicationBuilder(args);

// Register app dependecny services
builder.Services.RegisterAppServices();

builder.Services.AddHostedService<Worker>();

var host = builder.Build();
host.Run();
