/* Performance Testing Using Timeout
Problem:
Create a method LongRunningTask() that sleeps for 3 seconds before returning a result.
Use NUnit [Timeout(2000)] or MSTest [Timeout(2000)] to fail the test if the method takes more than 2 seconds. */

using NUnit.Framework;

namespace PerformanceApp
{
    [TestFixture]
    public class UnitTest1
    {
        private TaskService task;

        [SetUp]
        public void Setup()
        {
            task = new TaskService();
        }

        [Test]
        [Timeout(4000)]
        public void LongTask_Timeout()
        {
            task.LongRunningTask();
        }
    }
}
