   M S B A M L   `   `   `  ����X  TReproductorMusicaTagEditables, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullk:clr-namespace:ReproductorMusicaTagEditables.Mvvm.ViewModel,ReproductorMusicaTagEditables.Mvvm.ViewModel  5      A    ;ReproductorMusicaTagEditables.Mvvm.View.Pages.DescargasPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      P	viewModel:clr-namespace:ReproductorMusicaTagEditables.Mvvm.ViewModel     5      j fMahApps.Metro.IconPacks.FontAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a8fa-http://metro.mahapps.com/winfx/xaml/iconpacks   5      T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f:control,http://metro.mahapps.com/winfx/xaml/controls  5        N� Title$  DescargasPage��5       � 	Resources 5       �� Source�� 5   
   $4 ./Mvvm/View/Pages/Theme/generalesPageTheme.xaml?�6   %     � DataContext 5      E   ?ReproductorMusicaTagEditables.Mvvm.ViewModel.DescargasViewModel  5   
   -   5        descargarViewModel��5   '   .��5      � $��15q�6    � ColumnDefinitions 5   
   �� 5      �� 5      $	��76* �6    � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6   �� 5      $��5 �6   .+�5#   
   � $��2��6    5$      �� 5%      .+�5(      ��  �� Orientation$ 
Horizontal=�6   $��Center=�5)      .+�5*      1  +MahApps.Metro.IconPacks.PackIconFontAwesome     Kind$ YoutubeBrands=�6)   $��0 7 10 0q�5+   )   $��80��5,   )   $��80��5-   )   
���  ��5.   )   �� 50      
�������$��35(�52      $��SemiBold"�53      $
��0 23q�54      ��50      �� *Irg.TitutloVentana+54        56      $ 	BellSolid=�6)   $��Center=�6:   $��35��57   )   $��35��64   $��10 0 0 0q�6@   
���  �� � ToolTip$X RExisten canciones descargadas y convertidas. Las puede ver desde el botón editar.��5:   )   y�59   )   �� *NotificacionCancion+5:   )   5<      5=      � 5?   
   $��1��6   $��2��6   .+�5@      �� .+�5A      �� $
��0 15q�6   .+�5B      �� $��Formato��6    
�������$��18(�5D       $��0 15 0 0q�5E       �� 5G      -   5        	 ��Name$	 
selectores��5H   !   $ 
Horizontal=�5G   !   $��0 15 0 0q�5I   !   .+�5J      	� -   5        
 	�Name$	
 mp3��5J   &    d� 	IsChecked$
 trueY�5K   &      radioSelector#��[  5L   &   $ Convertir a mp3��5O   &   {�5N   &   �� *HabilitarBotones+.��5P      �� $ 
Horizontal=�6)   .+�5Q   "     -   5          Name$ iconMp3��5Q   9   $ CircleSolid=�5R   9   
���  ��5S   9   �� 5T   "   $	��MP3��6,   
���  ��$��5 0 0 0q�5V   ,   5W      5X      	� 5Y      -   5        $	
 wav��5Y   &   $ falseY�5Z   &   #��[  5[   &   $��10 0 0 0q�5\   &   $ Convertir a wav��5_   &   {�5^   &   �� *HabilitarBotones+.��5`      �� $ 
Horizontal=�6)   .+�5a   "     -   5        $ iconWav��5a   9   $ CircleRegular=�5b   9   
���  ��5c   9   �� 5d   "   $	��WAV��6,   
���  ��$��5 0 0 0q�5f   ,   5g      5h      	� 5i      -   5        $	
 m4a��5i   &   $ falseY�5j   &   #��[  5k   &   $��10 0 0 0q�5l   &   $ Convertir a m4a��5o   &   {�5n   &   �� *HabilitarBotones+.��5p      �� $ 
Horizontal=�6)   .+�5q   "     -   5        $ iconM4a��5q   9   $ CircleRegular=�5r   9   
���  ��5s   9   �� 5t   "   $	��M4A��6,   
���  ��$��5 0 0 0q�5v   ,   5w      5x      5y      5z      �� 5}      .+�5      �� $ 
Horizontal=�6!   .+�5�      �� $ ��URLs de videos a convertir��6$   
�������$��18(�5�   $   $
��0 15q�5�   $   �� 5�      $��Descargado...��6$   
���  ��$��18(�5�   $   $��7 0 0 0q�62   $��Center=�5�   $   �� 5�      
���  ��$��18(�5�   $   $��7 0 0 0q�62   $��Center=�5�   $   ��5�   $   �� *CantidadDescargando+5�   $   5�      �� 5�      $
��Auto=�6#   $	��200��5�   !   .��5�      �� -	   5         ��Name$ itemDescargas��5�   '   ��5�      �� 5�   "   .R�5�   &   �� 5�   #   5�      5�      5�      �� 5�      $ 
Horizontal=�6   $��0 30 0 0q�5�      .+�5�      �� -
   5          
btnGeneral#��[ 5�      
���P��
�������$! Editar archivos descargados��5�      {�5�      �� *HabilitarBotones+.��5�      �� $ 
Horizontal=�6%   .+�5�          btnIcon#��[ 65   $ TagSolid=�6V   �� 5�      $��Editar��6(   
�������$��5 0 0 0q�6I   5�      5�      �� 5�      -   5        #��[ 5�      
�������
���   �$
��10 0q�5�      $, &Mover archivos a una ruta seleccionada��5�      {�5�      �� *HabilitarBotones+.��5�      �� $ 
Horizontal=�6%   .+�5�        #��[ 65   $ DirectionsSolid=�6V   
���   �6m   �� 5�      $��Mover��6(   
���   �$��5 0 0 0q�6H   5�      5�      �� 5�      -   5        #��[ 5�      
���  ��
�������$ Borrar todos los archivos��5�      {�5�      �� *HabilitarBotones+.��5�      �� $ 
Horizontal=�6%   .+�5�        #��[ 65   $ 
BroomSolid=�6V   �� 5�      $��Eliminar��6(   
�������$��5 0 0 0q�6K   5�      5�      �� 5�      $��10 0 0 0q�6!   .+�5�      �� $H��BNo Cambie de página mientras el proceso de descarga está activo.��6$   
���  ��$��15(�5�   $   y�5�   $   �� *MjeDescargaActivado+5�      5�      5�      5�      �� 5�   
   $��1��6   $	��250��6   $	��600��6*   $��-327 -20 0 0q�5�      
���   � J� Opacity$	 0.8Q�5�      $��Center=�5�      $��Center=�5�      y�5�      �� *MjeDescargaActivado+._�5�      )  #MahApps.Metro.Controls.ProgressRing  
���  ��$��70��5�   #   $��70��5�   #   5�      5�      5�      