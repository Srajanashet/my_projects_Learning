using ConsoleApp1.AutomatiomTestResultManager.Interfaces;
using ConsoleApp1.AutomatiomTestResultManager.Models;

namespace ConsoleApp1.AutatiomTestResultManager.Services
{
    public class TestResultService : ITestResultService
    {
        private readonly List<TestResult> _results = new();

        public void Add(TestResult result)
        {
            _results.Add(result);
        }

        public List<TestResult> GetAll()
        {
            return _results;
        }
    }
}

