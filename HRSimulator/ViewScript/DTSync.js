function getDT() {
            var getDay, getDate, getMonth, getYear, getHour,getMinute,getSec,workStat,workstring;

    $.getJSON('https://script.google.com/macros/s/AKfycbyd5AcbAnWi2Yn0xhFRbyzS4qMq1VucMVgVvhul5XqS9HkAyJY/exec?tz=Asia/Bangkok', function (data) {
        getDay = data.dayofweek;
        getDate = data.day;
        getMonth = data.month;
        getYear = data.year + 543;
        getHour = String(data.hours).padStart(2, '0');
        getMinute = String(data.minutes).padStart(2, '0');
        getSec = String(data.seconds).padStart(2, '0');
        timestring = data.hours + getMinute + getSec;
   
        var monthString;

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
        } else if (getMonth == 6) {
            monthString = 'มิถุนายน'
        } else if (getMonth == 7) {
            monthString = 'กรกฎาคม'
        } else if (getMonth == 8) {
            monthString = 'สิงหาคม'
        } else if (getMonth == 9) {
            monthString = 'กันยายน'
        } else if (getMonth == 10) {
            monthString = 'ตุลาคม'
        } else if (getMonth == 11) {
            monthString = 'พฤศจิกายน'
        } else if (getMonth == 12) {
            monthString = 'ธันวาคม'
        }

        var currentDateString = "วันที่ " + getDate + " " + monthString + " พ.ศ. " + getYear;
        var currentTimeString = "เวลา " + getHour + ":" + getMinute + ":" + getSec;

        $("#date").html(currentDateString);
        $("#clock").html(currentTimeString);
    });

   
}
