   M S B A M L   `   `   `  ����  Resource Allocation$    Resource_Allocation.Client_Add   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        N� Title$  
Client_Add��5      .��5
      �  � ColumnDefinitions 5   
   �� 5      $
��1.5* �6   �� 5      $��2* �6   �� 5      $
��1.5* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   ��5   
   �� 5       �� ImageSource$ .\Resources\Dull.jpg��6   .+�5    
   ��    headerTextStyle#��[  6   $��45��69   $	��160��6E   $��1��6Q   $��Center=�6c   .��6~   
New Client5"      �� 5$   
   -   5        $��	nameLabel��5$      $��1��6#   $��2 30 0 0q�62   $��Right=�6F   .��6b   _Company Name:6r   �� 5%   
   -   5        $��nameText��5%      $��1��6$   $��1��63   $��2 30 0 0q�6E   ��5&   
   �� *CompanyName+ �� Mode$ TwoWay=��� 5(   
   -   5        $��
firstLabel��5(      $��2q�6$   $��2��61   $��Right=�6@   .��6\   _Contact Firstname:6q   �� 5)   
   -   5        $��	firstText��5)      $��2��6%   $��1��64   $��2q�6F   ��5*   
   �� *First+$ TwoWay=��� 5,   
   -   5        $��	lastLabel��5,      $��2q�6#   $��3��60   $��Right=�6?   .��6[   _Contact Lastname:6o   �� 5-   
   -   5        $��lastText��5-      $��3��6$   $��1��63   $��2q�6E   ��5.   
   �� *Last+$ TwoWay=��� 50   
   -   5        $��	cityLabel��50      $��2q�6#   $��4��60   $��Right=�6?   .��6[   _City:6c   �� 51   
   -   5        $��cityText��51      $��4��6$   $��1��63   $��2q�6E   ��52   
   �� *City+$ TwoWay=��� 54   
   -	   5        $��
stateLabel��54      $��2q�6$   $��5��61   $��Right=�6@   .��6\   	_State:6e   �� 55   
   -
   5        $��	stateText��55      $��5��6%   $��1��64   $��2q�6F   ��56   
   �� *State+$ TwoWay=��� 58   
   -   5        $��zipLabel��58      $��2q�6"   $��6��6/   $��Right=�6>   .��6Z   _Zip:6a   �� 59   
   -   5        $��zipText��59      $��6��6#   $��1��62   $��2q�6D   ��5:   
   �� *Zip+$ TwoWay=��� 5=   
   $��7��6   $��1��6$   $��15 20q�66   .+�5>      �� -   5        $
��Save��5>      $	��175��69   $��30��6E     buttonStyle#��[ 6Q   5?      5@      5A      