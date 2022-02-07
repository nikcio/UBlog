<template>
    <div>
        <BlogItem v-for="item in content.data.contentAtRoot.nodes[0].children" :item="item" />
    </div>
</template>

<script setup>
var myHeaders = new Headers();
myHeaders.append("Content-Type", "application/json");

var graphql = JSON.stringify({
    query: `{
        contentAtRoot (first: 1) {
            nodes {
            children {
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
    body: graphql,
    redirect: 'follow'
};

var { data: content } = await useAsyncData('data', () => fetch("https://localhost:49155/graphql/", requestOptions)
    .then(response => response.json())
    .catch(error => console.log('error', error)))
</script>