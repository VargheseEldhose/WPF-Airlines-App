   M S B A M L   `   `   `  ����B  >MidTerm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MidTermMidTerm  5   	       MidTerm.PassengersWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:MidTerm     5   	   -   5          �Name$  PassWind��5   	    � Title$ PassengersWindow��5   	   $	��450��6"   $	��800��6/    � ContextMenu 5	      �� 5
   
   .@�5      m� -   5         m�Name$ InsertPassenger��5      $��Insert��6E   6W   m� 5      -   5        $ UpdatePassenger��5      $��Update��6H   6Z   5      .��5      � #��� ��6    � ColumnDefinitions 5   
   �� 5      $��0* �6   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      .+�5   
   ]� $��False��6   $��	0,0,0,191q�6*   $��3��6=   .+�5      o� -   5         o�Name$ MenuPassenger��5      $	��796��6*   $��21��66   $��0,-4,0,0q�6B   .@�5      m� -   5        $
 File��5      $
��File��6)   .@�5      m� -   5        $	 New��5      $	��New��6,   m� 5      -   5        $
 Save��5      $
��Save��6-   m� 5      -   5        $
 Quit��5      $
��Quit��6-   6;   5      m� 5       -	   5        $
 Edit��5       $
��Edit��6)   .@�5!      m� -
   5        $ InsertPassM��5!      $��Insert��64   6D   m� 5"      -   5        $ UpdateM��5"      $��Update��60   6@   m� 5#      -   5        $ DeletePassM��5#      $��Delete��64   6D   5$      m� 5%      -   5        $ HelpP��5%      $
��Help��6*   68   m� 5&      -   5        $ Homepage��5&      $��HomepageOnly��6-   .@�5'      m� -   5        $ ViewCustMenu3��5'      $��View Customer��66   6M   m� 5(      -   5        $ ViewAirLineMenu2��5(      $��View Airline��69   6O   m� 5)      -   5        $ ViewFlightMenu3��5)      $��View Flights��68   6N   m� 5*      -   5        $ ViewPassmenu4��5*      $��View Passenger��66   6N   5+      5,      5-      �� 5.   
   -   5         ��Name$ LBPassengers��5.      $��2��6@   $��0,26,0,0q�6T   ��6(   �� 6f   �� 5/   
   $��Customer ID��6   $��2��6&   $
��Left=�66   $��
117,50,0,0q�6Q   $	��Top=�6e   �� 50   
   $��LabelFlightID��6   $��2��6(   $
��Left=�68   $��
114,87,0,0q�6S   $	��Top=�6g   �� 51   
   -   5         ��Name$ TBCustID��51      $��2��6$   $
��Left=�64   $��
200,54,0,0q�6O   	 �� TextWrapping$
	 Wrap=�6c   $	��Top=�6w   $	��120��6�   �� 52   
   -   5        $ 
TBFlightID��52      $��2��6&   $
��Left=�66   $��
200,91,0,0q�6Q   $
	 Wrap=�6e   $	��Top=�6y   $	��120��6�   �� 53   
   -   5        
 ��Name$
 BtnAdd��53      $��Insert��6!   $��2��62   $
��Left=�6B   $��
83,154,0,0q�6]   $	��Top=�6q   $��71��6�   6�   �� 54   
   -   5        $
 	BtnUpdate��54      $��Update��6$   $��2��65   $
��Left=�6E   $��181,154,0,0q�6`   $	��Top=�6u    J� RenderTransformOrigin$ 0.021,-0.946&�6�   $��79��6�   6�   �� 55   
   -   5        $
 BtnDlt��55      $��Delete��6!   $��2��62   $
��Left=�6B   $��293,154,0,0q�6]   $	��Top=�6r   $��76��6�   6�   57      58      