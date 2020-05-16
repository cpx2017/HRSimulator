function updateClock() {
    var currentTime = new Date();
    var currentHours = currentTime.getHours();
    var currentMinutes = currentTime.getMinutes();
    var currentSeconds = currentTime.getSeconds();
    var day = currentTime.getDay();
    var date = currentTime.getDate();
    var month = currentTime.getMonth() + 1;
    var year = currentTime.getFullYear() + 543;

    // Pad the minutes and seconds with leading zeros, if required
    currentMinutes = (currentMinutes < 10 ? "0" : "") + currentMinutes;
    currentSeconds = (currentSeconds < 10 ? "0" : "") + currentSeconds;

    // Convert an hours component of "0" to "12"
    currentHours = (currentHours == 0) ? 23 : currentHours;
    var workStat;
    

    if (day >= 1 && day <= 5) {
        var startTime = '8:30:00 AM';
        var endTime = '5:30:00 PM';
        var now = new Date();

        var startDate = dateObj(startTime); // get date objects
        var endDate = dateObj(endTime);

        if (startDate > endDate) { // check if start comes before end
            var temp = startDate; // if so, assume it's across midnight
            startDate = endDate;   // and swap the dates
            endDate = temp;
        }
        workStat = now < endDate && now > startDate ? 'บริษัทเปิดทำการ' : 'บริษัทอยู่นอกเวลาทำการ';

    } else {
        workStat = 'บริษัทปิดทำการในวันเสาร์-อาทิตย์'
    }

    var monthString;
    if (month == 1) {
        monthString = 'มกราคม'
    } else if (month == 2) {
        monthString = 'กุมภาพันธ์'
    } else if (month == 3) {
        monthString = 'มีนาคม'
    } else if (month == 4) {
        monthString = 'เมษายน'
    } else if (month == 5) {
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
    // Compose the string for display
    var currentDateString = "วันที่ " + date + " " + monthString + " พ.ศ. " + year;
    var currentTimeString = "เวลา " + currentHours + ":" + currentMinutes + ":" + currentSeconds;

    $("#date").html(currentDateString);
    $("#clock").html(currentTimeString);
    $("#workstat").html(workStat);

    $('#workstat').click(function () {
        if (workStat == 'บริษัทเปิดทำการ') {
            swal(
                {
                    text: 'ช่วงวันเวลาเปิดทำการ ทุกฟังก์ชันในระบบเปิดใช้งานตามปกติ',
                    type: 'info',
                    showCancelButton: false,
                    confirmButtonClass: 'btn btn-success'
                }
            )
        } else if (workStat == 'บริษัทอยู่นอกเวลาทำการ') {
            swal(
                {
                    text: 'ช่วงนอกเวลาทำการ คุณสามารถส่งใบลาได้ทุกประเภท และสามารถบันทึกเวลาเลิกงานไม่เกิน 20.00 น.',
                    type: 'info',
                    showCancelButton: false,
                    confirmButtonClass: 'btn btn-success'
                }
            )
        } else if (workStat == 'บริษัทปิดทำการในวันเสาร์-อาทิตย์') {
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

    //$(document).bind("contextmenu", function (e) {
    //    swal(
    //        {
    //            text: 'Right-Click was disabled from this site for security reason. To Cut, Copy or Paste any text Please use following shortcut (Ctrl + X), (Ctrl + C) or (Ctrl + V).',
    //            type: 'info',
    //            showCancelButton: false,
    //            confirmButtonClass: 'btn btn-success'
    //        }
    //    )
    //    e.preventDefault();
    //});
    //$(document).keydown(function (e) {
    //    if (e.which === 123) {
    //        swal(
    //            {
    //                text: 'Inspect Element was disabled from this site for security reason.',
    //                type: 'info',
    //                showCancelButton: false,
    //                confirmButtonClass: 'btn btn-success'
    //            }
    //        )
    //        return false;
    //    }
    //});
}