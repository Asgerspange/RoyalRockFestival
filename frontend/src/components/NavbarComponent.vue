<template>
    <nav class="navbar navbar-expand-lg navbar-light">
        <div class="container">
            <div class="col-lg-3 col-md-10 col-sm-11">
                <router-link class="navbar-brand" to="/">
                    <img src="@/img/royalrockfestivallogo.jpg" alt="Your Logo" width="175px">
                </router-link>
            </div>
            
            <div class="col-lg-7 col-md-2 col-sm-1">
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarSupportedContent">
                    <ul class="navbar-nav mr-auto spacing">
                        <li class="col-lg-4 col-md-1" v-for="(link, index) in links" :key="index">
                            <router-link :to="link.route" class="nav-link">{{ link.label }}</router-link>
                        </li>
                    </ul>
                </div>
            </div>
            <div class="col-lg-2"></div>
            <div class="col-lg-1 collapse navbar-collapse" id="navbarSupportedContent">
                <template v-if="isLoggedIn">
                    <span>{{ user.username }}</span>
                </template>
                <template v-else>
                    <router-link to="/login" class="p-button p-component">Login</router-link>
                </template>
            </div>
        </div>
    </nav>
</template>

<script>
    import { RouterLink } from 'vue-router';
    import { useStore } from '../store';

    export default {
        data() {
            return {
                links: [
                    { label: 'FORSIDE', route: '/' },
                    { label: 'NYHEDER', route: '/news' },
                    { label: 'EVENTS', route: '/events' },
                    { label: 'ROYAL ROCK', route: '/rock' },
                    { label: 'KONTAKT', route: '/contact' }
                ],
                isLoggedIn: false,
                checkState: true,
                user: null
            };
        },

        computed: {
            isLoggedIn() {
                let user = useStore().getUser;

                if (user.username == '') {
                    this.isLoggedIn = false;
                    this.user = null;
                    
                    return
                }

                this.user = user
                return this.isLoggedIn = true;
            }
        },
        components: { RouterLink }
    }
</script>

<style lang="scss" scoped>
    .navbar {
        box-shadow: 0 0 10px 0 rgba(0, 0, 0, 0.2);
        z-index: 10;
    }
</style>
