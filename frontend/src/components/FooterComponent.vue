<template>
    <div class="bg footer">
        <div class="container">
            <div class="row">
                <div class="col-lg-2 d-flex flex-column">
                    <RouterLink to="/" class="footer--text">FORSIDE</RouterLink>
                    <RouterLink to="/news" class="footer--text">NYHEDER</RouterLink>
                    <RouterLink to="/events" class="footer--text">EVENTS</RouterLink>
                </div>
                <div class="col-lg-2 d-flex flex-column">
                    <RouterLink to="/rock" class="footer--text">ROYAL ROCK</RouterLink>
                </div>
                <div class="col-lg-4">
                    <p class="footer--text">© 2024 Royal Rock Festival</p>
                </div>
                <div class="col-lg-4 contact">
                    <strong>Royal Rock Festival</strong>
                    <div class="info mt-2">
                        <p>Rockens Boulevard 168</p>
                        <p>5000, Odense</p>
                        <p>fakemail@royalrockfestival.dk</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<style lang="scss" scoped>
    .footer {
        margin-top: auto;
        background-color: #372b27;
        color: white;
        padding: 20px 0;
    }
    
    .footer--text {
        font-size: 1rem;
        text-align: center;
        font-weight: bold;
    }

    .contact {
        text-align: left;
        .info {
            line-height: 5px;
        }
    }
</style>