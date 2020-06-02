Imports System.Net
Imports System.Net.Mail
Imports System.Web.Mvc

Namespace Controllers
    Public Class ReportController
        Inherits Controller

        ' GET: Report
        Function getReport() As ActionResult
            Return View()
        End Function

        Private Function Response_stat(actionCase As String) As ReportModel
            Dim respone As ReportModel
            respone = New ReportModel
            Select Case actionCase
                Case "success"
                    respone.errorcode = 0
                Case "error"
                    respone.errorcode = 1
            End Select
            Return respone
        End Function

        Function autoReply(ByVal senderMail As String) As Integer
            Dim errorcode As Integer

            Dim getMail As MailMessage = New MailMessage()
            getMail.To.Add(senderMail)
            getMail.From = New MailAddress("cpx.hrsimreport@gmail.com")
            getMail.Subject = "[ระบบตอบกลับอัตโนมัติ] ยืนยันการรับแจ้งปัญหาระบบ"
            getMail.Body = "เราขอเรียนแจ้งให้ทราบว่า การแจ้งปัญหาระบบได้ถูกส่งไปยังผู้พัฒนาแล้ว ทางผู้พัฒนาอาจใช้เวลาประมาณ 3-5 วันเพื่อแก้ไขปัญหาให้แล้วเสร็จ ขออภัยในความไม่สะดวก" & vbNewLine & vbNewLine & "_____________________" & vbNewLine & "ทีมผู้พัฒนาระบบ HR Simulator (cpx.hrsimreport@gmail.com)"
            getMail.IsBodyHtml = False

            Dim setup As SmtpClient = New SmtpClient
            setup.Host = "smtp.gmail.com"
            setup.Port = 587
            setup.EnableSsl = True

            Dim NetworkCre As NetworkCredential = New NetworkCredential("cpx.hrsimreport@gmail.com", "19582Cnt")
            setup.UseDefaultCredentials = True
            setup.Credentials = NetworkCre

            Try
                setup.Send(getMail)
            Catch exc As Exception
                Response.Write("Send failure: " & exc.ToString())
                errorcode = 1
            Finally
                errorcode = 0
            End Try

            Return errorcode
        End Function

        <HttpPost>
        Public Function sendReport(ByVal getReportData As ReportModel) As JsonResult
            Dim getsyncReport As ReportModel = New ReportModel With {
                .name = getReportData.name,
                .email = getReportData.email,
                .type = getReportData.type,
                .title = getReportData.title,
                .detail = getReportData.detail
            }

            Dim getMail As MailMessage = New MailMessage()
            getMail.To.Add("cpx.hrsimreport@gmail.com")
            getMail.From = New MailAddress(getsyncReport.email)
            getMail.Subject = "[" & getsyncReport.type & "] " & getsyncReport.title
            getMail.Body = getsyncReport.detail & vbNewLine & vbNewLine & "_____________________" & vbNewLine & getsyncReport.name & " (" & getsyncReport.email & ")"
            getMail.IsBodyHtml = False

            Dim setup As SmtpClient = New SmtpClient
            setup.Host = "smtp.gmail.com"
            setup.Port = 587
            setup.EnableSsl = True

            Dim NetworkCre As NetworkCredential = New NetworkCredential("cpx.hrsimreport@gmail.com", "19582Cnt")
            setup.UseDefaultCredentials = True
            setup.Credentials = NetworkCre

            Dim responseStat As ReportModel
            Try
                setup.Send(getMail)
            Catch exc As Exception
                Response.Write("Send failure: " & exc.ToString())
                responseStat = Response_stat("error")
            Finally
                responseStat = Response_stat("success")
                autoReply(getsyncReport.email)
            End Try

            Return Json(responseStat, JsonRequestBehavior.AllowGet)
        End Function
    End Class
End Namespace