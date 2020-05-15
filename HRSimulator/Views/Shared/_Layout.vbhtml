<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=0, minimal-ui">
    <meta content="Admin Dashboard" name="description" />
    <meta content="Mannatthemes" name="author" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />

    <!-- Default Class -->
    <link rel="shortcut icon" href="~/Content/System/image/favicon.ico">
    <link href="~/Content/System/css/morris.css" rel="stylesheet" type="text/css">
    <link href="~/Content/System/css/bootstrap.min.css" rel="stylesheet" type="text/css">
    <link href="~/Content/Custom/css/icons.css" rel="stylesheet" type="text/css">
    <link href="~/Content/Custom/css/style.css" rel="stylesheet" type="text/css">
    <link href="https://cdn.jsdelivr.net/npm/busy-load/dist/app.min.css" rel="stylesheet">

    <!-- Extension Class -->

</head>


<body class="fixed-left">

    <!-- Begin page -->
    <div id="wrapper">

        <div class="left side-menu">
            <button type="button" class="button-menu-mobile button-menu-mobile-topbar open-left waves-effect">
                <i class="ion-close"></i>
            </button>

            <!-- LOGO -->
            <div class="topbar-left">
                <div class="text-center">
                    <a href="index.html" class="logo"><i class="mdi mdi-assistant"></i> HR Simulator</a>
                </div>
            </div>

            <div class="sidebar-inner slimscrollleft">

                <div id="sidebar-menu">
                    <div class="topbar-left">
                        <div class="text-center mb-2">
                            <a class="waves-effect" id="date"></a>
                        </div>
                        <div class="text-center mb-2">
                            <a class="waves-effect" id="clock"></a>
                        </div>
                        <div class="text-center mb-3">
                            <b><a class="waves-effect" id="workstat"></a></b>
                        </div>
                    </div>

                    <ul>
                        <li class="menu-title">เมนู</li>

                        <li>
                            <a href="/Home/Home" class="waves-effect"><i class="mdi mdi-home"></i><span> หน้าหลัก </span></a>
                        </li>

                        <li class="has_sub">
                            <a href="javascript:void(0);" class="waves-effect"><i class="mdi mdi-account-check"></i> <span> ข้อมูลตำแหน่งงาน </span> <span class="float-right"><i class="mdi mdi-chevron-right"></i></span></a>
                            <ul class="list-unstyled">
                                <li><a href="/Job/Add">เพิ่มชื่อตำแหน่งงาน</a></li>
                                <li><a href="/Job/Edit">แก้ไขชื่อตำแหน่งงาน</a></li>
                            </ul>
                        </li>

                        <li class="has_sub">
                            <a href="javascript:void(0);" class="waves-effect"><i class="mdi mdi-account-multiple"></i> <span> ข้อมูลแผนก </span> <span class="float-right"><i class="mdi mdi-chevron-right"></i></span></a>
                            <ul class="list-unstyled">
                                <li><a href="#">เพิ่มชื่อแผนกงาน</a></li>
                                <li><a href="#">แก้ไขชื่อแผนกงาน</a></li>
                            </ul>
                        </li>

                        <li class="has_sub">
                            <a href="javascript:void(0);" class="waves-effect"><i class="mdi mdi-account-circle"></i> <span> ข้อมูลพนักงาน </span> <span class="float-right"><i class="mdi mdi-chevron-right"></i></span></a>
                            <ul class="list-unstyled">
                                <li><a href="#">รายชื่อพนักงาน</a></li>
                                <li><a href="#">เพิ่มข้อมูลพนักงาน</a></li>
                                <li><a href="#">แก้ไขข้อมูลพนักงาน</a></li>
                                <li><a href="#">เปลี่ยนสถานะลาออกของพนักงาน</a></li>
                            </ul>
                        </li>

                        <li>
                            <a href="calendar.html" class="waves-effect"><i class="mdi mdi-note-plus"></i><span> ข้อมูลการลา </span></a>
                        </li>

                        <li>
                            <a href="calendar.html" class="waves-effect"><i class="mdi mdi-calendar-clock"></i><span> บันทึกเวลาเข้า-เลิกงาน </span></a>
                        </li>
                    </ul>
                </div>
                <div class="clearfix"></div>
            </div> <!-- end sidebarinner -->
        </div>

        <div class="content-page">
            <!-- Start content -->
            <div class="content">

                <!-- Top Bar Start -->
                <div class="topbar">

                    <nav class="navbar-custom">


                        <ul class="list-inline menu-left mb-0">
                            <li class="float-left">
                                <button class="button-menu-mobile open-left waves-light waves-effect">
                                    <i class="mdi mdi-menu"></i>
                                </button>
                            </li>
                        </ul>
                        <li class="list-inline-item dropdown notification-list">
                            <a class="nav-link dropdown-toggle arrow-none waves-effect" data-toggle="dropdown" href="#" role="button"
                               aria-haspopup="false" aria-expanded="false">
                                <i class="ti-bell noti-icon"></i>
                                <span class="badge badge-success noti-icon-badge">23</span>
                            </a>
                            <div class="dropdown-menu dropdown-menu-left dropdown-arrow dropdown-menu-lg">
                                <!-- item-->
                                <div class="dropdown-item noti-title">
                                    <h5><span class="badge badge-danger float-right">87</span>Notification</h5>
                                </div>

                                <!-- item-->
                                <a href="javascript:void(0);" class="dropdown-item notify-item">
                                    <div class="notify-icon bg-primary"><i class="mdi mdi-cart-outline"></i></div>
                                    <p class="notify-details"><b>บันทึกเวลาเลิกงาน</b><small class="text-muted">นายชิณธร [รหัสพนักงาน 0091] ลงชื่อเวลาเลิกงานเมื่อ 6/5/2020 19:20:15</small></p>
                                </a>

                                <!-- item-->
                                <a href="javascript:void(0);" class="dropdown-item notify-item">
                                    <div class="notify-icon bg-success"><i class="mdi mdi-message"></i></div>
                                    <p class="notify-details"><b>บันทึกการลา</b><small class="text-muted">นางสาววารี [รหัสพนักงาน 0014] อนุมัติการลาของนางสาวิตรี [รหัสพนักงาน 0074] เรียบร้อยแล้ว</small></p>
                                </a>

                                <!-- item-->
                                <a href="javascript:void(0);" class="dropdown-item notify-item">
                                    <div class="notify-icon bg-warning"><i class="mdi mdi-martini"></i></div>
                                    <p class="notify-details"><b>เพิ่มข้อมูลพนักงาน</b><small class="text-muted">นางสาววารี [รหัสพนักงาน 0789] เพิ่มข้อมูลพนักงานคนใหม่ [รหัสพนักงาน 0111] ในระบบแล้ว ขอต้อนรับเข้าสู่ระบบ HR Simulator</small></p>
                                </a>

                            </div>
                        </li>
                        <div class="clearfix"></div>



                    </nav>

                </div>
                <!-- Top Bar End -->

                <div class="page-content-wrapper ">

                    <div class="container-fluid">



                        @RenderBody()

                    </div><!-- container -->


                </div> <!-- Page content Wrapper -->

            </div> <!-- content -->

            <footer class="footer">
                © 2020 CPXDevStudio, Allright Reserved.
            </footer>

        </div>
        <!-- End Right content here -->

    </div>


    <!-- Default Script -->
    <script src="~/Content/System/js/jquery.min.js"></script>
    <script src="~/Content/System/js/popper.min.js"></script>
    <script src="~/Content/System/js/bootstrap.min.js"></script>
    <script src="~/Content/System/js/modernizr.min.js"></script>
    <script src="~/Content/System/js/detect.js"></script>
    <script src="~/Content/System/js/fastclick.js"></script>
    <script src="~/Content/System/js/jquery.slimscroll.js"></script>
    <script src="~/Content/System/js/jquery.blockUI.js"></script>
    <script src="~/Content/System/js/waves.js"></script>
    <script src="~/Content/System/js/jquery.nicescroll.js"></script>
    <script src="~/Content/System/js/jquery.scrollTo.min.js"></script>
    <script src="~/Content/Custom/js/app.js"></script>

    <script src="~/Content/System/js/skycons.min.js"></script>
    <script src="~/Content/System/js/raphael-min.js"></script>
    <script src="~/Content/System/js/morris.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/busy-load/dist/app.min.js"></script>

    <!-- Extension Script -->
    <script src="~/ViewScript/dateObj.js"></script>
    <script src="~/ViewScript/_layout.js"></script>
    <script>
        $.busyLoadSetup({ spinner: "circles", text: "กำลังโหลดหน้าเว็บ", animation: "fade", background: "rgba(0, 0, 0, 0.80)" });
        $.busyLoadFull("show");
        updateClock();
        $(document).ready(function () {
            $.busyLoadFull("hide");
            setInterval('updateClock()', 1000);
        });
    </script>
</body>
</html>







