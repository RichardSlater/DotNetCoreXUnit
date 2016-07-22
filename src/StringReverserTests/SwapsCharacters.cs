using Xunit;
using StringReverser;

namespace StringReverserTests {
    public class SwapsCharacters {
        [Fact]
        public void TwoDigitSwap() {
            const string original = "ab";
            var reverser = new Engine();
            var result = reverser.Reverse(original);
            Assert.Equal("ba", result);
        }
    }
}