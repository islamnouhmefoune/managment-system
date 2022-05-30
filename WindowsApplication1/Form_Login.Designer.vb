<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Login
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cancelBTN = New System.Windows.Forms.Button()
        Me.passwordtxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.typeCB = New System.Windows.Forms.ComboBox()
        Me.usernametxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.loginBTN = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.cancelBTN)
        Me.Panel1.Controls.Add(Me.passwordtxt)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.typeCB)
        Me.Panel1.Controls.Add(Me.usernametxt)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.loginBTN)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(767, 508)
        Me.Panel1.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel3.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.IMG_0846_1_
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel3.Location = New System.Drawing.Point(36, 166)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(208, 206)
        Me.Panel3.TabIndex = 17
        '
        'Panel2
        '
        Me.Panel2.AllowDrop = True
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(767, 114)
        Me.Panel2.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nina", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(288, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 39)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "USER LOGIN"
        '
        'cancelBTN
        '
        Me.cancelBTN.AllowDrop = True
        Me.cancelBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.cancelBTN.FlatAppearance.BorderSize = 0
        Me.cancelBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelBTN.Font = New System.Drawing.Font("Nina", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelBTN.ForeColor = System.Drawing.Color.White
        Me.cancelBTN.Location = New System.Drawing.Point(377, 432)
        Me.cancelBTN.Name = "cancelBTN"
        Me.cancelBTN.Size = New System.Drawing.Size(123, 40)
        Me.cancelBTN.TabIndex = 15
        Me.cancelBTN.Text = "Cancel"
        Me.cancelBTN.UseVisualStyleBackColor = False
        '
        'passwordtxt
        '
        Me.passwordtxt.AllowDrop = True
        Me.passwordtxt.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordtxt.Location = New System.Drawing.Point(461, 248)
        Me.passwordtxt.Name = "passwordtxt"
        Me.passwordtxt.Size = New System.Drawing.Size(201, 27)
        Me.passwordtxt.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AllowDrop = True
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(306, 336)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 19)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Type Login"
        '
        'Label2
        '
        Me.Label2.AllowDrop = True
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(306, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 19)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Username"
        '
        'typeCB
        '
        Me.typeCB.AllowDrop = True
        Me.typeCB.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.typeCB.FormattingEnabled = True
        Me.typeCB.Items.AddRange(New Object() {"USER", "ADMINE"})
        Me.typeCB.Location = New System.Drawing.Point(461, 333)
        Me.typeCB.Name = "typeCB"
        Me.typeCB.Size = New System.Drawing.Size(201, 27)
        Me.typeCB.TabIndex = 11
        '
        'usernametxt
        '
        Me.usernametxt.AllowDrop = True
        Me.usernametxt.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernametxt.Location = New System.Drawing.Point(461, 166)
        Me.usernametxt.Name = "usernametxt"
        Me.usernametxt.Size = New System.Drawing.Size(201, 27)
        Me.usernametxt.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AllowDrop = True
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(306, 251)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 19)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Password"
        '
        'loginBTN
        '
        Me.loginBTN.AllowDrop = True
        Me.loginBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.loginBTN.FlatAppearance.BorderSize = 0
        Me.loginBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginBTN.Font = New System.Drawing.Font("Nina", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBTN.ForeColor = System.Drawing.Color.White
        Me.loginBTN.Location = New System.Drawing.Point(200, 432)
        Me.loginBTN.Name = "loginBTN"
        Me.loginBTN.Size = New System.Drawing.Size(123, 40)
        Me.loginBTN.TabIndex = 8
        Me.loginBTN.Text = "Login"
        Me.loginBTN.UseVisualStyleBackColor = False
        '
        'Form_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(767, 508)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form_Login"
        Me.Text = "Form_Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cancelBTN As Button
    Friend WithEvents passwordtxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents typeCB As ComboBox
    Friend WithEvents usernametxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents loginBTN As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
End Class
