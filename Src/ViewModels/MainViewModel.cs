using HoonsLib.WPF;
using HoonsLib.WPF.Base;
using MacroH.Models;
using MacroH.Repositorys;
using MacroH.ViewModels;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MacroH.Src.ViewModels
{
  public class MainViewModel : ViewModelBase
  {
    private bool stopCalled = false;
    private void KeyDownEvent(KeyEventArgs e)
    {
      switch (e.Key)
      {
        case Key.Delete:
          if (SelectedMacroBase != null)
            MacroBases.Remove(SelectedMacroBase);
          break;
      }
    }

    private async Task Run()
    {
      do
      {
        SelectedIndex = 0;
        foreach (var macro in MacroBases)
        {
          if (stopCalled) goto stop;
          await macro.Run();
          SelectedIndex++;
        }
      } while (IsRepeat);
    stop:
      stopCalled = false;
    }

    private async void SaveMethod(object _)
    {
      SaveFileDialog sfd = new SaveFileDialog();
      if (sfd.ShowDialog() == true)
      {
        await MacroRepository.Create(sfd.FileName);
        var saveLogic = new SaveLogic();
        foreach (Macro m in saveLogic.GetMacros(MacroBases))
        {
          await MacroRepository.Save(sfd.FileName, m);
        }
      }
    }

    private async void LoadMethod(object _)
    {
      OpenFileDialog ofd = new OpenFileDialog();
      if (ofd.ShowDialog() == true)
      {
        List<Macro> macros = await MacroRepository.GetMacros(ofd.FileName);
        var loadLogic = new LoadLogic(macros);
        MacroBases = new ObservableCollection<MacroBase>(loadLogic.GetMacroBases());
      }
    }

    private void OnHotKeyStartHandler(HotkeyMaker hotKey)
    {
      Task.WhenAny(Run());
    }

    private void OnHotKeyStopHandler(HotkeyMaker hotKey)
    {
      stopCalled = true;
    }


    public MainViewModel()
    {
      var hotkey = new HotkeyMaker(Key.F1, KeyModifier.NoRepeat, OnHotKeyStartHandler);
      var hotkeyF2 = new HotkeyMaker(Key.F2, KeyModifier.NoRepeat, OnHotKeyStopHandler);

      MacroBases = new ObservableCollection<MacroBase>();
      MacroKeyCommand = new RelayCommand<object>(obj => MacroBases.Add(new SendKeysControlViewModel()));
      MacroMouseCommand = new RelayCommand<object>(obj => MacroBases.Add(new MouseControlViewModel()));
      KeyDownCommand = new RelayCommand<KeyEventArgs>(KeyDownEvent);
      RunCommand = new RelayCommand<object>(async (obj) => { await Run(); });
      SaveCommand = new RelayCommand<object>(SaveMethod);
      LoadCommand = new RelayCommand<object>(LoadMethod);
    }

    public ObservableCollection<MacroBase> MacroBases { get; set; }
    public MacroBase? SelectedMacroBase { get; set; } = null;
    public ICommand MacroKeyCommand { get; set; }
    public ICommand MacroMouseCommand { get; set; }
    public ICommand KeyDownCommand { get; set; }
    public ICommand RunCommand { get; set; }
    public ICommand SaveCommand { get; set; }
    public ICommand LoadCommand { get; set; }
    public int SelectedIndex { get; set; }
    public bool IsRepeat { get; set; }
  }

}
