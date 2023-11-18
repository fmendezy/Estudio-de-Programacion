from flask import Flask, request, jsonify, render_template

app = Flask(__name__)

@app.route('/')
def index():
    return 'Ejemplo manejo de Listas'

# 1°er Ruta que recibe un array como parametro en la URL
# Se puede probar en la url: http://127.0.0.1:5000/array/5,4,3
@app.route('/array/<int_list>')
def process_Array(int_list):
    return f'Array recibido: {int_list}', 200

# 2°da Ruta que recibe un array como datos de un formulario POST
# Se puede probar en http://127.0.0.1:5000/submit
@app.route('/submit', methods=['GET', 'POST'])
def submit_array():
    if request.method == 'POST':
        array_data = request.form.get('array').split(',')# Separamos los datos recibidos con comas
        return f'Array recibido: {array_data}', 200
    else:# Aqui se hace uso de GET tras ingresar a la URL /submit y se rendedira el html
        return render_template('form.html')

# 3°ra Ruta que envia un array como respuesta JSON
@app.route('/get_array', methods=['GET'])
def get_array():
    example_array = [1, 2, 3, 4, 5]
    return jsonify(array=example_array)

if __name__ == '__main__':
    app.run()
