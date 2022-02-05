<template>
    <div v-for="tag in tags">
        <p>{{ tag }}</p>
    </div>
</template>

<script lang="ts" setup>
const props = defineProps({
    data: Object
})

let tags = props.data.value
</script>