using HoonsLib.WPF.Base;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using wf = System.Windows.Forms;
namespace MacroH.Views
{
  /// <summary>
  /// MouseControl.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class MouseControl : UserControl
  {
    public MouseControl()
    {
      InitializeComponent();

      MousePointSetCommand = new RelayCommand<object>((obj) => { txtPoint.Text = $"{wf.Cursor.Position.X},{wf.Cursor.Position.Y}"; });
      KeyGesture findKeyGesture = new KeyGesture(Key.S, ModifierKeys.Shift | ModifierKeys.Alt);
      KeyBinding findKeyBinding = new KeyBinding(MousePointSetCommand, findKeyGesture);
      InputBindings.Add(findKeyBinding);
    }

    ICommand MousePointSetCommand { get; set; }

    public string MousePoint
    {
      get { return (string)GetValue(MousePointProperty); }
      set { SetValue(MousePointProperty, value); }
    }

    // Using a DependencyProperty as the backing store for MousePoint.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty MousePointProperty =
        DependencyProperty.Register("MousePoint", typeof(string), typeof(MouseControl), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
  }
}
