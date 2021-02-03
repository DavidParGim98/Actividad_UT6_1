using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Actividad_UT6_1
{
    public static class CommandMenu
    {
        public static readonly RoutedUICommand Nueva = new RoutedUICommand
            (
                "Nueva",
                "Nueva",
                typeof(CommandMenu),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.N, ModifierKeys.Control)
                }
            );

        public static readonly RoutedUICommand Guardar = new RoutedUICommand
            (
                "Guardar",
                "Guardar",
                typeof(CommandMenu),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.G, ModifierKeys.Control)
                }
            );

        public static readonly RoutedUICommand Salir = new RoutedUICommand
            (
                "Salir",
                "Salir",
                typeof(CommandMenu),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.S, ModifierKeys.Control)
                }
            );

        public static readonly RoutedUICommand Configuracion = new RoutedUICommand
            (
                "Configuracion",
                "Configuracion",
                typeof(CommandMenu),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.C, ModifierKeys.Control)
                }
            );

        public static readonly RoutedUICommand Conexion = new RoutedUICommand
            (
                "Conexion",
                "Conexion",
                typeof(CommandMenu),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.O, ModifierKeys.Control)
                }
            );

        public static readonly RoutedUICommand Enviar = new RoutedUICommand
            (
                "Enviar",
                "Enviar",
                typeof(CommandMenu),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.Enter)
                }
            );
    }
}
