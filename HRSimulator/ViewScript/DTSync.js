function getDT() {
            var getDay, getDate, getMonth, getYear, getHour,getMinute,getSec,workStat,workstring;

    $.getJSON('https://script.googleusercontent.com/macros/echo?user_content_key=nVc9AumQ-RW8Bsp7yfd8Do_jeHh7jv5zB-yQ19p4sJPRTMnOp3IMS-oX4-HDnzDzWELIhzsDMyQoXT0hwJAwpZq7q2y10oaPm5_BxDlH2jW0nuo2oDemN9CCS2h10ox_1xSncGQajx_ryfhECjZEnJ9GRkcRevgjTvo8Dc32iw_BLJPcPfRdVKhJT5HNzQuXEeN3QFwl2n0M6ZmO-h7C6bwVq0tbM60-uGhoxl1-0xZ49QdGJB90pQ&lib=MwxUjRcLr2qLlnVOLh12wSNkqcO1Ikdrk', function (data) {
        getDay = data.dayofweek;
        getDate = data.day;
        getMonth = data.month;
        getYear = data.year + 543;
        getHour = String(data.hours).padStart(2, '0');
        getMinute = String(data.minutes).padStart(2, '0');
        getSec = String(data.seconds).padStart(2, '0');
        timestring = data.hours + getMinute + getSec;
        if (getDay >= 1 && getDay <= 5) {
            if (timestring >= 83000 && timestring <= 173000) {
                workStat = 0;
            } else {
                workStat = 1;
            }
        } else {
            workStat = 2;
        }

        var monthString;

        if (workStat == 0) {
            workstring = 'บริษัทเปิดทำการ';
        } else if (workStat == 1) {
            workstring = 'บริษัทอยู่นอกเวลาทำการ';
        } else if (workStat == 2) {
            workstring = 'บริษัทปิดทำการในวันเสาร์-อาทิตย์'
        }

        if (getMonth == 1) {
            monthString = 'มกราคม'
        } else if (getMonth == 2) {
            monthString = 'กุมภาพันธ์'
        } else if (getMonth == 3) {
            monthString = 'มีนาคม'
        } else if (getMonth == 4) {
            monthString = 'เมษายน'
        } else if (getMonth == 5) {
            monthString = 'พฤษภาคม'
        } else if (month == 6) {
            monthString = 'มิถุนายน'
        } else if (month == 7) {
            monthString = 'กรกฎาคม'
        } else if (month == 8) {
            monthString = 'สิงหาคม'
        } else if (month == 9) {
            monthString = 'กันยายน'
        } else if (month == 10) {
            monthString = 'ตุลาคม'
        } else if (month == 11) {
            monthString = 'พฤศจิกายน'
        } else if (month == 12) {
            monthString = 'ธันวาคม'
        }

        var currentDateString = "วันที่ " + getDate + " " + monthString + " พ.ศ. " + getYear;
        var currentTimeString = "เวลา " + getHour + ":" + getMinute + ":" + getSec;

        $("#date").html(currentDateString);
        $("#clock").html(currentTimeString);
        $("#workstat").html(workstring);

        $('#workstat').click(function () {
            if (workStat == 0) {
                swal(
                    {
                        text: 'ช่วงวันเวลาเปิดทำการ ทุกฟังก์ชันในระบบเปิดใช้งานตามปกติ',
                        type: 'info',
                        showCancelButton: false,
                        confirmButtonClass: 'btn btn-success'
                    }
                )
            } else if (workStat == 1) {
                swal(
                    {
                        text: 'ช่วงนอกเวลาทำการ คุณสามารถส่งใบลาได้ทุกประเภท และสามารถบันทึกเวลาเลิกงานไม่เกิน 20.00 น.',
                        type: 'info',
                        showCancelButton: false,
                        confirmButtonClass: 'btn btn-success'
                    }
                )
            } else if (workStat == 2) {
                swal(
                    {
                        text: 'ช่วงนอกเวลาทำการ (วันหยุดนักขัตฤกษ์) คุณสามารถส่งใบลาได้ทุกประเภท ยกเว้นลาป่วย และไม่สามารถบันทึกเวลาทำงานล่วงหน้าหรือย้อนหลังได้',
                        type: 'info',
                        showCancelButton: false,
                        confirmButtonClass: 'btn btn-success'
                    }
                )
            }
        })
    });

            var i = 1;
    if (i == 0) {
                $(document).bind("contextmenu", function (e) {
                    swal(
                        {
                            text: 'Right-Click was disabled from this site for system security reason. To Cut, Copy or Paste any text Please use following shortcut (Ctrl + X), (Ctrl + C) or (Ctrl + V).',
                            type: 'info',
                            showCancelButton: false,
                            confirmButtonClass: 'btn btn-success'
                        }
                    )
                    e.preventDefault();
                });
                $(document).keydown(function (e) {
                    if (e.which === 123) {
                        swal(
                            {
                                text: 'Inspect Element was disabled from this site for system security reason.',
                                type: 'info',
                                showCancelButton: false,
                                confirmButtonClass: 'btn btn-success'
                            }
                        )
                        return false;
                    }
                });

        console.clear();
            }
}
