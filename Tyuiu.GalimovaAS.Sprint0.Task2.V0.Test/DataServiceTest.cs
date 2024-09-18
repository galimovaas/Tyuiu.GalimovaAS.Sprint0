using Tyuiu.GalimovaAS.Sprint0.Task2.V0.Lib;
namespace Tyuiu.GalimovaAS.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Alina";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Hello, Alina", res);
            
        }
    }
}