let notyf = new Notyf({
    duration: 3000,
    position: {
        x: 'right',
        y: 'top',
    },
});

$(document).ready(function () {
    $('#replyForm').on('submit', function (event) {
        event.preventDefault();

        var formData = new FormData(this);
        formData.append('AppUserID', '@User.FindFirst(ClaimTypes.NameIdentifier)?.Value');
        formData.append('TopicID', '@Model.TopicID');

        $.ajax({
            url: '@Url.Action("CreateReply", "Replys")',
            type: 'POST',
            data: formData,
            contentType: false,
            processData: false,
            success: function (data) {
                notyf.success('Cevabınız başarıyla gönderildi');
                $('#responseMessage').html('<p>Yanıt başarıyla gönderildi!</p>');
                $('#replyForm')[0].reset();
            },
            error: function (xhr, status, error) {
                notyf.error('Cevap gönderilirken bir sorun oluştu');
                $('#responseMessage').html('<p>Hata: ' + error + '</p>');
            }
        });
    });
});