using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaApplicationTest.Views;

public partial class MainWindowMenuUserControl : UserControl
{
    public MainWindowMenuUserControl()
    {
        InitializeComponent();
    }
    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void ExitButtonClick(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        // Schließe das gesamte Programm
        Environment.Exit(0);
    }
}