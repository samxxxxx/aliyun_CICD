namespace CICD_TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var i = 10 / 10;
            Assert.NotEqual(0, i);
        }
    }
}