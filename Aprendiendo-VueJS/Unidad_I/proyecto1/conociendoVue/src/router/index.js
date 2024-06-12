import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
//import Page2 from '../views/Page2.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'inicio',
      component: HomeView
    },
    {
      path: '/about',
      name: 'quienes-somos',
      component: () => import('../views/AboutView.vue')
    }/*,
    {
      path: '/Page2',
      name: 'pagina-2',
      component: () => import('../views/Page2.vue')
    }*/
  ]
})

export default router
