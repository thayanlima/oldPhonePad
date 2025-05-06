using Xunit;
using OldPhonePadDecoder;

namespace OldPhonePadTests
{
    public class OldPhonePadDecoderTests
    {
        [Fact]
        public void Test_SingleLetter()
        {
            Assert.Equal("E", OldPhonePad.Decode("33#"));
        }

        [Fact]
        public void Test_WithBackspace()
        {
            Assert.Equal("B", OldPhonePad.Decode("227*#"));
        }

        [Fact]
        public void Test_FullWord()
        {
            Assert.Equal("HELLO", OldPhonePad.Decode("4433555 555666#"));
        }

        [Fact]
        public void Test_ComplexSequence()
        {
            Assert.Equal("TURING", OldPhonePad.Decode("8 88777444666*664#"));
        }

        [Fact]
        public void Test_EmptyInput()
        {
            Assert.Equal("", OldPhonePad.Decode("#"));
        }
    }
}
