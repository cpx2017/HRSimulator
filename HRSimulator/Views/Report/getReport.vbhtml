<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=0, minimal-ui">
    <title>แจ้งปัญหาระบบ</title>
    <meta content="Admin Dashboard" name="description" />
    <meta content="Mannatthemes" name="author" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />

    <!-- Default Class -->
    <link rel="shortcut icon" href="~/Content/System/image/favicon.ico">
    <link href="~/Content/System/css/sweetalert2.min.css" rel="stylesheet" type="text/css">
    <link href="~/Content/System/css/dataTables.bootstrap4.min.css" rel="stylesheet" type="text/css" />
    <link href="~/Content/System/css/responsive.bootstrap4.min.css" rel="stylesheet" type="text/css" />
    <link href="https://cdn.jsdelivr.net/npm/summernote@0.8.18/dist/summernote-lite.min.css" rel="stylesheet">

    <!-- Extension Class -->

</head>


<body class="fixed-left">

    <div class="row">
        <div class="col-sm-12">
            <div class="page-title-box">
                <div class="btn-group float-right">
                    <ol class="breadcrumb hide-phone p-0 m-0">
                        <li class="breadcrumb-item"><a href="#">HR Simulator</a></li>
                        <li class="breadcrumb-item"><a href="#">แจ้งปัญหาการใช้งานระบบ</a></li>
                    </ol>
                </div>
                <h4 class="page-title">แจ้งปัญหาการใช้งานระบบ</h4>
            </div>
        </div>
    </div>
    <!-- end page title end breadcrumb -->

    <div class="row">
        <div class="col-12">
            <div class="card m-b-30">
                <div class="card-body">

                    <p class="text-muted m-b-30 font-14">
                        หากพบว่าระบบมีปัญหา ไม่ว่าจะเป็นการแสดงผลไม่ถูกต้อง, ไม่สามารถบันทึกข้อมูลได้ หรือปัญหาอื่นๆ ที่ไม่สามารถแก้ไขได้จากคู่มือ
                        อาจเกิดจากข้อผิดพลาดของระบบ หากสามารถเข้าระบบเว็บได้ สามารถ Report ได้ที่นี่
                    </p>
                    <div class="container-fluid">
                        <div class="row">
                            <div class="col-md-12">
                                <div class="panel-group">
                                    <div class="card">
                                        <div class="col-md-12 card-body">
                                            <div class="col-md-12">
                                                <div class="row">
                                                    <div class="form-group col-md-7">
                                                        <label>ชื่อผู้รายงาน</label>
                                                        <input type="text" id="Name" class="form-control" required />
                                                    </div>
                                                </div>
                                                <div class="row">
                                                    <div class="form-group col-md-7">
                                                        <label>อีเมล์ผู้รายงาน</label>
                                                        <input type="email" id="Mail" class="form-control" required />
                                                    </div>
                                                </div>
                                                <div class="row">
                                                    <div class="form-group col-md-7">
                                                        <label>หมวดปัญหาที่พบ</label>
                                                        <select class="select2 form-control" id="type" required>
                                                            <option value="">>เลือกหมวดปัญหาที่พบ<</option>
                                                            <option value="การแสดงผลไม่ถูกต้อง">การแสดงผลไม่ถูกต้อง</option>
                                                            <option value="เพิ่ม/แก้ไขข้อมูลไม่สำเร็จ">เพิ่ม/แก้ไขข้อมูลไม่สำเร็จ</option>
                                                            <option value="ระบบใช้เวลาโหลดนานเกินไป">ระบบใช้เวลาโหลดนานเกินไป</option>
                                                            <option value="ปัญหาอื่นๆ">ปัญหาอื่นๆ</option>
                                                        </select>
                                                    </div>
                                                </div>
                                                <div class="row">
                                                    <div class="form-group col-md-7">
                                                        <label>หัวข้อปัญหาที่พบ</label>
                                                        <input type="text" id="header" class="form-control" required />
                                                    </div>
                                                </div>
                                                <div class="row">
                                                    <div class="form-group col-md-9">
                                                        <label>รายละเอียด</label>
                                                        <textarea type="text" id="detail" class="form-control" required></textarea>
                                                    </div>
                                                </div>

                                                <div class="row">
                                                    <div class="button-group">
                                                        <button type="button" id="btn_Save" class="btn btn-success"><i class="mdi mdi-content-save"></i> บันทึก</button>
                                                        <a href="/Home/Home" class="btn btn-default view-only"><i class="mdi mdi-reply"></i> ย้อนกลับ</a>
                                                    </div>
                                                </div>
                                            </div>
                                        </div> <!-- end col -->
                                    </div> <!-- end row -->
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
    <script src="https://cdn.jsdelivr.net/npm/summernote@0.8.18/dist/summernote-lite.min.js"></script>

    <!-- Extension Script -->
    <script src="~/ViewScript/getReport.js"></script>

    <script>
        $(document).ready(function () {
            event_click();
        })
    </script>
</body>
</html>

