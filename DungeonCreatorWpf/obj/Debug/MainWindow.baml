   M S B A M L   `   `   `  ����L  HDungeonCreatorWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:DungeonCreatorWpfDungeonCreatorWpf  5   	   "    DungeonCreatorWpf.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:DungeonCreatorWpf     5   	     � WindowState$  	Maximized=�5   	    � Title$ DungeonCreator��5	   	   $��737.912��6    $��1308.187��61   .��5
      � $��0,0,0,0q�6   .+�5   
   �� -   5        $
��List��5      $
��Left=�5      $��
10,10,0,35q�5      $	��100��5      5      �� 5   
   -   5        $��CreateNewLocationButton��5      $
��Left=�5      $��Bottom=�5      $��	10,0,0,10q�5      $	��100��5      $��New Location��5      5      � 5   
   -   5         �Name$ InputBox��5      $y�	Collapsed=�6!   .+�5      � 
���   � J� Opacity$	 0.5Q�6&   �� 5      $	��250��5      
�������
���   �$��1q�5      $��Center=�5       $��Center=�5!      ._�5"      �� .+�5#      �� -   5        $
��Text��5#       $��5q�6,   $��
Input Box:��67   $
��Bold"�6I   $��Cambria)�6[   �� 5$      -   5         ��Name$ InputTextBox��5$   �   $	��150��6   $��1q�6-   
���   �$��Center=�6U   $��Center=�6r   6�   �� 5%       �� Orientation$ 
Horizontal=�6!   $��Center=�6:   .+�5&      �� -   5         ��Name$ 	YesButton��5&   !   $��5q�64   $	��Yes��6?   ��6M   Z� 6c   �� 5'      -   5        $ NoButton��5'   !   $��5q�63   $��No��6>   ��6K   Z� 6a   5(      5)      5*      5+      5,      5.      