Imports System.Data
Public Class frmKetQua
    Private ketQuaTable As DataTable
    ' Nó nhận vào một DataTable có tên là 'dt' khi được gọi
    Public Sub New(ByVal dt As DataTable)

        ' khởi tạo các control trên giao diện
        InitializeComponent()

        ' Gán DataTable nhận được từ frmTimKiem vào biến của form này
        Me.ketQuaTable = dt
    End Sub

    Private Sub frmKetQua_Load(sender As Object, e As EventArgs) Handles Me.Load
        dgvKetQua.DataSource = Me.ketQuaTable
    End Sub
End Class