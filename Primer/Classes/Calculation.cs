using System;
using System.Collections.Generic;
using System.Linq;

namespace Primer.Classes;

public class Calculation
{
    public int CalcCount(List<Order> orders)
    {
        List<Order> filteredOrders = orders
            .Where(x => x.Status == 3)
            .ToList();
        int result = filteredOrders.Count;
        return result;
    }

    public double CalcTime(List<Order> orders)
    {
        int countOrder = CalcCount(orders);
        double sumTime = 0;
        double result = 0;
        foreach (var currentOrder in orders)
        {
            if (currentOrder.Status == 3)
            {
                var deltaTime = currentOrder.DateEnd - currentOrder.DateStart;
                sumTime = sumTime + deltaTime.TotalDays;
            }
        }

        result = sumTime / countOrder;
        return result;
    }
}