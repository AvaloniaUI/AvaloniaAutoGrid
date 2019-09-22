using Avalonia;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoGridExamples
{
    class Program
    {
        public static AppBuilder BuildAvaloniaApp()
          => AppBuilder.Configure<App>().UsePlatformDetect();

        public static int Main(string[] args)
          => BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);
    }   
}
