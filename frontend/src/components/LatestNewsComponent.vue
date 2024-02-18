<template>
    <h1 class="mb-5 line"><span>Seneste nyheder</span></h1>
    <div :class="[scroll ? 'scroll-box' : '']">
        <div v-for="news in latestNews" :key="news.id" class="col-12 mb-3">
            <div class="row">
                <div class="col-lg-1">
                    <img src="https://via.placeholder.com/80" alt="Placeholder" class="img-fluid">
                </div>
                <div class="card col-lg-11">
                    <div class="d-flex justify-content-between mt-3">
                        <p class="card-text">{{ news.author }}</p>
                        <p class="card-text">{{ news.date }}</p>
                    </div>
                    <hr>
                    <div class="card-body">
                        <h5 class="card-title">{{ news.content }}</h5>
                        <div class="float-end">
                            <router-link to="/test" class="p-button p-component text--white">Læs mere</router-link>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
import axios from 'axios'
export default {
    data() {
        return {
            latestNews: []
        }
    },

    props: {
        scroll: {
            type: Boolean,
            default: false
        }
    },

    mounted() {
        this.fetchLatestNews()
    },

    methods: {
        fetchLatestNews() {
            axios.get(`https://${import.meta.env.VITE_IP_ADDRESS}/api/news`).then(response => {
                this.latestNews = response.data
            })
        }
    },
}
</script>

<style lang="scss" scoped>
.scroll-box {
    max-height: 400px;
    overflow-y: auto;
    overflow-x: hidden;
    padding-right: 15px;
    scrollbar-width: thin;
    scrollbar-color: #888 transparent;
}

.scroll-box::-webkit-scrollbar {
    width: 8px;
}

.scroll-box::-webkit-scrollbar-track {
    background-color: transparent;
}

.scroll-box::-webkit-scrollbar-thumb {
    background-color: #888;
    border-radius: 4px;
}
</style>
