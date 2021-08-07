using Quartz;

namespace RoseQuartz
{
    public class Services
    {
        public RoseQuartzOptions Options { get; set; }

        public IScheduler Scheduler { get; set; }
        
        public static Services Create(RoseQuartzOptions options)
        {
            var services = new Services
            {
                Options = options,
                Scheduler = options.Scheduler,
            };

            return services;
        }
    }
}