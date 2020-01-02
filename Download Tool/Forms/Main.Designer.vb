<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MainForm = New Download_Tool.UbuntuTheme()
        Me.UbuntuControlBox1 = New Download_Tool.UbuntuControlBox()
        Me.DownloadFile = New Download_Tool.UbuntuButtonOrange()
        Me.MyExtension = New Download_Tool.UbuntuTextBox()
        Me.MyFileName = New Download_Tool.UbuntuTextBox()
        Me.MyLink = New Download_Tool.UbuntuTextBox()
        Me.MainForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainForm
        '
        Me.MainForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.MainForm.Controls.Add(Me.UbuntuControlBox1)
        Me.MainForm.Controls.Add(Me.DownloadFile)
        Me.MainForm.Controls.Add(Me.MyExtension)
        Me.MainForm.Controls.Add(Me.MyFileName)
        Me.MainForm.Controls.Add(Me.MyLink)
        Me.MainForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainForm.Location = New System.Drawing.Point(0, 0)
        Me.MainForm.Name = "MainForm"
        Me.MainForm.Size = New System.Drawing.Size(394, 157)
        Me.MainForm.TabIndex = 0
        Me.MainForm.Text = "Download Tool"
        '
        'UbuntuControlBox1
        '
        Me.UbuntuControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UbuntuControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.UbuntuControlBox1.Font = New System.Drawing.Font("Marlett", 7.0!)
        Me.UbuntuControlBox1.Location = New System.Drawing.Point(329, 3)
        Me.UbuntuControlBox1.Name = "UbuntuControlBox1"
        Me.UbuntuControlBox1.Size = New System.Drawing.Size(75, 23)
        Me.UbuntuControlBox1.TabIndex = 4
        Me.UbuntuControlBox1.Text = "UbuntuControlBox1"
        '
        'DownloadFile
        '
        Me.DownloadFile.BackColor = System.Drawing.Color.Transparent
        Me.DownloadFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.DownloadFile.Location = New System.Drawing.Point(12, 121)
        Me.DownloadFile.Name = "DownloadFile"
        Me.DownloadFile.Size = New System.Drawing.Size(370, 23)
        Me.DownloadFile.TabIndex = 3
        Me.DownloadFile.Text = "Download File(s)"
        '
        'MyExtension
        '
        Me.MyExtension.BackColor = System.Drawing.Color.White
        Me.MyExtension.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.MyExtension.Location = New System.Drawing.Point(12, 93)
        Me.MyExtension.MaxLength = 32767
        Me.MyExtension.Name = "MyExtension"
        Me.MyExtension.Size = New System.Drawing.Size(370, 26)
        Me.MyExtension.TabIndex = 2
        Me.MyExtension.Text = ".rar"
        Me.MyExtension.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.MyExtension.UseSystemPasswordChar = False
        '
        'MyFileName
        '
        Me.MyFileName.BackColor = System.Drawing.Color.White
        Me.MyFileName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.MyFileName.Location = New System.Drawing.Point(12, 65)
        Me.MyFileName.MaxLength = 32767
        Me.MyFileName.Name = "MyFileName"
        Me.MyFileName.Size = New System.Drawing.Size(370, 26)
        Me.MyFileName.TabIndex = 1
        Me.MyFileName.Text = "Download Tool"
        Me.MyFileName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.MyFileName.UseSystemPasswordChar = False
        '
        'MyLink
        '
        Me.MyLink.BackColor = System.Drawing.Color.White
        Me.MyLink.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.MyLink.Location = New System.Drawing.Point(12, 37)
        Me.MyLink.MaxLength = 32767
        Me.MyLink.Name = "MyLink"
        Me.MyLink.Size = New System.Drawing.Size(370, 26)
        Me.MyLink.TabIndex = 0
        Me.MyLink.Text = "https://github.com/RealBugzy/Download-Tool/archive/master.zip"
        Me.MyLink.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.MyLink.UseSystemPasswordChar = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 157)
        Me.Controls.Add(Me.MainForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Download Tool"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MainForm.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainForm As UbuntuTheme
    Friend WithEvents DownloadFile As UbuntuButtonOrange
    Friend WithEvents MyExtension As UbuntuTextBox
    Friend WithEvents MyFileName As UbuntuTextBox
    Friend WithEvents MyLink As UbuntuTextBox
    Friend WithEvents UbuntuControlBox1 As UbuntuControlBox
End Class
