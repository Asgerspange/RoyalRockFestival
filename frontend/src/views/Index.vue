<template>
    <div class="container">
        <HeroComponent />
        <div class="row mt-5">
            <div class="col-lg-12">
                <LatestNewsComponent :scroll="true" />
            </div>
        </div>
    </div>
</template>
<script>
    import HeroComponent from '@/components/HeroComponent.vue';
    import LatestNewsComponent from '@/components/LatestNewsComponent.vue';

    export default {
        components: {
            HeroComponent,
            LatestNewsComponent
        }
    }
</script>