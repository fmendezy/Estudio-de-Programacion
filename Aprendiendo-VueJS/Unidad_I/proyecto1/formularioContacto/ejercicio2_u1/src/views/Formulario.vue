 <template>
<!-- 
    Plantilla de ejemplo para comprender
  Estructuras de formularios 
 -->
  <div>
    <h1>Formulario de Registro</h1>
    <form @submit.prevent="validarFormulario">
      <div>
        <label for="nombre">Nombre:</label>
        <input v-model="nombre" type="text" id="nombre" />
        <span v-if="errores.nombre">{{ errores.nombre }}</span>
      </div>
      <div>
        <label for="email">Email:</label>
        <input v-model="email" type="email" id="email" />
        <span v-if="errores.email">{{ errores.email }}</span>
      </div>
      <div>
        <label for="password">Contraseña:</label>
        <input v-model="password" type="password" id="password" />
        <span v-if="errores.password">{{ errores.password }}</span>
      </div>
      <button type="submit">Registrar</button>
    </form>
  </div>
</template>

<script>
export default {
  data() {
    return {
      nombre: '',
      email: '',
      password: '',
      errores: {}
    };
  },
  methods: {
    validarFormulario() {
      this.errores = {};

      if (!this.nombre) {
        this.errores.nombre = 'El nombre es requerido.';
      }

      if (!this.email) {
        this.errores.email = 'El email es requerido.';
      } else if (!this.validarEmail(this.email)) {
        this.errores.email = 'El email no es válido.';
      }

      if (!this.password) {
        this.errores.password = 'La contraseña es requerida.';
      } else if (this.password.length < 6) {
        this.errores.password = 'La contraseña debe tener al menos 6 caracteres.';
      }

      if (Object.keys(this.errores).length === 0) {
        alert('Formulario enviado con éxito!');
        // Aquí puedes manejar el envío del formulario, por ejemplo, hacer una solicitud a una API
      }
    },
    validarEmail(email) {
      const re = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
      return re.test(String(email).toLowerCase());
    }
  }
};
</script>

<style scoped>
/* Agrega estilos si es necesario */
form div {
  margin-bottom: 10px;
}

span {
  color: red;
  font-size: 12px;
}
</style>
