namespace MobileLibTests
{
    using MobileLib;
    using NUnit.Framework;

    public class MobileLibTests
    {
        private Mobile mobile;

        [SetUp]
        public void Setup()
        {
            mobile = new Mobile();
        }

        [Test]
        public void TestPowerOn()
        {
            bool actualResponse = mobile.powerOn();
            Assert.IsTrue(actualResponse);
        }
    }
}
