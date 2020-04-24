<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.vao = New System.Windows.Forms.PictureBox()
        Me.thoat = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.vao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.thoat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vao
        '
        Me.vao.BackColor = System.Drawing.Color.Transparent
        Me.vao.Location = New System.Drawing.Point(648, 71)
        Me.vao.Name = "vao"
        Me.vao.Size = New System.Drawing.Size(185, 117)
        Me.vao.TabIndex = 0
        Me.vao.TabStop = False
        '
        'thoat
        '
        Me.thoat.BackColor = System.Drawing.Color.Transparent
        Me.thoat.Location = New System.Drawing.Point(616, 240)
        Me.thoat.Name = "thoat"
        Me.thoat.Size = New System.Drawing.Size(217, 118)
        Me.thoat.TabIndex = 1
        Me.thoat.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(613, 471)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Được tạo bởi Nguyễn Trung Nhẫn Forum http://luutru360.com"
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Stick_Math.My.Resources.Resources.home
        Me.ClientSize = New System.Drawing.Size(914, 493)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.thoat)
        Me.Controls.Add(Me.vao)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stick Math "
        CType(Me.vao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.thoat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vao As System.Windows.Forms.PictureBox
    Friend WithEvents thoat As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
