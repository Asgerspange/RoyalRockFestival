<template>
    <div class="container">
        <div class="row mt-5">
            <div class="col-lg-12">
                <div v-if="admin === 1">
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

    export default {
        data() {
            return {
                admin: 1,
                newNews: {
                    content: null,
                    author: null,
                }
            }
        },

        methods: {
            createNews() {
                axios.post('https://localhost:7014/api/news/create', { content: this.newNews.content, author: this.newNews.author }).then(response => {
                    console.log(response.data)
                })
            }
        },
        components: {
            LatestNewsComponent
        }
    }
</script>