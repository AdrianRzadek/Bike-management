   M S B A M L   `   `   `  ����@  <ProjP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ProjPProjP  5   	   3clr-namespace:ProjP.ViewModelsProjP.ViewModels  5   	       ProjP.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:ProjP     5   	   -vmclr-namespace:ProjP.ViewModels     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  
MainWindow��5   	   $	��800��6   $
��1200��6)    � WindowStartupLocation$ CenterScreen=�66    � WindowState$ Normal=�6[    � 
ResizeMode$ NoResize=�6p    � WindowStyle$
 None=�6�   
������� � 	Resources 5         MenuOpen �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime	 O� Value  	MenuClose��%�  &	        &	 �     �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $	 60Q�63     5      $ 0:0:0.5��6'   $		 200Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $		 200Q�63     5      $ 0:0:0.5��6'   $	 60Q�69   5      5      5      
 � Triggers
 5      :� 5   
    :� RoutedEvent$ ButtonBase.Click��6    :� 
SourceName$ ButtonOpenMenu��66   .[�5       �� #��[  6   5!      :� 5"   
   $ ButtonBase.Click��6   $ ButtonCloseMenu��66   .[�5#      �� #��[ 6   5$      .��5(      � 
�������.+�5*   
   �� $<��6C:\Users\adria\Documents\GitHub\PIV\ProjP\bikeride.png��6    J� OpacityMask
 �   �$��20,339,-20,51q�6d   �� 5+   
   ���	#FF1368BD$��200,173,160,461q�6+   $��72(�6D   Witaj na stronie głównej!6m    � 5,   
   -   5        $
��Main��5,      $
��Main��6   $��20,10,-20,-10q�6+   � 5.   
   $��60��6   $	��Top=�6   ���	#FF1368BD.+�50      �� $��Wypożyczalnia Rowerów��6   $��Center=�65   $��Center=�6R   $��24(�6m   �� 52      $��Center=�6    �� Orientation$ 
Horizontal=�64   $��Right=�6M   .+�54      '  !MaterialDesignThemes.Wpf.PopupBox  $��10q�6+      PlacementMode$ BottomAndAlignRightEdges=�67      	StaysOpen$ False��6`      PopupContent. 55      �� $	��150��6!   .+�56      �� -   5         ��Name$ ButtonLogout��56   !   $��Wyjdź��67   6G   57      58      5:      5;      � 5<   
   -   5         �Name$ GridMenu��5<      $��60��6!   $
