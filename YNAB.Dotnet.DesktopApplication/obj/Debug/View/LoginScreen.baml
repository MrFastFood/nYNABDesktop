   M S B A M L   `   `   `  ����Y  UYNAB.Dotnet.DesktopApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:YNAB.Dotnet.DesktopApplication.View#YNAB.Dotnet.DesktopApplication.View  5      c6clr-namespace:YNAB.Dotnet.DesktopApplication.ViewModel(YNAB.Dotnet.DesktopApplication.ViewModel  5      5    /YNAB.Dotnet.DesktopApplication.View.LoginScreen   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Clocal1clr-namespace:YNAB.Dotnet.DesktopApplication.View     5      Evm6clr-namespace:YNAB.Dotnet.DesktopApplication.ViewModel     5        N� 
Background
  ���� $	��450��5      $	��500��5       N� Title$ Log In��5       � DataContext 5      C   =YNAB.Dotnet.DesktopApplication.ViewModel.LoginScreenViewModel  5   
    � 	Resources 5       �� 
TargetType �� Property �� Value   MyWaterMarkStyle �� 
TargetType �� CornerRadius	 ��Name
 ��Name
 � Tag �� Triggers ]� 
Conditions �� Property �� Value �� 
TargetName P� Property P� Value��%�  '��       '�� H     &	  �     �� 5   
   " ��6   .�5      ��  � ��$ 15(�6)   5      �� 5   
   " ��6   .�5      ��  � ��
 �����6+   �� 5       � ��$ 18(�6)   �� 5       � ��$
 Bold"�6+   5      �� 5   
   " ��6)   .�5      ��  � �� 5      �� 5      " ��6&   .R�5       �� $��5q�6!   $ 5��6,   
����������	#FF7D8683$��1q�6h   ._�5!      � .+�5"   "   �� $	 PART_ContentHost��6/   $��5,0,0,0q�6I   $��Center=�6Z   �� 5#   "   $
 WaterMarkLabel��69   $��5,0,0,0q�6(   #��z 6Q   $��Center=�6q   $��15(�6�   $y�	Collapsed=�5$       
�������$��Arial)�6I   5%      5&       5(      ]� 5)       5*   "   �� 5+   &    � ��$  ��6@   ./�5-   "   �� $ WaterMarkLabel��6?    � y�$ Visible=�6[   5.      P� 5/       � {� .  . �50   "   ��  � ��
 �iii�6?   51      53      55      56      58      .��59      �� $ 15��6   
������� J� Effect 5:   
   3  -System.Windows.Media.Effects.DropShadowEffect  5;         
BlurRadius$ 10Q�6      Opacity$	 0.4Q�6/   ._�5=   
   �� .+�5>      �� $B��</YNAB.Dotnet.DesktopApplication;component/Resources/logo.png��6   � 5?      $��50,25,50,50q�6    � RowDefinitions 5@      �� 5A      �� 5B      $��20 �6$   �� 5C      $��50 �6$   �� 5D      $��50 �6$   �� 5E      $��50 �6$   .+�5I      �� $��1��6   $��Log in with��6)   
������� �� TextAlignment$ Center=�6N   $��Bottom=�6e   �� 5J      #��[  6   $ email address��6�   $��2��6�   ��6D   �� *
Username+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5K      #��[  6   $ password��6�   $��3��6�   ��6D   �� *
Password+$ PropertyChanged=�6�   �� 5M      $��
0,20,0,-20q�6   $��4��6-   $ 10��6:   ���#008caf._�5N      �� 
������ 
������ $��0q�6P   $��Log In��6d   ��6u   �� *LoginCommand+$ PropertyChanged=�5O      5Q      5R      5T      5U      