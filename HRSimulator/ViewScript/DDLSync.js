function getJob(ddl_id) {
    $(document).ready(function () {
        $.busyLoadSetup({ spinner: "circles", text: "กำลังดึงข้อมูลตำแหน่งงาน", animation: "fade", background: "rgba(0, 0, 0, 0.80)" });
        $.busyLoadFull("show");
        var getJobList = new Object();
        getJobList.action = 1;

        $.ajax({
            url: "/MasterDDLSync/JobDDLFunc",
            data: JSON.stringify(getJobList),
            type: "POST",
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
                    $(ddl_id).append($('<option>', {
                        value: stringify[i]['code'],
                        text: stringify[i]['JobName']
                    }));
                }
                $.busyLoadFull("hide");
            }
        });
});
}