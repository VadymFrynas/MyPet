   M S B A M L   `   `   `  ����A  =Wallet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WalletWallet  5   	       Wallet.UpdateAccount   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Wallet     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Wallet��5	   	   $��465.759��6   $��507.6��6)   .��5      � 
�������.+�5   
   �� .��5   
   �� $��	0,0,0,0.4q�6   .+�5      �� $��Update account info��6   $��30(�63   $
��Bold"�6A   $��Italic$�6S   $��Center=�6g   $��	0,30,0,40q�6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ MyGrid��5      
�������   GridLinesVisibility$	 All=�6A      CanUserAddRows .     AutoGenerateColumns .     HorizontalGridLinesBrush
 �����   VerticalGridLinesBrush
 �����$��50,0,51.8,10q�6�   $	��409��6�    � 	Resources 5      *  $System.Windows.Controls.DataGridCell �� 
TargetType	 �� Triggers
 P� Property P� Value �� Property �� Value��%�   '        �� 5      "  6    	 5      P� 5   "   
 �@ 
IsSelected .  . �5   &   ��  � ��
 �����6C   5   #   P� 5   "   
 �@ 
IsSelected . . �5   &   ��  � ��
 �����6C   5   #   5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Owner name��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6\   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *
_OwnerName+6\     5      $ Card number ��6)   $	 180 6]    6?   �� *	_CardName+6]     5       $	 Sum��6)   $ 75 6V    66   �� *_TotalMoney+6V   5$      � 5%      .+�5&      �� -   5         ��Name$
 Back��5&      $��Back to menu��6+   $
��Left=�6B   $��
48,20,12,5q�6]   $	��142��6q   
���   �
���2͚� "  MaterialDesignFlatDarkBgButton#��[  6�   $��52��6�    J� RenderTransformOrigin$ 0.503,0.508&�6   �� 5'      -   5        $ SaveUpdating��5'      $��Save updating��63   $��Center=�6K   $��
18,20,12,5q�6h   $	��242��6|   
���   �
���2͚�#��[  6�   $��52��6�   $ 0.503,0.508&�6  5)      5+      5-      50      51      