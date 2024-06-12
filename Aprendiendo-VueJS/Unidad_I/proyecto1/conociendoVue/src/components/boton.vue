<template>
    <button class="btn">{{ text }}</button>
  </template>
  
  <script>
  export default {
    props: ['text']
  };
  </script>
  
  <style scoped>
  .btn {
    padding: 10px;
    background-color:white;
    color: black;
  }
  </style>
  