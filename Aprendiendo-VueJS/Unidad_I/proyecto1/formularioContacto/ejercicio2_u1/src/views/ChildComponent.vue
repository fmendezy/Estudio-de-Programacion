<template>
    <div>
      <h2>Componente Hijo</h2>
      <p>Esto es del componente hijo</p>
      <p>{{ mensaje }}</p>
    </div>
  </template>
  
  <script>
  export default {
    props: {
      mensaje: {
        type: String,
        required: true
      }
    }
  };
  </script>
  
  <style scoped>
  /* Agrega estilos si es necesario */
  </style>
  