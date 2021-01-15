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

//============================================= Book ticket ==========================================================

var strGhe = ''; var count = 0; var total = 0;

//Chọn phim
$('.label_Phim').off('click').on('click', function (e) {
    e.preventDefault();

    // hiện thẻ div yêu cầu chọn phim
    $('#div_Message').prop('hidden', false);

    //ẩn thẻ div chọn ghế
    $('#div_dsGhe').prop('hidden', true);

    //modal loading chờ load dữ liệu
    $('#Loading').modal('show');

    // thay đổi màu sắc của label không được chọn
    $('.label_Phim').css({ 'background-color': 'white', 'color': 'black' });

    var data = $(this).data('id'); // lấy dữ liệu của label khi click vào

    var splitString = data.split("."); // cắt chuỗi
    var maPhim = splitString[0]; // mã phim
    var tenPhim = splitString[1]; // tên phim

    // load Suất chiếu
    $.ajax({
        url: "BookTicket/Load_LichChieu/" + maPhim, // đường dẫn đến file xử lý
        type: "GET",
        dataType: "json",
        success: function (response) {
            //ẩn model loading
            $("#Loading").removeClass("in");
            $(".modal-backdrop").remove();
            $("#Loading").hide();

            if (response.status) { // nếu thành công
                var data = response.data;

                var html = '';
                var template = $('#lstLichChieu').html();

                // render html
                $.each(data, function (index, item) {
                    html += Mustache.render(template, {
                        ngayChieu: item.ngayChieu.split('T')[0],
                        maLichChieu: item.maLichChieu,
                        maPhong: item.phong,
                        thoiGian: item.thoiGian.hours + ':' + item.thoiGian.minutes,
                        soGheTrong: item.soGheTrong,
                        dsLichChieu: response.total
                    });
                });

                $('#DanhSachSuatChieu').html(html);
                $('body').css('overflow', "auto");
            } else {
                alert("Lỗi");
            }
        }
    });

    // đổ tên phim vào input
    document.forms["bookTicket"]["TenPhim"].value = tenPhim;
    document.forms["bookTicket"]["MaPhim"].value = maPhim;

    // xóa suất chiếu + phòng
    document.forms["bookTicket"]["SuatChieu"].value = "";
    document.forms["bookTicket"]["Phong"].value = "";

    //đánh dấu đang chọn
    $(this).css({ 'background-color': 'black', 'color': 'white' });
});

//chọn suất
function ChooseMovieSchedule(data) {
    // ẩn thẻ div yêu cầu chọn phim
    $('#div_Message').prop('hidden', true);

    //hiện thẻ div chọn ghế
    $('#div_dsGhe').prop('hidden', false);

    //Xóa ghế đang chọn
    Reset();

    // thay đổi màu sắc của label không được chọn
    $('.label_SuatChieu').css({ 'background-color': 'white', 'color': 'black' });

    var splitString = data.split(" "); // cắt chuỗi
    var maSuatChieu = splitString[0]; // mã suât chiếu
    var ngayChieu = splitString[1].split("T"); // ngày chiếu
    var thoiGian = splitString[2]; // thời gian
    var maPhong = splitString[3]; // mã phòng
    var soGheTrong = splitString[4]; // số ghế trống

    // load ghế theo phòng chiếu
    $.ajax({
        url: "BookTicket/Load_Ghe/" + maSuatChieu,
        type: "GET",
        dataType: "json",
        success: function (response) {
            if (response.status) {
                var data = response.data;

                // số lượng ghế
                var count = response.count;
                var TenGhe; var TrangThai;

                for (var i = 0; i < count; i++) {
                    TenGhe = data[i]['tenGhe'];
                    TrangThai = data[i]['trangThai'];

                    // nếu trạng thái là true (có nghĩa đã được mua) thì tô màu mà disabled không cho chọn
                    if (TrangThai) {
                        $('#' + TenGhe).css({ 'background-color': 'dodgerblue', 'color': 'black' });
                        $('#' + TenGhe).prop('disabled', true);
                    } else {
                        $('#' + TenGhe).css({ 'background-color': 'white', 'color': 'black' });
                        $('#' + TenGhe).prop('disabled', false);
                    }
                }
            }
        }
    });


    // đổ dữ liệu vào input
    document.forms["bookTicket"]["SuatChieu"].value = ngayChieu[0] + ' | ' + thoiGian;
    document.forms["bookTicket"]["MaSuatChieu"].value = maSuatChieu;
    document.forms["bookTicket"]["Phong"].value = maPhong;

    $('#label_SuatChieu_' + maSuatChieu).css({ 'background-color': 'black', 'color': 'white' });
}

