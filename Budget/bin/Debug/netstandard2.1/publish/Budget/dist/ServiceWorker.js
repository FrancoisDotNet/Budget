console.log("This is service worker talking!");
var cacheName = 'blazor-pwa-sample';
var filesToCache = [
    './',
    //Html and css files
    './index.html',
    './css/bootstrap/bootstrap.min.css',
    './css/open-iconic/font/css/open-iconic-bootstrap.min.css', 
    './css/open-iconic/font/fonts/open-iconic.woff',
    //Blazor framework
    './_framework/blazor.webassembly.js',
    './_framework/blazor.boot.json',
    //Our additional files
    './manifest.json',
    './ServiceWorker.js',
    './default-icon-192x192.png',
    './default-icon-512x512.png',
    //The web assembly/.net dll's
    './_framework/wasm/mono.js',
    './_framework/wasm/mono.wasm',
    './_framework/_bin/Microsoft.AspNetCore.Blazor.Browser.dll',
    './_framework/_bin/Microsoft.AspNetCore.Blazor.dll',
    './_framework/_bin/Microsoft.Extensions.DependencyInjection.Abstractions.dll',
    './_framework/_bin/Microsoft.Extensions.DependencyInjection.dll',
    './_framework/_bin/Microsoft.JSInterop.dll',
    './_framework/_bin/mscorlib.dll',
    './_framework/_bin/System.Net.Http.dll',
    './_framework/_bin/Mono.WebAssembly.Interop.dll',
    './_framework/_bin/System.dll',
    './_framework/_bin/System.Core.dll',
    '/_framework/_bin/Blazored.LocalStorage.dll',
    //The compiled project .dll's
    './_framework/_bin/Budget.dll'
];

self.addEventListener('install', function (e) {
    console.log('[ServiceWorker] Install');
    e.waitUntil(
        caches.open(cacheName).then(function (cache) {
            console.log('[ServiceWorker] Caching app shell');
            return cache.addAll(filesToCache); 
        })
    );
});

self.addEventListener('activate', event => {
    event.waitUntil(self.clients.claim());
});

self.addEventListener('fetch', event => {
    event.respondWith(
        caches.match(event.request, { ignoreSearch: true }).then(response => {
            return response || fetch(event.request);
        })
    );
});