   M S B A M L   `   `   `  ����B  >MidTerm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MidTermMidTerm  5   	       MidTerm.LoginWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:MidTerm     5   	   -   5          �Name$  	LgnWindow��5   	    � Title$ LoginWindow��5   	   $	��450��6   $	��800��6*   .��5	      � #��� ��6    � RowDefinitions 5
   
   �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� -   5         ��Name$ LBLuser��5      $��Username��6!   $
��Left=�64   $��	229,0,0,0q�6O   $��Center=�6b   $��Center=�6}   $��Center=�6�   $��49��6�   $	��129��6�   $��18(�6�   �� 5   
   $��Password��6   $
��Left=�6#   $��242,136,0,0q�6>   $	��Top=�6S   $��Center=�6k   $��Center=�6�   $��56��6�   $	��102��6�   $��18(�6�   �� 5   
   -   5         ��Name$ TbUser��5      $
��Left=�6"   $��	363,0,0,0q�6=    �� TextWrapping$
 Wrap=�6P   $��Center=�6d   $	��239��6   $
��Left=�6�   $	��Top=�6�   $��23��6�   $��2��6�   G� 5   
   -   5         G�Name$ 
PBpassword��5      $
��Left=�6*   $��363,151,0,0q�6E   $	��Top=�6Z   $	��239��6r   $��26��6~   $��2��6�   �� 5   
   -   5         ��Name$ BtnLogin��5      $��Login��6#   $
��Left=�63   $��
242,75,0,0q�6N   $	��Top=�6b   $��34��6z   $	��138��6�   $��16(�6�   $��1��6�   ���	#FFF6F3F36�   �� 5   
   -   5        $ 	BtnCancel��5      $��Cancel��6$   $
��Left=�65   $��	66,73,0,0q�6P   $	��Top=�6c   $��36��6{   $	��151��6�   $��16(�6�   $��1��6�   $��1��6�   ���	#FFFCFAFA6�   5      5      