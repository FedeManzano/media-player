   M S B A M L   `   `   `  ����X  TReproductorMusicaTagEditables, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Eclr-namespace:ReproductorMusicaTagEditables.Controls.InfoCancionTabla7ReproductorMusicaTagEditables.Controls.InfoCancionTabla  5      k:clr-namespace:ReproductorMusicaTagEditables.Mvvm.ViewModel,ReproductorMusicaTagEditables.Mvvm.ViewModel  5      {Bclr-namespace:ReproductorMusicaTagEditables.Controls.AgregarALista4ReproductorMusicaTagEditables.Controls.AgregarALista  5
      E    ?ReproductorMusicaTagEditables.Mvvm.View.Pages.TodasLasCanciones   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      WtuplaEclr-namespace:ReproductorMusicaTagEditables.Controls.InfoCancionTabla     5      P	viewModel:clr-namespace:ReproductorMusicaTagEditables.Mvvm.ViewModel     5      j fMahApps.Metro.IconPacks.FontAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a8fa-http://metro.mahapps.com/winfx/xaml/iconpacks   5      T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f6mah,http://metro.mahapps.com/winfx/xaml/controls  5	      YagregarCancionesBclr-namespace:ReproductorMusicaTagEditables.Controls.AgregarALista  5
        N� Title$  TodasLasCanciones��5       � 	Resources 5       �� Source�� 5   
   $4 ./Mvvm/View/Pages/Theme/generalesPageTheme.xaml?�6   %     � DataContext 5      E   ?ReproductorMusicaTagEditables.Mvvm.ViewModel.PrincipalViewModel  5   
   -   5        panelPrincipal��5   '   .��5      �  � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��55 �6   �� 5      $��* �6   .+�5   
   � $��0��6   $��Center=�6    � ColumnDefinitions 5      �� 5       �� 5!      $	��650 �6#   .+�5$      ��    tituloPrincipalPaginas#��[  6   ��5%      ��  �� Path$ Irg.TitutloVentana��� 5'      $��1��6   $��Right=�5(      $��Center=�5)       �� Orientation$ 
Horizontal=�5*      .+�5,      )  #MahApps.Metro.Controls.ProgressRing  $��0 0 10 0q�5-      
���  ��   IsActive 5/      �� *Irg.Preloader+�� 51        btnEliminarHistorial#��[ 6   $��0 0 10 0q�52      	 � ToolTip$	 Seleccionar directorio��54      ��53      �� *CargarMusicaCommand+{�55      �� *Habilitados+.��56      �� $ 
Horizontal=�6!   .+�57      1  +MahApps.Metro.IconPacks.PackIconFontAwesome    iconEliminarHistorial#��[ 58      
   Kind$
 FolderOpenSolid=�59      
���  ��5:      5<      5=      �� 5>      #��[ 6   $+	 %Agregar canciones a las ya existentes��5?      $��0 0 10 0q�5@      ��5A      �� *AgregarCommand+{�5B      �� *Habilitados+.��5C      �� $ 
Horizontal=�6!   .+�5D        #��[ 61   $
 	PlusSolid=�5E   !   
�������5F   !   5G      5H      �� 5I      -   5        #��[ 5I      $��0 0 10 0q�5J      $#	 Respaldar los datos guardados��5L      {�5M      �� *Habilitados+.��5N      �� $ 
Horizontal=�6!   .+�5O        #��[ 5P   !   $
 SaveRegular=�5Q   !   
�������5R   !   5T      5U      �� 5V      -   5        #��[ 5V      $��0 0 10 0q�5W      $'	 !Recuperar información respaldada��5Y      {�5Z      �� *Habilitados+.��5[      �� $ 
Horizontal=�6!   .+�5\        #��[ 5]   !   $
 DownloadSolid=�5^   !   
�������5_   !   5a      5b      �� 5c      -   5        #��[ 5c      $	 Editar tags��5d      $��0 0 10 0q�5e      {�5g      �� *Habilitados+.��5h      �� $ 
Horizontal=�6!   .+�5i        #��[ 61   $
 TagSolid=�5j   1   
�������5k   1   5l      5m      5n      5p      � 5r   
   $��1��6   $
��0 10q�6    5s      �� 5t      $	��600 �6#   �� 5u      .+�5x      �� $ 
Horizontal=�6   .+�5y      �� $��Todas las Canciones��5z      $��Center=�5{      
�������$��22(�5}      �� 5~      $��Center=�5�      ���#ccc$��12(�5�      $��0 4 0 0 q�5�      ��5      �� *CantidadCanciones+5�      �� 5�      -   5        #��[ 5�      $	 Últimos escuchados.��5�      $��15 0 0 0q�67   y�5�      �� *HayHistorial+.��5�      �� $ 
Horizontal=�6!   .+�5�        #��[ 61   $
 HistorySolid=�6`   �� 5�        txtEliminacion#��[ 6$   $��Más Recientes��6L   $��5 0 0 0q�6a   5�      5�      �� 5�      -   5        #��[ 5�      $	 Listas de regalo.��5�      $��15 0 0 0q�65   y�5�      �� *RegalosVisibilidad+.��5�      �� $ 
