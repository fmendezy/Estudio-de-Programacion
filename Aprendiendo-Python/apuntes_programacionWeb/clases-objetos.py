# Prueba 1
class Coche:
    def __init__(self, marca, modelo):
        self.marca = marca
        self.modelo = modelo

    def acelerar(self):
        print(f"El coche {self.marca} {self.modelo} está acelerando.")

autito1 = Coche("Chevrolet", "Spark LT 1.0")
print(f"El vehiculo es un {autito1.marca}, modelo: {autito1.modelo}")

# Prueba 2
class Persona:
    def __init__(self, nombre, edad):
        self.nombre = nombre
        self.edad = edad
persona1 = Persona("Francisco", 29)
print(f"El programador se llama {persona1.nombre} y tiene {persona1.edad} años.")

# Prueba 3 - Variables Privadas
class CuentaBancaria:
    def __init__(self, saldo):
        self._saldo = saldo # Notese el guión bajo después del self.
    def consultar_saldo(self):
        return self._saldo

cuenta1 = CuentaBancaria(2500)
print(cuenta1._saldo)
print(cuenta1.consultar_saldo())