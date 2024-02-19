<template>
    <div class="container">
        <div class="row mt-5">
            <div class="col-lg-12">
                <div>
                    <form>
                        <div class="row">
                            <div class="col-lg-4">
                                    <label for="content" class="form-label">Titel</label>
                                    <input type="text" class="form-control" id="author" v-model="newEvent.title">
                            </div>
                            <div class="col-lg-4">
                                    <label for="author" class="form-label">Placering</label>
                                    <input type="text" class="form-control" id="author" v-model="newEvent.location">
                            </div>
                            <div class="col-lg-4">
                                <label for="author" class="form-label">Dato</label>
                                <Calendar v-model="newEvent.date" dateFormat="yyyy-mm-dd" />
                            </div>
                            <div class="col-lg-12">
                                <label for="content" class="form-label">Beskrivelse</label>
                                <textarea class="form-control" id="content" v-model="newEvent.content"> </textarea>
                            </div>

                            <div class="col-lg-4"></div>
                            <div class="col-lg-4 text-center mt-4">
                                <button type="submit" @click=createEvent() class="btn btn-primary">Opret Event</button>
                            </div>
                            <div class="col-lg-4"></div>
                            
                        </div>
                    </form>
                </div>
                <EventsComponent />
            </div>
        </div>
    </div>
</template>
<script>
    import axios from 'axios';
    import EventsComponent from '@/components/EventsComponent.vue';
    import { useStore } from '@/store';

    export default {
        data() {
            return {
                newEvent: {
                    title: null,
                    location: null,
                    date: null,
                    content: null,
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
            createEvent() {
                axios.post(`https://${import.meta.env.VITE_IP_ADDRESS}/api/events/create`, { title: this.newEvent.title, location: this.newEvent.location, date: this.newEvent.date, content: this.newEvent.content}).then(response => {
                })
            }
        },

        components: {
            EventsComponent
        }
    }
</script>