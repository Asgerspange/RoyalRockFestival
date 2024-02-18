<template>
    <NavbarComponent />
    <RouterView />
    <div class="mt-5">
        <FooterComponent />
    </div>
</template>

<script>
    import NavbarComponent from './components/NavbarComponent.vue';
    import FooterComponent from './components/FooterComponent.vue';

    export default {
        components: {
            NavbarComponent,
            FooterComponent
        }
    }
</script>
