   M S B A M L   `   `   `  ����@  <Timer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TimerTimer  5   	       Timer.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Timer     5   	     � Title$  
MainWindow��5   	   $	��300��6   $	��300��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��2* �6   �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� $��1��60   $��3��6=   $��Center=�6Q   $��Center=�6n   $��45(�6�   ��6   �� *TimeDisplay+6�   �� 5   
   $��Start��6   $��50��6B   $��30��6M   $��0��6Y   $��3��6i   ��6!   �� *StartCommand+6i   �� 5   
   $��Pause��6   $��50��6B   $��30��6M   $��1��6Y   $��3��6i   ��6!   �� *PauseCommand+6i   �� 5   
   $��Reset��6   $��50��6B   $��30��6M   $��2��6Y   $��3��6i   ��6!   �� *ResetCommand+6i   �� 5   
   $��^��6   $��30��6E   $��30��6P   $��0��6\   $��0��6l   $��Right=�6y   ��6   �� *IncreaseHourCommand+6y   �� 5   
   $��^��6   $��30��6G   $��30��6R   $��1��6^   $��0��6n   ��6   �� *IncreaseMinuteCommand+6n   �� 5   
   $��^��6   $��30��6G   $��30��6R   $��2��6^   $��0��6n   $
��Left=�6{   ��6   �� *IncreaseSecondCommand+6{   �� 5   
   $��v��6   $��30��6E   $��30��6P   $��0��6\   $��2��6l   $��Right=�6y   ��6   �� *DecreaseHourCommand+6y   �� 5   
   $��v��6   $��30��6G   $��30��6R   $��1��6^   $��2��6n   ��6   �� *DecreaseMinuteCommand+6n   �� 5    
   $��v��6   $��30��6G   $��30��6R   $��2��6^   $��2��6n   $
��Left=�6{   ��6   �� *DecreaseSecondCommand+6{   5!      5"      