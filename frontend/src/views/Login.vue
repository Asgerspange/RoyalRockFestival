<template>
    <div>
      <h2>Login</h2>
      <form @submit.prevent="login">
        <div>
          <label for="username">Username:</label>
          <input type="text" id="username" v-model="user.username">
        </div>
        <div>
          <label for="password">Password:</label>
          <input type="password" id="password" v-model="user.password">
        </div>
        <button type="submit">Login</button>
      </form>
      <div v-if="errorMessage" style="color: red;">{{ errorMessage }}</div>
    </div>
  </template>
  
<script>
import { useStore } from '../store';
    export default {
        data() {
            return {
                user: {
                    username: '',
                    password: ''
                },
                errorMessage: ''
            };
        },

        methods: {
            async login() {
                try {
                    const response = await fetch('https://192.168.87.139:7014/api/users/login', {
                        method: 'POST',
                        headers: {
                            'Content-Type': 'application/json'
                        },
                        body: JSON.stringify(this.user)
                    });

                    const data = await response.json();
                        if (response.ok) {
                            useStore().setUser(data);
                            this.$router.push('/');
                        } else {
                            this.errorMessage = data;
                        }
                        } catch (error) {
                            console.error('Error:', error);
                            this.errorMessage = 'An error occurred while logging in.';
                        }
                }
        }
    };
</script>

<style scoped>
/* Add your CSS styles here */
</style>
