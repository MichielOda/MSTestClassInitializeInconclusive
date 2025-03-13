namespace MSTestClassInitializeInconclusive
{
    [TestClass]
    public sealed class Test1
    {
        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            Assert.Inconclusive("Should not fail workflow");
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(true);
        }
    }
}
