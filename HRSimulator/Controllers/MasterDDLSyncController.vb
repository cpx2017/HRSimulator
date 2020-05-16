Imports System.Web.Mvc
Imports MySql.Data.MySqlClient

Namespace Controllers
    'Get DropDownList data from database. This Controller (Module) helps you!
    Public Class MasterDDLSyncController
        Inherits Controller

        Public dbCon As New MySqlConnection("datasource=remotemysql.com;port=3306;username=5XBTr0keKh;password=Qirn3jsE82;database=5XBTr0keKh")

        <HttpPost>
        Function JobDDLFunc(data As JobHeadDDL) As List(Of JobHeadDDL)
            Dim list_data As New List(Of JobHeadDDL)
            Dim getJob As JobHeadDDL
            Dim getJobList As JobHeadDDL = New JobHeadDDL With {
                .action = data.action
            }

            If getJobList.action = 1 Then
                dbCon.Open()
                Dim cmdSelect As New MySqlCommand
                Dim genAdapt As MySqlDataAdapter = New MySqlDataAdapter()
                Dim genDS As New DataSet
                cmdSelect = New MySqlCommand("select * from m_Jobhead", dbCon)

                genAdapt.SelectCommand = cmdSelect

                genAdapt.Fill(genDS, "table")
                If genDS.Tables("table").Rows.Count > 0 Then
                    Dim dr As DataRow

                    For Each dr In genDS.Tables("table").Rows
                        getJob = New JobHeadDDL
                        getJob.code = dr("code").ToString
                        getJob.JobName = dr("JobName").ToString
                        list_data.Add(getJob)
                    Next
                    dbCon.Close()
                Else
                    dbCon.Close()
                End If

            End If
            Return list_data
        End Function

        Function DepartDDLFunc(ByVal data As String) As Integer
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

        Function Province(ByVal data As String) As Integer
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

        Public Class JobHeadDDL
            Public Property code As String
            Public Property JobName As String
            Public Property action As Integer

            Public Property errorcode As Integer
        End Class
        Public Class DepartDDL
            Public Property JobCode As String
            Public Property DepartCode As String
            Public Property DepartName As String
            Public Property action As Integer

            Public Property errorcode As Integer
        End Class
    End Class
End Namespace