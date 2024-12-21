using AirlineCoreLibrary.Service;

namespace AirlinesMessageProcessor
{
    public class Worker(ILogger<Worker> logger, IEventPublisher publisher) : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                if (logger.IsEnabled(LogLevel.Information))
                {
                    logger.LogInformation("Flight Event Processing: {time}", DateTimeOffset.Now);

                    // Simulate a flight event
                    await publisher.PublishFlightEventAsync();
                }
                await Task.Delay(5000, stoppingToken);
            }
        }
    }
}
