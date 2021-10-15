using FluentAssertions;
using Tethos.Moq;
using Xunit;

namespace Shorty.Tests
{
    public class ShortyTests : AutoMockingTest
    {
        [Fact]
        public void Generate_ShouldHaveDefaultLength()
        {
            // Arrange
            var sut = Container.Resolve<IShorty>();
            var expectedLength = 20;

            // Act
            var actual = sut.Generate();

            // Assert
            actual.Should().HaveLength(expectedLength);
        }

        [Fact]
        public void Generate_WithOptions_ShouldMatchLength()
        {
            // Arrange
            var sut = Container.Resolve<IShorty>();
            var expectedLength = 50;

            // Act
            var actual = sut.Generate(new ShortyOptions() { Length = expectedLength });

            // Assert
            actual.Should().HaveLength(expectedLength);
        }
    }
}
