<template>
    <div>
        <BlogItem v-for="item in content.data.atRoot[0].children" :item="item" />
    </div>
</template>

<script setup>
var myHeaders = new Headers();
myHeaders.append("Content-Type", "application/json");

var graphql = JSON.stringify({
    query: "{\r\n    atRoot {\r\n                children {\r\n                    properties {\r\n                        alias,\r\n                        value\r\n                    }\r\n                }\r\n            }\r\n}",
    variables: {}
})
var requestOptions = {
    method: 'POST',
    headers: myHeaders,
    body: graphql,
    redirect: 'follow'
};

var { data: content } = await useAsyncData('data', () => fetch("https://localhost:49153/graphql/", requestOptions)
    .then(response => response.json())
    .catch(error => console.log('error', error)))
</script>