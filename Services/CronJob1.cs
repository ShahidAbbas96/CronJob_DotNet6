using Microsoft.Extensions.Logging;

namespace CronJob_DotNet6.Services
{
    public class CronJob1 (IScheduleConfig<CronJob1> config)
        : CronJobService(config.CronExpression, config.TimeZoneInfo)
    {
        public override Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("CronJob 1 starts.");
            return base.StartAsync(cancellationToken);
        }

        public override Task DoWork(CancellationToken cancellationToken)
        {
            Console.WriteLine($"CronJob 1 is working.{DateTime.Now}");
            return Task.CompletedTask;
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("CronJob 1 is stopping.");
            return base.StopAsync(cancellationToken);
        }
    }
}
