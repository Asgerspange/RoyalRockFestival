<template>
    <div class="container mt-5">
        <div class="row justify-content-center">
            <div class="col-md-6">
                <div class="custom-card wow fadeIn" data-wow-duration="1s" data-wow-delay="0.5s" @mouseover="rotateCard" @mouseout="resetCard">
                    <div class="custom-card-inner">
                        <div class="custom-card-front">
                            <div class="custom-card-header bg-custom-purple text-white">
                                <h2 class="custom-heading text-center mb-0">🔒 Login 🛡️</h2>
                            </div>
                            <div class="custom-card-body">
                                <form @submit.prevent="validateForm" ref="loginForm" class="custom-form">
                                    <div class="custom-form-group">
                                        <label for="username" class="custom-label">👤 Username:</label>
                                        <input type="text" id="username" v-model="user.username" class="custom-input form-control" placeholder="🔑 Enter your username" required>
                                        <div class="invalid-feedback" v-if="formErrors.username">{{ formErrors.username }}</div>
                                    </div>
                                    <div class="custom-form-group">
                                        <label for="password" class="custom-label">🔑 Password:</label>
                                        <input type="password" id="password" v-model="user.password" class="custom-input form-control" placeholder="🔒 Enter your password" required>
                                        <div class="invalid-feedback" v-if="formErrors.password">{{ formErrors.password }}</div>
                                    </div>
                                    <button type="submit" class="custom-btn btn btn-custom-purple btn-block">🚪 Login 🚀</button>
                                </form>
                                <div v-if="errorMessage" class="custom-error-message mt-3 text-danger">❌ {{ errorMessage }}</div>
                            </div>
                        </div>
                        <div class="custom-card-back wow fadeIn" data-wow-duration="1s" data-wow-delay="0.5s">
                            <h3 class="custom-heading text-center mb-0">🤖 Thank you for visiting 🤖</h3>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
import { useStore } from '../store';
import WOW from 'wow.js';

export default {
    data() {
        return {
            user: {
                username: '',
                password: ''
            },
            errorMessage: '',
            formErrors: {
                username: '',
                password: ''
            }
        };
    },
    mounted() {
        new WOW().init();
    },
    methods: {
        async login() {
            try {
                const response = await fetch(`https://${import.meta.env.VITE_IP_ADDRESS}/api/users/login`, {
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
        },
        validateForm() {
            this.formErrors.username = '';
            this.formErrors.password = '';

            if (!this.user.username) {
                this.formErrors.username = 'Username is required.';
            }

            if (!this.user.password) {
                this.formErrors.password = 'Password is required.';
            }

            if (this.formErrors.username || this.formErrors.password) {
                return;
            }

            // If form is valid, proceed with login
            this.login();
        },
        rotateCard() {
            this.$refs.loginForm.classList.add('hover');
        },
        resetCard() {
            this.$refs.loginForm.classList.remove('hover');
        }
    }
};
</script>


<style lang="scss" scoped>
    .container {
        display: flex;
        flex-direction: column;
        min-height: 100vh;
    }

    $purple: #8e44ad;
    $lightPurple: #a569bd;
    $darkPurple: #7d3c98;
    $lightGray: #f1ecf9;
    $darkGray: rgba(0, 0, 0, 0.2);

    .custom-card {
        border: 4px solid $purple;
        border-radius: 30px;
        box-shadow: 0 0 30px $darkGray;
        &-header {
            border-bottom: none;
            border-radius: 20px 20px 0 0;
        }
        &-body {
            padding: 40px;
        }
    }

    .custom-heading {
        font-size: 36px;
        font-weight: bold;
        text-shadow: 2px 2px 4px rgba(0, 0, 0, 0.3);
    }

    .custom-form {
        background-color: $lightGray;
        border-radius: 20px;
        padding: 30px;
    }

    .custom-form-group {
        margin-bottom: 40px;
    }

    .custom-label {
        font-weight: bold;
        font-size: 20px;
    }

    .custom-input {
        border: 2px solid $purple;
        border-radius: 15px;
        padding: 20px;
        font-size: 18px;
        &::placeholder {
            color: $lightPurple;
        }
    }

    .custom-btn {
        border: none;
        border-radius: 15px;
        padding: 20px;
        font-size: 20px;
        background-color: $purple;
        box-shadow: 0 6px 10px $darkGray;
        transition: background-color 0.3s ease;
        &:hover {
            background-color: $darkPurple;
        }
    }

    .custom-error-message {
        font-size: 24px;
        text-align: center;
        text-transform: uppercase;
        letter-spacing: 2px;
        margin-top: 30px;
    }

    .custom-card {
        perspective: 1000px;
        &.hover .custom-card-inner {
            transform: rotateY(180deg);
        }
    }
    .custom-card-inner {
        position: relative;
        width: 100%;
        height: 100%;
        transition: transform 1s;
        transform-style: preserve-3d;
    }
    .custom-card-front,
    .custom-card-back {
        position: absolute;
        width: 100%;
        height: 100%;
        backface-visibility: hidden;
    }
    .custom-card-front {
        z-index: 2;
    }
    .custom-card-back {
        transform: rotateY(180deg);
        background-color: #f1ecf9;
        display: flex;
        justify-content: center;
        align-items: center;
    }
</style>
