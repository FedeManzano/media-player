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
	* :heavy_plus_sign:[Agregar una cancion](#agregar-una-canción)
	* :heavy_plus_sign:[Agregar varias canciones](#agregar-varias-canciones)
	* :heavy_plus_sign:[Agregar un álbum](#agregar-un-álbum)
	* :heavy_minus_sign:[Eliminar de la lista](#eliminar-lista-de-reproducción)
	* :heavy_minus_sign:[Eliminar una canción](#eliminar-canción-de-una-lista)
* :earth_americas: [Descargar de Youtube](#descargar-de-youtube)
	* :arrow_down: [Muestra de descargas](#muestra-de-descarga-de-tres-canciones)
	* :arrow_down: [Acceder a las canciones](#accesos-a-los-traks-descargados)
* :clock330: [Historial](#historial)	
* :thumbsup: [Favoritos](#favoritos)
* :gift: [Regalos](#regalos)
* :arrow_forward: [Reproducción](#reproducción)
	* :frowning_person: [Reproducir canciones de un artista](#reproducir-canciones-de-un-artista)
	* :dvd: [Reproducir álbum](#reproducir-álbum)
	* :twisted_rightwards_arrows: [Reproducción random](#reproducción-random)
	* :bookmark_tabs: [Persistencia](#persistencia)

### Descargar Reproductor

Para descargar el reproductor lo podemos hacer desde los siguientes enlaces:

Dependiendo la arquitectura de su sistema operativo deberán seleccionar una de estas dos opciones: 

:arrow_down: [Descarga Instalador v3.0.0 32 Bits](https://mega.nz/file/UUtEyKyA#JU3B77Yjk1r9EjLBaT9htchKpgYewk8kVMtzsCvdwXg)

:arrow_down: [Descarga Instalador v3.0.0 64 Bits](https://mega.nz/file/IRMwBJzB#NdRlIjXmTbzb9FQhL26mkpfumHftY51v9Q57bL5eDv4)


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

![Creación de lista](https://github.com/FedeManzano/media-player/blob/master/ReproductorMusicaTagEditables/Manual/Imagenes/crearLista.png?raw=true)

Una vez creada la lista aparecera con el siguiente avatar indicando que de momento la lista está vacía.

![Lista vacía](https://github.com/FedeManzano/media-player/blob/master/ReproductorMusicaTagEditables/Manual/Imagenes/avatarLista.png?raw=true)

> Una vez creada la lista, el usuario ya puede agregar canciones a la misma.

#### Agregar una canción

En la vista de la pista con un clic derecho abrimos un menú contextual, en él seleccionar la opción agregar a lista. esto abrirá una nueva ventana en la cual se enlistan todas las listas que haya creado el usuario.

![Pista de audio](https://github.com/FedeManzano/media-player/blob/master/ReproductorMusicaTagEditables/Manual/Imagenes/agregarCancion.png?raw=true)


#### Agregar varias canciones

Para agregar varias canciones a la lista que el usuario quiera hay que marcar varias canciones del listado. Esto hará que aparezcan dos botones que permitirán `Desmarcar Todas` y `Agregar`.
Cuando el usuario presiona el botón aceptar se abrirá la ventana vista anteriormente con todas las canciones a agregar cargadas.

![Pista de audio](https://github.com/FedeManzano/media-player/blob/master/ReproductorMusicaTagEditables/Manual/Imagenes/agregarVarias.png?raw=true)

> Esto mismo podemos hacerlo desde la página de los álbumes agregando las canciones que el usuario seleccione del álbum.

#### Agregar un álbum

Para agregar todo un álbum, el usuario puede hacerlo desde la página del álbum con el botón agregar en la parte superior de la página o haciendo clic derecho sobre el avatar del álbum desde la opción `Albumes` del menú principal.

![Agregar álbum](https://github.com/FedeManzano/media-player/blob/master/ReproductorMusicaTagEditables/Manual/Imagenes/paginaAlbumAgregar.png?raw=true)

La otra forma es del avatar del álbum que podemos encontrar en la página del artista o en la opción `Albumes` del menú principal.

![Agregar álbum](https://github.com/FedeManzano/media-player/blob/master/ReproductorMusicaTagEditables/Manual/Imagenes/artistaAgregarAlbum.png?raw=true)

![Agregar álbum](https://github.com/FedeManzano/media-player/blob/master/ReproductorMusicaTagEditables/Manual/Imagenes/agregarAlbumTodos.png?raw=true)

#### Eliminar lista de reproducción

Para eliminar la lista de reprodución entera simplemente hay que darle clic derecho al avatar de la lista en la opción `+ Mis Listas`.

![Eliminar lista](https://github.com/FedeManzano/media-player/blob/master/ReproductorMusicaTagEditables/Manual/Imagenes/eliminarLista.png?raw=true)

#### Eliminar canción de una lista

Desde la página de la lista, en la canción que el usuario quiera eliminar, dar clic derecho y seleccionalr eliminar de la lista.

![Eliminar canción](https://github.com/FedeManzano/media-player/blob/master/ReproductorMusicaTagEditables/Manual/Imagenes/eliminarCancion.png?raw=true)

### Descargar de Youtube

Desde la opción `Descargas` del menú principal accedemos a la sección descargas de la aplicación.

![Página de descargas](https://github.com/FedeManzano/media-player/blob/master/ReproductorMusicaTagEditables/Manual/Imagenes/descargas1.png?raw=true)

#### Muestra de descarga de tres canciones

Estado del reproductor mientras descarga tres canciones:


![Descargando](https://github.com/FedeManzano/media-player/blob/master/ReproductorMusicaTagEditables/Manual/Imagenes/descarga2.png?raw=true)

> Mientras está descargando, el reproductor desactiva los accesos a otras páginas y a los botones para evitar que se pierda la descarga en curso.

Una vez descargado el reproductor muestra lo siguiente:


![Fin de descarga](https://github.com/FedeManzano/media-player/blob/master/ReproductorMusicaTagEditables/Manual/Imagenes/descargas3.png?raw=true)

#### Accesos a los traks descargados

Desde los botones inferiores podemos **Editar**, **Mover** y/o **Eliminar** las canciones descargadas.

> Para poder acceder a las canciones descargadas hay que moverlas a un directorio del equipo de usuario. Lo recomendable es primero editarlas y luego moverlas para diferenciarlas por su metadata.

En secciones anteriores de esta documentación se muestra como editar las metadata de los archivos de audio. Una vez editados simplemente hay que moverlos a un directorio seleccionado por el usuario. A partir de esto, las canciones son agregadas automáticamente al listado ya existente de canciones y se puede tener acceso a ellas.

### Historial

En el historial de la plicación se conforman dos listados, el primero, contiene los últimos siete álbumes escuchados por el usuario, el segundo contiene las últimas siete listas de reprodución escuchadas. A partir de esto podemos acceder rápido a las canciones que el usuario escucha con mas frecuencia y permite automátizar el agregado de canciones a las listas de reproducción.

![Historial](https://github.com/FedeManzano/media-player/blob/master/ReproductorMusicaTagEditables/Manual/Imagenes/historial1.png?raw=true)

Si el usuario hace clic en cualquier álbum o listas, el reproductor lo enviará a la página asociada.

> Al historial podemos accedes desde la opción del menú principal o desde la página principal en el botón **más recientes**.

![Accesos](https://github.com/FedeManzano/media-player/blob/master/ReproductorMusicaTagEditables/Manual/Imagenes/historial2.png?raw=true)

### Favoritos

Listado generado automáticamente con el fin de mostrale al usuarios las canciones preferidas en orden decreciente en función a la cantidad de veces que las escucha.

![Accesos](https://github.com/FedeManzano/media-player/blob/master/ReproductorMusicaTagEditables/Manual/Imagenes/favoritos1.png?raw=true)

> Esta lista no puede eliminarse. Pero permite eliminar canciones como vimos en secciones anteriores a esta documentación.

### Regalos

Todos los meses el reproductor genera listas de reproducción automáticas, con las cincuenta canciones más escuchadas del mes anterior.
El acceso a estas listas, ordenadas por año y mes de creación lo hacemos desde la página principal.

![Regalos](https://github.com/FedeManzano/media-player/blob/master/ReproductorMusicaTagEditables/Manual/Imagenes/regalos1.png?raw=true)

Cuando ingresamos a este ícono nos enviará a la página de todos los regalos guardados.

![Regalos](https://github.com/FedeManzano/media-player/blob/master/ReproductorMusicaTagEditables/Manual/Imagenes/regalo2.png?raw=true)


Si ingresamos al regalo de la imágen anterior iremos a la página del mismo.

![Regalos](https://github.com/FedeManzano/media-player/blob/master/ReproductorMusicaTagEditables/Manual/Imagenes/regalo3.png?raw=true)


> De esta lista no podemos eliminar canciones. Pero podemos eliminar el regalo entero si lo deseamos, como se muestra en la siguiente imágen:

![Regalos](https://github.com/FedeManzano/media-player/blob/master/ReproductorMusicaTagEditables/Manual/Imagenes/regalo4.png?raw=true)

Haciendo clic derecho sobre el regalo y seleccionar la opción **Eliminar Regalo**.

### Reproducción

Siempre que reproduzcamos canciones individuales las mismas no se cargará n solas, sino que iran acompañadas del listado al cual pertenecen sin importar en la pagina que se encuentre el usuario.

**Por ejemplo: Si desde la página de un álbum le damos al botón play de un track pasaremos a escuchar ese específico track, pero con el se cargarán en la lista actual todas las canciones del álbum.**

> Si cambiamos de página y recorremos la aplición el listado no cambiará, por lo tanto, las canciones que se iran reproduciendo son las previamente seleccionadas.

Lo mismo que pasa con los álbumes pasa con los géneros, los artistas y listas de reproducción.

#### Reproducir canciones de un artista

Para reproducir las canciones de un artistas simplemente el usuario accede a la página del artista que le interesa y le da al botón **Reproducir Todas**.


![Reproducir](https://github.com/FedeManzano/media-player/blob/master/ReproductorMusicaTagEditables/Manual/Imagenes/rerpoducir1.png?raw=true)


#### Reproducir álbum

Lo mismo que en el caso de los artistas pero desde la página del álbum.

![Reproducir](https://github.com/FedeManzano/media-player/blob/master/ReproductorMusicaTagEditables/Manual/Imagenes/reproducir2.png?raw=true)

> Para las listas de reproducción y géneros musicales es exactamente el mismo proceso.

#### Reproducción random

Para alterar el orden de reproducción de la lista en curso, el usuario debe seleccionar el botón de rerpoducción aleatorea del control del track.

![Reproducir](https://github.com/FedeManzano/media-player/blob/master/ReproductorMusicaTagEditables/Manual/Imagenes/reproducir3.png?raw=true)

#### Persistencia

El reproductor almacena el listado de canciones actuales y la canción en curso para que cuando la aplicación se cierre estos datos no se pierdan. Cuando el usuario inicia nuevamente la aplicación se recura el listado y la canción en curso.

