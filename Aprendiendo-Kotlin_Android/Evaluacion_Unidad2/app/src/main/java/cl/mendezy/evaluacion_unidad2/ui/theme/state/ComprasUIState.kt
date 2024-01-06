package cl.mendezy.evaluacion_unidad2.ui.theme.state

import cl.mendezy.evaluacion_unidad2.data.modelo.Compra

data class ComprasUIState (

    val mensaje:String = "",

    val compras:List<Compra> = listOf<Compra>()

)