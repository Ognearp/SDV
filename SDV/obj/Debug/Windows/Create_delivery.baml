   M S B A M L   `   `   `  ����W  SNotification.Wpf, Version=6.1.0.0, Culture=neutral, PublicKeyToken=1acac493089262b5_Aclr-namespace:Notification.Wpf.Controls;assembly=Notification.WpfNotification.Wpf.Controls  5   	   > :SDV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SDV.WindowsSDV.Windows 5	   	   !   SDV.Windows.Create_delivery   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962a@Material1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   _ [MaterialDesignExtensions, Version=3.3.0.0, Culture=neutral, PublicKeyToken=c5ebccebe084d64fN	Exception>https://spiegelp.github.io/MaterialDesignExtensions/winfx/xaml  5   	   TNotificationAclr-namespace:Notification.Wpf.Controls;assembly=Notification.Wpf  5   	   :d2http://schemas.microsoft.com/expression/blend/2008  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   %localclr-namespace:SDV.Windows  5	   	   6  0MaterialDesignExtensions.Controls.MaterialWindow    BorderBackgroundBrush  �#FB7E51 � Title$! Создать заявку��5   	   $��527.976��6    $��987.546��61   $	��527��6A   $	��987��6Q   $	��527��6`   $	��987��6p   .��5      � .+�5   
   �� $��Disabled=�6   $��1,0,0,52q�6�   $��Stretch=�6�   $��Stretch=�6�   $
��Left=�6�   $	��479��6  ��6K   �� *Amountproducts+ �� SelectedItem 6r   �� *Currentproduct+��5      �� 5       �� DataType" ��6    .R�5      � .+�5      �� $
��Left=�6    $��0,0,0,0q�6;   $	��100��6L   $��80��6X   ��6d   �� *Products.photo+6�   �� 5      $��100,0,100,0q�6&   $��Stretch=�6;   $	��Top=�6Y   .+�5      ��  �� Orientation$ 
Horizontal=�6)   .+�5   "   �� $��90��6,   $
��Wrap=�67   ��6K   �� *Products.name_product+6t   5      5      >  8MaterialDesignExtensions.Controls.OversizedNumberSpinner  5      
   Max$	 100��6;      Value 6E   �� *AmountProducts+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�6�   �� 5      -   5        $��0,0,40,0q�5   !   $��Right=�6G   $��Добавить��6c   6x   5      5      5      �� 5   
   
���   �$��1q�6%   $
��Left=�69   $��
480,1,0,52q�6T   $��2��6i   �� 5   
   $	��439��6j   $��0,0,1,0q�6w   $	��Top=�6�   $��Right=�6�   $	��493��6�   ��6   �� *Products_To_Delivery+ 6@   �� *Currentindelivry+��5      �� 5       " ��6    .R�5!      � .+�5"      �� $
��Left=�6    $��0,0,0,0q�6;   $	��100��6L   $��80��6X   ��6d   �� *Products.photo+6�   �� 5#      $��100,0,100,0q�6&   $��Stretch=�6;   $	��Top=�6Y   .+�5$      �� $ 
Horizontal=�6)   .+�5%   "   �� $	��200��6,   $
��Wrap=�68   ��6L   �� *Products.name_product+6u   5&      �� 5'      $ 
Horizontal=�6)   .+�5(   "   �� $
��Wrap=�6,   $��Количетсво ��6@   6V   �� 5)   "   $
��Wrap=�6,   ��6@   �� *amount+6[   5*      5+      �� 5,      -   5        $��Right=�5,   7   $��Удалить��6S   6g   5-      5.      50       � 51   
   ���#FDBB5D���#FDBB5D$��1q�6;   $��52��6O   $��Bottom=�6[   0   *Notification.Wpf.Controls.NotificationArea  52   
   -   5        	  Name$	 Notify��52   (   
   Position$
 BottomRight=�68      MaxItems$ 15��6O   $��7,344,666,8q�6]   �� 53   
   -   5        $)��#Сформировать заказ��53   (   $��	0,0,36,10q�6E   $��32��6X   $��Bottom=�6d   $��Right=�6   $	��183��6�   54      55      