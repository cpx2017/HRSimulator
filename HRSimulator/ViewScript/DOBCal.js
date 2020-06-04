function BirthAge(DOB, AgeOut) {
    $('#E_Birthdate').change(function () {
        $.busyLoadSetup({ spinner: "circles", text: "กำลังคำนวนอายุปัจจุบัน", animation: "fade", background: "rgba(0, 0, 0, 0.80)" });
        $.busyLoadFull("show");
        var birthDay = DOB;
        var BirOD = new Date(birthDay);
        var today = new Date();
        var age = today.getTime() - BirOD.getTime();
        age = Math.floor(age / (1000 * 60 * 60 * 24 * 365.25));
        if (age <= 0) {
            $(AgeOut).val(0)
        } else {
            $(AgeOut).val(age)
        }

        $.busyLoadFull("hide");
    })
    
}