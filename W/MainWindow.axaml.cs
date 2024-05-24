using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Primer.Windows;

namespace Primer;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void BtnLogin_OnClick(object? sender, RoutedEventArgs e)
    {
        try
        {
            Orders afterLogin = new Orders();
            afterLogin.ShowDialog(this);
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
        }
    }
}