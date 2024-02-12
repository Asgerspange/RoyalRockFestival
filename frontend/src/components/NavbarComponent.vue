<template>
    <nav class="navbar navbar-expand-lg navbar-light">
        <div class="col-lg-1 col-md-12 col-sm-12"></div>
        <div class="col-lg-5">
            <a class="navbar-brand" href="#">
                <img src="@/img/royalrockfestivallogo.jpg" alt="Your Logo" width="175px">
            </a>
        </div>
        
        <div class="col-lg-5">
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarSupportedContent">
                <ul class="navbar-nav mr-auto spacing">
                    <li class="col-lg-3" v-for="(link, index) in links" :key="index">
                        <router-link :to="link.route" class="nav-link">{{ link.label }}</router-link>
                    </li>
                    <div class="col-lg-2">
                        <button class="login-button" type="button">Login</button>
                    </div>
                </ul>
            </div>
        </div>
        <div class="col-lg-1 col-md-12 col-sm-12"></div>
    </nav>
</template>

<script>
    import { RouterLink } from 'vue-router';

    export default {
        data() {
        return {
            links: [
            { label: 'FORSIDE', route: '/' },
            { label: 'NYHEDER', route: '/news' },
            { label: 'EVENTS', route: '/events' },
            { label: 'ROYAL ROCK', route: '/royal-rock' },
            { label: 'KONTAKT', route: '/contact' }
            ]
        };
        },
        components: { RouterLink }
    }
</script>

<style lang="scss" scoped>

    .login-button {
        background-color: purple;
        color: white;
        border: none;
        border-radius: 8px;
        padding: 2px 2px 2px;
        width: 100%;
    
    }

    .navbar {
        box-shadow: 0 0 10px 0 rgba(0, 0, 0, 0.2);
        z-index: 10;
    }
</style>
