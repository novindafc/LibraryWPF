   M S B A M L   `   `   `  ����E  ALibraryWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:LibraryWPF
LibraryWPF  5   	       LibraryWPF.MemberWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:LibraryWPF     5   	     � Title$  MemberWindow��5   	   $	��500��6   $	��800��6+   .��5	      � $��0,0,0,-6q�6   .+�5
   
   �� $��Center=�6   $��30��61   $��0,37,0,0q�6=   $
��DATA��6O   $
��Wrap=�6[   $	��Top=�6o   $	��800��6�   $
��Bold"�6�   ���	#FF0C0B0B$��Microsoft JhengHei)�6�    �� TextAlignment$ Center=�6�   $��16(�6�   ]� 5   
   $��	0,2,0,471q�6   .+�5      o� $	��Top=�6   $��17��6(   .@�5      m� -   5        $��_Home��5      .@�5      m� $��_Exit��6   5      m� 5      $��_Data��6   .@�5      m� -   5        $��_Book��5       m� Icon 5      �� 5      $A��;C:/Users/bimasakti/source/repos/LibraryWPF/Assets/books.png��6$   5      m� 5      -   5        $��_Member��5       5      �� 5      $C��=C:/Users/bimasakti/source/repos/LibraryWPF/Assets/members.png��6$   5      m� 5      -   5        $��_BookLog��5       5      �� 5      $C��=C:/Users/bimasakti/source/repos/LibraryWPF/Assets/booklog.png��6$   5      5       5,      50      �� 51   
   $��Member��6   $
��Left=�6!   $��	11,68,0,0q�6<   $	��Top=�6O   �� 52   
   -   5        $	��Add��52      $
��Left=�6   $��25��6:   $��	16,97,0,0q�6F   $	��Top=�6Y   $��71��6q   6|   &   System.Windows.Controls.DataGrid  53   
   -   5        $��dataGrid��53         AutoGenerateColumns$ False��6#      CanUserAddRows$ False��6?   $��16,129,24,26q�54         RowBackground �#fff$
��Bold"�55      ���#525252$
��True��56      $	��390��6&      AlternatingRowBackground �#f2f2f2���#000$��1q�57   7   $��Visible=�58      $
��Auto=�59         Columns 5:      0  *System.Windows.Controls.DataGridTextColumn  5;      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   	   
IsReadOnly$
	 True��6O   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 61   ��  �� Path$ id�6O     5<      $
 Name��6%   $
	 True��6S   
 63   �� $
 name�6S     5=      $ Gender��6%   $
	 True��6W   
 65   �� $ gender�6W     5>      $ Phone��6%   $
	 True��6U   
 64   �� $ phone�6U     5?      $ 
Occupation��6%   $
	 True��6_   
 69   �� $ 
occupation�6_     5@      $ Email��6%   $
	 True��6U   
 64   �� $ email�6U   4  .System.Windows.Controls.DataGridTemplateColumn  5A      $ Update��6)      CellTemplate 5B      �� 5C      .R�5D      �� $��btnView��6%   -   5        $��Update��5D   4   6E   5E      5G        5H      $ Delete��6)    5I      �� 5J      .R�5K      �� $��btnView��6%   -   5        $��Delete��5K   4   6E   5L      5N      5P      5Q      5R      