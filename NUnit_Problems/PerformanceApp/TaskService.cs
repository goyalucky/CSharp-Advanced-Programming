using System.Threading;

namespace PerformanceApp
{
    public class TaskService
    {
        public int LongRunningTask()
        {
            Thread.Sleep(1000); // 1 sec
            return 1;
        }
    }
}