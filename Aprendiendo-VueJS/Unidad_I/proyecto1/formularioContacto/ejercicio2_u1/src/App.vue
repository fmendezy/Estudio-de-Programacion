<template>
    <div id="nav">      
      <router-link to="/">Inicio</router-link> |
      <router-link to="/Contacto">Formulario de Contacto</router-link> |
      <router-link to="/acerca">Sobre mi</router-link> |
      <RouterLink to="/total">Precio Total</RouterLink> |
      <RouterLink to="/parent">Padre</RouterLink> |
      <RouterLink to="/child">Hijo</RouterLink> |
      <RouterLink to="/emit">Emisor de Evento</RouterLink> |
      <RouterLink to="/receive">Receptor de Evento</RouterLink> |
      <a href="https://www.google.cl">Google</a>
    </div>
    <router-view />
</template>

