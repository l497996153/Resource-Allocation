   M S B A M L   `   `   `  ����N  JResource Allocation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Resource_AllocationResource_Allocation  5      $    Resource_Allocation.ClientPage   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Resource_Allocation     5        N� Title$  
ClientPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5       � RowDefinitions 5   
   �� 5      $
��0.4* �6   �� 5      $��2* �6   �� 5      $��40 �6   ��5   
   �� 5       �� ImageSource$ .\Resources\Dull.jpg��6   .+�5   
   ��    headerTextStyle#��[  6   $��0��69   $��50��6F   $��222,0q�6R   $��36(�6a   .��6o   Client5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��
ClientGrid��5    )   $��Center=�5      $	��Top=�6*   $��0,12,0,0q�6B   $��1��6T   $	��300��6a   $	��781��6n      AutoGenerateColumns$ False��5       $��12(�6;      Columns 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn   Header$ Company Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 1.3* 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� 	 �� Path$	 CompanyName�
 �� UpdateSourceTrigger$
 PropertyChanged=�6�     5$      $ Contact Firstname��6%   $
 1.3* 6�    6@   �� $	 First�$
 PropertyChanged=�6�     5%      $ Contact Lastname��6%   $
 1.3* 6�    6?   �� $
	 Last�$
 PropertyChanged=�6�     5&      $
 City��6%   $	 .8* 6w    63   �� $
	 City�$
 PropertyChanged=�6w     5'      $ State��6%   $	 .8* 6y    64   �� $	 State�$
 PropertyChanged=�6y     5(      $	 Zip��6%   $	 .8* 6u    62   �� $		 Zip�$
 PropertyChanged=�6u   4  .System.Windows.Controls.DataGridTemplateColumn  5*      $ Action��6)   $ 1* 69      CellTemplate 5+      �� 5,      .R�5-      ��  �� Orientation$ 
Horizontal=�6)   .+�5.   "   �� -   5          buttonColStyle#��[ 5.   )   $��40��6Q   $	��1 0q�6\   .��6~   Update6�   �� 5/   "   -   5        #��[ 5/   )   $��40��6Q   $	��1 0q�6\   .��6~   Delete6�   50      51      53      56      �� 58   
   -   5        $��1��58   #   $��2��63   $	��150��6@   $��40��6O     buttonStyle#��[ 6_   .��6�   Add6�   59      5:      