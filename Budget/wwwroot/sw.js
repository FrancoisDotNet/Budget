var cacheName = 'budget';
var filesToCache = [
    //wwwroot
    './index.html',
    './serviceworker.js',
    './manifest.json',
    './css/open-iconic/font/css/open-iconic-bootstrap.min.css', 
    './css/open-iconic/font/fonts/open-iconic.woff',
    './icon-192x192.png',
    './icon-512x512.png',
    //_framework
    './_framework/blazor.webassembly.js',
    './_framework/blazor.boot.json',
    //_framework/wasm
    './_framework/wasm/mono.js',
    './_framework/wasm/mono.wasm',
    //_framework/_bin
    './_framework/_bin/Microsoft.AspNetCore.Blazor.dll',
    './_framework/_bin/Microsoft.Extensions.DependencyInjection.Abstractions.dll',
    './_framework/_bin/Microsoft.Extensions.DependencyInjection.dll',
    './_framework/_bin/Microsoft.JSInterop.dll',
    './_framework/_bin/mscorlib.dll',
    './_framework/_bin/System.Net.Http.dll',
    './_framework/_bin/Mono.WebAssembly.Interop.dll',
    './_framework/_bin/System.dll',
    './_framework/_bin/System.Core.dll',
    './_framework/_bin/Blazored.LocalStorage.dll',
    './_framework/_bin/Budget.dll'
];

self.addEventListener('install', function (e) {
    e.waitUntil(
        caches.open(cacheName).then(function (cache) {
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