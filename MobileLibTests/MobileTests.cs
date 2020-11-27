namespace MobileLibTests
{
    using MobileLib;
    using Moq;
    using NUnit.Framework;

    public class MobileLibTests
    {
        private Mobile mobile;

        private Mock<ICamera> mockedCamera;

        [SetUp]
        public void Setup()
        {
            mockedCamera = new Moq.Mock<ICamera>();
            mobile = new Mobile(mockedCamera.Object);
        }

        [Test]
        public void TestPowerOnWhenCameraOnWorksNormally()
        {
            // SetUp
            mockedCamera.Setup(x => x.On()).Returns(true);

            // Act
            bool actualResponse = mobile.powerOn();

            // Assert
            Assert.IsTrue(actualResponse);
            mockedCamera.Verify(x => x.On(), Times.Once());
        }

        [Test]
        public void TestPowerOnWhenCameraOnMalFunctions()
        {
            // SetUp
            mockedCamera.Setup(x => x.On()).Returns(false);

            // Act
            bool actualResponse = mobile.powerOn();

            // Assert
            Assert.IsFalse(actualResponse);
            mockedCamera.Verify(x => x.On(), Times.Once());
        }
    }
}
