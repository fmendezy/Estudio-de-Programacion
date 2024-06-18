<template>
    <div>
      <h1>Componente Padre</h1>
      <ChildComponent :mensaje="mensajeDelPadre" />
    </div>
  </template>
  
  <script>
  import ChildComponent from './ChildComponent.vue';
  
  export default {
    components: {
      ChildComponent
    },
    data() {
      return {
        mensajeDelPadre: 'Hola desde el Componente Padre'
      };
    }
  };
  </script>
  
  <style scoped>
  /* Agrega estilos si es necesario */
  </style>
  