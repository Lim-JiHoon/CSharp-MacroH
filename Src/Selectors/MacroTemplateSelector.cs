using MacroH.Src.ViewModels;
using MacroH.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace MacroH.Selectors
{
  public class MacroTemplateSelector : DataTemplateSelector
  {
    public override DataTemplate? SelectTemplate(object item, DependencyObject container)
    {
      FrameworkElement element = (FrameworkElement)container;
      MacroBase macro = (MacroBase)item;

      if (macro is MouseControlViewModel)
      {
        return (DataTemplate)element.FindResource("MouseMacro");
      }
      else if (macro is SendKeysControlViewModel)
      {
        return (DataTemplate)element.FindResource("SendKeysMacro");
      }
      return null;
      //return base.SelectTemplate(item, container);
    }
  }
}
