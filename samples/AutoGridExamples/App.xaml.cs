using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Avalonia;
using Avalonia.Gtk3;
using Avalonia.Markup.Xaml;

namespace AutoGridExamples
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        static void Main(string[] args)
        {
            BuildAvaloniaApp().Start<MainWindow>();
        }

        static AppBuilder BuildAvaloniaApp() => AppBuilder.Configure<App>()
            .UsePlatformDetect().UseGtk3(new Gtk3PlatformOptions { UseGpuAcceleration = true });


    }

}