��Left=�6,   ���	#FF1F3D68.+�5>      �� .+�5@      � $	��150��6   
�������$
{�True��68   .+�5A      �� $8��2C:\Users\adria\Documents\GitHub\PIV\ProjP\bike.png��6   �� 5C      -   5        $ ButtonCloseMenu��5C      $��60��66   $��60��6A   $	��Top=�6{   $��Right=�6�   $y�	Collapsed=�6�    � Cursor$
 Hand��6�   ��6N   Z� ��6d   Z� .��5D      '  !MaterialDesignThemes.Wpf.PackIcon  ���	#FF1B3861   Kind$ 	ArrowLeft=�6I   $��25��6Z   $��25��6e   5E      �� 5F      -   5        $ ButtonOpenMenu��5F      $��60��65   $��60��6@   $	��Top=�6z   $��Right=�6�   ��6M   Z� ��6c   Z� .��5G        ���	#FF1B3861$
 Menu=�6I   $��25��6U   $��25��6`   5H      5K      �� 5N      $��Disabled=�6   ���	#FF1368BD.@�5O      �� $��60��6#   .��5P      �� -   5        $ 
HomeButton��5P   !   $
 Hand��6Q   $��70��6_   $	��200��6k    J� RenderTransformOrigin$ 0.525,0&�6w   $
��Left=�6�   $��Center=�6�   $��	-10,0,0,0q�6�   ��6�   Z� .��5Q      �� $ 
Horizontal=�6)   $ 0.647,0.522&�6B   $	��190��6f   .+�5R   "    � -   5          �Name$ _NavigationFrame0��5R   (     � NavigationUIVisibility$ Hidden=�6C     5S   "   $ ViewDashboard=�6:   $��25��6O   $��25��6Z   $��10q�6f   $��Center=�6r   �� 5T   "   $
��Home��6,   $��Center=�68   $��Right=�6S   $��20 10q�6o   5U      5V      5W      �� 5Y      -   5         ��Name$ klienci��5Y   #   $��60��65   .��5Z      �� -	   5        $ KlienciButton��5Z   !   $
 Hand��6V   $��70��6d   $	��200��6p   $ 0.525,0&�6|   $
��Left=�6�   $��Center=�6�   $��	-10,0,0,0q�6�   ��6�   Z� .��5[      �� $ 
Horizontal=�6)   $	��200��6B   $ 	0.322,0.5&�6N   $��Stretch=�6p   .+�5\   "    � -
   5        $ _NavigationFrame1��5\   (   $ Hidden=�6C     5]   "   $ AccountBoxMultiple=�6:   $��25��6T   $��25��6_   $��10q�6k   $��Center=�6w   �� 5^   "   $��Klienci��6,   $��Center=�6<   $��20 10q�6W   5`      5a      5b      �� 5d      $��60��6#   .��5e      �� -   5        $ WypożyczeniaButton��5e   !   $
 Hand��6`   $��70��6n   $	��200��6z   $ 0.525,0&�6�   $
��Left=�6�   $��Center=�6�   $��	-10,0,0,0q�6�   ��6�   Z� .��5f      �� $ 
Horizontal=�6)   .+�5g   "    � -   5        $ _NavigationFrame2��5g   (   $ Hidden=�6C     5h   "   $ Pencil=�6:   $��25��6H   $��25��6S   $��10q�6_   $��Center=�6k   �� 5i   "   $��Wypożyczenia��6,   $��Center=�6@   $��20 10q�6[   5k      5l      5m      �� 5o      $��60��6#   $	��332��6/   .��5p      �� -   5        $ FakturyButton��5p   !   $
 Hand��6V   $��70��6d   $	��200��6p   $ 0.525,0&�6|   $
��Left=�6�   $��Center=�6�   $��	-10,0,0,0q�6�   ��6�   Z� ��6�   Z� .��5q      �� $ 
Horizontal=�6)   $	��200��6B   .+�5r   "    � -   5        $ _NavigationFrame3��5r   (   $ Hidden=�6C     5s   "   $ receipt=�6:   $��25��6I   $��25��6T   $��10q�6`   $��Center=�6l   �� 5t   "   $��Faktury��6,   $��Center=�6;   $��20 10q�6V   5v      5w      5x      �� 5z      $��60��6#   .��5{      �� -   5        $ RoweryButton��5{   !   $
 Hand��6T   $��70��6b   $	��200��6n   $ 0.525,0&�6z   $
��Left=�6�   $��Center=�6�   $��	-28,0,0,0q�6�   ��6�   Z� ��6�   Z� .��5|      �� $ 
Horizontal=�6)   .+�5}   "    � -   5        $ _NavigationFrame4��5}   (   $ Hidden=�6C     5~   "   $ bicycle=�6:   $��25��6I   $��25��6T   $��10q�6`   $��Center=�6l   �� 5   "   $��Rowery��6,   $��Center=�6:   $��20 10q�6U   5�      5�      5�      �� 5�      $��60��6#   .��5�      �� -   5        $ PracownicyButton��5�   !   $
 Hand��6\   $��70��6j   $	��200��6v   $ 0.525,0&�6�   $
��Left=�6�   $��Center=�6�   $��	-18,0,0,0q�6�   ��6�   Z� ��6  Z� .��5�      �� $ 
Horizontal=�6)   .+�5�   "     $ Account=�6:   $��25��6I   $��25��6T    � 5�   "   -   5        $ _NavigationFrame5��5�   (   $ Hidden=�6C   �� 5�   "   $��
Pracownicy��6,   $��Center=�6>   $��20 10q�6Y   5�      5�      5�      5�      5�      5�      5�      5�      