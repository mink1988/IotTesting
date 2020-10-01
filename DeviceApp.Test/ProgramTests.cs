using Xunit;

namespace DeviceApp.Test
{
    public class ProgramTests
    {
        [Fact]
        public void GetRandomValue()
        {
            var baseValue = 100;
            var multiplier = 0;

            var actual = Program.GetRandomValue(baseValue, multiplier);

            Assert.Equal(100, actual);
        }
    }
}
