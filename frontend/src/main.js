import { createApp } from 'vue'
import { createPinia } from 'pinia'
import Primevue from 'primevue/config'

import 'bootstrap/dist/js/bootstrap.bundle.min.js';

import './scss/app.scss'

import InputText from 'primevue/inputtext'
import Button from 'primevue/button'
import Calendar from 'primevue/calendar';

import 'primevue/resources/themes/aura-light-purple/theme.css'

import App from './App.vue'
import router from './router'

const store = createPinia()

const app = createApp(App)
    .use(router)
    .use(store)
    .use(Primevue)
    .component('InputText', InputText)
    .component('Calendar', Calendar)
    .component('Button', Button)

app.mount('#app')
