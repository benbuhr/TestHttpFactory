using System.Threading.Tasks;

namespace TestHttpFactory
{
    public interface ITestService
    {
        Task<string> GetTest();
    }
}