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
                'พบข้อผิดพลาด',
                'ขออภัย ระบบเกิดข้อผิดพลาดในการโหลดข้อมูลสภาพอากาศและพิกัดในขณะนี้',
                'error'
            )
        },
        success: function (response) {
            var stringify = JSON.parse(JSON.stringify(response));
            $('#temper').text('อุณหภูมิตอนนี้ ' + stringify['Temp'].toFixed(0) + '°C (รู้สึกได้ ' + stringify['FeelTemp'].toFixed(0) + '°C)');
            $('#weather').text(stringify['WeatherHead'] + ', ' + stringify['WeatherDetail']);
            $('#locate').text('สถานที่ปัจจุบัน ' + stringify['CityinThai'] + ', ' + stringify['Country']);

            if (stringify['WeatherHead'] == 'Clouds') {
                $("#weathericon").addClass("mdi mdi-weather-cloudy");
            }
            else if (stringify['WeatherHead'] == 'Rain') {
                $("#weathericon").addClass("mdi mdi-weather-rainy");
            }
            else if (stringify['WeatherHead'] == 'Drizzle') {
                $("#weathericon").addClass("mdi mdi-weather-pouring");
            }
            else if (stringify['WeatherHead'] == 'Thunderstorm') {
                $("#weathericon").addClass("mdi mdi-weather-lightning");
            }
            else if (stringify['WeatherHead'] == 'Clear') {
                $("#weathericon").addClass("mdi mdi-weather-sunny");
            }
            else if (stringify['WeatherHead'] == 'Fog') {
                $("#weathericon").addClass("mdi mdi-weather-fog");
            } else {
                $("#weathericon").addClass("mdi mdi-weather-partlycloudy");
            }
            $.busyLoadFull("hide");
        }
    });
}