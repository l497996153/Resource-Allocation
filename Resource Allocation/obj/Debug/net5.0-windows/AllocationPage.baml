   M S B A M L   `   `   `  ����N  JResource Allocation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Resource_AllocationResource_Allocation  5      (    "Resource_Allocation.AllocationPage   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Resource_Allocation     5        N� Title$  AllocationPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��0.4* �6   �� 5      $��2* �6   �� 5      $��40 �6   ��5   
   �� 5       �� ImageSource$ .\Resources\Dull.jpg��6   .+�5   
   ��    headerTextStyle#��[  6   $��0��69   $��0��6G   $��2��6W   $��50��6k   $��36(�6w   $	��185��6�   .��6�   
Allocation5      �� 5   
   -   5        $��client_list��5      $��Center=�6&   $	��Top=�6C   $��	50,12,0,0q�6[   $��1��6n   $	��285��6{   $��30��6�    �� DisplayMemberPath$
 Name��5        �� SelectedValuePath$ ID��6,   6C   &   System.Windows.Controls.DataGrid  5"   
   -   5        $��signedResourceGrid��5$   )   $��
10,47,0,10q�5#      $��1��6!   $��0��6.      AutoGenerateColumns$ False��5$      $��12(�6C   $��Center=�6Q      Columns 5%      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn   Header$ 
First Name��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6[   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6:   ��  �� Path$ First�6[     5'      $ 	Last Name��6%   $	 * 6Y   
 69   �� $
 Last�6Y   4  .System.Windows.Controls.DataGridTemplateColumn  5(      $ Action��6)   $	 1* 69      CellTemplate 5)      �� 5*      .R�5+      ��  �� Orientation$ 
Horizontal=�6)   .+�5,   "   �� -   5          buttonColStyle#��[ 5,   )   $��50��6Q   $	��1 0q�6\   $��Center=�6   .��6�   Unsign6�   5-      5.      50      52        54   
   -   5        $��unsignedResourceGrid��56   )   $��Center=�55      $��1��6(   $��1��66   $	��320��6F   $ False��56      $��12(�6E   $��Center=�6S   z�57      V� 58      .~�59      ��  �� ScaleX$ 1Q�6%   �� 5:      �� 5;      T� 5<      5=       5?        5@      $ 
First Name��6%   $	 * 6[   
 6:   �� $ First�6[     5A      $ 	Last Name��6%   $	 * 6Y   
 69   �� $
 Last�6Y     5B      $ Action��6)   $	 1* 69    5C      �� 5D      .R�5E      �� $ 
Horizontal=�6)   .+�5F   "   �� -   5        #��[ 5F   )   $��40��6Q   $	��1 0q�6\   $��Center=�6|   .��6�   Sign6�   5G      5H      5J      5L      5M      5N      