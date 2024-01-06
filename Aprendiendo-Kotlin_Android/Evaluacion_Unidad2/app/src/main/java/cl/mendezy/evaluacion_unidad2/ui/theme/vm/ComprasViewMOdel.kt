package cl.mendezy.evaluacion_unidad2.ui.theme.vm

import android.content.Context
import android.util.Log
import androidx.lifecycle.ViewModel
import androidx.lifecycle.viewModelScope
import cl.mendezy.evaluacion_unidad2.R
import cl.mendezy.evaluacion_unidad2.data.ComprasRepository
import cl.mendezy.evaluacion_unidad2.data.modelo.Compra
import cl.mendezy.evaluacion_unidad2.ui.theme.state.ComprasUIState
import kotlinx.coroutines.Job
import kotlinx.coroutines.flow.MutableStateFlow
import kotlinx.coroutines.flow.StateFlow
import kotlinx.coroutines.flow.asStateFlow
import kotlinx.coroutines.flow.update
import kotlinx.coroutines.launch
import java.io.FileInputStream
import java.io.FileOutputStream
import java.util.UUID

class ComprasViewModel (
    private val comprasRepository: ComprasRepository = ComprasRepository()
) : ViewModel() {

    companion object{
        const val FILE_NAME = "compras.data"
    }
    private var job: Job? = null
    private val _uiState = MutableStateFlow(ComprasUIState())
    val uiState: StateFlow<ComprasUIState> = _uiState.asStateFlow()
    init {
        obtenerCompras()
    }

    private fun obtenerCompras(){

        job?.cancel()
        job = viewModelScope.launch {
            val comprasStream = comprasRepository.getComprasStream()
            comprasStream.collect { comprasActualizadas ->
                Log.v("ComprasViewModel", "obtenerCompras() update{}")
                _uiState.update { currentState ->
                    currentState.copy(
                        compras = comprasActualizadas
                    )

                }

            }

        }

    }

    fun obtenerComprasGuardadasEnDisco(fileInputStream: FileInputStream){

        comprasRepository.getComprasEnDisco(fileInputStream)

    }

    fun guardarComprasEnDisco(fileOutputStream: FileOutputStream){

        comprasRepository.guardarComprasEnDisco(fileOutputStream)

    }

    fun eliminarCompra(compra: Compra){
        job = viewModelScope.launch {
            comprasRepository.eliminar(compra)

            _uiState.update {
                it.copy(mensaje = "Compra eliminada: ${compra.descripcion}")
            }

            obtenerCompras()

        }
    }

    fun agregarCompra(compra:String){
        job = viewModelScope.launch {
            val c = Compra(UUID.randomUUID().toString(), compra)

            comprasRepository.insertar(c)

            _uiState.update {
                it.copy(mensaje = "Compra agregada: ${c.descripcion}")
            }

            obtenerCompras()

        }
    }
}