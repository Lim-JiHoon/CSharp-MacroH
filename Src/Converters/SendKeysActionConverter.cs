using MacroH.Models;
using System;
using System.Globalization;
using System.Windows.Data;

namespace MacroH.Converters
{
  public class SendKeysActionConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      return (SendKeysAction)value == (SendKeysAction)parameter;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      return value.Equals(true) ? parameter : Binding.DoNothing;
    }

    public static SendKeysAction StringToEnum(string action)
    {
      return action switch
      {
        "sendkeys" => SendKeysAction.SendKeys,
        _ => SendKeysAction.OnlyText,
      };
    }
  }
}
