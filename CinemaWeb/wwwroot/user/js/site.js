showEdit = (url, title) => {
    $.ajax({
        type: "GET",
        url: url,
        success: function (xong) {
            $("#form-modal .modal-title").html(title);
            $("#form-modal .modal-body").html(xong);
            $("#form-modal").modal("show");
        }
    })
}