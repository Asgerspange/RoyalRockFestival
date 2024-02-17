<template>
    <div class="container d-flex mt-5">
        <div class="col-lg-2"></div>
        <div class="col-lg-1">
            <img src="https://via.placeholder.com/80" alt="Placeholder" class="img-fluid">
        </div>
        <div class="card col-lg-6">
            <div class="card-body">
                <h5 class="card-title">{{ event.title }}</h5>
                <h5 class="card-text">{{ event.location }}</h5>
                <strong class="card-text">{{ event.date }}</strong>
                <p class="card-text">{{ event.content }}</p>
            </div>
        </div>
        <div class="col-lg-3"></div>
    </div>
</template>

<script>
    import axios from 'axios'

    export default {
        data() {
            return {
                event: []
            }

        },

        mounted() {
            this.fetchEvent()
        },

        methods: {
            fetchEvent() {
                axios.get('https://192.168.87.139:7014/api/events/' + this.$route.params.id).then(response => {
                    this.event = response.data
                })
            }
        },
    }
</script>