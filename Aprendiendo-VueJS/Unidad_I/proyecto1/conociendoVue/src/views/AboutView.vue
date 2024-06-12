<template>
  <div class="about">
    <h1>This is an about page</h1>
    <Button text="Cliqueame!" />
  </div>
</template>

<script>
import Button from '@/components/boton.vue';

export default {
  components: {
    Button
  }
};
</script>

<style>
@media (min-width: 1024px) {
  .about {
    min-height: 100vh;
    display: flex;
    align-items: center;
  }
}
</style>

<style scoped>
h1 {
  color: green;
}
</style>
