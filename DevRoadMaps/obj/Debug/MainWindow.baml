   M S B A M L   `   `   `  ����F  BDevRoadMaps, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:DevRoadMapsDevRoadMaps  5   	       DevRoadMaps.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:DevRoadMaps     5   	     � Title$  
MainWindow��5   	   $	��900��6   $
��1440��6)    � WindowStyle$
 None=�66    � 
ResizeMode$ 	CanResize=�5	   	   '  !System.Windows.Shell.WindowChrome   WindowChrome 5
        5   
      CaptionHeight$ 30Q�6   .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��* �6   .+�5   
   �    IsHitTestVisibleInChrome .  $��0��6=   ���#3d3d3d � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $	��110 �6#   .+�5      �� $��DevRoadMaps��6   $��0��6+   $��14(�6;   $	��100��6I   $
��Left=�6U   $��10,5,0,0q�6p   
�������6�   � 5       . $	��110��6E   $��0,0,0,0q�6Q   $��1��6b   .+�5      �� -   5         ��Name$ MinimizeBtn��5      $��30��6.   $��30��69      Button.Hoverless#���   6E   $��5,0,5,0q�6p   
������ .��5      �� $��Images/minimize.png��6   5      �� 5      -   5        $ MaximizeBtn��5      $��30��6.   $��30��69   #���   6E   $��0,0,0,0q�6p   
������ .��5      �� $��Images/maximize.png��6   5      �� 5      -   5        $ CloseBtn��5      $��30��6+   $��30��66   #���   6B   $��5,0,5,0q�6m   
������ .��5       �� $��Images/close.png��6   5!      5"      5#      � 5$   
   $��1��6    5%      �� 5&      $	��300 �6#   �� 5'      $
��200* �6#   .+�5)      � $��0��6   	 � Orientation$	 Vertical=�6(   
�������5+      5,      5-      5.      