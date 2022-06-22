using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroH.Models
{
  public enum MouseControlAction
  {
    Click,
    DoubleClick,
    MouseUp,
    MouseDown,
    MouseMove
  }

  public enum SendKeysAction
  {
    SendKeys,
    OnlyText
  }
}
