   M S B A M L   `   `   `  ����H  DMarketManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:MarketManager.ViewModelMarketManager.ViewModel  5      T PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5          MarketManager.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      7local%clr-namespace:MarketManager.ViewModel     5      PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5        � Title$  
MainWindow��5      $	��800��5      $
��1100��5      
�������$��0q�5
       � 
ResizeMode$ CanResizeWithGrip=�5       � WindowStartupLocation$ CenterScreen=�5       � DataContext 5      +   %MarketManager.ViewModel.MainViewModel  5   
   .��5      � .+�5   
   �� *  $MahApps.Metro.Controls.TextBoxHelper   ClearTextButton . $��30��6@   $��785,17,7,719.5q�6�    �� 	IsEnabled .  J� RenderTransformOrigin$ 0.5,0.5&�6�   )  #MahApps.Metro.Controls.ButtonHelper   CornerRadius$ 5��6�   ��6L   �� *
SearchTerm+ �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=�.��6  5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��158,64,10,10.5q�5      
   AutoGenerateColumns
 . $��1q�6G   $	��700��6�      
IsReadOnly . ��6[   �� *QueryResult.Lookup+$ OneWay=�5      5      5      