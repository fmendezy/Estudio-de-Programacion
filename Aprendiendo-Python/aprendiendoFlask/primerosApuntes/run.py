from flask import Flask, render_template, request
app = Flask(__name__)

@app.route('/')
def inicio():
    num1 = 30
    num2 = 50
    resultado = num1+num2
    nombreDev = "Francisco"
    return render_template("index.html",res=resultado,nomDev=nombreDev)

@app.route('/contacto',methods=['GET','POST'])
def contacto():
    if request.method == 'POST':
        varNum1 = int(request.form['num1'])
        varNum2 = int(request.form['num2'])
        resultadoCalculo = varNum1+varNum2
        return render_template("contacto.html",variable=resultadoCalculo)
    return render_template("contacto.html")

if __name__ == '__main__':
        app.run()