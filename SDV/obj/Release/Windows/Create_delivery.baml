   M S B A M L   `   `   `  ���� >  :SDV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SDV.WindowsSDV.Windows  !    SDV.Windows.Create_delivery   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962a@Material1http://materialdesigninxaml.net/winfx/xaml/themes  _ [MaterialDesignExtensions, Version=3.3.0.0, Culture=neutral, PublicKeyToken=c5ebccebe084d64fN	Exception>https://spiegelp.github.io/MaterialDesignExtensions/winfx/xaml  :d2http://schemas.microsoft.com/expression/blend/2008  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  %localclr-namespace:SDV.Windows    � Title$!  Создать заявку��$��499.437��$��993.254��.��� .+��� $��Disabled=�$��1,0,0,52q�$��Stretch=�$��Stretch=�$
��Left=�$	��479������ *Amountproducts+ �� SelectedItem �� *Currentproduct+����  �� DataType" ��.R�� .+��� $
��Left=�$��0,0,0,0q�$	��100��$��80������ *Products.photo+�� $��100,0,100,0q�$��Stretch=�$	��Top=�.+���  �� Orientation$ 
Horizontal=�.+��� $��90��$
��Wrap=����� *Products.name_product+>  8MaterialDesignExtensions.Controls.OversizedNumberSpinner  
   Max$	 100��   Value �� *AmountProducts+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=��� -   $��0,0,40,0q�$��Right=�$��Добавить���� 
���   �$��1q�$
��Left=�$��
480,0,0,52q�$��2��$	��415��$��Bottom=��� $	��416��$��0,0,1,0q�$	��Top=�$��Right=�$	��502������ *Products_To_Delivery+ �� *Currentindelivry+���� " ��.R�� .+��� $
��Left=�$��0,0,0,0q�$	��100��$��80������ *Products.photo+�� $��100,0,100,0q�$��Stretch=�$	��Top=�.+��� $ 
Horizontal=�.+��� $	��200��$
��Wrap=����� *Products.name_product+�� $ 
Horizontal=�.+��� $
��Wrap=�$��Количетсво ���� $
��Wrap=����� *amount+�� -   $��Right=�$��Удалить�� � ���#FDA022���#FDA022$��1q�$��52��$��Bottom=��� -   $)��#Сформировать заказ��$��	0,0,36,10q�$��32��$��Bottom=�$��Right=�$	��183��