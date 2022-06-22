using HoonsLib.Common;
using HoonsLib.WPF.Base;
using MacroH.Models;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Input;
using wf = System.Windows.Forms;

namespace MacroH.ViewModels
{
  public class MouseControlViewModel : MacroBase
  {
    //[DllImport("User32.dll")]
    //private static extern bool SetCursorPos(int X, int Y);

    private async Task RunMouseAction()
    {
      switch (MouseAction)
      {
        case MouseControlAction.Click:
          MouseEvent.MouseClick();
          break;
        case MouseControlAction.DoubleClick:
          MouseEvent.MouseClick();
          await Task.Delay(50);
          MouseEvent.MouseClick();
          break;
        case MouseControlAction.MouseDown:
          MouseEvent.MouseDown();
          break;
        case MouseControlAction.MouseUp:
          MouseEvent.MouseUp();
          break;
        default:
          break;
      };

    }
    public MouseControlViewModel()
    {
      MouseActionCommand = new RelayCommand<MouseControlAction>(a => MouseAction = a);
    }

    public async override Task Run()
    {
      await base.Run();
      wf.Cursor.Position = Point;
      await Task.Delay(50);
      await RunMouseAction();
    }
    public Point Point { get; set; }
    public ICommand MouseActionCommand { get; set; }
    public MouseControlAction MouseAction { get; set; } = MouseControlAction.Click;
  }
}
