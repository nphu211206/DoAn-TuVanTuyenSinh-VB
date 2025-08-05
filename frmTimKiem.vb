Imports System.Data.SqlClient
Public Class frmTimKiem

    Private Sub frmTimKiem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Gọi hàm kết nối đến CSDL từ Module
        Connect()

        ' Tạo câu lệnh SQL để lấy danh sách khối thi
        Dim sql As String = "SELECT MaKhoi FROM tbl_KhoiThi ORDER BY MaKhoi"
        Dim cmd As New SqlCommand(sql, Conn)
        Dim dr As SqlDataReader

        Try
            ' Thực thi câu lệnh và đọc dữ liệu
            dr = cmd.ExecuteReader()

            ' Dùng vòng lặp để đọc từng dòng dữ liệu và thêm vào ComboBox
            While dr.Read()
                cboKhoiThi.Items.Add(dr("MaKhoi").ToString())
            End While
        Finally
            ' Luôn đóng DataReader và ngắt kết nối dù có lỗi hay không
            If dr IsNot Nothing Then dr.Close()
            Disconnect()
        End Try
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        ' --- BƯỚC 1: KIỂM TRA DỮ LIỆU ĐẦU VÀO ---
        If cboKhoiThi.SelectedIndex = -1 Then
            MsgBox("Bạn vui lòng chọn một khối thi để xét tuyển.", MsgBoxStyle.Exclamation, "Thiếu thông tin")
            Return ' Dừng thực hiện nếu chưa chọn khối thi
        End If

        ' --- BƯỚC 2: LẤY THÔNG TIN TỪ FORM ---
        Dim maKhoi As String = cboKhoiThi.SelectedItem.ToString()
        Dim nganhYeuThich As String = txtNganhYeuThich.Text.Trim() ' Dùng Trim() để xóa khoảng trắng thừa

        ' --- BƯỚC 3: TÍNH TỔNG ĐIỂM DỰA VÀO KHỐI THI ĐÃ CHỌN ---
        Dim diemToan, diemLy, diemHoa, diemAnh, diemVan, diemSinh As Double
        ' Dùng TryParse để tránh lỗi nếu người dùng nhập chữ
        Double.TryParse(txtDiemToan.Text, diemToan)
        Double.TryParse(txtDiemLy.Text, diemLy)
        Double.TryParse(txtDiemHoa.Text, diemHoa)
        Double.TryParse(txtDiemAnh.Text, diemAnh)
        Double.TryParse(txtDiemVan.Text, diemVan)
        Double.TryParse(txtDiemSinh.Text, diemSinh)

        Dim tongDiem As Double = 0
        Select Case maKhoi
            Case "A00"
                tongDiem = diemToan + diemLy + diemHoa
            Case "A01"
                tongDiem = diemToan + diemLy + diemAnh
            Case "B00"
                tongDiem = diemToan + diemHoa + diemSinh
            Case "C00"
                tongDiem = diemVan + diemLy + diemHoa ' Giả định, bạn có thể sửa lại môn cho đúng
            Case "D01"
                tongDiem = diemToan + diemVan + diemAnh
            Case "D07"
                tongDiem = diemToan + diemHoa + diemAnh
            Case Else
                MsgBox("Khối thi này chưa được hỗ trợ tính điểm.", MsgBoxStyle.Information, "Thông báo")
                Return
        End Select

        lblTongDiem.Text = "Tổng điểm khối " & maKhoi & ": " & tongDiem.ToString("0.00") ' Cập nhật điểm lên Label

        ' --- BƯỚC 4: TẠO CÂU LỆNH SQL VÀ TRUY VẤN CSDL ---
        Dim sqlQuery As String = "SELECT tr.TenTruong, ng.TenNganh, nts.MaKhoi, nts.DiemChuan " &
                               "FROM tbl_NganhTuyenSinh AS nts " &
                               "JOIN tbl_TruongDaiHoc AS tr ON nts.MaTruong = tr.MaTruong " &
                               "JOIN tbl_NganhHoc AS ng ON nts.MaNganh = ng.MaNganh " &
                               "WHERE nts.MaKhoi = @maKhoi AND nts.DiemChuan <= @tongDiem "

        ' Nếu người dùng có nhập ngành yêu thích, thì thêm điều kiện tìm kiếm gần đúng
        If Not String.IsNullOrEmpty(nganhYeuThich) Then
            sqlQuery &= " AND ng.TenNganh LIKE @tenNganh"
        End If

        sqlQuery &= " ORDER BY nts.DiemChuan DESC" ' Sắp xếp điểm từ cao xuống thấp

        Dim cmd As New SqlCommand()
        Dim dt As New DataTable("KetQuaTimKiem")

        Try
            Connect()
            cmd.Connection = Conn
            cmd.CommandText = sqlQuery

            ' Dùng Parameters để tránh lỗi SQL Injection (rất quan trọng)
            cmd.Parameters.AddWithValue("@maKhoi", maKhoi)
            cmd.Parameters.AddWithValue("@tongDiem", tongDiem)
            If Not String.IsNullOrEmpty(nganhYeuThich) Then
                cmd.Parameters.AddWithValue("@tenNganh", "%" & nganhYeuThich & "%")
            End If

            ' Dùng SqlDataAdapter để lấy dữ liệu và đổ vào DataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dt)

        Finally
            Disconnect()
        End Try

        ' --- BƯỚC 5: XỬ LÝ KẾT QUẢ VÀ HIỂN THỊ ---
        If dt.Rows.Count = 0 Then
            MsgBox("Rất tiếc, không tìm thấy ngành/trường nào phù hợp với điểm số và tiêu chí của bạn.", MsgBoxStyle.Information, "Không có kết quả")
        Else
            ' Nếu có kết quả, chúng ta sẽ mở Form kết quả và truyền DataTable này sang
            ' (Chúng ta sẽ tạo Form này ở giai đoạn tiếp theo)
            MsgBox("Tìm thấy " & dt.Rows.Count & " kết quả phù hợp! Chuẩn bị hiển thị...")

            Dim f_ketqua As New frmKetQua(dt) ' Tạo một instance của Form kết quả, truyền dữ liệu qua
            f_ketqua.Show() ' Hiển thị Form kết quả
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles lblTongDiem.Click

    End Sub
End Class