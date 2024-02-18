<template>
    <h1 class="mb-5 line"><span>Kommende Events</span></h1>
    <div :class="[scroll ? 'scroll-box' : '']">
        <div v-for="event in events" :key="event.id" class="col-12 mb-3">
            <div class="row">
                <div class="col-lg-1">
                    <img src="https://via.placeholder.com/80" alt="Placeholder" class="img-fluid">
                </div>
                <div class="card col-lg-11">
                    <div class="card-body">
                        <h3 class="card-title">{{ event.title }}</h3>
                        <h5 class="card-text">{{ event.location }}</h5>
                        <strong class="card-text">{{ event.date }}</strong>
                        <div class="float-end">
                            <router-link :to="'/events/' + event.id" class="p-button p-component text--white">Læs mere</router-link>
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
            events: []
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
            axios.get(`https://${import.meta.env.VITE_IP_ADDRESS}/api/events`).then(response => {
                console.log(response.data)
                this.events = response.data
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
