<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimKiem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDiemSinh = New System.Windows.Forms.TextBox()
        Me.txtDiemVan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDiemHoa = New System.Windows.Forms.TextBox()
        Me.txtDiemAnh = New System.Windows.Forms.TextBox()
        Me.txtDiemLy = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDiemToan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboKhoiThi = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNganhYeuThich = New System.Windows.Forms.TextBox()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.lblTongDiem = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTongDiem)
        Me.GroupBox1.Controls.Add(Me.txtDiemSinh)
        Me.GroupBox1.Controls.Add(Me.txtDiemVan)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtDiemHoa)
        Me.GroupBox1.Controls.Add(Me.txtDiemAnh)
        Me.GroupBox1.Controls.Add(Me.txtDiemLy)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDiemToan)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(43, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(324, 306)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nhập thông tin tra cứu"
        '
        'txtDiemSinh
        '
        Me.txtDiemSinh.Location = New System.Drawing.Point(168, 190)
        Me.txtDiemSinh.Name = "txtDiemSinh"
        Me.txtDiemSinh.Size = New System.Drawing.Size(100, 20)
        Me.txtDiemSinh.TabIndex = 11
        '
        'txtDiemVan
        '
        Me.txtDiemVan.Location = New System.Drawing.Point(7, 191)
        Me.txtDiemVan.Name = "txtDiemVan"
        Me.txtDiemVan.Size = New System.Drawing.Size(100, 20)
        Me.txtDiemVan.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(168, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Điểm Sinh:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Điểm Văn:"
        '
        'txtDiemHoa
        '
        Me.txtDiemHoa.Location = New System.Drawing.Point(6, 123)
        Me.txtDiemHoa.Name = "txtDiemHoa"
        Me.txtDiemHoa.Size = New System.Drawing.Size(100, 20)
        Me.txtDiemHoa.TabIndex = 7
        '
        'txtDiemAnh
        '
        Me.txtDiemAnh.Location = New System.Drawing.Point(168, 123)
        Me.txtDiemAnh.Name = "txtDiemAnh"
        Me.txtDiemAnh.Size = New System.Drawing.Size(100, 20)
        Me.txtDiemAnh.TabIndex = 6
        '
        'txtDiemLy
        '
        Me.txtDiemLy.Location = New System.Drawing.Point(168, 57)
        Me.txtDiemLy.Name = "txtDiemLy"
        Me.txtDiemLy.Size = New System.Drawing.Size(100, 20)
        Me.txtDiemLy.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(165, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Điểm Anh:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Điểm Hóa:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(165, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Điểm Lý:"
        '
        'txtDiemToan
        '
        Me.txtDiemToan.Location = New System.Drawing.Point(6, 57)
        Me.txtDiemToan.Name = "txtDiemToan"
        Me.txtDiemToan.Size = New System.Drawing.Size(100, 20)
        Me.txtDiemToan.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Điểm Toán:"
        '
        'cboKhoiThi
        '
        Me.cboKhoiThi.FormattingEnabled = True
        Me.cboKhoiThi.Location = New System.Drawing.Point(541, 58)
        Me.cboKhoiThi.Name = "cboKhoiThi"
        Me.cboKhoiThi.Size = New System.Drawing.Size(198, 21)
        Me.cboKhoiThi.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(459, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 15)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Chọn khối thi:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(441, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 15)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Ngành yêu thích:"
        '
        'txtNganhYeuThich
        '
        Me.txtNganhYeuThich.Location = New System.Drawing.Point(541, 121)
        Me.txtNganhYeuThich.Name = "txtNganhYeuThich"
        Me.txtNganhYeuThich.Size = New System.Drawing.Size(198, 20)
        Me.txtNganhYeuThich.TabIndex = 4
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimKiem.Location = New System.Drawing.Point(541, 245)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(213, 99)
        Me.btnTimKiem.TabIndex = 5
        Me.btnTimKiem.Text = "Tìm kiếm Nguyện vọng"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'lblTongDiem
        '
        Me.lblTongDiem.AutoSize = True
        Me.lblTongDiem.Location = New System.Drawing.Point(102, 261)
        Me.lblTongDiem.Name = "lblTongDiem"
        Me.lblTongDiem.Size = New System.Drawing.Size(70, 13)
        Me.lblTongDiem.TabIndex = 6
        Me.lblTongDiem.Text = "Tổng điểm: 0"
        '
        'frmTimKiem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 397)
        Me.Controls.Add(Me.btnTimKiem)
        Me.Controls.Add(Me.txtNganhYeuThich)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboKhoiThi)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmTimKiem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chương trình Tư vấn Tuyển sinh Đại học"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDiemSinh As TextBox
    Friend WithEvents txtDiemVan As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDiemHoa As TextBox
    Friend WithEvents txtDiemAnh As TextBox
    Friend WithEvents txtDiemLy As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDiemToan As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboKhoiThi As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNganhYeuThich As TextBox
    Friend WithEvents btnTimKiem As Button
    Friend WithEvents lblTongDiem As Label
End Class
