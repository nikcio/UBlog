<template>
    <div class="blog-post">
        <h3 v-if="properties['title']">{{ properties['title']?.value }}</h3>
        <div class="tags" v-if="properties['tags']">
            <Tags :data="properties['tags']" />
        </div>
        <p v-if="properties['author']" class="author">By: {{ properties['author'].name }}</p>
        <div v-if="properties['text']" class="text-content" v-html="properties['text'].value"></div>
    </div>
</template>

<script lang="ts" setup>
const props = defineProps({
    content: Object
})

let properties = Object.assign({}, ...props?.content?.properties?.map((x) => ({ [x?.alias]: x?.value })));
</script>

<style scoped>
.blog-post h3 {
    font-size: 36px;
    font-weight: 700;
    margin: 0;
    margin-bottom: 5px;
}

.blog-post .tags {
    display: flex;
    gap: 10px;
}

.blog-post .author {
    font-size: 14px;
    margin-top: 10px;
    margin-bottom: 0;
}
</style>