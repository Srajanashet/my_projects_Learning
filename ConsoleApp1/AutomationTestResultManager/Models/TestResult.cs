namespace ConsoleApp1.AutomatiomTestResultManager.Models
{
    public class TestResult
    {
        public int Id { get; }
        public string TestName { get; }
        public string Status { get; }
        public double ExecutionTime { get; }
        public DateTime ExecutedOn { get; }

        public TestResult(int id, string testName, string status, double executionTime)
        {
            Id = id;
            TestName = testName;
            Status = status;
            ExecutionTime = executionTime;
            ExecutedOn = DateTime.Now;
        }
    }
}

