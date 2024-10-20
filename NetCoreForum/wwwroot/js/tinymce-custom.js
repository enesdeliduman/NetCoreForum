tinymce.init({
    skin: 'oxide-dark',
    selector: 'textarea[name="ReplyContent"]',
    content_css: 'dark',
    menubar: false,
    plugins: 'lists link image table',
    toolbar: 'undo redo | styleselect | bold italic | alignleft aligncenter alignright | bullist numlist outdent indent | link image', // Araç çubuğundaki butonlar
    language: "tr",
    images_upload_url: '',
    automatic_uploads: true,
    file_picker_callback: function (callback, value, meta) {
        if (meta.filetype === 'image') {
            const input = document.createElement('input');
            input.setAttribute('type', 'file');
            input.setAttribute('accept', 'image/*');
            input.onchange = function () {
                const file = this.files[0];
                const reader = new FileReader();
                reader.onload = function () {
                    callback(reader.result, {
                        alt: file.name
                    });
                };
                reader.readAsDataURL(file);
            };
            input.click();
        }
    }
});