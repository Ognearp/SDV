   M S B A M L   `   `   `  ����_  [MaterialDesignExtensions, Version=3.3.0.0, Culture=neutral, PublicKeyToken=c5ebccebe084d64fwQclr-namespace:MaterialDesignExtensions.Controls;assembly=MaterialDesignExtensions!MaterialDesignExtensions.Controls  5   	   > :SDV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SDV.WindowsSDV.Windows 5   	       SDV.Windows.Shops_products   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962a@Material1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   a	ExceptionQclr-namespace:MaterialDesignExtensions.Controls;assembly=MaterialDesignExtensions  5   	   :d2http://schemas.microsoft.com/expression/blend/2008  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   %localclr-namespace:SDV.Windows  5   	   6   0MaterialDesignExtensions.Controls.MaterialWindow    BorderBackgroundBrush  �#FB7E51 � Title$* $Продукты в магазине��5
   	   $	��750��6%   $
��1300��62   $	��750��6?   $
��1450��6O   $	��750��6_   $
��1500��6o   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��205* �6   �� 5      $
��214* �6   �� 5      $
��852* �6    � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $
��116* �6   �� 5      $
��387* �6   �� 5      $��90 �6   .+�5   
   �� $��Disabled=�6   $��5q�6m   $��Stretch=�6x   $��Stretch=�6�   $��1��6�   $��1��6�   $��2��6�   $��2��6�   ��6J   �� *
Filterlist+��5      �� 5       �� DataType" ��6    .R�5      � .+�5      �� $
��Left=�6    $��0,0,0,0q�6;   $	��100��6L   $��80��6X   ��6d   �� *photo+6   �� 5      $��	100,0,0,0q�6&   $��Stretch=�69   $	��Top=�6W   .+�5      ��  �� Orientation$ 
Horizontal=�6)   .+�5   "   �� ��6,   �� *name_product+6L   �� 5   "   $	�� | ��6,   69   �� 5    "   ��6,   �� *type_product+6L   5!      �� 5"      $��WrapWithOverflow=�6E   ��6(   �� *description+6h   �� 5#      ��6(   �� *	unit_of+6C   �� 5$      $ 
Horizontal=�6)   .+�5%   "   �� $/��)Количество в магазине ��6,   6L   �� 5&   "   ��6,   �� *CurrentShop+6K   5'      5)      �� 5+      $��0,0,40,0q�6$   $	��Top=�66   $��Right=�6N   $��Цена��6j   6x   �� 5,      $��Right=�6$   ��6@   �� *cost+6X   5-      5.      ��50      �� 51       �� 
TargetType" ��6      MaterialDesignListBoxItem �� BasedOn# [  6;    �� Triggers 52      P� 53      	 P� Property	 �@J�IsMouseOver
 P� Value
 . . �54      ��  �� Property � �� �� Value �	#FFFFBE696O   55      P� 56      	 �@��
IsSelected
 . . �57      ��  � �� �#FDA0226M   58      5;      5=       � 5>   
   ���#FDA022���#FDBB5D$��1q�6;   $��3��6Q   $��3��6_   � 5?   
   ���#FDBB5D$
��Left=�6%   $	��200��6@   $��1��6M   $��2��6Z   .+�5@      �� 
���   �$��1q�6)   $��10q�6=    �� CornerRadius$ 3��6I   ._�5A      #  MaterialDesignThemes.Wpf.Card  $��Stretch=�6!   ���#FB7E51.��5B      9� $��16(�6   $��5q�6-   $��Stretch=�68   ���#FB7E51$��Тип��6m   $	��Top=�6z   .��5C      � ���#FB7E51.+�5D      �� $��10,0,5,0q�6)   .+�5E   "   �� ��6*   �� *
FilterType+��5F   &   �� 5G   *   " ��67   .R�5H   .   �� -   5        $��16(�5H   7   ��6~   �� *Name+ d� 	IsChecked 6�   �� *
IsSelected+6�   5I   +   5K   #   5L      5M      5N      5O      5P      5Q       � 5S   
   ���#FDBB5D$��3��6'   $��-1,0,0,0q�6;   �� 5T   
   $
��Left=�6P   $��40��6k   $��	73,17,0,0q�6w    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��462��6�   $��22(�6�   $��3��6�   ��6   �� *Search+ �� UpdateSourceTrigger$ PropertyChanged=�6�   '  !MaterialDesignThemes.Wpf.PackIcon  5U   
      Kind$ Search=�6   $
��Left=�6*   $��47��6E   $��	10,14,0,0q�6Q   $	��Top=�6d   $��58��6|   �� 5V   
   -   5         3 /MaterialDesignFloatingActionMiniSecondaryButton#��[ 5V   (    � ToolTip$1 +MaterialDesignFloatingActionMiniLightButton��6q   $
��Left=�6�   $��
201,18,0,0q�6�   $	��Top=�6�   $��62��6�   $��3��6�   $��2��6  $��61��6  .��5W        $ ChevronDoubleLeft=�6    $��24��69   $��50��6D   6S   5X      �� 5Y   
   -   5        #��[ 5Y   $   $1 +MaterialDesignFloatingActionMiniLightButton��6o   $
��Left=�6�   $��
332,19,0,0q�6�   $	��Top=�6�   $��62��6�   $��3��6�   $��2��6  $��61��6  .��5Z        $ ChevronDoubleRight=�6    $��24��6:   $��50��6E   6T   5[      �� 5\   
   ���#293345$��18(�6+   $��2��69   $��
277,0,0,24q�6I   $��3��6]   $
��Wrap=�6j   $
��Left=�6�   $��49��6�   $��28��6�   $��Bottom=�6�   ��6~   �� *PageDisplay+6�   �� 5]   
   $��16(�6    �� DisplayMemberPath$ Title��6f   $��2��6�   $��149,31,0,13q�6�   $
��Left=�6�   $	��261��6�   ��6!   �� *
SortParams+ �� SelectedItem 6D   �� *
Sortitem+6�   d� 5^   
   -   5         d�Name$ Togle��5^       $  MaterialDesignSwitchToggleButton#��[ 6(   $  Default ToggleButton Style��6b   $��411,22,342,2q�6�   $��2��6�   6�   �� 5_   
   $��14(�6   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Цена от��6_    ! MaterialDesignOutlinedTextBox#��[ 6�   $��51��6�   $��
14,284,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��2��6  $
��Left=�6  $��82��6.  ��6!   �� *	Mincost+$ PropertyChanged=�6.  �� 5`   
   $��14(�6   $ Цена до��6^   #��[ 6�   $��50��6�   $��102,284,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��2��6  $
��Left=�6  $��85��6.  ��6    �� *	Maxcost+$ PropertyChanged=�6.  �� 5a   
   -   5        $��16(�5a       " MaterialDesignFlatAccentButton#��[ 6<   ���#293345$!��Создать заявку��6�   $��	39,0,0,41q�6�   $��2��6�   $��42��6�   $
��Left=�6�   $	��150��6�   $��Bottom=�6�     5b   
   $ ApplicationEditOutline=�6   $
��Left=�6;   $��36��6V   $��
12,352,0,0q�6b   $	��Top=�6v   $��36��6�   $��2��6�   �� 5c   
   -   5        $��
Назад��5c   !   $��2��61   $��	0,20,52,0q�6A   $��Right=�6T   $��74��6p   $��32��6{   $	��Top=�6�   5d      5e      