//Chọn Ghế
$('.button_Seat').off('click').on('click', function (e) {
    e.preventDefault();

    var data = $(this).data('id');
    var Ghe = String(data); // chuyển san kiểu chuỗi
    var doDaiGhe = Ghe.length; // lấy độ dài chuỗi của Ghế

    //nếu ghế được chọn
    if (strGhe.search(Ghe) != -1) {
        // bỏ chọn ghế và cập nhật tổng tiền
        var seat, temp;

        // xóa Ghế ra khỏi chuỗi str
        if (doDaiGhe < 3) { // (A1->A9) có độ dài chuỗi của Ghế là 2 nên sẽ xóa 3 ký tự
            // nếu số ghế < 10 (vd: A1->A9) thì lấy ra số ghế + khoảng trắng (A1 ) và thay thế rỗng
            seat = strGhe.substr(strGhe.indexOf(Ghe), 3);
            temp = strGhe.replace(seat, '');
        } else { // (A10->A15) có độ dài chuỗi của Ghế là 3 nên sẽ xóa 4 ký tự
            seat = strGhe.substr(strGhe.indexOf(Ghe), 4);
            temp = strGhe.replace(seat, '');
        }

        //gán lại chuỗi đã cập nhật
        strGhe = temp;

        //cập nhật tổng tiền
        count--;
        total = 100000 * count;

        //bỏ đánh dấu và xuất số ghế đang chọn lên input
        document.forms["bookTicket"]["Ghe"].value = strGhe;
        document.forms["bookTicket"]["TongTien"].value = total;

        $(this).css({ 'background-color': 'white', 'color': 'black' });
    } else { // nếu ghế chưa được chọn
        if (count == 10) {
            $('#Maximum').modal();
            return; // không cho chọn nữa
        }
        strGhe += Ghe + ' '; // cộng chuỗi
        count++; // đếm số ghế
        total = 100000 * count; // tính tổng tiền

        // đổ dữ liệu vào input
        document.forms["bookTicket"]["Ghe"].value = strGhe;
        document.forms["bookTicket"]["TongTien"].value = total;

        //đánh dấu
        $(this).css({ 'background-color': 'black', 'color': 'white' });
    }
});

//Chọn lại ghế
function Reset() {
    //cập nhật lại trạng thái ban đầu của ghế
    count = 0; total = 0;

    var arr = strGhe.split(" ");
    for (var i = 0; i < arr.length; i++) {
        $('#' + arr[i]).css({ 'background-color': 'white', 'color': 'black' });
    }

    strGhe = '';

    document.forms["bookTicket"]["Ghe"].value = strGhe;
    document.forms["bookTicket"]["TongTien"].value = '';
}

