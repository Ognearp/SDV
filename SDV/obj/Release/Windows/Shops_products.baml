   M S B A M L   `   `   `  ���� _  [MaterialDesignExtensions, Version=3.3.0.0, Culture=neutral, PublicKeyToken=c5ebccebe084d64fwQclr-namespace:MaterialDesignExtensions.Controls;assembly=MaterialDesignExtensions!MaterialDesignExtensions.Controls  > :SDV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SDV.WindowsSDV.Windows     SDV.Windows.Shops_products   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962a@Material1http://materialdesigninxaml.net/winfx/xaml/themes  a	ExceptionQclr-namespace:MaterialDesignExtensions.Controls;assembly=MaterialDesignExtensions  :d2http://schemas.microsoft.com/expression/blend/2008  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  %localclr-namespace:SDV.Windows  6   0MaterialDesignExtensions.Controls.MaterialWindow    BorderBackgroundBrush  �#F95665 � Title$* $Продукты в магазине��$	��750��$
��1300��.���  � ColumnDefinitions �� $
��205* ��� $
��214* ��� $
��852* � � RowDefinitions �� $��70 ��� $
��116* ��� $
��387* ��� $��90 �.+��� $��Disabled=�$��5q�$��Stretch=�$��Stretch=�$��1��$��1��$��2��$��2������ *
Filterlist+����  �� DataType" ��.R�� .+��� $
��Left=�$��0,0,0,0q�$	��100��$��80������ *photo+�� $��	100,0,0,0q�$��Stretch=�$	��Top=�.+���  �� Orientation$ 
Horizontal=�.+��� ���� *name_product+�� $	�� | ���� ���� *type_product+�� $��WrapWithOverflow=����� *description+�� $��0,0,0,20q����� *	unit_of+�� $��0,0,40,0q�$	��Top=�$��Right=�$��Цена���� $��Right=����� *cost+����  �� 
TargetType" ��   MaterialDesignListBoxItem �� BasedOn# [   �� Triggers P� 	 P� Property	 �@J�IsMouseOver
 P� Value
 . . ���  �� Property � �� �� Value �	#FFFFBE69P� 	 �@��
IsSelected
 . . ���  � �� �#FDA022 � ���#FDA022���#FDA022$��1q�$��3��$��3��� ���#FDA022$
��Left=�$	��200��$��1��$��2��.+��� 
���   �$��1q�$��10q� �� CornerRadius$ 3��._�#  MaterialDesignThemes.Wpf.Card  $��Stretch=����#FB7E51.��9� $��5q�$��Stretch=����#FB7E51$��Тип��$	��Top=�.��� ���#FB7E51.+��� $��10,0,5,0q�.+��� ���� *
FilterType+���� " ��.R��� -   ���� *Name+ d� 	IsChecked �� *
IsSelected+ � ���#FDA022$��3��$��-1,0,0,0q��� $
��Left=�$��40��$��	73,17,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��462��$��22(�$��3������ *Search+ �� UpdateSourceTrigger$ PropertyChanged=�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Search=�$
��Left=�$��47��$��	10,14,0,0q�$	��Top=�$��58���� -    3 /MaterialDesignFloatingActionMiniSecondaryButton#��[  � ToolTip$1 +MaterialDesignFloatingActionMiniLightButton��$
��Left=�$��
201,18,0,0q�$	��Top=�$��62��$��3��$��2��$��61��.��  $ ChevronDoubleLeft=�$��24��$��50���� -   #��[ $1 +MaterialDesignFloatingActionMiniLightButton��$
��Left=�$��
340,19,0,0q�$	��Top=�$��62��$��3��$��2��$��61��.��  $ ChevronDoubleRight=�$��24��$��50���� ���#293345$��18(�$��2��$��
277,0,0,24q�$��3��$
��Wrap=�$
��Left=�$��49��$��28��$��Bottom=����� *PageDisplay+��  �� DisplayMemberPath$ Title��$��2��$��149,31,0,13q�$
��Left=�$	��261������ *
SortParams+ �� SelectedItem �� *
Sortitem+d� -    d�Name$ Togle�� $  MaterialDesignSwitchToggleButton#��[ $  Default ToggleButton Style��$��411,22,342,2q�$��2���� )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Цена от�� ! MaterialDesignOutlinedTextBox#��[ $��51��$��
14,256,0,0q�$
 Wrap=�$	��Top=�$��2��$
��Left=�$��82������ *	Mincost+$ PropertyChanged=��� $ Цена до��#��[ $��50��$��102,256,0,0q�$
 Wrap=�$	��Top=�$��2��$
��Left=�$��85������ *	Maxcost+$ PropertyChanged=��� -    " MaterialDesignFlatAccentButton#��[ ���#293345$!��Создать заявку��$��52,334,19,53q�$��2��$
��Auto��  $ ApplicationEditOutline=�$
��Left=�$��36��$��
16,339,0,0q�$	��Top=�$��36��$��2��