   M S B A M L   `   `   `  ����E  ALibraryWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:LibraryWPF
LibraryWPF  5   	       LibraryWPF.BookWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:LibraryWPF     5   	     � Title$  
bookWindow��5   	   $	��500��6   $	��800��6)   .��5	      � $��0,0,0,-6q�6   .+�5
   
   �� $��Center=�6   $��30��61   $��0,37,0,0q�6=   $
��DATA��6O   $
��Wrap=�6[   $	��Top=�6o   $	��800��6�   $
��Bold"�6�   ���	#FF0C0B0B$��Microsoft JhengHei)�6�    �� TextAlignment$ Center=�6�   $��16(�6�   ]� 5   
   $��	0,2,0,462q�6   .+�5      o� $	��Top=�6   $��30��6(   .@�5      m� -   5        $��_Home��5      .@�5      m� $��_Exit��6   5      m� 5      $��_Data��6   .@�5      m� -   5        $��_Book��5       m� Icon 5      �� 5      $A��;C:/Users/bimasakti/source/repos/LibraryWPF/Assets/books.png��6$   5      m� 5      -   5        $��_Member��5       5      �� 5      $C��=C:/Users/bimasakti/source/repos/LibraryWPF/Assets/members.png��6$   5      m� 5      -   5        $��_BookLog��5       5      �� 5      $C��=C:/Users/bimasakti/source/repos/LibraryWPF/Assets/booklog.png��6$   5      5       5,      5-      �� 5.   
   $
��Book��6   $
��Left=�6   $��	11,68,0,0q�6:   $	��Top=�6M   �� 5/   
   -   5        $	��Add��5/      $
��Left=�6   $��25��6:   $��	16,97,0,0q�6F   $	��Top=�6Y   $��71��6q   6|   &   System.Windows.Controls.DataGrid  50   
   -   5        $��dataGrid��50         AutoGenerateColumns$ False��6#      CanUserAddRows$ False��6?   $��16,129,24,26q�51         RowBackground �#fff$
��Bold"�52      ���#525252$
��True��53      $	��390��6&      AlternatingRowBackground �#f2f2f2���#000$��1q�54   7   $��Visible=�55      $
��Auto=�56         Columns 57      0  *System.Windows.Controls.DataGridTextColumn  58      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   	   
IsReadOnly$
	 True��6O   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 61   ��  �� Path$ id�6O     59      $ Title��6%   $
	 True��6U   
 64   �� $ title�6U     5:      $ Author��6%   $
	 True��6W   
 65   �� $ author�6W     5;      $ Position��6%   $
	 True��6[   
 67   �� $ position�6[     5<      $	 Qty��6%   $
	 True��6Q   
 62   �� $	 qty�6Q     5=      $ Remain��6%   $
	 True��6X   
 65   �� $ remains�6X   4  .System.Windows.Controls.DataGridTemplateColumn  5>      $ Update��6)      CellTemplate 5?      �� 5@      .R�5A      �� $��btnView��6%   -   5        $��Update��5A   4   6E   5B      5D        5E      $ Delete��6)    5F      �� 5G      .R�5H      �� $��btnView��6%   -   5        $��Delete��5H   4   
 � Tag 6\   ��  �� RelativeSource ��  �� AncestorType DataGridRow5I      5K      5M      5N      5O      