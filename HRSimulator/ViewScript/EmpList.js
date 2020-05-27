
function getEmp() {
    $.busyLoadSetup({ spinner: "circles", text: "กำลังดึงรายชื่อพนักงาน", animation: "fade", background: "rgba(0, 0, 0, 0.80)" });
    $.busyLoadFull("show");
    $.ajax({
        url: "/Employee/EmpList",
        type: "GET",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        error: function () {
            $.busyLoadFull("hide")
            swal(
                'พบข้อผิดพลาด',
                'ไม่สามารถโหลดข้อมูลตำแหน่งงานในระบบได้ กรุณาลองใหม่อีกครั้ง',
                'error'
            )
        },
        success: function (response) {
            var stringify = JSON.parse(JSON.stringify(response));
            for (var i = 0; i < stringify.length; i++) {
                $('#EmpData').DataTable({
                    columns: [
                        {
                            width: 120,
                            data: stringify[i]['code']
                        },
                        {
                            width: 200,
                            data: "name"
                        },
                        {
                            width: 150,
                            data: "ar_number"
                        },
                        {
                            width: 150,
                            data: "status",
                            render: function (data, type) {
                                var text = '';
                                (data == "ACTIVE") ? text = 'ใช้งาน' : text = 'ยกเลิกใช้งาน';
                                return text;
                            }
                        },
                        {
                            width: 60,
                            render: function (data) {
                                var button = '<a href="#" class="view pr-1"><i class="fas fa-search"></i></a>';
                                button += '<a href="#" class="edit pr-1"><i class="fas fa-pencil-alt"></i></a>';
                                button += '<a data-toggle="modal" class="DeleteFunc pr-1"><i class="fas fa-trash-alt"></i></a>';
                                return button;
                            }
                        },

                    ],
                }),
                    $.busyLoadFull("hide");
            };
        },
    });
}
