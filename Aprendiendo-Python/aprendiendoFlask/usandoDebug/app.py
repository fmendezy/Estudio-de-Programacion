from flask import Flask
app = Flask(__name__)
# Activa el modo de depuración
app.debug = True
@app.route('/')
def index():
    # Generamos un error intencional
    resultado = 1 / 0
    return '¡Hola, mundo!'

if __name__ == '__main__':
    app.run()
