import { createWebHistory, createRouter } from "vue-router";
import Inicio from "@/views/Inicio.vue";
import Contacto from "@/views/Contacto.vue";
import Acerca from "@/views/Acerca.vue";
import TotalPrice from '@/views/TotalPrice.vue';
// Pruebas de Props y Eventos entre componentes
import ParentComponent from '@/views/ParentComponent.vue';
import ChildComponent from '@/views/ChildComponent.vue';
// Pruebas de Event Bus
import EventEmitter from '@/views/EventEmitter.vue';
import EventReceiver from '@/views/EventReceiver.vue';


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
  {
    path: "/total",
    name: "TotalPrice",
    component: TotalPrice,
  },
  // Pruebas de Props y Eventos entre componentes
  {
    path: "/parent",
    name: "ParentComponent",
    component: ParentComponent,
  },
  {
    path: "/child",
    name: "ChildComponent",
    component: ChildComponent,
  },
  // Pruebas de Event Bus
  { 
    path: '/emit',
    name: 'Emit',
    component: EventEmitter
  },
  { 
    path: '/receive',
    name: 'Receive',
    component: EventReceiver
  }
];

const router = createRouter({
  history: createWebHistory(),
  routes,
});

export default router;