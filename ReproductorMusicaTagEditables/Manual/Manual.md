# :books: Manual Media Player 

![License](https://img.shields.io/badge/LICENSE-%20MIT-green)
![Versión](https://img.shields.io/badge/VERSIÓN-%203.0.0-purple)

## :link: Indice de contenidos

* :earth_americas: [Descargar](#descargar-reproductor)
* :dvd: [Instalar reproductor](#instalación)
* :medal_military: [Presentación de la aplicación](#presentación)
* :open_file_folder: [Seleccionar Directorio](#seleccionar)
* :heavy_plus_sign: [Añadir canciones](#añadir-canciones)
* :floppy_disk: [Respaldo de estado](#respaldo-de-estado)
	* :open_file_folder: [Contenido de respaldo](#contenido-de-respaldo)
* :arrow_down: [Recuperar Respaldo](#recuperar-respaldo)	
* :label: [Editar metadata](#editar-de-metadata)
	* :open_file_folder: [Cargar Directorio](#cargar-directorio-a-editar)
	* :pencil2: [Editar información mínima](#editar-información-mínima)
	* :pencil2: [Edición completa](#edición-completa)
	* :pencil2: [Edición por álbum](#edición-por-álbum)
	* :pencil2: [Edición de números](#edición-de-números)
* :musical_note:[Pista de audio](#pista-de-audio)	
* :memo:[Listas de reproducción](#listas-de-reproducción)
	* :heavy_plus_sign:[Crear lista](#crear-listas-de-reproducción)
	* :heavy_plus_sign:[Listas de reproducción](#agregar-una-canción)
	* :musical_note:[Agregar una canción](#agregar-una-canción)


### Descargar Reproductor

Para descargar el reproductor lo podemos hacer desde los siguientes enlaces:

Dependiendo la arquitectura de su sistema operativo deberán seleccionar una de estas dos opciones: 

:arrow_down: [Descarga Instalador v3.0.0 32 Bits](https://mega.nz/file/5RVzlZAJ#qXCj2Hqt6S9h7CTT59D8jn7qh_5LQHuOnYSAWH-o9qk)

:arrow_down: [Descarga Instalador v3.0.0 64 Bits](https://mega.nz/file/VNtSCDyT#dzuM746-4SdvtUAdA7fB8EgpPOfyGMF4NOCqefASkTA)


El resultado de la descarga nos va a dejar un archivo llamado `MediaPlayer.zip`.

### Instalación 

Lo primero es descomprimir el archivo `MediaPlayer.zip` recién descargado.
Dentro de la carpeta extraída nos aparecerá la siguiente estructura de archivos:

```txt
MediaPlayer
	| Application Files
		| Todos los archivos de la aplicación
    | ReproductorMusicaTagEditables.application
	| setup.exe       
```
Ejecutamos el archivo :dvd:`setup.exe` y aceptamos en el asistente de instalación.

![Asistente](https://github.com/FedeManzano/media-player/blob/master/ReproductorMusicaTagEditables/Manual/Imagenes/asistente.png)

Luego, desde el menú de busqueda del sistema operativo, buscamos el :musical_note: `ReproductorMusicaTagEditables.exe`.  

![Ejecutar App](https://github.com/FedeManzano/media-player/blob/master/ReproductorMusicaTagEditables/Manual/Imagenes/ejecutar.png?raw=true)

### Presentación

El esquema básico de los controles puede verse en la siguiente imágen:

![Esquema](https://github.com/FedeManzano/media-player/blob/master/ReproductorMusicaTagEditables/Manual/Imagenes/presentacion1.png?raw=true)

### Seleccionar

Cuando iniciamos por primera vez el reproductor, el mismo, se encuentra vacío. Para cargar los archivos de audio lo hacemos desde el menú secundario de la página principal.


![Seleccionar](https://github.com/FedeManzano/media-player/blob/master/ReproductorMusicaTagEditables/Manual/Imagenes/seleccionar.png?raw=true)

En el momento de seleccionar un directorio todos los archivos de audio que posean un formato aceptado por el reproductor se van a cargar en el repositorio de canciones de la aplicación.

> Cuando se utiliza el botón :open_file_folder: se sobreescriben todas las canciones del reproductor. Esto quiere decir que si se utiliza esta función y el reproductor ya tenía información previamente cargada, la misma se reemplazará por la nueva información (No permite añadir nuevas canciones).

### Añadir canciones

Para añadir canciones sin sobrescribir las ya existentes hay que utilizar el botón :heavy_plus_sign: Agregar. De esta manera se puede incrementar el número de canciones enlazadas en el reproductor sin perder las ya existentes.

> Si con esta función volvemos a cargar un directorio precargado, los enlaces internos del reproductor por cada canción repetida se duplicará.
Si esto sucede podemos solucionar el problema desde el botón :open_file_folder: visto anteriormente.

### Respaldo de estado

Para almacenar la información de estado del reproductor se utiliza el botón :floppy_disk: del menú secundario de la página principal.

Cuando se realiza el respaldo se pedirá al usuario que elija un directorio de salida para crear el archivo `.zip` con el siguiente formato.

```txt
Respaldo-[dd-MM-yyyy]-[Hash del archivo].zip     
```

El formato contiene la fecha de creación del reapaldo y su código hash que no permite modificaciones. En el caso que el archivo creado sea modificado de alguna manera, el mismo no va a poder recuperarse y la información se habrá perdido.

#### Contenido de respaldo

* :open_file_folder: Historial
	* :page_facing_up: HistorialAlbumes.json
	* :page_facing_up: HistorialListas.json
* :open_file_folder: Listas
	* :open_file_folder: Regalos
	* :page_facing_up: FAVORITOS.json
	* :page_facing_up: ... Resto de las listas

> Lo que se respalda es la información del reproductor no los archivos de audio.

### Recuperar respaldo

Desde el botón :arrow_down: del menú secundario de la página principal se puede recuperar el respaldo.

> Todas las canciones e información cargada después del respaldo se perderá cuando recuperemos el respaldo.

Una vez cargado de respaldo hay que reiniciar el reproductor para ver los cambios generados por la información. 

### Editar de metadata

Para poder filtrar las canciones agregadas al reproductor por Álbumes, Artistas, Géneros, guardar el historial y crear listas de reproducción personalizadas es necesario que la información de los metadatos de los archivos de audio exista. Esto se puede realizar a través del botón :label: del menú secundario de la página principal.

![Editor](https://github.com/FedeManzano/media-player/blob/master/ReproductorMusicaTagEditables/Manual/Imagenes/editor.png?raw=true)

#### Cargar directorio a editar

Desde el botón `Seleccionar` seleccionamos el directorio con los archivos de audio que queremos editar. Si el mismo contiene varios subdirectorios estos también serán cargados.

> Recomendación: Cargar canciones pertenecientes a un Álbum especifico para que sea más facil editar los campos de los archivos.

#### Editar información mínima

La información mínima que es necesaria para poder buscar y filtrar la información musical son los campos `Álbum` y `Artista`.

Completando estos dos campos el reproductor va a poder dar acceso rápido a las canciones y generar el historial de reproducción. También a partir de esto podemos crear listas de reproducción con las canciones que se seleccionen por el usuario.

El procedimiento para realizar esto es marcar todas las caciones desde el botón `Marcar Todas` en la parte superior.

![Edición mínima](https://github.com/FedeManzano/media-player/blob/master/ReproductorMusicaTagEditables/Manual/Imagenes/edicionMinima.png?raw=true)

Con esto editamos los campos mínimos y suficientes. El resultado queda de la siguiente manera.

![Edición mínima](https://github.com/FedeManzano/media-player/blob/master/ReproductorMusicaTagEditables/Manual/Imagenes/resultadoEdicion.png?raw=true)

#### Edición completa

Para editar toda la información simplemente hay que llenar los demás campos.

![Edición completa](https://github.com/FedeManzano/media-player/blob/master/ReproductorMusicaTagEditables/Manual/Imagenes/edicionCompleta.png?raw=true)

#### Edición por álbum

Podemos editar la información de los metadatos de los archivos de audio a través de la página del álbum. Si previamente estos archivos estaban asignados a un álbum especifico, entonces se puden editar estos datos desde la página del álbum.

![Edición álbum](https://github.com/FedeManzano/media-player/blob/master/ReproductorMusicaTagEditables/Manual/Imagenes/edicionAlbum.png?raw=true)

Estos son tracks a medio editar, y para completar este proceso hay que presionar el botón `Modificar`. 
Se abrirá el editor de tags con las canciones del álbum cargadas.

![Edición álbum](https://github.com/FedeManzano/media-player/blob/master/ReproductorMusicaTagEditables/Manual/Imagenes/edicionAlbumTags.png?raw=true)

Después de darle al botón editar el resultado es el siguiente:

![Edición álbum](https://github.com/FedeManzano/media-player/blob/master/ReproductorMusicaTagEditables/Manual/Imagenes/paginaEditada.png?raw=true)

#### Edición de números

La edición de los números de tracks permite ordenar las canciones de forma creciente según este valor, si el mismo está disponible.
Para hacerlo de forma automática seleccionamos todas las canciones en el editor de tags y luego le damos a el botón números. Esto va a enumerar de forma creciente los tracks.

### Pista de audio

La vista de la pista de audio contiene los controles para reproducir el track, ir a la página del álbum al cual pertenece, ir al la página del artista y la información del género y el año de lanzamiento del álbum.

![Pista de audio](https://github.com/FedeManzano/media-player/blob/master/ReproductorMusicaTagEditables/Manual/Imagenes/pista.png?raw=true)

> Cuando presionamos el botón :arrow_forward: de la pista no sólo reproduce el track, también carga el listado de canciones al cual pertenece. Por ejemplo: 
Desde la página principal carga el listado de todas las canciones que tiene a disposición el reproductor. Si hacemos lo mismo desde la página de un álbum, carga el listado de canciones del álbum. Esto implica que cuando el usuario cambia de canción se van a reproducir las del listado cargado, sin importar en la página en la que se encuentre el usuario.

### Listas de reproducción

Se pueden crear listas de reproducción personalizadas junto con las páginas para visualizar estas listas.
Las canciones puden agregarse de a una o en conjunto dependiendo las necesidades del usuario.

#### Crear listas de reproducción

Desde el menú principal de la aplicación, en el apartado `+ Mis Listas` presionar el botón `+ Crear` en la parte superior derecha de la vista.

![Pista de audio](https://github.com/FedeManzano/media-player/blob/master/ReproductorMusicaTagEditables/Manual/Imagenes/crearLista.png?raw=true)

Una vez creada la lista aparecera con el siguiente avatar indicando que de momento la lista está vacía.

![Pista de audio](https://github.com/FedeManzano/media-player/blob/master/ReproductorMusicaTagEditables/Manual/Imagenes/avatarLista.png?raw=true)

> Una vez creada la lista, el usuario ya puede agregar canciones a la misma.

#### Agregar una canción


