<template>
    <div>
        <header>
            <Image imageSource="/logos/logo.svg" imageAlt="Logo" />
        </header>
        <main>
            <BlogList />
        </main>
    </div>
</template>

<script lang="ts" setup>
useMeta(() => ({
    title: "Nikcio - Blog"
}))
</script>