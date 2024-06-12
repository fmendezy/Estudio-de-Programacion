import { createWebHistory, createRouter } from "vue-router";
import Inicio from "@/views/Inicio.vue";
import Contacto from "@/views/Contacto.vue";
import Acerca from "@/views/Acerca.vue";


const routes = [
  {
    path: "/",
    name: "Inicio",
    component: Inicio,
  },
    {
    path: "/contacto",
    name: "Contacto",
    component: Contacto,
  },
  {
    path: "/acerca",
    name: "Acerca",
    component: Acerca,
  },
];

const router = createRouter({
  history: createWebHistory(),
  routes,
});

export default router;