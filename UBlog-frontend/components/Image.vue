<template>
    <img :src="imageSource" :alt="imageAlt" />
</template>

<script lang="ts" setup>
/* eslint-disable no-undef */
// eslint-disable-next-line @typescript-eslint/no-unused-vars
const props = defineProps({
    imageSource: {
        type: String,
        default: ""
    },
    imageAlt: {
        type: String,
        default: ""
    },
})
/* eslint-enable no-undef */
</script>