   M S B A M L   `   `   `  ����H  DDMAutoservice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:DMAutoservice.ViewsDMAutoservice.Views  5   	   #    DMAutoservice.Views.LogInView   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:DMAutoservice.Views     5   	     � Title$  Log In��5   	   $	��400��6   $	��300��6&   .��5	      �� .+�5
   
   �� $&�� Please provide your credentials:��6   $��16(�6<   $
��Bold"�6J   $��20, 40q�6\   
�������6l   � 5   
    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   .+�5      �� $��0��6   $��Center=�6)   $��Right=�6D   .+�5      �� $
��User��6   $��16(�6(   $��DemiBold"�66   $��20q�6L   �� 5      $
��Pass��6   $��16(�6(   $��DemiBold"�66   $��20q�6L   5      �� 5      $��1��6   $��Center=�6)   .+�5      �� $��16(�69   $��20q�6H   ��6   �� *Log.LoginName+6H   �� 5      $��16(�68   $��20q�6G   ��6   �� *Log.Password+6G   5      5      �� 5   
   .+�5      �� -   5        $��Log in��5   .   
�����w�$��50, 0q�6[   $��5q�6j   $��16(�6v   
�������6�   �� 5      $��5q�6   ��6#   �� *Logins+ �� SelectedItem 6B   �� *Log+��5      �� 5      .R�5      ��  �� Orientation$ Vertical=�6%   .+�5      � .+�5    "   �� $��User Name:          ��6,   �� 5!   "    �� 
IsReadOnly . ��6*   �� *	LoginName+6E   5"      � 5#      .+�5$   "   �� $��User Password:     ��6,   �� 5%   "    . ��6*   �� *
Password+6D   5&      5'      5(      5*      5+      5,      5/      