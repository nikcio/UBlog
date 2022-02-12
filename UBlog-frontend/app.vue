<template>
  <div>
    <NuxtPage />
  </div>
</template>

<script lang="ts" setup>
useMeta(() => ({
  meta: [
    {
      hid: 'description',
      name: 'description',
      content: 'A personal blog for Nikolaj Brask-Nielsen'
    },
    {
      hid: 'keywords',
      name: 'keywords',
      content: 'nikcio, Nikolaj Brask-Nielsen, Personal blog, Nikcio, Umbraco, graphql'
    },
    {
      hid: 'robots',
      name: 'robots',
      content: 'index, follow'
    },
    {
      hid: 'http-equiv',
      "http-equiv": 'Content-Type',
      content: 'text/html; charset=utf-8'
    },
    {
      hid: 'language',
      name: 'language',
      content: 'English'
    },
    {
      hid: 'revisit-after',
      name: 'revisit-after',
      content: '7 days'
    },
    {
      hid: 'author',
      name: 'author',
      content: 'Nikolaj "Nikcio" Brask-Nielsen'
    },
    {
      hid: 'og:type',
      property: 'og:type',
      content: 'website'
    },
    {
      hid: 'og:url',
      property: 'og:url',
      content: 'https://blog.nikcio.com/'
    },
    {
      hid: 'og:title',
      property: 'og:title',
      content: 'UBlog - Nikcio'
    },
    {
      hid: 'og:description',
      property: 'og:description',
      content: 'A personal blog for Nikolaj Brask-Nielsen'
    },
    {
      hid: 'og:image',
      property: 'og:image',
      content: 'https://blog.nikcio.com/images/SoMe.jpg'
    },
    {
      hid: 'twitter:card',
      property: 'twitter:card',
      content: 'summary_large_image'
    },
    {
      hid: 'twitter:url',
      property: 'twitter:url',
      content: 'https://blog.nikcio.com/'
    },
    {
      hid: 'twitter:title',
      property: 'twitter:title',
      content: 'UBlog - Nikcio'
    },
    {
      hid: 'twitter:image',
      property: 'twitter:image',
      content: 'https://blog.nikcio.com/images/SoMe.jpg'
    },
    {
      hid: 'msapplication-TileColor',
      name: 'msapplication-TileColor',
      content: '#2b5797'
    },
    {
      hid: 'msapplication-config',
      name: 'msapplication-config',
      content: '/favicons/browserconfig.xml'
    },
    {
      hid: 'theme-color',
      name: 'theme-color',
      content: '#ffffff'
    }
  ],
  link: [
    {
      hid: 'apple-touch-icon',
      rel: 'apple-touch-icon',
      sizes: '180x180',
      href: '/favicons/apple-touch-icon.png'
    },
    {
      hid: 'icon-32',
      rel: 'icon',
      type: 'image/png',
      sizes: '32x32',
      href: '/favicons/favicon-32x32.png'
    },
    {
      hid: 'icon-16',
      rel: 'icon',
      type: 'image/png',
      sizes: '16x16',
      href: '/favicons/favicon-16x16.png'
    },
    {
      hid: 'manifest',
      rel: 'manifest',
      href: '/favicons/site.webmanifest'
    },
    {
      hid: 'mask-icon',
      rel: 'mask-icon',
      href: '/favicons/safari-pinned-tab.svg',
      color: '#ef6f6c'
    },
    {
      hid: 'shortcut icon',
      rel: 'shortcut icon',
      href: '/favicon.ico'
    }
  ]
}))
</script>

<style>
html {
  font-family: -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, Helvetica,
    Arial, sans-serif, "Apple Color Emoji", "Segoe UI Emoji", "Segoe UI Symbol";
}
</style>