using System;
using System.Threading.Tasks;
using Xunit;
using XUnitTestExample.Attributes;

namespace XUnitTestExample
{
    public class UnitTest1
    {
        [Theory]
        [JsonFileData("all_data.json")]
        public async Task CanAddAll(int value1, int value2, int expected)
        {
            await Task.Delay(10000);
        }

        [Theory]
        [JsonFileData("data.json", "AddData")]
        public async Task CanAdd(int value1, int value2, int expected)
        {
            await Task.Delay(10000);
        }

        [Theory]
        [JsonFileData("data.json", "SubtractData")]
        public async Task CanSubtract(int value1, int value2, int expected)
        {
            await Task.Delay(10000);
        }
    }
}
