<template>
    <div>
      <h1>Precio Total</h1>
      <p>
        Precio: 
        <input v-model.number="precio" type="number">
      </p>
      <p>
        Cantidad: 
        <input v-model.number="cantidad" type="number">
      </p>
      <p>Total: {{ total }}</p>
    </div>
  </template>
  
  <script>
  export default {
    data() {
      return {
        precio: 10,
        cantidad: 2
      };
    },
    computed: {
      total() {
        return this.precio * this.cantidad;
      }
    }
  };
  </script>
  
  <style scoped>
  /* Agrega estilos si es necesario */
  </style>
  