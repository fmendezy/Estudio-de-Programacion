package cl.mendezy.curso_androidmaster.firstapp

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import cl.mendezy.curso_androidmaster.R

class FirstAppActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_first_app)
        // Aquí va lo que se ejecuta al inicio al arrancar la pantalla
    }
}