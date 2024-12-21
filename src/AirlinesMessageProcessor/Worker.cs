using AirlineCoreLibrary.Service;

namespace AirlinesMessageProcessor
{
    public class Worker(IEventProcessor processor) : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                Console.WriteLine($"Flight Event Listening to Process: {DateTimeOffset.Now}");

                // Simulate a flight event
                await processor.ProcessFlightEventAsync();

                await Task.Delay(5000, stoppingToken);
            }
        }
    }
}
