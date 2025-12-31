using ConsoleApp1.AutomatiomTestResultManager.Models;

namespace ConsoleApp1.AutomatiomTestResultManager.Interfaces
{
    public interface ITestResultService
    {
        void Add(TestResult result);
        List<TestResult> GetAll();
    }
}
