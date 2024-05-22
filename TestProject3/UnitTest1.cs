using Primer.Classes;
namespace TestProject3;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        //Arrange
        var _orders = new List<Order>()
        {
            new Order()
            {
                ID = 1, Description = "abobas", DateStart = new DateTime(2024, 04, 1),
                DateEnd = new DateTime(2024, 05, 01), Status = 1
            },
            new Order()
            {
                ID = 2, Description = "BOO", DateStart = new DateTime(2024, 01, 12),
                DateEnd = new DateTime(2024, 02, 01), Status = 2
            },
            new Order()
            {
                ID = 3, Description = "AuCh", DateStart = new DateTime(2024, 03, 30),
                DateEnd = new DateTime(2024, 05, 12), Status = 3
            },
            new Order()
            {
                ID = 4, Description = "Gadjishka Delaesh", DateStart = new DateTime(2024, 10, 23),
                DateEnd = new DateTime(2025, 05, 01), Status = 3
            },
        };
        double expected = 4;
        double actual = 0;
        Calculation calculation = new Calculation();
        //Act
        actual = calculation.CalcTime(_orders);
        //Assert
        Assert.AreEqual(expected, actual);
    }
}