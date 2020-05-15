<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=0, minimal-ui">
    <title>เพิ่มตำแหน่งงาน</title>
    <meta content="Admin Dashboard" name="description" />
    <meta content="Mannatthemes" name="author" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />

    <!-- Default Class -->
    <link rel="shortcut icon" href="~/Content/System/image/favicon.ico">
    <link href="~/Content/System/css/select2.min.css" rel="stylesheet" type="text/css" />
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
                        <li class="breadcrumb-item"><a href="#">ข้อมูลตำแหน่งงาน</a></li>
                        <li class="breadcrumb-item active">เพิ่มข้อมูลตำแหน่งงาน</li>
                    </ol>
                </div>
                <h4 class="page-title">เพิ่มข้อมูลตำแหน่งงาน</h4>
            </div>
        </div>
    </div>
    <!-- end page title end breadcrumb -->

    <div class="row">
        <div class="col-12">
            <div class="card m-b-30">
                <div class="card-body">

                    <h4 class="mt-0 header-title">แก้ไขตำแหน่งงาน</h4>
                    <p class="text-muted m-b-30 font-14">
                        เลือกตำแหน่งงานที่ต้องการแก้ไข และแก้ไขชื่อตำแหน่งงานที่ต้องการ โดยไม่ให้ซ้ำกับตำแหน่งงานที่มีอยู่แล้วในระบบ
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
                                                        <label>ตำแหน่งงานที่ต้องการแก้ไข</label>
                                                        <select class="select2 form-control">
                                                            <option>Select</option>
                                                            <optgroup label="Alaskan/Hawaiian Time Zone">
                                                                <option value="AK">Alaska</option>
                                                                <option value="HI">Hawaii</option>
                                                            </optgroup>
                                                            <optgroup label="Pacific Time Zone">
                                                                <option value="CA">California</option>
                                                                <option value="NV">Nevada</option>
                                                                <option value="OR">Oregon</option>
                                                                <option value="WA">Washington</option>
                                                            </optgroup>
                                                            <optgroup label="Mountain Time Zone">
                                                                <option value="AZ">Arizona</option>
                                                                <option value="CO">Colorado</option>
                                                                <option value="ID">Idaho</option>
                                                                <option value="MT">Montana</option>
                                                                <option value="NE">Nebraska</option>
                                                                <option value="NM">New Mexico</option>
                                                                <option value="ND">North Dakota</option>
                                                                <option value="UT">Utah</option>
                                                                <option value="WY">Wyoming</option>
                                                            </optgroup>
                                                            <optgroup label="Central Time Zone">
                                                                <option value="AL">Alabama</option>
                                                                <option value="AR">Arkansas</option>
                                                                <option value="IL">Illinois</option>
                                                                <option value="IA">Iowa</option>
                                                                <option value="KS">Kansas</option>
                                                                <option value="KY">Kentucky</option>
                                                                <option value="LA">Louisiana</option>
                                                                <option value="MN">Minnesota</option>
                                                                <option value="MS">Mississippi</option>
                                                                <option value="MO">Missouri</option>
                                                                <option value="OK">Oklahoma</option>
                                                                <option value="SD">South Dakota</option>
                                                                <option value="TX">Texas</option>
                                                                <option value="TN">Tennessee</option>
                                                                <option value="WI">Wisconsin</option>
                                                            </optgroup>
                                                            <optgroup label="Eastern Time Zone">
                                                                <option value="CT">Connecticut</option>
                                                                <option value="DE">Delaware</option>
                                                                <option value="FL">Florida</option>
                                                                <option value="GA">Georgia</option>
                                                                <option value="IN">Indiana</option>
                                                                <option value="ME">Maine</option>
                                                                <option value="MD">Maryland</option>
                                                                <option value="MA">Massachusetts</option>
                                                                <option value="MI">Michigan</option>
                                                                <option value="NH">New Hampshire</option>
                                                                <option value="NJ">New Jersey</option>
                                                                <option value="NY">New York</option>
                                                                <option value="NC">North Carolina</option>
                                                                <option value="OH">Ohio</option>
                                                                <option value="PA">Pennsylvania</option>
                                                                <option value="RI">Rhode Island</option>
                                                                <option value="SC">South Carolina</option>
                                                                <option value="VT">Vermont</option>
                                                                <option value="VA">Virginia</option>
                                                                <option value="WV">West Virginia</option>
                                                            </optgroup>
                                                        </select>
                                                    </div>
                                                </div>
                                                <div class="row">
                                                    <div class="form-group col-md-7">
                                                        <label>ชื่อตำแหน่งงาน</label>
                                                        <input type="text" id="JobName" class="form-control" required />
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
    <script src="~/Content/System/js/select2.min.js"></script>

    <!-- Extension Script -->
    <script src="~/ViewScript/JobAdd.js"></script>

    <script>
        $(document).ready(function () {
            event_click();
        })
    </script>
</body>
</html>