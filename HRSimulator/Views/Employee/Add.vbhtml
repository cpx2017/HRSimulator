<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=0, minimal-ui">
    <title>เพิ่มแผนกสายงาน</title>
    <meta content="Admin Dashboard" name="description" />
    <meta content="Mannatthemes" name="author" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />

    <!-- Default Class -->
    <link rel="shortcut icon" href="~/Content/System/image/favicon.ico">
    <link href="~/Content/System/css/sweetalert2.min.css" rel="stylesheet" type="text/css">
    <link href="~/Content/System/css/dataTables.bootstrap4.min.css" rel="stylesheet" type="text/css" />
    <link href="~/Content/System/css/responsive.bootstrap4.min.css" rel="stylesheet" type="text/css" />

    <!-- Extension Class -->

</head>


<body class="fixed-left">

    <div class="row">
        <div class="col-sm-12">
            <div class="page-title-box">
                <div class="btn-group float-right">
                    <ol class="breadcrumb hide-phone p-0 m-0">
                        <li class="breadcrumb-item"><a href="#">HR Simulator</a></li>
                        <li class="breadcrumb-item"><a href="#">ข้อมูลพนักงาน</a></li>
                        <li class="breadcrumb-item active">เพิ่มข้อมูลพนักงาน</li>
                    </ol>
                </div>
                <h4 class="page-title">เพิ่มข้อมูลแผนกสายงาน</h4>
            </div>
        </div>
    </div>
    <!-- end page title end breadcrumb -->

    <div class="row">
        <div class="col-12">
            <div class="card m-b-30">
                <div class="card-body">

                    <h4 class="mt-0 header-title">เพิ่มแผนกสายงาน</h4>
                    <p class="text-muted m-b-30 font-14">
                        เลือกตำแหน่งงานที่ต้องการเพิ่มแผนกสายงาน และกรอกชื่อแผนกสายงานย่อยของตำแหน่งงานนั้น
                    </p>
                    <div class="container-fluid">
                        <div class="row">
                            <div class="col-md-12">
                                <div class="panel-group">
                                    <div class="col-md-12">
                                        <div class="row">
                                            <div class="form-group col-md-3">
                                                <label>คำนำหน้า</label>
                                                <select class="select2 form-control" id="NTitle" required>
                                                    <option value="">>เลือกคำนำหน้า<</option>
                                                    <option value="">นาย</option>
                                                    <option value="">นางสาว</option>
                                                </select>
                                            </div>
                                            <div class="form-group col-md-4">
                                                <label>ชื่อจริง (ไม่ต้องกรอกคำนำหน้า)</label>
                                                <input type="text" id="E_Name" class="form-control" required />
                                            </div>
                                            <div class="form-group col-md-5">
                                                <label>นามสกุล</label>
                                                <input type="text" id="E_Surname" class="form-control" required />
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="form-group col-md-4">
                                                <label>รหัสบัตรประชาชน / เลขที่หนังสือเดินทาง</label>
                                                <input type="text" id="E_NID" maxlength="13" class="form-control" required />
                                            </div>
                                            <div class="form-group col-md-4">
                                                <label>วัน/เดือน/ปีเกิดของคุณ</label>
                                                <input type="text" class="form-control" placeholder="dd/mm/yyyy" id="E_Birthdate">
                                            </div>
                                            <div class="form-group col-md-2">
                                                <label>อายุ (ปี)</label>
                                                <input type="text" id="E_Age" class="form-control" readonly />
                                            </div>
                                            <div class="form-group col-md-2">
                                                <label>เชื้อชาติ</label>
                                                <select class="select2 form-control" id="NTitle" required>
                                                    <option value="">>เลือกคำนำหน้า<</option>
                                                    <option value="">ไทย</option>
                                                    <option value="">นางสาว</option>
                                                </select>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="button-group">
                                                <button type="button" id="btn_Save" class="btn btn-success"><i class="mdi mdi-content-save"></i> บันทึก</button>
                                                <a href="/Home/Home" class="btn btn-outline-danger"><i class="mdi mdi-reply"></i> ย้อนกลับ</a>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div> <!-- end col -->
                    </div>
                </div>
            </div>
        </div> <!-- end col -->
    </div>                    <!-- Default Script -->
    <script src="~/Content/System/js/jquery.min.js"></script>
    <script src="~/Content/System/js/sweetalert2.min.js"></script>

    <!-- Extension Script -->
    <script src="~/ViewScript/DDLSync.js"></script>
    <script src="~/ViewScript/EmpAdd.js"></script>
    <script src="~/ViewScript/DOBCal.js"></script>

    <script>
        $(document).ready(function () {
            var D, M, Y, date;
            $('#E_Birthdate').datepicker({
                format: 'dd/mm/yyyy',
                autoclose: true,
                language: 'th-TH',
                thaiyear: true
            }).on('changeDate', function (ev) {

                var newDate = new Date(ev.date);

                D = newDate.getDate();
                M = newDate.getMonth() + 1;
                Y = newDate.getFullYear();

               date = Y + '/' + M + '/' + D
                BirthAge(date, '#E_Age');
            });
            $('#E_Age').click(function () {
                swal(
                    {
                        title: 'อายุปัจจุบัน',
                        text: 'หลังจากที่ท่านเลือก/กรอกวันเดือนปีเกิดแล้ว ระบบจะคำนวนอายุให้โดยอัตโนมัติ (ช่องนี้ถูกปิดไม่ให้กรอก)',
                        type: 'info',
                        showCancelButton: false,
                        confirmButtonClass: 'btn btn-success'
                    }
                )
            })
            getJob("#JobList");
            event_click();
        })
    </script>
</body>
</html>