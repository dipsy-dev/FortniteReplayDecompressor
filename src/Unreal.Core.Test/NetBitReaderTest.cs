using Xunit;

namespace Unreal.Core.Test
{
    public class NetBitReaderTest
    {
        [Fact]
        public void RepMovementTest()
        {
            byte[] rawData = {
                0x50, 0x76, 0x07, 0x4F, 0xEB, 0xB0, 0x7F, 0x90, 0x01, 0xDD, 0x81, 0x0F,
                0xE2, 0x0E, 0x20
            };
            var reader = new NetBitReader(rawData, 79);
            reader.SerializeRepMovement();
            Assert.False(reader.IsError);
            Assert.True(reader.AtEnd());
        }

        [Fact]
        public void RepMovementTest2()
        {
            byte[] rawData = {
                0xD0, 0xD7, 0x07, 0x6F, 0xB0, 0xB3, 0x7F, 0x90, 0x01, 0xDD, 0x81, 0x0F,
                0xE2, 0x0E, 0x20
            };

            var reader = new NetBitReader(rawData, 118);
            reader.SerializeRepMovement();
            Assert.False(reader.IsError);
            Assert.True(reader.AtEnd());
        }

        [Fact]
        public void RepMovementTest3()
        {
            byte[] rawData = {
                0x34, 0xC6, 0x7F, 0xF7, 0xA1, 0xB7, 0x8B, 0xB0, 0x9F, 0xA2, 0xFE, 0xDD,
                0xD9, 0x25
            };

            var reader = new NetBitReader(rawData, 110);
            reader.SerializeRepMovement(locationQuantizationLevel: Models.Enums.VectorQuantization.RoundOneDecimal);
            Assert.False(reader.IsError);
            Assert.True(reader.AtEnd());
        }

        [Fact]
        public void RepMovementTest4()
        {
            byte[] rawData = {
                0x5A, 0x45, 0x13, 0xEF, 0x35, 0xFC, 0xA4, 0x4E, 0x77, 0xBF, 0x00, 0xDE,
                0x1D, 0xD6, 0xF2, 0x18, 0xB0, 0x95, 0x4C, 0xF5, 0xD1, 0xF0, 0x14, 0x7E,
                0xA7, 0x97, 0x1B, 0x01
            };

            var reader = new NetBitReader(rawData, 218);
            reader.SerializeRepMovement();
            Assert.False(reader.IsError);
            Assert.True(reader.AtEnd());
        }

        [Fact]
        public void NetUniqueIdTest()
        {
            byte[] rawData = {
                0x08, 0x31, 0x00, 0x00, 0x00, 0x44, 0x45, 0x53, 0x4B, 0x54, 0x4F, 0x50,
                0x2D, 0x32, 0x32, 0x38, 0x4E, 0x47, 0x43, 0x35, 0x2D, 0x42, 0x39, 0x31,
                0x33, 0x37, 0x31, 0x30, 0x38, 0x34, 0x46, 0x46, 0x32, 0x46, 0x37, 0x45,
                0x35, 0x44, 0x36, 0x38, 0x38, 0x30, 0x31, 0x39, 0x35, 0x30, 0x35, 0x30,
                0x39, 0x41, 0x43, 0x31, 0x34, 0x00
            };

            var reader = new NetBitReader(rawData, 432);
            reader.SerializePropertyNetId();
            Assert.False(reader.IsError);
            Assert.True(reader.AtEnd());
        }

        [Fact]
        public void NetUniqueIdTest2()
        {
            byte[] rawData = {
                0x11, 0x10, 0x37, 0xDF, 0x4A, 0x07, 0x98, 0xC2, 0x40, 0x2E, 0xAA, 0x62,
                0x69, 0x47, 0xEC, 0x29, 0x90, 0x3F
            };

            var reader = new NetBitReader(rawData, 144);
            reader.SerializePropertyNetId();
            Assert.False(reader.IsError);
            Assert.True(reader.AtEnd());
        }

        [Fact]
        public void NetUniqueIdTest3()
        {
            byte[] rawData = {
                0x29, 0x08, 0x25, 0x35, 0x43, 0x94, 0x31, 0x47, 0x40, 0x39
            };

            var reader = new NetBitReader(rawData, 80);
            reader.SerializePropertyNetId();
            Assert.False(reader.IsError);
            Assert.True(reader.AtEnd());
        }
    }
}
