function getJob(ddl_id) {
     $.busyLoadSetup({ spinner: "circles", text: "กำลังดึงข้อมูลตำแหน่งงาน", animation: "fade", background: "rgba(0, 0, 0, 0.80)" });
    
    $.busyLoadFull("show");
    var getJobList = new Object();
    getJobList.action = 1;

    return new Promise(resolve => {
        setTimeout(() => {
            resolve($.ajax({
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
                success: function (data) {
                    if (!data.onError) {
                        data.getItems = jQuery.parseJSON(data.getItems);
                        $.each((data.getItems), function (index, e) {
                            let item = $("<option/>");
                            $(item).attr("value", e.code).text(e.JobName);
                            $(ddl_id).append($(item));
                        });
                        $.busyLoadFull("hide");
                    } else {
                        $.busyLoadFull("hide")
                        swal(
                            'พบข้อผิดพลาด',
                            'ไม่พบข้อมูลในระบบ กรุณาเพิ่มข้อมูลตำแหน่งงาน',
                            'error'
                        )
                    }
                }
            }));
        }, 100);
    });
} 