using NUnit.Framework;
using Moq;

namespace TestingApp.Tests
{
    // Aryan Kumar Raj - 231fa18066
    
    [TestFixture]
    public class MathServiceTests
    {
        private Mock<ICalculator> _mockCalculator;
        private MathService _mathService;

        [SetUp]
        public void Setup()
        {
            // Initialize mock and inject into service
            _mockCalculator = new Mock<ICalculator>();
            _mathService = new MathService(_mockCalculator.Object);
        }

        [Test]
        public void CalculateSum_ShouldReturnCorrectResult()
        {
            // Arrange
            int a = 5;
            int b = 10;
            _mockCalculator.Setup(c => c.Add(a, b)).Returns(15);

            // Act
            int result = _mathService.CalculateSum(a, b);

            // Assert
            Assert.AreEqual(15, result);
            _mockCalculator.Verify(c => c.Add(a, b), Times.Once);
        }

        [Test]
        public void CalculateDifference_ShouldReturnCorrectResult()
        {
            // Arrange
            int a = 20;
            int b = 5;
            _mockCalculator.Setup(c => c.Subtract(a, b)).Returns(15);

            // Act
            int result = _mathService.CalculateDifference(a, b);

            // Assert
            Assert.AreEqual(15, result);
            _mockCalculator.Verify(c => c.Subtract(a, b), Times.Once);
        }
    }
}
