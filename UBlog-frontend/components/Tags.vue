<template>
    <div v-for="tag in tags">
        <p class="tag">#{{ tag }}</p>
    </div>
</template>

<script lang="ts" setup>
const props = defineProps({
    data: Object
})

let tags = props?.data?.value
</script>

<style scoped>
p.tag {
    font-size: 14px;
}
</style>