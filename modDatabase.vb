Imports System.Data.SqlClient

Module modDatabase

    ' Khai báo một đối tượng kết nối có thể dùng chung cho toàn bộ Project
    Public Conn As New SqlConnection()

    ' Chuỗi kết nối đến CSDL SQL Server 

    Private ConnectionString As String = "Data Source=DESKTOP-UKPMA8V\SQLEXPRESS02;Initial Catalog=DB_TuyenSinhDH;Integrated Security=True"

    ' Sub để mở kết nối
    Public Sub Connect()
        Try
            If Conn.State = ConnectionState.Closed Then
                Conn.ConnectionString = ConnectionString
                Conn.Open()
                ' MsgBox("Kết nối thành công!") ' Có thể bật lên để kiểm tra lúc đầu
            End If
        Catch ex As Exception
            MsgBox("Không thể kết nối đến CSDL. Lỗi: " & ex.Message)
        End Try
    End Sub

    ' Sub để đóng kết nối
    Public Sub Disconnect()
        If Conn.State = ConnectionState.Open Then
            Conn.Close()
            ' MsgBox("Đã ngắt kết nối.")
        End If
    End Sub

End Module