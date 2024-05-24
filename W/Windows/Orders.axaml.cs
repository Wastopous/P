using System;
using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Primer.Classes;

namespace Primer.Windows;

public partial class Orders : Window
{
    private List<Order> _orders;
    public Orders()
    {
        InitializeComponent();
        _orders = new List<Order>()
        {
            new Order(){ ID = 1, Description = "abobas", DateStart = new DateTime(2024, 04, 1), DateEnd = new DateTime(2024, 05, 01), Status = 1},
            new Order(){ ID = 2, Description = "BOO", DateStart = new DateTime(2024, 01, 12), DateEnd = new DateTime(2024, 02, 01), Status = 2},
            new Order(){ ID = 3, Description = "AuCh", DateStart = new DateTime(2024, 03, 30), DateEnd = new DateTime(2024, 05, 12), Status = 3},
            new Order(){ ID = 4, Description = "Gadjishka Delaesh", DateStart = new DateTime(2024, 10, 23), DateEnd = new DateTime(2025, 05, 01), Status = 3},
        };
        dataGridOrder.ItemsSource = _orders;
    }

    private void BackBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        this.Close();
    }

    private void BntCalc_OnClick(object? sender, RoutedEventArgs e)
    {
        Calculation calculation = new Calculation();
        int countOrder = calculation.CalcCount(_orders);
        TxtCount.Text = countOrder.ToString();
    }

    private void BntCalcTime_OnClick_OnClick(object? sender, RoutedEventArgs e)
    {
        Calculation calculation = new Calculation();
        double averageTime = calculation.CalcTime(_orders);
        TxtCountTime.Text = averageTime.ToString();

    }
}