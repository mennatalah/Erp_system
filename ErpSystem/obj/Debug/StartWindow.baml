   M S B A M L   `   `   `  ����D  @ErpSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ErpSystem	ErpSystem  5   	       ErpSystem.StartWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   #localclr-namespace:ErpSystem  5   	     � Title$  StartWindow��5	   	   $	��450��6   $	��800��6*   .��5
      � $
��0,20q�6    � ColumnDefinitions 5   
   �� 5      $��* �5      5      �� 5      $��3* �5      6   .+�5   
   � $��0��6   
��� ��� � RowDefinitions 5      �� 5      $��70 �6    �� 5      $��70 �6    �� 5      $��70 �6    �� 5      $��70 �6    �� 5      $��70 �6    .+�5      �� -   5         ��Name$ companiesbtn��5      $��1��5      
�������   MaterialDesignFlatButton#��[  5      $��	Companies��5       $
��Auto��5!   �   {�6   �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType$ WindowL�6�   �� 5"      -   5        $ companiesAdressbtn��5$      $��2��5#      
�������#��[  5'      $��Companies Addresses��5(      $
��Auto��5)   �   {�6   �� *DataContext.ControlsEnabled+ �� *FindAncestor+$ WindowL�6�   �� 5*      -   5        $ companiesTelephonbtn��5,      $��3��5+      
�������#��[  5/      $��Companies Telephones��50      $
��Auto��51   �   {�6   �� *DataContext.ControlsEnabled+ �� *FindAncestor+$ WindowL�6�   �� 52      -   5        $ 
contactbtn��54      $��0��53      
�������#��[  57      $��Contacts��58      $
��Auto��59   �   {�6   �� *DataContext.ControlsEnabled+ �� *FindAncestor+$ WindowL�6�   �� 5:      -   5        $ 
signOutbtn��5<      $��4��5;      
�������#��[  5?      $��Sign out��5@      $
��Auto��5A   �   {�6   �� *DataContext.ControlsEnabled+ �� *FindAncestor+$ WindowL�6�   5C      � 5D   
   $��1��6   .+�5F      &   System.Windows.Controls.DataGrid  -   5          Name$ myGrid��5H         CanUserAddRows .     SelectionUnit$ FullRow=�5J      ��5G      �� *Items2+5K      5M      5P      5Q      