   M S B A M L   `   `   `  ����>  :SDV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SDV.WindowsSDV.Windows  5   	   _ [MaterialDesignExtensions, Version=3.3.0.0, Culture=neutral, PublicKeyToken=c5ebccebe084d64fwQclr-namespace:MaterialDesignExtensions.Controls;assembly=MaterialDesignExtensions!MaterialDesignExtensions.Controls 5   	   #    SDV.Windows.Warehouse_product   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SDV.Windows     5   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962a@Material1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   a	ExceptionQclr-namespace:MaterialDesignExtensions.Controls;assembly=MaterialDesignExtensions  5   	   6  0MaterialDesignExtensions.Controls.MaterialWindow    BorderBackgroundBrush  �#FB7E51 � Title$( "Продукты на складе��5
   	   $	��782��6$   $��1223.5��61   $	��782��6A   $
��1220��6Q   $	��782��6a   $
��1500��6q   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��205* �6   �� 5      $
��214* �6   �� 5      $
��852* �6    � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $
��116* �6   �� 5      $
��387* �6   �� 5      $��90 �6   .+�5   
   �� $��16(�6   $��Disabled=�6!   $��3,5,5,5q�6{   $��Stretch=�6�   $��Stretch=�6�   $��1��6�   $��2��6�   $��3��6�   ��6X   �� *
Filterlist+ �� View 5      �� 5      .P�5      �� $'��!Название продукта��6S    �� DisplayMemberBinding 6%   �� *name_product+6S   �� 5      $��Цена��6L    6%   �� *cost+6L   �� 5      $,��&Количество на складе��6[    6&   �� *CurrentWarehouse+6[   5      5        � 5!   
   ���#FDBB5D���#FDBB5D$��1q�6;   $��3��6Q   $��3��6_   �� 5"   
   -   5        $��16(�5"       "  MaterialDesignFlatAccentButton#��[  64   ���#293345$'��!Посмотреть заявки��6�   $��	74,30,0,0q�6�   $��3��6�   $��42��6�   $
��Left=�6�   $	��201��6�   $	��Top=�6�   $��2��6
  '  !MaterialDesignThemes.Wpf.PackIcon  5#   
      Kind$ CoffeeMakerCheckOutline=�6   $
��Left=�6;   $��34��6V   $��	49,34,0,0q�6b   $	��Top=�6u   $��34��6�   $��3��6�    J� RenderTransformOrigin$ 0.382,3.676&�6�    � 5$   
   ���#FDBB5D$��3��6'   $��-1,0,0,0q�6;   �� 5%   
   -   5        $��
Назад��5%   !   $��2��61   $��	0,16,39,0q�6A   $��Right=�6T   $��74��6p   $��32��6{   $	��Top=�6�   5&      5'      