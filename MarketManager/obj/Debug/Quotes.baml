   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   H DMarketManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:MarketManager.ViewModelMarketManager.ViewModel 5   	      MarketManager.Quotes   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   7local%clr-namespace:MarketManager.ViewModel     5   	   
����� �  � WindowStartupLocation$  CenterScreen=�5
   	    � Title$ Quotes��5   	   $	��400��6   $	��400��6%    � DataContext 5      ,  &MarketManager.ViewModel.QuoteViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5       $
��Auto �6   6,   �� 5!      $��* �6   6)   �� 5"      $��40 �6   6*    � ColumnDefinitions 5$   
   �� 5%      $
��auto �6   6.   �� 5&      $
��auto �6   6.   .+�5(   
   �� $��Name:��6   $��0��6    $��0��60   6?   �� 5)   
   $��Symbol:��6   $��0��6"   $��1��62   6A   �� 5*   
   $��Last Price:��6   $��0��6&   $��2��66   6E   �� 5+   
   $��Change:��6   $��0��6"   $��3��62   6A   �� 5,   
   $��	Change %:��6   $��0��6$   $��4��64   6C   �� 5-   
   $��Time stamp:��6   $��0��6&   $��5��66   6E   �� 5.   
   $��MS Date:��6   $��0��6#   $��6��63   6B   �� 5/   
   $��Market Cap:��6   $��0��6&   $��7��66   6E   �� 50   
   $��Volume:��6   $��0��6"   $��8��62   6A   �� 51   
   $��Change YTD:��6   $��0��6&   $��9��66   6E   �� 52   
   $��Change YTD %:��6   $��0��6(   $��10��68   6H   �� 53   
   $��High:��6   $��0��6    $��11��60   6@   �� 54   
   $
��Low:��6   $��0��6   $��12��6/   6?   �� 55   
   $��Open:��6   $��0��6    $��13��60   6@   �� 56   
   $��1��6   $��0��6$   ��61   �� *
Quote.Name+6O   �� 57   
   $��1��6   $��1��6$   ��61   �� *Quote.Symbol+6Q   �� 58   
   $��1��6   $��2��6$   ��61   �� *Quote.LastPrice+6T   �� 59   
   $��1��6   $��3��6$   ��61   �� *Quote.Change+6Q   �� 5:   
   $��1��6   $��4��6$   ��61   �� *Quote.ChangePercent+6X   �� 5;   
   $��1��6   $��5��6$   ��61   �� *Quote.Timestamp+6T   �� 5<   
   $��1��6   $��6��6$   ��61   �� *Quote.MSDate+6Q   �� 5=   
   $��1��6   $��7��6$   ��61   �� *Quote.MarketCap+6T   �� 5>   
   $��1��6   $��8��6$   ��61   �� *Quote.Volume+6Q   �� 5?   
   $��1��6   $��9��6$   ��61   �� *Quote.ChangeYTD+6T   �� 5@   
   $��1��6   $��10��6$   ��62   �� *Quote.ChangePercentYTD+6\   �� 5A   
   $��1��6   $��11��6$   ��62   �� *
Quote.High+6P   �� 5B   
   $��1��6   $��12��6$   ��62   �� *	Quote.Low+6O   �� 5C   
   $��1��6   $��13��6$   ��62   �� *
Quote.Open+6P   5D      5E      