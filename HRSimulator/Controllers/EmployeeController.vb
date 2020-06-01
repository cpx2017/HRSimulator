Imports System.Web.Mvc
Imports HRSimulator.EmployeeModel
Imports MySql.Data.MySqlClient

Namespace Controllers
    Public Class EmployeeController
        Inherits Controller
        Public dbCon As New MySqlConnection("datasource=remotemysql.com;port=3306;username=5XBTr0keKh;password=Qirn3jsE82;database=5XBTr0keKh")

        ' GET: Employee
        Function List() As ActionResult
            Return View()
        End Function
        Function Add() As ActionResult
            Return View()
        End Function
        Function Edit() As ActionResult
            Return View()
        End Function
        Function Retire() As ActionResult
            Return View()
        End Function

        Function Generate_RunningCode() As String
            dbCon.Open()
            Dim running_code As String = ""
            Dim genAdapt As MySqlDataAdapter
            Dim genDS As New DataSet
            genAdapt = New MySqlDataAdapter("select max(emp_count) as code from Employee", dbCon)
            genAdapt.Fill(genDS, "table")
            If genDS.Tables("table").Rows.Count > 0 Then
                running_code = genDS.Tables("table").Rows(0)("code").ToString
            Else
                running_code = ""
            End If
            dbCon.Close()

            If running_code.Length > 0 Then
                running_code = 1 + running_code
            Else
                running_code = "10"
            End If
            Return running_code
        End Function
        Private Function Response_stat(actionCase As String) As JobHeadModel
            Dim respone As JobHeadModel
            respone = New JobHeadModel
            Select Case actionCase
                Case "success"
                    respone.errorcode = 0
                Case "duplicate"
                    respone.errorcode = 1
            End Select
            Return respone
        End Function

    End Class
End Namespace