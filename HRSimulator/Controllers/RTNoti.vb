Imports Microsoft.AspNet.SignalR

Public Class RTNoti
    Inherits Hub

    Public Sub Hello()
        Clients.All.Hello()
    End Sub
End Class
