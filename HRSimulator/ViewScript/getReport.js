
function event_click() {
    $('#btn_Save').click(function () {
        var pattern = /^[A-Z0-9._%+-]+@([A-Z0-9-]+\.)+[A-Z]{2,4}$/i;
        if ($('input textarea').val() != '' && $('select').val() != '') {
            if (!pattern.test($('#Mail').val())) {
                swal(
                    'พบข้อผิดพลาด',
                    'อีเมล์ไม่ถูกต้อง กรุณาตรวจสอบอีเมล์ของคุณ',
                    'error'
                )
            } else {
                $.busyLoadSetup({ spinner: "circles", text: "กำลังส่งแบบรายงานไปยังผู้พัฒนาระบบ", animation: "fade", background: "rgba(0, 0, 0, 0.80)" });
                var report = new Object();
                report.name = $('#Name').val();
                report.email = $('#Mail').val();
                report.type = $('#type').val();
                report.title = $('#header').val();
                report.detail = $('#detail').val();
                $.busyLoadFull("show");
                $.ajax({
                    url: "/report/sendReport",
                    data: JSON.stringify(report),
                    type: "POST",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    error: function () {
                        $.busyLoadFull("hide")
                        swal(
                            'พบข้อผิดพลาด',
                            'ไม่สามารถส่งรายงานปัญหาในระบบได้ กรุณาลองใหม่อีกครั้ง',
                            'error'
                        )
                    },
                    success: function (response) {
                        if (response.errorcode == 0) {
                            $.busyLoadFull("hide")
                            swal(
                                'รายงานข้อผิดพลาดเรียบร้อย',
                                'ระบบส่งแบบรายงานปัญหาระบบเรียบร้อยแล้ว ผู้พัฒนาจะดำเนินแก้ไขระบบตามคำขอภายใน 3-5 วัน ขออภัยในความไม่สะดวก',
                                'success'
                            )
                            $('#Name').val('');
                            $('#Mail').val('');
                           $('#type').val('');
                            $('#header').val('');
                            $('#detail').val('');
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
            }
            
        } else {
            swal(
                'พบข้อผิดพลาด',
                'กรุณากรอกข้อมูลให้ครบทุกช่อง',
                'error'
            )
        }
    });
}

