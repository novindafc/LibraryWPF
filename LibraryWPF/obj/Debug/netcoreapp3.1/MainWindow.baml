   M S B A M L   `   `   `  ����E  ALibraryWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:LibraryWPF
LibraryWPF  5   	       LibraryWPF.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:LibraryWPF     5   	     � Title$  
MainWindow��5   	   $	��500��6   $	��800��6)   .��5	      � $��	0,0,-2,-6q�6   .+�5
   
   �� $��Center=�6   $��30��61   $��0,37,0,0q�6=   $
��HOME��6O   $
��Wrap=�6[   $	��Top=�6o   $	��800��6�   $
��Bold"�6�   ���	#FF0C0B0B$��Microsoft JhengHei)�6�    �� TextAlignment$ Center=�6�   $��16(�6�   ]� 5   
   $��	0,2,0,462q�6   .+�5      o� $	��Top=�6   $��21��6(   .@�5      m� -   5        $��_Home��5      .@�5      m� $��_Exit��6   5      m� 5      $��_Data��6   .@�5      m� -   5        $��_Book��5       m� Icon 5      �� 5      $A��;C:/Users/bimasakti/source/repos/LibraryWPF/Assets/books.png��6$   5      m� 5      -   5        $��_Member��5       5      �� 5      $C��=C:/Users/bimasakti/source/repos/LibraryWPF/Assets/members.png��6$   5      m� 5      -   5        $��_BookLog��5       5      �� 5      $C��=C:/Users/bimasakti/source/repos/LibraryWPF/Assets/booklog.png��6$   5      5       5!      5"      �� 5#   
   $��Borrow Book��6   $
��Left=�6&   $��	11,68,0,0q�6A   $	��Top=�6T   �� 5$   
   -   5        $	��Add��5$      $
��Left=�6   $��25��6:   $��	16,97,0,0q�6F   $	��Top=�6Y   $��71��6q   6|   &   System.Windows.Controls.DataGrid  5%   
   -   5        $��dataGrid��5%         AutoGenerateColumns$ False��6#      CanUserAddRows$ False��6?   $��16,129,16,35q�5&         RowBackground �#fff$
��Bold"�5'      ���#525252$
��True��5(      $	��390��6&      AlternatingRowBackground �#f2f2f2���#000$��1q�5)   7   $��Visible=�5*      $
��Auto=�5+         Columns 5,      0  *System.Windows.Controls.DataGridTextColumn  5-      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   	   
IsReadOnly$
	 True��6O   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 61   ��  �� Path$ id�6O     5.      $ 
Start Time��6%   $
	 True��6^   
 69   �� $ 	startTime�6^     5/      $ End Time��6%   $
	 True��6Z   
 67   �� $ endTime�6Z     50      $ Book Id��6%   $
	 True��6X   
 66   �� $ bookId�6X     51      $ 	Member Id��6%   $
	 True��6\   
 68   �� $ memberId�6\     52      $ Status��6%   $
	 True��6W   
 65   �� $ status�6W   54      59      5:      