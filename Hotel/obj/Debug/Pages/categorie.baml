   M S B A M L   `   `   `  ����@  <Hotel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Hotel.PagesHotel.Pages  5          Hotel.Pages.categorie   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Hotel.Pages     5        N� Title$  	categorie��5	      .��5      � ���	#FF0087A2 � ColumnDefinitions 5   
   �� 5      $	��20* �6   �� 5      $
��100* �6   �� 5      $	��20* �6   �� 5      $
��100* �6   �� 5      $
��440* �6   �� 5      $
��100* �6   �� 5      $	��20* �6    � RowDefinitions 5   
   �� 5      $
��400* �6   �� 5      $	��10* �6   �� 5      $	��30* �6   �� 5      $	��10* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ gridcat��5         AutoGenerateColumns .     
IsReadOnly . $��0��6R   $��1��6_   $��5��6o   
�������   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 61   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6>   �� *id+  5      $ Название��6%   $
 Auto 67   	 6D   �� *Name+  5      $ Цена��6%   $
 Auto 63   	 6@   �� *Price+4  .System.Windows.Controls.DataGridTemplateColumn  5       $
 Auto 6)   
   CellTemplate
 5!      �� 5"      .R�5#      ��  ��Name$ btnEdit��6=   $ ��Редактировать��6%      btn#��[  6O   5$      5&      5(      �� 5)   
   -   5        $ btnAdd��5)      $��1��6!   $��2��61   $��Добавить��6>   #��[  6Q   6n   �� 5*   
   -   5        $��	btnDelete��5*   ]   $��Удалить��6   $��3��6#   $��2��63   #��[  6@   $��30��6n   $	��Top=�6z   6�   �� 5+   
   -   5        $ btnback��5+      $��2��6"   $��
Назад��6/   #��[  6?   $��5��6]   6m   5-      5.      