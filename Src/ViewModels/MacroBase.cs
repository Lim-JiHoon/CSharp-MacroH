using HoonsLib.WPF.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroH.ViewModels
{
  public abstract class MacroBase : ViewModelBase
  {
    public virtual string DelaySec { get; set; } = "0";

    public virtual Task Run()
    {
      float.TryParse(DelaySec, out float sec);
      return Task.Delay((int)(sec * 1000));
    }
  }
}
