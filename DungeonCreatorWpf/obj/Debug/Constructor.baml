   M S B A M L   `   `   `  ����L  HDungeonCreatorWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:DungeonCreatorWpfDungeonCreatorWpf  5   	   #    DungeonCreatorWpf.Constructor   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:DungeonCreatorWpf     5   	     � WindowState$  	Maximized=�5   	   $	��350��5	   	   $	��500��5
   	    � Title$ Constructor��5   	   $��611.538��6   $��767.033��6.   .��5      � $��0,0,2,4q�6   .+�5   
   �� -   5        $��DungeonName��5      $��Dungeon Name��6S   $
��Left=�6j   $��	10,10,0,0q�6�   $	��Top=�6�   �� 5   
   -   5        $��Описание��5      $
��Left=�6$   $��	10,64,0,0q�6?   $	��Top=�6R   $��66��6j   5      �� 5   
   -   5        $��Answer��5      $��
Ответ��64   $
��Left=�6D   $��	10,89,0,0q�6_   $	��Top=�6r   $��66��6�   �� 5   
   -   5        $��Enter��5      $��Вход��62   $
��Left=�6A   $��
10,114,0,0q�6\   $	��Top=�6p   $��66��6�   �� 5   
   -   5        $��EncounterList��5      $
��Left=�6Y   $	��165��6t   $��	78,64,0,0q�6�   $	��Top=�6�   $	��100��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.375Q�6&   T� 5      5      5      �� 5   
   -   5        $��Описание��5      $
��Left=�6A   $��
82,239,0,0q�6\   $	��Top=�6p   $��95��6�   $ 0.5,0.5&�6�   �� 5   
   -   5        $��
ActionList��5      $
��Left=�6$   $	��165��6?   $��
228,64,0,0q�6L   $	��Top=�6`   $	��100��6x   $ 0.5,0.5&�6�   z�5      V� 5      .~�5       �� �� 5!      �� 5"      $ -0.375Q�6&   T� 5#      5$      5&      �� 5'   
   -   5        $��	ActionDis��5'      $��Описание��6:   $
��Left=�6M   $��231,239,0,0q�6h   $	��Top=�6}   $��95��6�   $ 0.713,0.585&�6�   �� 5(   
   -	   5        $��
ActionCons��5(      $��Последствия��6<   $
��Left=�6R   $��231,264,0,0q�6m   $	��Top=�6�   $��95��6�   $ 0.713,0.585&�6�   �� 5)   
   -
   5        $��Сохранить��5)       $��	0,0,275,5q�64   $ 1.308,11.316&�6G   $��20��6l   $��Bottom=�6x   $��Right=�6�   $��95��6�   �� 5*   
   -   5        $��EncounterName��5*      $��Имя��6B   $
��Left=�6P   $��
82,264,0,0q�6k   $	��Top=�6   $��95��6�   $ 0.713,0.585&�6�   �� 5+   
   -   5        $��MainData��5+      $��387,10,10,35q�6"    �� TextWrapping$
 Wrap=�68   $��Start Typing��6L   �� 5,   
   -   5        $��
DungeonMap��5,      $
��Left=�6#   $	��242��6>   $	��Top=�6K   $	��244��6c   $��
82,300,0,0q�6o   �� 5-   
   -   5        $��SetDungeonMap��5-      $��Изменить��6D   $��
151,0,0,10q�6W   $ 1.308,11.316&�6k   $��20��6�   $��Bottom=�6�   $
��Left=�6�   $��95��6�   �� 5.   
   $
��Left=�6   $��3��6+   $��326,-91,0,0q�66   $	��Top=�6K   $��0��6c   �� 5/   
   -   5         ��Name$ Check��5/      $��Готово��64   $��	652,0,0,5q�6E   $ 1.308,11.316&�6X   $��20��6}   $��Bottom=�6�   $
��Left=�6�   $��95��6�   �� 50   
   -   5        $
��Test��50      $��Сохранить��61   $��0,0,662,125q�6E   $ 1.308,11.316&�6Z   $��20��6   $��Bottom=�6�   $��Right=�6�   $��95��6�   52      53      