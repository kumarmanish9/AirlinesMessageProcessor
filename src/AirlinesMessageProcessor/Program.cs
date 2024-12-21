using AirlineCoreLibrary.Utility;
using AirlinesMessageProcessor;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.RegisterAppServices();
builder.Services.AddHostedService<Worker>();

var host = builder.Build();
host.Run();
