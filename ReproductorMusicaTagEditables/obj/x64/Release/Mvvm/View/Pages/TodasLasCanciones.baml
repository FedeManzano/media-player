   M S B A M L   `   `   `  ���� X  TReproductorMusicaTagEditables, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Eclr-namespace:ReproductorMusicaTagEditables.Controls.InfoCancionTabla7ReproductorMusicaTagEditables.Controls.InfoCancionTabla  k:clr-namespace:ReproductorMusicaTagEditables.Mvvm.ViewModel,ReproductorMusicaTagEditables.Mvvm.ViewModel  {Bclr-namespace:ReproductorMusicaTagEditables.Controls.AgregarALista4ReproductorMusicaTagEditables.Controls.AgregarALista  E    ?ReproductorMusicaTagEditables.Mvvm.View.Pages.TodasLasCanciones   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     WtuplaEclr-namespace:ReproductorMusicaTagEditables.Controls.InfoCancionTabla     P	viewModel:clr-namespace:ReproductorMusicaTagEditables.Mvvm.ViewModel     j fMahApps.Metro.IconPacks.FontAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a8fa-http://metro.mahapps.com/winfx/xaml/iconpacks   T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f6mah,http://metro.mahapps.com/winfx/xaml/controls  YagregarCancionesBclr-namespace:ReproductorMusicaTagEditables.Controls.AgregarALista    N� Title$  TodasLasCanciones�� � 	Resources  �� Source�� $4 ./Mvvm/View/Pages/Theme/generalesPageTheme.xaml?�%     � DataContext E   ?ReproductorMusicaTagEditables.Mvvm.ViewModel.PrincipalViewModel  -   panelPrincipal��.���  � RowDefinitions �� $	��100 ��� $��55 ��� $��* �.+�� $��0��$��Center=� � ColumnDefinitions �� �� $	��650 �.+���    tituloPrincipalPaginas#��[  ����  �� Path$ Irg.TitutloVentana��� $��1��$��Right=�$��Center=� �� Orientation$ 
Horizontal=�.+�)  #MahApps.Metro.Controls.ProgressRing  $��0 0 10 0q�
���  ��   IsActive �� *Irg.Preloader+��   btnEliminarHistorial#��[ $��0 0 10 0q�	 � ToolTip$	 Seleccionar directorio������ *CargarMusicaCommand+{��� *Habilitados+.���� $ 
Horizontal=�.+�1  +MahApps.Metro.IconPacks.PackIconFontAwesome    iconEliminarHistorial#��[ 
   Kind$
 FolderOpenSolid=�
���  ���� #��[ $+	 %Agregar canciones a las ya existentes��$��0 0 10 0q����� *AgregarCommand+{��� *Habilitados+.���� $ 
Horizontal=�.+�  #��[ $
 	PlusSolid=�
��������� -   #��[ $��0 0 10 0q�$#	 Respaldar los datos guardados��{��� *Habilitados+.���� $ 
Horizontal=�.+�  #��[ $
 SaveRegular=�
��������� -   #��[ $��0 0 10 0q�$'	 !Recuperar información respaldada��{��� *Habilitados+.���� $ 
Horizontal=�.+�  #��[ $
 DownloadSolid=�
��������� -   #��[ $	 Editar tags��$��0 0 10 0q�{��� *Habilitados+.���� $ 
Horizontal=�.+�  #��[ $
 TagSolid=�
�������� $��1��$
��0 10q� �� $	��600 ��� .+��� $ 
Horizontal=�.+��� $��Todas las Canciones��$��Center=�
�������$��22(��� $��Center=����#ccc$��12(�$��0 4 0 0 q����� *CantidadCanciones+�� -   #��[ $	 Últimos escuchados.��$��15 0 0 0q�y��� *HayHistorial+.���� $ 
Horizontal=�.+�  #��[ $
 HistorySolid=���   txtEliminacion#��[ $��Más Recientes��$��5 0 0 0q��� -   #��[ $	 Listas de regalo.��$��15 0 0 0q�y��� *RegalosVisibilidad+.���� $ 
Horizontal=�.+�  #��[ $
 	GiftSolid=�
���  ��O   IReproductorMusicaTagEditables.Controls.AgregarALista.AgregarAListaControl  -     Name$ agregarControl��O   IReproductorMusicaTagEditables.Controls.AgregarALista.AgregarAListaControl   AgregarClick$! agregarControl_AgregarClick��   DesmarcarClick$# agregarControl_DesmarcarClick��$��Right=�$��1���� $��2��$
��3500��
���   � J� Opacity$ 0Q�$��-1300 0 0 0 q�y��� *CapaProtectora+�� -    ��Name$ txtSinCanciones��$��No hay canciones cargadas�����#ccc$��2��$��22(�$��Center=�$��Center=�y��� *Irg.IsMensajeVisible+�� -	    ��Name$ scrollCanciones��$��2��$
��Auto=�y��� *Irg.IslistadoVisible+.���� -
    ��Name$ itemList������ *
Irg.Partes+���� .R��� ���� .R�N   HReproductorMusicaTagEditables.Controls.InfoCancionTabla.InfoCancionTabla  N   HReproductorMusicaTagEditables.Controls.InfoCancionTabla.InfoCancionTabla   	PlayClick InfoCancionTabla_PlayClick   ArtistaClick! InfoCancionTabla_ArtistaClick   
AlbumClick InfoCancionTabla_AlbumClick   
MouseLeave InfoCancionTabla_MouseLeave   
Habilitado .     Comando ��  �� ElementName$ panelPrincipal��$ PlayCommand�   ParametroComando �� *.+   
NumeroInfo �� *Numero+   
TituloInfo �� *Titulo+   ArtistaInfo �� *	Artista+   	AlbumInfo �� *Album+   
GeneroInfo �� *Genero+   AnoInfo �� *FechaLanzamiento+    DuracionInfo  �� *
Duracion+!   
ColorTexto! �� *EstadoColor+"   HabilitadoCarga" �� $ panelPrincipal��$ Habilitados