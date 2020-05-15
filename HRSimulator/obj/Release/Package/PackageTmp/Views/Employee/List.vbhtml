<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=0, minimal-ui">
    <title>รายชื่อพนักงาน</title>
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
                        <li class="breadcrumb-item active">รายชื่อพนักงานทั้งหมด</li>
                    </ol>
                </div>
                <h4 class="page-title">รายชื่อพนักงาน</h4>
            </div>
        </div>
    </div>
    <!-- end page title end breadcrumb -->

    <div class="row">
        <div class="col-12">
            <div class="card m-b-30">
                <div class="card-body">

                    <h4 class="mt-0 header-title">รายชื่อพนักงานในบริษัท</h4>
                    <p class="text-muted m-b-30 font-14">
                       ข้อมูลที่เห็นเป็นข้อมูลพนักงานจาก Database จริงๆ แต่ Detail อาจแตกต่างกันบ้าง
                        ตาม Requirement ของบริษัท
                    </p>

                    <table id="datatable" class="table table-bordered">
                        <thead>
                            <tr>
                                <th>รหัสพนักงาน</th>
                                <th>ชื่อ-นามสกุล</th>
                                <th>อายุ</th>
                                <th>ตำแหน่ง</th>
                                <th>เบอร์โทรติดต่อ</th>
                                <th>Salary</th>
                            </tr>
                        </thead>


                        <tbody>
                            
                        </tbody>
                    </table>

                </div>
            </div>
        </div> <!-- end col -->
    </div> <!-- end row -->
    <!-- Default Script -->
    <script src="~/Content/System/js/jquery.min.js"></script>
    <script src="~/Content/System/js/sweetalert2.min.js"></script>

    <!-- Extension Script -->
    <script src="~/Content/System/js/jquery.dataTables.min.js"></script>
    <script src="~/Content/System/js/dataTables.bootstrap4.min.js"></script>
    <script src="~/Content/System/js/dataTables.buttons.min.js"></script>
    <script src="~/Content/System/js/dataTables.responsive.min.js"></script>
    <script src="~/Content/System/js/responsive.bootstrap4.min.js"></script>
</body>
</html>