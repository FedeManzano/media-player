   M S B A M L   `   `   `  ���� !  ReproductorMusicaTagEditablesS    MReproductorMusicaTagEditables.Controls.InfoAlbumPagina.InfoAlbumPaginaControl   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     j fMahApps.Metro.IconPacks.FontAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a8fa-http://metro.mahapps.com/winfx/xaml/iconpacks   -     >�Name$  	infoAlbum�� � 	Resources  �� Source�� $9 3/Controls/InfoAlbumPagina/InfoAlbumPaginaTheme.xaml?�%    .����    bordePrincipal#��[  ._��  � ColumnDefinitions �� $	��190 ��� .+���   bordeImagen#��[ ����  �� ElementName$ 	infoAlbum�� �� Path$ ImagenAlbum��� $��1��$��10 0 0 0q�.+���   nombreArtista#��[ ���� $ 	infoAlbum��$ NombreAlbum���  �� Orientation$ 
Horizontal=�$
��0 10q�.+��� $��Artista��  txtDatos#��[ �� $��·��#��[ $
��10 0q��� -     
btnArtista#��[ ���� $ 	infoAlbum��$ NombreArtista��� $ 
Horizontal=�$
��0 10q�.+��� #��[ ���� $ 	infoAlbum��$ CantidadCanciones��� $��·��#��[ $
��10 0q��� 
�������#��[ ���� $ 	infoAlbum��$ Horas��� $ 
Horizontal=�$
��0 10q�.+���   
btnPlayAll#��[  � ToolTip$/ )Reproducir todas las canciones del álbum������ $ 	infoAlbum��$ ReproducirCommand����� $ 	infoAlbum��$ ReproducirParamCommand�.���� $ 
Horizontal=�.+�1  +MahApps.Metro.IconPacks.PackIconFontAwesome     Kind$ PlayCircleRegular=�$��0 0 10 0q��� $��Reproducir Todo���� -   #��[ 
�������$��10 0 0 0q�$< 6Agregar canciones del artista a lista de reproducción��.���� $ 
Horizontal=�.+�  $ 	PlusSolid=�$��0 0 10 0q��� $��Agregar���� -   #��[ 
�������$��10 0 0 0q�$* $Modificar la metadata de los tracks.��.���� $ 
Horizontal=�.+�  $ TagSolid=�$��0 0 10 0q��� $��	Modificar��