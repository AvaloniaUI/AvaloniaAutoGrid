using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AutoGridExamples
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class MainWindow : Window
    {
        public MainWindow()
        {
            AvaloniaXamlLoader.Load(this);
            //this.AttachDevTools();
        }
    }
}
