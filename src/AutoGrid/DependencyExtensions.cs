using Avalonia;
using Avalonia.Data;

namespace AvaloniaAutoGrid
{
    using System.Windows;

    static class DependencyExtensions
    {
        /// <summary>
        /// Sets the value of the <paramref name="property"/> only if it hasn't been explicitly set.
        /// </summary>
        public static bool SetIfDefault<T>(this AvaloniaObject o, AvaloniaProperty property, T value)
        {

            var diag = Avalonia.Diagnostics.AvaloniaObjectExtensions.GetDiagnostic(o, property);
            if (diag.Priority == BindingPriority.Unset)
            {
                o.SetValue(property, value);
                return true;
            }

            return false;

            o.SetValue(property, value);
            return true;
            //TODO: Implement in AvaloniaUI
            /*
            if (AvaloniaPropertyHelper.GetValueSource(o, property).BaseValueSource == BaseValueSource.Default)
            {
                o.SetValue(property, value);

                return true;
            }

            return false;*/
        }
    }
}
