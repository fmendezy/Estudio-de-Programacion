<template>
    <div>
      <h2>Componente Emisor</h2>
      <button @click="emitirEvento">Emitir Evento</button>
    </div>
  </template>
  
  <script>
  import eventBus from '../eventBus.js';
  
  export default {
    methods: {
      emitirEvento() {
        eventBus.emit('miEvento', 'Hola desde el Emisor');
      }
    }
  };
  </script>
  
  <style scoped>
  /* Agrega estilos si es necesario */
  </style>
  