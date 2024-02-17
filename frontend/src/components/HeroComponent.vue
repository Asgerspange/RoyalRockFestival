<template>
    <div class="container">
        <div class="row align-items-center">
            <div class="col-lg-12">
                <div class="hero position-relative">
                    <img class="background--image img-fluid" src="@/img/banner.png" alt="Banner">
                    <div class="hero-text text-center text-lg-left">
                        <h1>Royal Rock Festival</h1>
                        <h5>Til alle os der støtter Rockens Talenter..</h5>
                    </div>
                </div>
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
    }
</script>

<style lang="scss" scoped>
    .hero-text {
        position: absolute;
        top: 25%;
        left: 0;
        right: 0;
        z-index: 1;
        color: white;
    }

    .hero-text h1, .hero-text h5 {
        font-size: 1.5rem;

        @media screen and (max-width: 768px) {
            font-size: 1rem;
            
        }
    }
</style>
