function getWeather() {
    $.busyLoadSetup({ spinner: "circles", text: "กำลังดึงข้อมูลสภาพอากาศ", animation: "fade", background: "rgba(0, 0, 0, 0.80)" });
    $.busyLoadFull("show");
    $.ajax({
        url: "/Home/Weather",
        type: "GET",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        error: function () {
            $.busyLoadFull("hide")
            swal(
                'ขออภัย ระบบเกิดข้อผิดพลาดในการโหลดข้อมูลสภาพอากาศและพิกัดในขณะนี้',
                'คำแนะนำ: เลือกการเชื่อมต่อเครือข่ายเป็น WiFi ชื่ออื่น หรือ Cellular หรือปิด VPN',
                'error'
            )
        },
        success: function (response) {
            var stringify = JSON.parse(JSON.stringify(response));
            $('#temper').text('อุณหภูมิตอนนี้ ' + stringify['Temp'].toFixed(1) + '°C (รู้สึกได้ ' + stringify['FeelTemp'].toFixed(1) + '°C)');
            $('#weather').text(stringify['WeatherHead'] + ', ' + stringify['WeatherDetail']);

            $.busyLoadFull("hide");
        }
    });
}