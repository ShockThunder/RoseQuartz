using System.Threading.Tasks;

namespace RoseQuartz
{
    public class SchedulerService
    {
        public async Task<string> GetSchedulerInfo(Services services)
        {
            var result = await services.Scheduler.GetMetaData();

            return $"{result.SchedulerName} == {result.SchedulerType}";
        }
    }
}