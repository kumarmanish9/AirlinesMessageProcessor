using AirlineCoreLibrary.Service;
using AirlineCoreLibrary.Utility;

namespace AirlinesMessageProcessor
{
    public class Worker(IEventProcessor processor) : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                AppLogger.LogInfo($"Flight Event Listening to Process: {DateTimeOffset.Now}");

                // Simulate a flight event
                await processor.ProcessFlightEventAsync();

                // Wait for 5 seconds before processing the next event
                Thread.Sleep(5000);
            }
        }
    }
}