Horizontal=�6!   .+�5�        #��[ 61   $
 	GiftSolid=�6`   
���  ��6q   5�      5�      5�      O   IReproductorMusicaTagEditables.Controls.AgregarALista.AgregarAListaControl  5�      -   5          Name$ agregarControl��5�   5   O   IReproductorMusicaTagEditables.Controls.AgregarALista.AgregarAListaControl   AgregarClick$! agregarControl_AgregarClick��5�   5      DesmarcarClick$# agregarControl_DesmarcarClick��5�   5   $��Right=�5�   5   $��1��5�   5   5�   5   5�      �� 5�   
   $��2��6   $
��3500��6   
���   � J� Opacity$ 0Q�6>   $��-1300 0 0 0 q�5�      y�5�      �� *CapaProtectora+5�      �� 5�   
   -   5         ��Name$ txtSinCanciones��5�      $��No hay canciones cargadas��5�      ���#ccc$��2��5�      $��22(�5�      $��Center=�5�      $��Center=�5�      y�5�      �� *Irg.IsMensajeVisible+�� 5�   
   -	   5         ��Name$ scrollCanciones��5�      $��2��5�      $
��Auto=�5�      y�5�      �� *Irg.IslistadoVisible+.��5�      �� -
   5         ��Name$ itemList��5�      ��5�      �� *
Irg.Partes+��5�      �� 5�      .R�5�      �� 5�      ��5�      �� 5�      .R�5�      N   HReproductorMusicaTagEditables.Controls.InfoCancionTabla.InfoCancionTabla  N   HReproductorMusicaTagEditables.Controls.InfoCancionTabla.InfoCancionTabla   	PlayClick InfoCancionTabla_PlayClick5�   1      ArtistaClick! InfoCancionTabla_ArtistaClick5�   1      
AlbumClick InfoCancionTabla_AlbumClick5�   1      
MouseLeave InfoCancionTabla_MouseLeave5�   1      
Habilitado .     Comando 5�   1   ��  �� ElementName$ panelPrincipal��$ PlayCommand�   ParametroComando 5�   1   �� *.+   
NumeroInfo 5�   1   �� *Numero+   
TituloInfo 5�   1   �� *Titulo+   ArtistaInfo 5�   1   �� *	Artista+   	AlbumInfo 5�   1   �� *Album+   
GeneroInfo 5�   1   �� *Genero+   AnoInfo 5�   1   �� *FechaLanzamiento+    DuracionInfo  5�   1   �� *
Duracion+!   
ColorTexto! 5�   1   �� *EstadoColor+"   HabilitadoCarga" 5�   1   �� $ panelPrincipal��$ Habilitados�5�      5�      5�      5�      5�      5�      