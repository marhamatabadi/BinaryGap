using System.Diagnostics;

namespace BinaryGap.Test
{
    public class MainTest
    {
        [Theory]
        [InlineData([0, 0])]
        [InlineData([9, 2])]
        [InlineData([32, 0])]
        [InlineData([529, 4])]
        [InlineData([20, 1])]
        [InlineData([15, 0])]
        [InlineData([-1, 0])]
        [InlineData([int.MaxValue, 0])]
        public void Solution_AnswersTest(int n, int expected)
        {
            int actual = Main.Solution(n);
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void Solution_PerformanceTest()
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            // Act

            for (int i = 0; i < 10000; i++) // Run function multiple times (adjust iterations)
            {
                int N = new Random().Next(int.MaxValue);
                Main.Solution(N);

            }
            stopwatch.Stop();

            double elapsedMilliseconds = stopwatch.ElapsedMilliseconds;


            Assert.True(elapsedMilliseconds < 10, "elapsed Milliseconds Should be less then 10ms");
        }
    }
}