//Thanh toán
$('#btnThanhToan').off('click').on('click', function (e) {
    e.preventDefault();

    // lấy thông tin phim + suất + ghế + tổng tiền
    var Username = $('#Username').val();
    var MaPhim = $('#MaPhim').val();
    var MaSuatChieu = $('#MaSuatChieu').val();
    var NgayMua = $('#SuatChieu').val();
    var Phong = $('#Phong').val();
    var Ghe = $('#Ghe').val();
    var TongTien = $('#TongTien').val();

    // nếu thông tin còn thiếu
    if (MaPhim == "" || MaSuatChieu == "" || Phong == "" || Ghe == "" || TongTien == "") {
        // thông báo modal thất bại
        $('#BookTicketFail').modal();
    } else {
        var data = {
            Username: Username,
            MaPhim: MaPhim,
            MaSuatChieu: MaSuatChieu,
            NgayMua: NgayMua,
            Phong: Phong,
            Ghe: Ghe,
            TongTien: TongTien
        };

        $.ajax({
            url: 'BookTicket/ThanhToan',
            type: "POST",
            dataType: "json",
            data: { data: JSON.stringify(data) },
            success: function (response) {
                if (response.status) {
                    // khi thanh toán thành công thì thực hiện cập nhật trạng thái ghế
                    var arrGhe = response.maghe;
                    console.log(arrGhe);

                    $.ajax({
                        url: "API/GheAPI/UpdateStatus/",
                        type: "POST",
                        contentType: "application/json, charset=UTF-8",
                        data: JSON.stringify({ "MaLichChieu": MaSuatChieu, "arrMaGhe": arrGhe, "TrangThai": true }),
                        success: function (response) {
                            if (response == '0') {
                                alert('Cập nhật thất bại');
                            } else {
                                if (response == 'success') {
                                    // xóa thông tin
                                    $('#TenPhim').val('');
                                    $('#MaPhim').val('');
                                    $('#MaSuatChieu').val('');
                                    $('#SuatChieu').val('');
                                    $('#Phong').val('');
                                    $('#Ghe').val('');
                                    $('#TongTien').val('');

                                    // hiển thị modal thành công
                                    $('#BookTicketSuccessful').modal({ backdrop: "static" });
                                }
                            }
                        }
                    });
                } else {
                    alert("Không lập được hóa đơn");
                }
            }
        });
    }
});


//================================== Trang chi tiết ==========================================

//Kiểm tra đăng nhập trước khi đặt vé
$('#buttonBookTicket').off('click').on('click', function (e) {
    e.preventDefault();
    var Username = $('#Username').val();
    if (Username == '') {
        $('#CommentMissingUsername').modal();
        return;
    }

    $(location).attr('href', '../../BookTicket');
});

//Đăng bình luận
$('#PostComment').off('click').on('click', function (e) {
    e.preventDefault();

    var Username = $('#Username').val();
    var MaPhim = $('#MaPhim').val();
    var NoiDung = $('#CommentContent').val();

    if (Username == '') {
        $('#CommentMissingUsername').modal();
        return;
    } else if (NoiDung == '') {
        $('#CommentMissingContent').modal();
        return;
    }

    var data = {
        MaPhim: MaPhim,
        Username: Username,
        NoiDung: NoiDung
    };

    $.ajax({
        url: '../../Home/PostBinhLuan',
        type: "POST",
        dataType: 'json',
        data: { data: JSON.stringify(data) },
        success: function (response) {
            if (response.status) {
                $('#CommentContent').val('');
                $('#CommentSuccessful').modal();
            }
        }
    });
});

//load danh sách bình luận
$(function () {
    var check = document.getElementById('LoadComment');
    if (check == null) {
        return
    } else {
        var MaPhim = $('#MaPhim').val();

        $.ajax({
            url: '../../Home/LoadBinhLuan/' + MaPhim,
            type: 'GET',
            dataType: 'json',
            success: function (response) {
                if (response.status) {
                    var data = response.data;
                    var html = '';
                    var template = $('#listBinhLuan').html();

                    // nếu phim chưa có bình luận nào
                    if (data[0] == null) {
                        html += "<hr/><center><h4>Phim hiện chưa có bình luận nào</h4></center><hr/>"
                        $('#LoadComment').html(html);
                    } else {
                        // render html
                        $.each(data, function (index, item) {
                            var ngayDang = item.ngayDang.split("T");
                            var ngay = ngayDang[0]; // lấy ngày
                            var thoiGian = ngayDang[1].split(":")[0] + ':' + ngayDang[1].split(":")[1]; // lấy giờ
                            html += Mustache.render(template, {
                                NguoiDang: item.nguoiDang,
                                NoiDung: item.noiDung,
                                NgayDang: ngay + ' | ' + thoiGian
                            });
                        });

                        $('#LoadComment').html(html);
                    }
                }
            }
        });
    }
});

