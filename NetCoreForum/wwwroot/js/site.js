ClassicEditor
    .create(document.querySelector('#editor'), {
        theme: 'dark' // Koyu tema ayarı
    })
    .catch(error => {
        console.error(error);
    });