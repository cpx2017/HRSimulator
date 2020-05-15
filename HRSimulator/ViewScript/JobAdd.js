
function event_click() {
    $('#btn_Save').click(function () {
        $.busyLoadSetup({ spinner: "circles", text: "กำลังเพิ่มข้อมูลในระบบ", animation: "fade", background: "rgba(0, 0, 0, 0.80)" });
        var insertJob = new Object();
        insertJob.JobName = $('#JobName').val();
        $.busyLoadFull("show");
        $.ajax({
            url: "/Job/insert",
            data: JSON.stringify(insertJob),
            type: "POST",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            error: function () {
                $.busyLoadFull("hide")
                swal(
                    'พบข้อผิดพลาด',
                    'ไม่สามารถบันทึกข้อมูลในระบบได้ กรุณาลองใหม่อีกครั้ง',
                    'error'
                )
            },
            success: function (response) {
                if (response.errorcode == 0) {
                    window.location.href = "/Home/Home"
                    $.busyLoadFull("hide")
                } else {
                    $.busyLoadFull("hide")
                    swal(
                        'พบข้อผิดพลาด',
                        'ข้อมูลซ้ำกันในระบบ กรุณาลองใหม่',
                        'error'
                    )
                }
            }
        });
    });
}

