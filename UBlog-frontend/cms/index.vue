<template>
    <div>
        <header>
            <Image imageSource="/logos/logo.svg" imageAlt="Logo" />
        </header>
        <main class="content">
            <BlogPost :content="content?.data?.contentByRoute" />
        </main>
        <NuxtLink class="back-link" to="/">Go back</NuxtLink>
    </div>
</template>

<script lang="ts" setup>
import BlogPost from '~/cms/BlogPost.vue'

var route = useRoute();

var myHeaders = new Headers();
myHeaders.append("Content-Type", "application/json");

var graphql = JSON.stringify({
    query: `{
        contentByRoute (route: "${route.path}") {
            name,
            properties {
            alias,
            value
            }
        }
    }`,
    variables: {}
})
var requestOptions = {
    method: 'POST',
    headers: myHeaders,
    body: graphql
};

var { data: content }: any = await useAsyncData('data', () => fetch(useRuntimeConfig().API_URL, requestOptions)
    .then(response => response.json())
    .catch(error => console.log('error', error)));

useMeta(() => ({
    title: content?.value?.data?.contentByRoute?.name
}))
</script>

<style scoped>
main.content {
    max-width: 500px;
    width: 100%;
    margin: auto;
}

.back-link {
    position: fixed;
    bottom: 40px;
    left: 20px;
    border: 1px solid black;
    border-radius: 5px;
    padding: 5px;
    text-decoration: none;
    color: black;
}

.back-link:hover {
    background-color: lightgray;
}
</style>