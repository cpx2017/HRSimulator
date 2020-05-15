<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=0, minimal-ui">
    <title>หน้าหลัก</title>
    <meta content="Admin Dashboard" name="description" />
    <meta content="Mannatthemes" name="author" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />

    <!-- Default Class -->
    <link rel="shortcut icon" href="~/Content/System/image/favicon.ico">
    <link href="~/Content/System/css/sweetalert2.min.css" rel="stylesheet" type="text/css">


    <!-- Extension Class -->

</head>


<body class="fixed-left">

    <div class="row">
        <div class="col-sm-12">
            <div class="page-title-box">
                <div class="btn-group float-right">
                    <ol class="breadcrumb hide-phone p-0 m-0">
                        <li class="breadcrumb-item"><a href="#">HR Simulator</a></li>
                        <li class="breadcrumb-item active">หน้าหลัก</li>
                    </ol>
                </div>
                <h4 class="page-title">หน้าหลัก</h4>
            </div>
        </div>
    </div>
    <!-- end page title end breadcrumb -->


    <div class="row">
        <!-- Column -->
        <div class="col-md-6 col-lg-6 col-xl-4" id="TimestampModal">
            <div class="card m-b-30">
                <div class="card-body">
                    <div class="d-flex flex-row">
                        <div class="col-3 align-self-center">
                            <div class="round">
                                <i class="mdi mdi-calendar-clock"></i>
                            </div>
                        </div>
                        <div class="col-8 align-self-center text-center">
                            <div class="m-l-10">
                                <h5 class="mt-0 round-inner">10 คน</h5>
                                <p class="mb-0 text-muted">จำนวนพนักงานเข้าทำงานวันนี้</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Column -->
        <!-- Column -->
        <div class="col-md-6 col-lg-6 col-xl-4" id="LateModal">
            <div class="card m-b-30">
                <div class="card-body">
                    <div class="d-flex flex-row">
                        <div class="col-3 align-self-center">
                            <div class="round">
                                <i class="mdi mdi-clock-alert"></i>
                            </div>
                        </div>
                        <div class="col-9 align-self-center text-center">
                            <div class="m-l-10">
                                <h5 class="mt-0 round-inner">2 คน</h5>
                                <p class="mb-0 text-muted">จำนวนพนักงานที่มาสาย/ขาดงาน</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Column -->
        <!-- Column -->
        <div class="col-md-6 col-lg-6 col-xl-4" id="ExceptModal">
            <div class="card m-b-30">
                <div class="card-body">
                    <div class="d-flex flex-row">
                        <div class="col-3 align-self-center">
                            <div class="round ">
                                <i class="mdi mdi-note-plus"></i>
                            </div>
                        </div>
                        <div class="col-9 align-self-center text-center">
                            <div class="m-l-10">
                                <h5 class="mt-0 round-inner">2 คน</h5>
                                <p class="mb-0 text-muted">จำนวนพนักงานที่ลางานวันนี้</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Column -->
    </div>


    <!-- Default Script -->
    <script src="~/Content/System/js/jquery.min.js"></script>
    <script src="~/Content/System/js/sweetalert2.min.js"></script>

    <!-- Extension Script -->
    <script>
        $('#TimestampModal').click(function () {
            swal(
                {
                    text: 'ข้อมูลจำนวนพนักงานที่เข้าทำงานทั้งหมดในแต่ละวัน ไม่ว่าจะตรงเวลาหรือมาสาย และมีการบันทึกข้อมูลในระบบแล้ว',
                    type: 'info',
                    showCancelButton: false,
                    confirmButtonClass: 'btn btn-success'
                }
            )
        });
        $('#LateModal').click(function () {
            swal(
                {
                    text: 'ข้อมูลจำนวนพนักงานที่เข้างานสายในแต่ละวัน และมีการบันทึกข้อมูลในระบบแล้ว หรือคนที่ไม่ได้มีการบันทึกเวลาเข้างานหรือยื่นใบลา จะมีสถานะเป็นขาดงานในวันนั้น',
                    type: 'info',
                    showCancelButton: false,
                    confirmButtonClass: 'btn btn-success'
                }
            )
        });
        $('#ExceptModal').click(function () {
            swal(
                {
                    text: 'ข้อมูลจำนวนพนักงานที่ยื่นใบลา และมีการบันทึกข้อมูลในระบบแล้ว ไม่ว่าจะอนุมัติหรือไม่ก็ตาม',
                    type: 'info',
                    showCancelButton: false,
                    confirmButtonClass: 'btn btn-success'
                }
            )
        });
    </script>
</body>
</html>