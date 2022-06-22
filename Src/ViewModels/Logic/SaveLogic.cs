using MacroH.Converters;
using MacroH.Models;
using MacroH.Src.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroH.ViewModels
{
  public class SaveLogic
  {
    public IEnumerable<Macro> GetMacros(IEnumerable<MacroBase> macroBases)
    {
      List<Macro> macros = new List<Macro>();
      foreach (var macroBase in macroBases)
      {
        Macro macro;
        double.TryParse(macroBase.DelaySec, out double delay);
        switch (macroBase)
        {
          case SendKeysControlViewModel mac:
            macro = GetMacro_Sendkeys(mac, delay);
            break;
          case MouseControlViewModel mac:
            macro = GetMacro_Mouse(mac, delay);
            break;
          default:
            continue;
        }
        macros.Add(macro);
      }

      return macros;
    }

    private Macro GetMacro_Sendkeys(SendKeysControlViewModel mac, double delay)
    {
      return new Macro()
      {
        Kind = "sendkeys",
        Text = mac.Keys,
        Action = mac.SendKeysAction == SendKeysAction.SendKeys ? "sendkeys" : "onlytext",
        Delay = delay
      };
    }

    private Macro GetMacro_Mouse(MouseControlViewModel mac, double delay)
    {
      string action = MouseActionConverter.EnumToString(mac.MouseAction);
      return new Macro()
      {
        Kind = "mouse",
        Action = action,
        MousePoint = $"{mac.Point.X},{mac.Point.Y}",
        Delay = delay
      };
    }
  }
}
