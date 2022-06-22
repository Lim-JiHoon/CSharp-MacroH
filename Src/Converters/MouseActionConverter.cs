using MacroH.Models;
using System;
using System.Globalization;
using System.Windows.Data;

namespace MacroH.Converters
{
  public class MouseActionConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      var mouseAction = (MouseControlAction)value;
      var param = (MouseControlAction)parameter;
      return mouseAction == param;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      return value.Equals(true) ? parameter : Binding.DoNothing;
    }

    public static string EnumToString(MouseControlAction mouseAction)
    {
      switch (mouseAction)
      {
        case MouseControlAction.Click:
          return "click";
        case MouseControlAction.DoubleClick:
          return "doubleclick";
        case MouseControlAction.MouseUp:
          return "mouseup";
        case MouseControlAction.MouseDown:
          return "mousedown";
        default:
          return "mousemove";
      }
    }

    public static MouseControlAction StringToEnum(string mouseActionString)
    {
      switch (mouseActionString)
      {
        case "click":
          return MouseControlAction.Click;
        case "doubleclick":
          return MouseControlAction.DoubleClick;
        case "mouseup":
          return MouseControlAction.MouseUp;
        case "mousedown":
          return MouseControlAction.MouseDown;
        default:
          return MouseControlAction.MouseMove;
      }
    }
  }
}
