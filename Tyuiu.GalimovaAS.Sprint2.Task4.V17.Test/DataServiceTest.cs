using Tyuiu.GalimovaAS.Sprint2.Task4.V17.Lib;
namespace Tyuiu.GalimovaAS.Sprint2.Task4.V17.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds = new DataService();
        double x = -10;
        double y = 16;
        double res = ds.Calculate(x, y);
        double wait = 2975389733287.302;
        Assert.AreEqual(wait, res);
    }

    [TestMethod]
    public void VolidCondition2()
    {
        DataService ds = new DataService();
        double x = 51;
        double y = 40;
        double res = ds.Calculate(x, y);
        double wait = 40.005;
        Assert.AreEqual(wait, res);
    }
}
