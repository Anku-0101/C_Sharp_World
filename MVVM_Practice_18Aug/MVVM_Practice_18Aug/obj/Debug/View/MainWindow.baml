   M S B A M L   `   `   `  ����N  JMVVM_Practice_18Aug, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:MVVM_Practice_18AugMVVM_Practice_18Aug  5   	   M+clr-namespace:MVVM_Practice_18Aug.ViewModelMVVM_Practice_18Aug.ViewModel  5   	   $    MVVM_Practice_18Aug.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:MVVM_Practice_18Aug     5   	   :vm+clr-namespace:MVVM_Practice_18Aug.ViewModel     5   	     � Title$  
MainWindow��5
   	   $	��450��6   $	��800��6)    � 	Resources 5      3  -MVVM_Practice_18Aug.ViewModel.PersonViewModel   PersonVM��%   &	          5   
   6   5      .��5      �  � DataContext 6   ��  �� Source# [   � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��
First Name��6   �� 5   
   $��	Last Name��6   $��1��6$   �� 5   
   -   5         ��Name$ 	firstName��5      $��1��6H   ��6%   �� *Person_.FirstName+6H   �� 5   
   -   5        $ lastName��5      $��1��6$   $��1��6V   ��64   �� *Person_.LastName+6V   �� 5   
   $��Submit��63   $��2��6D   ��6   �� *SubmitCommand+6D   �� 5   
   $��3��63   $��1��6@   $
��Auto��6P   ��6   �� *	Persons+ �� View 5       �� 5!      .P�5"      �� $��
First Name��6%    �� Width$
 Auto��6e   	 �� DisplayMemberBinding	 69   �� *	FirstName+6e   �� 5#      $��	Last Name��6%   $
 Auto��6c   	 68   �� *
LastName+6c   �� 5$      $��	Full Name��6%   $
 Auto��6b   	 68   �� *
FullName+6b   5%      5'      5(      5)      