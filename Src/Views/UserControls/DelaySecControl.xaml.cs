using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MacroH.Views
{
  /// <summary>
  /// DelaySecControl.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class DelaySecControl : UserControl
  {
    private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
    {
      e.Handled = !IsTextAllowed(e.Text);
    }

    private static readonly Regex _regex = new Regex("[^0-9.-]+"); //regex that matches disallowed text
    private static bool IsTextAllowed(string text)
    {
      return !_regex.IsMatch(text);
    }

    private void TextBox_Pasting(object sender, DataObjectPastingEventArgs e)
    {
      if (e.DataObject.GetDataPresent(typeof(String)))
      {
        String text = (String)e.DataObject.GetData(typeof(String));
        if (!IsTextAllowed(text))
        {
          e.CancelCommand();
        }
      }
      else
      {
        e.CancelCommand();
      }
    }

    public DelaySecControl()
    {
      InitializeComponent();
    }



    public string DelaySec
    {
      get { return (string)GetValue(DelaySecProperty); }
      set { SetValue(DelaySecProperty, value); }
    }

    // Using a DependencyProperty as the backing store for DelaySec.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty DelaySecProperty =
        DependencyProperty.Register("DelaySec", typeof(string), typeof(DelaySecControl), new FrameworkPropertyMetadata("", FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
  }
}
