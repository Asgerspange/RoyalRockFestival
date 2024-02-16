<template>
        <div class="row">
            <div class="col-lg-12">
                <div class="hero position-relative">
                    <div class="hero-text text-center text-lg-left">
                        <h1>Royal Rock Festival</h1>
                        <h5>Til alle os der støtter Rockens Talenter..</h5>

                        <div class="row mt-4">
                            <div class="col-5">
                                <FloatLabel>
                                    <InputText type="text" v-model="user.name" id="navn"/>
                                    <label for="navn">Fulde navn</label>
                                </FloatLabel>
                            </div>

                            <div class="col-5">
                                <FloatLabel>
                                    <InputText type="text" v-model="user.mail" id="navn"/>
                                    <label for="navn">Mail</label>
                                </FloatLabel>
                            </div>

                            <div class="col-2">
                                <Button label="Tilmeld!" @click="test()"/>
                            </div>
                        </div>

                    </div>
                    <img class="background--image img-fluid" src="@/img/banner.png">
                </div>
            </div>
        </div>
</template>

<script>
    export default {
        data() {
            return {
                user: {
                    name: null,
                    mail: null,
                    test: null
                }
            }
        },

        methods: {
            test() {
                console.log(this.user)
            }
        }
    }
</script>

<style lang="scss" scoped>
    .background--image {
        max-width: 100%;
        height: auto;
        background-color: white;
        margin: 0 auto;
        display: block;
    }
    .hero-text {
        position: absolute;
        top: 50%;
        left: 50%;
        transform: translate(-50%, -50%);
        z-index: 1;
        color: white;
    }

    .hero-text p {
        font-size: 1.5rem;
    }
</style>
