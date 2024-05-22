using Primer.Classes;

namespace TestProject1;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestingCalculation()
    {
        //Arrange
         var _orders = new List<Order>()
        {
            new Order(){ ID = 1, Description = "abobas", DateStart = new DateTime(2024, 04, 1), DateEnd = new DateTime(2024, 05, 01), Status = 1},
            new Order(){ ID = 2, Description = "BOO", DateStart = new DateTime(2024, 01, 12), DateEnd = new DateTime(2024, 02, 01), Status = 2},
            new Order(){ ID = 3, Description = "AuCh", DateStart = new DateTime(2024, 03, 30), DateEnd = new DateTime(2024, 05, 12), Status = 3},
            new Order(){ ID = 4, Description = "Gadjishka Delaesh", DateStart = new DateTime(2024, 10, 23), DateEnd = new DateTime(2025, 05, 01), Status = 3},
        };
         int expected = 4;
         int actual = 0;
         Calculation calculation = new Calculation();
         //Act
         actual = calculation.CalcCount(_orders);
         //Assert
         Assert.AreEqual(expected, actual);
    }
}