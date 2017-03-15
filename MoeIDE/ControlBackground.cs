using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Meowtrix.MoeIDE
{
    public class ControlBackground
    {
        public static void OverrideBackground(string typeName) => OverrideBackground(typeName, Brushes.Transparent);
        public static void OverrideBackground(string typeName, Brush brush)
        {
            //var type = AppDomain.CurrentDomain.GetAssemblies().Select(x => x.GetType(typeName, false)).Where(x => x != null).FirstOrDefault();
            var type = Type.GetType(typeName, false);
            if (type == null) return;
            Control.BackgroundProperty.OverrideMetadata(type, new FrameworkPropertyMetadata(brush));
        }
    }
}
