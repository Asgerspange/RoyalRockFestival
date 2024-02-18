<template>
    <div class="container">
        <div class="row mt-5">
            <div class="col-lg-12">
                <div v-if="user.isAdmin == true">
                    <form>
                        <div class="mb-3">
                            <label for="content" class="form-label">Indhold</label>
                            <textarea class="form-control" id="content" v-model="newNews.content"></textarea>
                        </div>
                        <div class="mb-3">
                            <label for="author" class="form-label">Forfatter</label>
                            <input type="text" class="form-control" id="author" v-model="newNews.author">
                        </div>
                        <button type="submit" @click=createNews() class="btn btn-primary">Opret nyhed</button>
                    </form>
                </div>
                <LatestNewsComponent />
            </div>
        </div>
    </div>
</template>
<script>
    import axios from 'axios';
    import LatestNewsComponent from '@/components/LatestNewsComponent.vue';
    import { useStore } from '@/store';

    export default {
        data() {
            return {
                newNews: {
                    content: null,
                    author: null,
                },

                user: {
                    username: '',
                    password: '',
                    isAdmin: null
                }
            }
        },

        mounted() {
            this.user = useStore().getUser;
        },

        methods: {
            createNews() {
                axios.post(`https://${import.meta.env.VITE_IP_ADDRESS}/api/news/create`, { content: this.newNews.content, author: this.newNews.author }).then(response => {
                    console.log(response.data)
                })
            }
        },
        components: {
            LatestNewsComponent
        }
    }
</script>