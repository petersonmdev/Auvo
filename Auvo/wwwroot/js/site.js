// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $('#single-select-field').select2({
        theme: "bootstrap-5",
        width: $(this).data('width') ? $(this).data('width') : $(this).hasClass('w-100') ? '100%' : 'style',
        placeholder: $(this).data('placeholder')
    });

    $('#single-select-field').on('select2:select', function (e) {
        var cidadeId = e.params.data.id;
        $.ajax({
            url: 'home/getprevisao',
            type: 'POST',
            data: { id: cidadeId },
            contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
            success: function (data) {
                $("#content-previsao-week").html(data)
            },
            error: function (error) {
                alert(error);
            }
        });
    });
});

