<template>
    <div>
        <h3 v-if="properties['title']">{{ properties['title'].value }}</h3>
        <div v-if="properties['tags']">
            <Tags :data="properties['tags']" />
        </div>
        <span v-if="properties['author']">Author: {{ properties['author'].name }}</span>
        <p v-if="properties['text']" v-html="properties['text'].value"></p>
    </div>
</template>

<script lang="ts" setup>
const props = defineProps({
    item: Object
})

let properties = Object.assign({}, ...props.item.properties.map((x) => ({ [x.alias]: x.value })));

</script>