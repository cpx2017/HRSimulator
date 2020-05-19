Imports System.Web.Mvc
Imports HRSimulator.JobHeadModel
Imports MySql.Data.MySqlClient
Imports HRSimulator.JSON
Imports Newtonsoft.Json

Namespace Controllers
    Public Class JobController
        Inherits Controller

        Public dbCon As New MySqlConnection("datasource=remotemysql.com;port=3306;username=5XBTr0keKh;password=Qirn3jsE82;database=5XBTr0keKh")

        ' GET: Job
        Function Add() As ActionResult
            Return View()
        End Function

        Function Edit() As ActionResult
            Return View()
        End Function

        Function checkExist(ByVal data As String) As Integer
            dbCon.Open()
            Dim ExistCount As Integer
            Dim cmdSelect As New MySqlCommand
            Dim genAdapt As MySqlDataAdapter = New MySqlDataAdapter()
            Dim genDS As New DataSet
            cmdSelect = New MySqlCommand("select * from m_Jobhead where JobName=@JobName", dbCon)
            cmdSelect.Parameters.Add("@JobName", MySqlDbType.VarChar).Value = data

            genAdapt.SelectCommand = cmdSelect

            genAdapt.Fill(genDS, "table")
            If genDS.Tables("table").Rows.Count > 0 Then
                ExistCount = 1
            Else
                ExistCount = 0
            End If
            dbCon.Close()
            Return ExistCount
        End Function

        Function Generate_RunningCode() As String
            dbCon.Open()
            Dim running_code As String = ""
            Dim genAdapt As MySqlDataAdapter
            Dim genDS As New DataSet
            genAdapt = New MySqlDataAdapter("select max(code) as mcode from m_Jobhead", dbCon)
            genAdapt.Fill(genDS, "table")
            If genDS.Tables("table").Rows.Count > 0 Then
                running_code = genDS.Tables("table").Rows(0)("mcode").ToString
            Else
                running_code = ""
            End If
            dbCon.Close()

            If running_code.Length = 2 Then
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

        <HttpPost>
        Public Function AddJob(ByVal getData As JobHeadModel) As JsonResult
            Dim insertJob As JobHeadModel = New JobHeadModel With {
                .JobName = getData.JobName
            }

            Dim responseStat As JobHeadModel
            Dim Exist As Integer = checkExist(getData.JobName)
            If Exist = 0 Then
                insertJob.code = Generate_RunningCode()
                Dim cmdQuery As New MySqlCommand("INSERT INTO `m_Jobhead`(`code`, `JobName`) VALUES (@code,@JobName)", dbCon)
                cmdQuery.Parameters.Add("@code", MySqlDbType.VarChar).Value = insertJob.code
                cmdQuery.Parameters.Add("@JobName", MySqlDbType.VarChar).Value = insertJob.JobName
                dbCon.Open()
                If cmdQuery.ExecuteNonQuery() = 1 Then
                    responseStat = Response_stat("success")
                End If
                dbCon.Close()
            Else
                responseStat = Response_stat("duplicate")
            End If
            Return Json(responseStat, JsonRequestBehavior.AllowGet)
        End Function
        <HttpPost>
        Public Function EditJob(ByVal getData As JobHeadModel) As JsonResult
            Dim updateJob As JobHeadModel = New JobHeadModel With {
                .code = getData.code,
                .JobName = getData.JobName
            }

            Dim responseStat As JobHeadModel
            Dim Exist As Integer = checkExist(getData.JobName)
            If Exist = 0 Then
                Dim cmdQuery As New MySqlCommand("UPDATE m_Jobhead SET JobName=@JobName WHERE code=@code", dbCon)
                cmdQuery.Parameters.Add("@code", MySqlDbType.VarChar).Value = updateJob.code
                cmdQuery.Parameters.Add("@JobName", MySqlDbType.VarChar).Value = updateJob.JobName
                dbCon.Open()
                If cmdQuery.ExecuteNonQuery() = 1 Then
                    responseStat = Response_stat("success")
                End If
                dbCon.Close()
            Else
                responseStat = Response_stat("duplicate")
            End If
            Return Json(responseStat, JsonRequestBehavior.AllowGet)
        End Function

    End Class
End Namespace