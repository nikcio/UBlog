<template>
    <div class="blog-list">
        <BlogItem v-for="item in content?.data?.contentAtRoot?.nodes[0]?.children" :item="item" />
    </div>
</template>

<script lang="ts" setup>
var myHeaders = new Headers();
myHeaders.append("Content-Type", "application/json");

var graphql = JSON.stringify({
    query: `{
        contentAtRoot (first: 1) {
            nodes {
            children {
                url,
                properties {
                alias,
                value
                }
            }
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

var { data: content } = await useAsyncData('data', () => fetch(useRuntimeConfig().API_URL, requestOptions)
    .then(response => response.json())
    .catch(error => console.log('error', error)));
</script>

<style scoped>
div.blog-list {
    display: flex;
    flex-direction: column;
    align-items: center;
    gap: 30px;
}
</style>