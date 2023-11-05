# Acceso via SSH (Más fácil) - Ubuntu 23.10
Con la finalidad de que nuestro terminal no nos solicite la contraseña de Github cada vez que deseamos subir un commit, así ganar más tiempo, quisiera compartir esta guía para generar una clave SSH que conectará nuestra cuenta de Github con nuestro sistema.

Es importante señalar que esta guía esta pensada para SO Linux, especificamente la distribución Ubuntu 23.10

## 0.- Tener configurado tu nombre y correo en el sistema
Para comenzar, si no lo tienes ya realizado debes tener tu correo y nombre registrado en git de su sistema operativo, hacerlo es muy facil, utiliza **uno por uno** los siguientes comandos para registrarlo.

	git config --global user.email "tu-correo@ejemplo.com"
 	git config --global user.name "Tu Nombre"
    
Con esto aparecerá tu información en los commit como autor de los mismos.

## 1.- Generar un par de claves SSH en tu sistema Linux:

Abre una terminal en tu sistema Linux y ejecuta el siguiente comando para generar un par de claves SSH (pública y privada):

	ssh-keygen -t ed25519 -C "tu-correo@ejemplo.com"

Asegúrate de reemplazar "**tu-correo@ejemplo.com**" con la dirección de correo electrónico asociada a tu cuenta de GitHub. Puedes utilizar otras opciones de algoritmos, como RSA, en lugar de **ed25519** si lo prefieres.

Este comando generará un par de claves SSH en el directorio **~/.ssh**, por defecto.

En la terminal verás algo como esto:

	The key fingerprint is
	SHA256:C9zqjhHJ1MJ/yACfCiJgaPBKwZF8Iu8mVxpZYCcv97w tu-correo@ejemplo.com
	The key's randomart image is:
	+--[ED25519 256]--+
	|B+B..            |
	|=O.O.o           |
	|*o=oX .          |
	|+o+*.X o         |
	|...++ O S        |
	|. =  . = .       |
	| +  . E .        |
	|     +           |
	|    ..o          |
	+----[SHA256]-----+

Esta es la llave SSH que se genero para ti, si no entiendes que lo que vez, no te preocupes, sigue avanzando.

## 2.- Agrega la clave SSH a tu agente SSH:
Debes agregar la clave privada a tu agente SSH para que se utilice al autenticarte con GitHub. Ejecuta el siguiente comando:

	eval "$(ssh-agent -s)"
	ssh-add ~/.ssh/id_ed25519

Asegúrate de que **~/.ssh/id_ed25519** sea la ubicación de tu clave privada si has utilizado una ubicación diferente.

## 3.- Copia la clave pública al portapapeles:
Utiliza el siguiente comando para copiar la clave pública al portapapeles:

	cat ~/.ssh/id_ed25519.pub | xclip -sel clip
Si no tienes xclip instalado, puedes usar cat para mostrar la clave en la terminal y copiarla manualmente.

**Para instalar xclip en ubuntu:**

	sudo apt install xclip
Una vez instalado, repites el paso anterior y ya la tendrás copiada en el portapapeles.

## 4.- Agrega la clave pública a tu cuenta de GitHub:
Ve a la página de configuración de claves SSH en tu cuenta de GitHub:

- Inicia sesión en GitHub.
- Haz clic en tu avatar en la esquina superior derecha y selecciona "Settings" (Configuración).
- En el menú de la izquierda, selecciona "SSH and GPG keys."
- Luego, haz clic en "New SSH key" (Nueva clave SSH), dale un nombre descriptivo y pega la clave pública que copiaste en el paso anterior. **Guarda la clave.**

## 5.- Confirma que la configuración funciona:
Para confirmar que la configuración funciona, puedes ejecutar:

	ssh -T git@github.com

Esto te debe mostrar un mensaje que confirma que has sido autenticado con éxito.

A partir de este punto, tu sistema debería estar configurado para utilizar la autenticación mediante SSH con GitHub, y no deberías ser solicitado para ingresar una contraseña cada vez que interactúes con tu repositorio en GitHub.

# ¿Al hacer push te sigue pidiendo contraseña?
Esto ocurre por que muchas veces descargamos los repositorios en nuestro PC mediante HTTPS **en lugar de SSH** *(donde tenemos nuestro pc registrado en github segun los pasos anteriores)*, entonces debemos asegurarnos que estemos usando el protocolo SSH, aqui te muestro como dejarlo perfecto.

## 1.- Verifica la URL remota actual:
	git remote -v
Esto te mostrará la URL de tu repositorio. Debería verse algo como:

	origin  https://github.com/tu_usuario/tu_repositorio.git (fetch)
	origin  https://github.com/tu_usuario/tu_repositorio.git (push)

## 2.- Cambia la URL remota para usar SSH en lugar de HTTPS:
	git remote set-url origin git@github.com:tu_usuario/tu_repositorio.git
Asegúrate de reemplazar tu_usuario y tu_repositorio con tu nombre de usuario y el nombre de tu repositorio en GitHub.

## 3.- Verifica la URL remota nuevamente para asegurarte de que se haya actualizado a SSH:
	git remote -v
Deberías ver algo como:

	origin  git@github.com:tu_usuario/tu_repositorio.git (fetch)
	origin  git@github.com:tu_usuario/tu_repositorio.git (push)

Ahora, cuando ejecutes git push, debería utilizar **automaticamente** la autenticación SSH en lugar de la autenticación HTTPS, y no te solicitará un nombre de usuario ni una contraseña. Asegúrate de que tu clave SSH esté configurada y funcionando correctamente en tu sistema como te explique en pasos anteriores.
