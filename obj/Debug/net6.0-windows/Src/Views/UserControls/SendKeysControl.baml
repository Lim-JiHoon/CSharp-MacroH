   M S B A M L   `   `   `  ����A  =MacroH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MacroH.ViewsMacroH.Views  5      -clr-namespace:MacroH.ModelsMacroH.Models  5      5clr-namespace:MacroH.ConvertersMacroH.Converters  5      "    MacroH.Views.SendKeysControl   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:MacroH.Views     5      .modelsclr-namespace:MacroH.Models     5      6
convertersclr-namespace:MacroH.Converters     5      -   5        $
��root��5
        � 	Resources  5      /   )MacroH.Converters.SendKeysActionConverter   SendKeysActionConverter �� 
TargetType �� Property �� Value �� 
TargetType ��Name ��Name��%�  &	        '��      '	�       5      6)   �� 5      " ��6   .�5      ��  � �� 5   
   �� 5      " ��6   .R�5      �� $ border��6   $��0 0 0 1q�5      
����i��#��z��5      ._�5      �� $ PART_ContentHost��6   5      5      5   	   5      �� 5      " 	�6   .�5      ��  � ��$ 20��6!   �� 5       � ��$ Center=�6,   �� 5        � ��$ Center=�63   5!      5"      .��5#      � $��50��6	    � ColumnDefinitions 5$      �� 5%      $	��100 �6   �� 5&      $��* �6   �� 5'      $
��auto �6   �� 5(      $
��auto �6   �� 5)      $
��auto �6   .+�5,      �� $��0��6   $��Center=�5-      $��Center=�5.      $��20(�5/      $��SendKeys��50      �� 52      $��1��6   $
��10 5q�6   
������ $��Center=�6E   $
��auto��53   _   ��6   ��  �� ElementName$
 root��	 �� Path$
	 Text�
 �� UpdateSourceTrigger$
 PropertyChanged=�6_   �� 54      $��2��6   $��Center=�6!   .+�55      	� $��SendKeys��6   "   MacroH.Models.SendKeysAction   SendKeys#��Z 57      ��56      �� *SendKeysActionCommand+ d� 	IsChecked 58      �� *SendKeysAction+ �� 	Converter# [   �� ConverterParameter# Z 	� 5;      $��OnlyText��6      OnlyText#��Z 5=      ��5<      �� *SendKeysActionCommand+ 5>      �� *SendKeysAction+# [  # Z 5A      �� 5B      $��3��6    " Style_Separators_Vertical_Pink#��[ 6!   "   MacroH.Views.DelaySecControl  5C      $��4��6:      DelaySec 6   �� *
DelaySec+6:   5D      5E      