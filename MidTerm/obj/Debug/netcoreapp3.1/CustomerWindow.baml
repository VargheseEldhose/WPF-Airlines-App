   M S B A M L   `   `   `  ����B  >MidTerm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MidTermMidTerm  5   	       MidTerm.CustomerWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:MidTerm     5   	   -   5          �Name$  
CustWindow��5   	    � Title$ CustomerWindow��5   	   $	��450��6    $	��800��6-   $��0,0,0,10q�6V    � ContextMenu 5	      �� 5
   
   .@�5      m� -   5         m�Name$ 
InsertCust��5      $��Insert��6D   6V   m� 5      -   5        $ 
UpdateCust��5      $��Update��6G   6Y   5      .��5      � $	��440��6   $	��Top=�6   #��� ��60    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      �� 5      .+�5   
   ]� $��False��6   $��	0,0,0,198q�6*   $��2��6=   .+�5      o� $	��798��6   $��37��6   $��0,2,0,0q�6+   .@�5      m� -   5        $
 File��5      $
��File��6)   .@�5      m� -   5        $	 New��5      $	��New��6,   m� 5      -   5        $
 Save��5      $
��Save��6-   m� 5      -   5        $
 Quit��5      $
��Quit��6-   6;   5      m� 5      -   5        $
 Edit��5      $
��Edit��6)   .@�5       m� -	   5        $ InsertCustFromMenu��5       $��Insert��6;   6K   m� 5!      -
   5        $ UpdateCustFromMenu��5!      $��Update��6;   6K   m� 5"      -   5        $ DeleteCustFromMenu��5"      $��Delete��6;   6K   5#      m� 5$      -   5        $ HelpC��5$      $
��Help��6*   68   m� 5%      -   5        $ Homepage��5%      $��HomepageOnly��6-   .@�5&      m� -   5        $ view_custMenu��5&      $��View Customers��66   6N   m� 5'      -   5        $ view_airlinM��5'      $��View Airlines��65   6L   m� 5(      -   5        $ view_flightM��5(      $��View Flights��65   6K   m� 5)      -   5        $ 
view_passM��5)      $��View Passengers��63   6L   5*      5+      5,      �� 5-   
   -   5         ��Name$ LBCustomers��5-      $��Stretch=�6'   $��0,27,0,0q�5.   Z   ��6   �� 6Z   �� 5/   
   $��Customer Name:��6   $��1��6)   $
��Left=�69   $��	47,39,0,0q�6T   $	��Top=�6g   $��14(�6   �� 50   
   -   5         ��Name$ 
TBCustName��50      $��1��6&   $
��Left=�66   $��
166,44,0,0q�6Q    �� TextWrapping$
 Wrap=�6e   $	��Top=�6y   $	��120��6�   �� 51   
   -   5        $ TBemailCust��51      $��1��6'   $
��Left=�67   $��
166,76,0,0q�6R   $
 Wrap=�6f   $	��Top=�6z   $	��120��6�   �� 52   
   -   5        $ TBaddressCust��52      $��1��6)   $
��Left=�69   $��	166,0,0,0q�6T   $
 Wrap=�6g   $��Center=�6{   $	��120��6�   	 J� RenderTransformOrigin$	 0.524,2.192&�6�   �� 53   
   -   5        $ TBPhoneCust��53      $��1��6'   $
��Left=�67   $��166,129,0,0q�6R   $
 Wrap=�6g   $	��Top=�6{   $	��120��6�   �� 54   
   $��Email��6   $��1��6    $
��Left=�60   $��
111,71,0,0q�6K   $	��Top=�6_   $��14(�6w   �� 55   
   $��Address��6   $��1��6"   $
��Left=�62   $��	101,0,0,0q�6M   $��Center=�6`   $��14(�6{   �� 56   
   $��Phone��6   $��1��6    $
��Left=�60   $��105,124,0,0q�6K   $	��Top=�6`   $��14(�6x   �� 57   
   -   5        
 ��Name$
 
BtnAddCust��57      $	��Add��6%   $��1��63   $
��Left=�6C   $��
74,180,0,0q�6^   $	��Top=�6r   $��14(�6�   $��48��6�   �� 58   
   -   5        $
 BtnUpdateCust��58      $��Update��6(   $��1��69   $��Center=�6I   $��	0,180,0,0q�6f   $	��Top=�6y   $��14(�6�   $��68��6�   �� 59   
   -   5        $
 BtnDeleteCust��59      $��Delete��6(   $��1��69   $
��Left=�6I   $��270,180,0,0q�6d   $	��Top=�6y   $��14(�6�   $��74��6�   5;      5<      