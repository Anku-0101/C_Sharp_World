   M S B A M L   `   `   `  ����Z  VWpf_Property_Data_EventTriggers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Wpf_Property_Data_EventTriggersWpf_Property_Data_EventTriggers  5   	   0    *Wpf_Property_Data_EventTriggers.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:Wpf_Property_Data_EventTriggers     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �� .+�5
   
   � .+�5      �� $%��Welcome to Strand Life Sciences��6   $��32(�6?   $��Center=�6M   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value
 � � �6G    �� Triggers 5      P� 5       P� Property �@J�IsMouseOver P� Value . . �5   "   ��  � ��
 �  ��6?   �� 5   "    � ��$ 	Underline{�6D   5      5      5      5      � 5   
   .+�5      �� $��Hello, buddy��6   $��24(�6,   $��Center=�6:   $��Center=�6W   ��5      �� 5      " ��6    5      :� 5       :� RoutedEvent$ 
MouseEnter��6+   [�5   "   �� 5    &   .��5!   *   �� .��5"   .   W�  g� Duration$ 	0:0:0.500D�6>   	 �� TargetProperty$	 FontSize�6S   	
 W� To$
 72X�6x   5#   +   5$   '   5&      :� 5'      $ 
MouseLeave��6+   [�5(   "   �� 5)   &   .��5*   *   �� .��5+   .   W� $ 	0:0:1.500D�6>   $	 FontSize�6S   $
 24X�6x   5,   +   5-   '   5/      51      53      54      �� 55   
   .+�56      �� -   5         ��Name$ cbHello��56      $��Is someone there?��6(   $��Center=�6D   �� 57      $��Center=�6   $��36(�65   ��58      �� 59      " ��6   .�5:      ��  � ��$ No��61   �� 5;       � ��
 �  ��67    5<      �� 5=       �� Binding 6*   ��  �� ElementName$ cbHello�� �� Path$ 	IsChecked� �� Value True6b   .a�5>   "   ��  � ��$ Yes the box is checked��69   �� 5?   "    � ��
 � � �6?   5@      5B      5D      5E      5F      5G      