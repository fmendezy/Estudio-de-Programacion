from flask import Flask, session
app = Flask(__name__)
# Clave secreta
app.config['SECRET_KEY'] = '*Ek%vBPuP$a4Ww'

@app.route('/')
def index():
    session['username'] = 'bsimpson'
    return 'Datos de sesión establecidos.'

@app.route('/perfil')
def perfil():
    if 'username' in session:
        username = session['username']
        return f'¡Bienvenido, {username}!'
    else:
        return f'No se encontraron datos de sesión.'

@app.route('/logout')
def logout():
    session.pop('username', None)
    return 'Sesion cerrada. Datos eliminados.'

if __name__ == '__main__':
    app.run()
