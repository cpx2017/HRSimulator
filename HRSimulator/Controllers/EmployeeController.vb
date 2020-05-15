Imports System.Web.Mvc
Imports HRSimulator.EmployeeModel

Namespace Controllers
    Public Class EmployeeController
        Inherits Controller

        ' GET: Employee
        Function List() As ActionResult
            Return View()
        End Function
    End Class
End Namespace