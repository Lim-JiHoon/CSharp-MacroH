   M S B A M L   `   `   `  ����A  =MacroH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MacroH.ViewsMacroH.Views  5   	   3clr-namespace:MacroH.SelectorsMacroH.Selectors  5   	       MacroH.Views.MainView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:MacroH.Views     5   	   4	selectorsclr-namespace:MacroH.Selectors     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3b+http://schemas.microsoft.com/xaml/behaviors  5   	     � Title$  
MainWindow��5
   	   $	��450��6   $	��800��6)    � 	Resources 5         
MouseMacro   MacroH.Views.MouseControl   
MousePoint  SendKeysMacro"   MacroH.Views.SendKeysControl   Text �� UpdateSourceTrigger,   &MacroH.Selectors.MacroTemplateSelector  selector��%�   &	        &	 @     &	 �     �� 5      .R�5         6   �� *Point+5      �� 5      .R�5         6   �� *Keys+$ PropertyChanged=�5        5      6&   5      .��5      ]� .+�5      ��  �� Padding$ 2q�6   $	��Top=�6   $��30��6.   ._�5      �  � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5       $
��auto �6   �� 5"      $
��auto �6   �� 5$      $
��auto �6   �� 5&      $��* �6   �� 5(      $
��auto �6   �� 5*      $
��auto �6   �� 5,      $
��auto �6   �� 5.      $
��auto �6   .+�51   
   �� $��0��6   $��3q�6!   $��저장��6L   ��6,   �� *SaveCommand+6L   �� 52   
   $��1��6   $��3q�6!   $��불러오기��6L   ��6,   �� *LoadCommand+6L   �� 53   
   $��2��6   $��3q�6!   $��Add SendKeys��6P   ��6,   �� *MacroKeyCommand+6P   �� 54   
   $��3��6   $��3q�6!   $��	Add Mouse��6R   ��6,   �� *MacroMouseCommand+6R   �� 55   
   $��6��6   $��3q�6#   $��반복��6M   $��Center=�6Z   $��Center=�6u    d� 	IsChecked 6.   �� *
IsRepeat+6u   �� 56   
   $��7��6   $��3q�6!   $��
시작(F1)��6,   �� 57   
   $��8��6   $��3q�6!   $��
중지(F2)��6,   59   	   5:      � 5<      .+�5=      �� -   5         ��Name$ lb��5=      #��[ 5@      	 �� SelectedIndex	 5>      �� *SelectedIndex+��5?      �� *
MacroBases+
 �� SelectedItem
 5A      �� *SelectedMacroBase+��5B   
   �� 5C       �� 
TargetType" ��6   .�5D      ��  �� Property � �� �� Value$ Stretch=�6;   5E      *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5G   
   +  %Microsoft.Xaml.Behaviors.EventTrigger  5H         	EventName$ KeyUp��6   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5I      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     PassEventArgsToCommand$
 True��5J   "      Command 5I   $   �� *KeyDownCommand+5J   "   5K      5M   	   5N      5O      5P      