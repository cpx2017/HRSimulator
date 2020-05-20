Imports System.Web.Mvc
Imports MySql.Data.MySqlClient

Namespace Controllers
    Public Class DepartController
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
            cmdSelect = New MySqlCommand("select * from m_JobDepart where Depart_Name=@DepartName", dbCon)
            cmdSelect.Parameters.Add("@DepartName", MySqlDbType.VarChar).Value = data

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

        Function Generate_RunningCode(ByVal data As String) As String
            dbCon.Open()
            Dim running_code As String = ""
            Dim cmdSelect As New MySqlCommand
            Dim genAdapt As MySqlDataAdapter = New MySqlDataAdapter()
            Dim genDS As New DataSet
            cmdSelect = New MySqlCommand("select max(code) as mcode from m_JobDepart where Job_Code=@JobCode", dbCon)
            cmdSelect.Parameters.Add("@JobCode", MySqlDbType.VarChar).Value = data

            genAdapt.SelectCommand = cmdSelect

            genAdapt.Fill(genDS, "table")
            If genDS.Tables("table").Rows.Count > 0 Then
                running_code = genDS.Tables("table").Rows(0)("mcode").ToString
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

        <HttpPost>
        Public Function AddDepart(ByVal getData As DepartModel) As JsonResult
            Dim insertDepart As DepartModel = New DepartModel With {
                .JobCode = getData.JobCode,
                   .code = getData.code,
            .DepartName = getData.DepartName
            }

            Dim responseStat As JobHeadModel
            Dim Exist As Integer = checkExist(getData.DepartName)
            If Exist = 0 Then
                insertDepart.code = Generate_RunningCode(insertDepart.JobCode)
                Dim cmdQuery As New MySqlCommand("INSERT INTO m_JobDepart(Job_code, code, Depart_Name) VALUES (@JobCode,@DepartCode,@DepartName)", dbCon)
                cmdQuery.Parameters.Add("@JobCode", MySqlDbType.VarChar).Value = insertDepart.JobCode
                cmdQuery.Parameters.Add("@DepartCode", MySqlDbType.VarChar).Value = insertDepart.code
                cmdQuery.Parameters.Add("@DepartName", MySqlDbType.VarChar).Value = insertDepart.DepartName
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
        Public Function EditDepart(ByVal getData As DepartModel) As JsonResult
            Dim updateDepart As DepartModel = New DepartModel With {
                .JobCode = getData.JobCode,
                   .code = getData.code,
            .DepartName = getData.DepartName
            }

            Dim responseStat As JobHeadModel
            Dim Exist As Integer = checkExist(getData.DepartName)
            If Exist = 0 Then
                Dim cmdQuery As New MySqlCommand("UPDATE m_JobDepart SET Depart_Name=@DepartName WHERE code=@DepartCode AND Job_code=@JobCode", dbCon)
                cmdQuery.Parameters.Add("@JobCode", MySqlDbType.VarChar).Value = updateDepart.JobCode
                cmdQuery.Parameters.Add("@DepartCode", MySqlDbType.VarChar).Value = updateDepart.code
                cmdQuery.Parameters.Add("@DepartName", MySqlDbType.VarChar).Value = updateDepart.DepartName
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