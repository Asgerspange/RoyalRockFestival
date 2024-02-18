import { defineStore } from 'pinia';

export const useStore = defineStore('store', {
    state: () => ({
        user: {
            username: '',
            email: '',
            isAdmin: false,
        },
    }),

    getters: {
        getUser() {
            return this.user;
        },
    },

    actions: {
        setUser (user) {
            this.user.username = user.username;
            this.user.email = user.email;
            this.user.isAdmin = user.isAdmin;
        }
    },
});