<template>
    <h1 class="mb-5 line"><span>Seneste nyheder</span></h1>
    <div class="scroll-box">
        <div v-for="news in latestNews" :key="news.id" class="col-12 mb-3">
            <div class="row">
                <div class="col-lg-2">
                    <img src="https://via.placeholder.com/150" alt="Placeholder" class="img-fluid">
                </div>
                <div class="card col-lg-10">
                    <div class="d-flex justify-content-between mt-3">
                        <p class="card-text">{{ news.author }}</p>
                        <p class="card-text">{{ news.date }}</p>
                    </div>
                    <hr>
                    <div class="card-body">
                        <h5 class="card-title">{{ news.content }}</h5>
                        <div class="col-3 float-end">
                            <router-link to="/test" class="p-button p-component text--white">Læs mere</router-link>
                        </div>
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
            latestNews: [
                {
                    id: 1,
                    content: 'Kashmir slutter deres Trespassers-tour af med 3 koncerter i Aalborg, København og Aarhus. Billetterne er allerede sat til salg.',
                    date: '2020-01-14',
                    author: 'Christian Nørrelund'
                },
                {
                    id: 2,
                    content: "Kashmir har netop udgivet deres nye album 'No Balance Palace' og er klar til at tage på tour.",
                    date: '2020-01-02',
                    author: 'Christian Nørrelund'
                },
                {
                    id: 3,
                    content: 'Kashmir har netop udgivet deres nye album No Balance Palace og er klar til at tage på tour.',
                    date: '2020-01-02',
                    author: 'Christian Nørrelund'
                },
                {
                    id: 4,
                    content: 'Kashmir har netop udgivet deres nye album No Balance Palace og er klar til at tage på tour.',
                    date: '2020-01-02',
                    author: 'Christian Nørrelund'
                },
            ]
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
