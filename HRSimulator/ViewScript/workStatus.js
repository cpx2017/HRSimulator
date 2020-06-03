function getWorkDetail() {
    var getDay, getDate, getMonth, getMinute, getSec;

    $.getJSON('https://script.google.com/macros/s/AKfycbyd5AcbAnWi2Yn0xhFRbyzS4qMq1VucMVgVvhul5XqS9HkAyJY/exec?tz=Asia/Bangkok', function (data) {
        getDay = data.dayofweek;
        getDate = data.day;
        getMonth = data.month;
        getYear = data.year + 543;
        getHour = String(data.hours).padStart(2, '0');
        getMinute = String(data.minutes).padStart(2, '0');
        getSec = String(data.seconds).padStart(2, '0');
        timestring = data.hours + getMinute + getSec;
        if (getDay >= 1 && getDay <= 5) {
                    $.getJSON('https://getfestivo.com/v2/holidays?api_key=e5604303b65ccba1f53ed2572e1449b7&country=TH&year=' + data.year + '&month=' + getMonth + '&day=' + getDate, function (holiday) {
                        if (holiday.holidays != '') {
                            $("#workstat").html('วันหยุดนักขัตฤกษ์');
                        } else {
                            if (timestring >= 83000 && timestring <= 173000) {
                                $("#workstat").html('บริษัทเปิดทำการ');
                            } else {
                                $("#workstat").html('บริษัทอยู่นอกเวลาทำการ');
                            }
                        }
                    })
        } else {
            $("#workstat").html('บริษัทปิดทำการในวันเสาร์-อาทิตย์');
        }

        var workStatusStr = $('#workstat').html();
        $('#workstat').click(function () {
            if (workStatusStr == 'บริษัทเปิดทำการ') {
                swal(
                    {
                        text: 'ช่วงวันเวลาเปิดทำการ ทุกฟังก์ชันในระบบเปิดใช้งานตามปกติ',
                        type: 'info',
                        showCancelButton: false,
                        confirmButtonClass: 'btn btn-success'
                    }
                )
            } else if (workStatusStr == 'บริษัทอยู่นอกเวลาทำการ') {
                swal(
                    {
                        text: 'ช่วงนอกเวลาทำการ คุณสามารถส่งใบลาได้ทุกประเภท และสามารถบันทึกเวลาเลิกงานไม่เกิน 20.00 น.',
                        type: 'info',
                        showCancelButton: false,
                        confirmButtonClass: 'btn btn-success'
                    }
                )
            } else if (workStatusStr == 'บริษัทปิดทำการในวันเสาร์-อาทิตย์') {
                swal(
                    {
                        text: 'ช่วงนอกเวลาทำการ (วันเสาร์-อาทิตย์) คุณสามารถส่งใบลาได้ทุกประเภท ยกเว้นลาป่วย และไม่สามารถบันทึกเวลาทำงานล่วงหน้าหรือย้อนหลังได้',
                        type: 'info',
                        showCancelButton: false,
                        confirmButtonClass: 'btn btn-success'
                    }
                )
            } else if (workStatusStr == 'วันหยุดนักขัตฤกษ์') {
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

  

}
