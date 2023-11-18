from flask import Flask, request, render_template
app = Flask(__name__)

@app.route('/')
def index():
    return '<a href=/formulario> Ingresa al Formulario </a>'

@app.route('/formulario', methods=['GET', 'POST'])
def formulario():
    if request.method == 'POST':
        # Procesar los datos del formulario
        nombre = request.form['nombre']
        correo = request.form['correo']

        # Realizar acciones con los datos
        return f'¡Hola, {nombre}! Tu correo es {correo}.'
    return render_template('formulario.html')

if __name__ == '__main__':
    app.run()
