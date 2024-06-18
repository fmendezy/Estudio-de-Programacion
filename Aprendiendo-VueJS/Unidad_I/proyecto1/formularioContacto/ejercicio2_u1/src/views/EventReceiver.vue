<template>
    <div>
      <h2>Componente Receptor</h2>
      <p>{{ mensaje }}</p>
    </div>
  </template>
  
  <script>
  import eventBus from '../eventBus.js';
  
  export default {
    data() {
      return {
        mensaje: ''
      };
    },
    mounted() {
      eventBus.on('miEvento', this.actualizarMensaje);
    },
    beforeUnmount() {
      eventBus.off('miEvento', this.actualizarMensaje);
    },
    methods: {
      actualizarMensaje(msg) {
        this.mensaje = msg;
      }
    }
  };
  </script>
  
  <style scoped>
  /* Agrega estilos si es necesario */
  </style>
  