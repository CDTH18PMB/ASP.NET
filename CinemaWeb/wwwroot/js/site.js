// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
showModal = (url, title) => {
    $.ajax({
        type: "GET",
        url: url,
        success: function (res) {
            $("#form-modal .modal-body").html(res);
            $("#form-modal .modal-title").html(title);
            $("#form-modal").modal("show");
        }
    })
}

//okie = () => {
//    alert("hiiiiiiiiiiiii");
//}
AddOrEdit = form => {
    try {
        $.ajax({
            type: 'POST',
            url: form.action,
            data: new FormData(form),
            contentType: false,
            processData: false,
            success: function (res) {
                if (res.isValid) {
                    $('#view-index').html(res.html)
                    $('#form-modal .modal-body').html('');
                    $('#form-modal .modal-title').html('Thành Công');
                    $('#form-modal').modal('show');
                }
                else
                    $('#form-modal .modal-body').html(res.html);
            },
            error: function (err) {
                console.log(err)
            }
        })
        return false;
    } catch (ex) {
        console.log(ex)
    }
}

Delete = form => {
    if (confirm("Bạn có muốn Xoá không ?")) {
        try {
            $.ajax({
                type: 'POST',
                url: form.action,
                data: new FormData(form),
                contentType: false,
                processData: false,
                success: function (res) {
                    $('#view-index').html(res.html)
                    $('#form-modal .modal-body').html('');
                    $('#form-modal .modal-title').html('Thành Công');
                    $('#form-modal').modal('show');
                },
                error: function (err) {
                    alert("Lỗi error");
                }
            })
        } catch (ex) {
            alert("Lỗi catch");
        }
    }
    return false;
}

