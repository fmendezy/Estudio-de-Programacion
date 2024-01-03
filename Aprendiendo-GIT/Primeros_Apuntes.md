# Comandos Básicos de uso de Git

Los siguientes **comandos**, permiten al estudiante comprender y utilizar de forma rápida la terminal de Git.

Es importante contar con nociones básicas del uso de terminales de comandos en sistemas operativos, podría recomendarte este buen curso de *Platzi* el cual me ayudo para esta finalidad, además del curso de Git en la misma plataforma:

*Quisiera aclarar que, los comandos de uso a continuación fueron aprendidos principalmente gracias a las mentorías de **DonEgidi** quien me está enseñando programación y a utilizar estas herramientas para el trabajo a diario, dado que no tengo como compartir las clases, es que recomiendo las de Platzi.*

> [Curso de Terminal y Línea de Comandos - Platzi](https://platzi.com/cursos/terminal/)
> [Curso de Git y Github [Empieza Gratis] - Platzi](https://platzi.com/cursos/git-github/)


## Subiendo cambios en git
Cuando ya tengas tu código listo para subir a un repositorio git el cual ya está configurado, será momento de subir los cambios, para esto usaremos los siguientes comandos.

    git status
Este comando nos mostrará todos los archivos que fueron modificados o eliminados de nuestro repositorio **local**, con ello podremos verificar que no hayamos editado un archivo distinto por error o que simplemente lo que subiremos sean los archivos correctos.

Una vez estamos seguros, usando una **analogía** de una empresa de paquetería *"prepararemos el paquete"* a enviar con el comando

    git add .
Este comando con el punto al final significa que **todos** los archivos se agregaran al *"paquete a subir"*, si deseas subir un archivo en particular, puedes reemplazar el punto por el *nombre del archivo* o su *ruta con el nombre*

    git add -A
Agregar todos los cambios al área de preparación. Para agregar todos los cambios, incluyendo archivos eliminados, movidos y modificados, al área de preparación (ideal cuando tienes muchas marcas rojas y *"git add ."* no te permite 'limpiar' esos archivos que quieres sincronizar entre tu directorio y el repositorio en github.

Ahora escribiremos en la *"etiqueta del paquete"*, para ello escribiremos el **commit**

    git commit -m "El comentario va acá"

 Con podremos y podrán saber en términos generales que fue lo que se hizo, en este punto es importante poder ser claro con lo que se está subiendo, para que tú ***"yo del futuro"*** o quienes trabajen contigo, sepan como encontrar código del pasado para poder entenderlo.
 
Ahora que tenemos nuestro paquete listo, debemos enviarlo (subirlo a github o el servidor donde este alojado.

    git push
Con esto se subirán los cambios al servidor.

## Otros comandos necesarios
Si trabajas con otras personas (cómo sucederá en la gran mayoría de los casos) otros harán sus propias modificaciones y por consecuente, **sus propios commits**.

Entonces será necesario actualizar nuestro repositorio local para recibir los últimos cambios que tiene el repositorio externo o el que está en el servidor, vamos, lo que se ve en github.com

    git pull
Nos permitirá actualizar nuestro repositorio con todo el codigo nuevo agregado.

    git fetch
Nos permitirá actualizar todo el código pero también los cambios en las estructuras del repositorio, este comando lo estoy recién interiorizando, así que actualizaré más sobre él a medida que valla aprendiendo más.


## Explorando los registros de commits
Cuando trabajes con commits, tendrás curiosidad o necesidad de conocer que otros commits realizaron otros desarrolladores, para ellos tendrás 2 formas de ver el registro completo de un repositorio.

    git log
Nos permitirá ver los commits de otros desarrolladores **con detalles**, como fecha, autor, correo, etc

    git log --oneline
Nos permitirá ver de forma resumida todos los commits de otros desarrolladores, pero se mostrará ***línea por línea***, es decir que **1 commit solo ocupará el espacio de una línea**, con esto se puede explorar más rápido cuando existen decenas, cientos o miles de commits en un proyecto.

## Trabajando con ramas
En construcción
