import { defineNuxtConfig } from 'nuxt3'

import { resolve } from 'path'

// https://v3.nuxtjs.org/docs/directory-structure/nuxt.config
export default defineNuxtConfig({
    hooks: {
        'pages:extend'(pages) {
            pages.push({
                name: 'cmsPage',
                path: '/:catchall(.*)',
                file: resolve(__dirname, 'cms/index.vue')
            })
        }
    },
    publicRuntimeConfig: {
        API_URL: process.env.API_URL
    },
})
