<template>
    <div class="blog-item">
        <h3 v-if="properties['title']">{{ properties['title']?.value }}</h3>
        <div class="tags" v-if="properties['tags']">
            <Tags :data="properties['tags']" />
        </div>
        <NuxtLink v-if="url" class="read-button" :to="url">Read</NuxtLink>
    </div>
</template>

<script lang="ts" setup>
const props = defineProps({
    item: Object
})

let properties = Object.assign({}, ...props?.item?.properties?.map((x) => ({ [x?.alias]: x?.value })));
let url = props?.item?.url;
</script>

<style scoped>
div.blog-item {
    display: flex;
    align-items: left;
    max-width: 400px;
    width: 100%;
    text-align: flex-start;
    flex-direction: column;
    border: 2px solid grey;
    padding: 35px;
    border-radius: 25px;
}

.blog-item h3 {
    font-size: 24px;
    font-weight: 700;
    margin: 0;
    margin-bottom: 5px;
}

.blog-item .tags {
    display: flex;
    gap: 10px;
}

.blog-item .read-button {
    display: block;
    text-decoration: none;
    color: #000;
    background: lightgrey;
    width: fit-content;
    padding: 5px 10px;
    border-radius: 10px;
}

.blog-item .read-button:hover {
    background: grey;
}
</style>