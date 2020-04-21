<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PetVoting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PetVoting))
        Me.btnVote = New System.Windows.Forms.Button()
        Me.picCat = New System.Windows.Forms.PictureBox()
        Me.lstOut = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picDog = New System.Windows.Forms.PictureBox()
        Me.picCat1 = New System.Windows.Forms.PictureBox()
        Me.picFish = New System.Windows.Forms.PictureBox()
        Me.picBird = New System.Windows.Forms.PictureBox()
        Me.lblDog = New System.Windows.Forms.Label()
        Me.lblCat = New System.Windows.Forms.Label()
        Me.lblFish = New System.Windows.Forms.Label()
        Me.lblBird = New System.Windows.Forms.Label()
        Me.picVote = New System.Windows.Forms.PictureBox()
        CType(Me.picCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCat1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFish, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBird, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVote
        '
        Me.btnVote.BackColor = System.Drawing.Color.LightPink
        Me.btnVote.Font = New System.Drawing.Font("Segoe Script", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVote.ForeColor = System.Drawing.Color.Black
        Me.btnVote.Location = New System.Drawing.Point(206, 16)
        Me.btnVote.Name = "btnVote"
        Me.btnVote.Size = New System.Drawing.Size(193, 68)
        Me.btnVote.TabIndex = 0
        Me.btnVote.Text = "Vote"
        Me.btnVote.UseVisualStyleBackColor = False
        '
        'picCat
        '
        Me.picCat.Location = New System.Drawing.Point(12, 84)
        Me.picCat.Name = "picCat"
        Me.picCat.Size = New System.Drawing.Size(0, 0)
        Me.picCat.TabIndex = 1
        Me.picCat.TabStop = False
        '
        'lstOut
        '
        Me.lstOut.BackColor = System.Drawing.Color.LightPink
        Me.lstOut.Font = New System.Drawing.Font("Segoe Script", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOut.FormattingEnabled = True
        Me.lstOut.ItemHeight = 27
        Me.lstOut.Location = New System.Drawing.Point(43, 295)
        Me.lstOut.Name = "lstOut"
        Me.lstOut.Size = New System.Drawing.Size(280, 193)
        Me.lstOut.TabIndex = 2
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightPink
        Me.btnClear.Font = New System.Drawing.Font("Segoe Script", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(387, 462)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(81, 32)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LightPink
        Me.btnExit.Font = New System.Drawing.Font("Segoe Script", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(495, 462)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(81, 32)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'picDog
        '
        Me.picDog.BackColor = System.Drawing.Color.Transparent
        Me.picDog.Image = CType(resources.GetObject("picDog.Image"), System.Drawing.Image)
        Me.picDog.Location = New System.Drawing.Point(-27, 99)
        Me.picDog.Name = "picDog"
        Me.picDog.Size = New System.Drawing.Size(205, 190)
        Me.picDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDog.TabIndex = 5
        Me.picDog.TabStop = False
        '
        'picCat1
        '
        Me.picCat1.BackColor = System.Drawing.Color.Transparent
        Me.picCat1.Image = CType(resources.GetObject("picCat1.Image"), System.Drawing.Image)
        Me.picCat1.Location = New System.Drawing.Point(147, 114)
        Me.picCat1.Name = "picCat1"
        Me.picCat1.Size = New System.Drawing.Size(131, 164)
        Me.picCat1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCat1.TabIndex = 6
        Me.picCat1.TabStop = False
        '
        'picFish
        '
        Me.picFish.BackColor = System.Drawing.Color.Transparent
        Me.picFish.Image = CType(resources.GetObject("picFish.Image"), System.Drawing.Image)
        Me.picFish.Location = New System.Drawing.Point(272, 129)
        Me.picFish.Name = "picFish"
        Me.picFish.Size = New System.Drawing.Size(196, 149)
        Me.picFish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFish.TabIndex = 7
        Me.picFish.TabStop = False
        '
        'picBird
        '
        Me.picBird.BackColor = System.Drawing.Color.Transparent
        Me.picBird.Image = CType(resources.GetObject("picBird.Image"), System.Drawing.Image)
        Me.picBird.Location = New System.Drawing.Point(458, 84)
        Me.picBird.Name = "picBird"
        Me.picBird.Size = New System.Drawing.Size(188, 249)
        Me.picBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBird.TabIndex = 8
        Me.picBird.TabStop = False
        '
        'lblDog
        '
        Me.lblDog.AutoSize = True
        Me.lblDog.BackColor = System.Drawing.Color.Transparent
        Me.lblDog.Font = New System.Drawing.Font("Segoe Script", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDog.Location = New System.Drawing.Point(49, 84)
        Me.lblDog.Name = "lblDog"
        Me.lblDog.Size = New System.Drawing.Size(33, 34)
        Me.lblDog.TabIndex = 9
        Me.lblDog.Text = "A"
        '
        'lblCat
        '
        Me.lblCat.AutoSize = True
        Me.lblCat.BackColor = System.Drawing.Color.Transparent
        Me.lblCat.Font = New System.Drawing.Font("Segoe Script", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCat.Location = New System.Drawing.Point(184, 84)
        Me.lblCat.Name = "lblCat"
        Me.lblCat.Size = New System.Drawing.Size(31, 34)
        Me.lblCat.TabIndex = 10
        Me.lblCat.Text = "B"
        '
        'lblFish
        '
        Me.lblFish.AutoSize = True
        Me.lblFish.BackColor = System.Drawing.Color.Transparent
        Me.lblFish.Font = New System.Drawing.Font("Segoe Script", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFish.Location = New System.Drawing.Point(337, 84)
        Me.lblFish.Name = "lblFish"
        Me.lblFish.Size = New System.Drawing.Size(30, 34)
        Me.lblFish.TabIndex = 11
        Me.lblFish.Text = "C"
        '
        'lblBird
        '
        Me.lblBird.AutoSize = True
        Me.lblBird.BackColor = System.Drawing.Color.Transparent
        Me.lblBird.Font = New System.Drawing.Font("Segoe Script", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBird.Location = New System.Drawing.Point(522, 84)
        Me.lblBird.Name = "lblBird"
        Me.lblBird.Size = New System.Drawing.Size(33, 34)
        Me.lblBird.TabIndex = 12
        Me.lblBird.Text = "D"
        '
        'picVote
        '
        Me.picVote.Image = CType(resources.GetObject("picVote.Image"), System.Drawing.Image)
        Me.picVote.Location = New System.Drawing.Point(329, 295)
        Me.picVote.Name = "picVote"
        Me.picVote.Size = New System.Drawing.Size(284, 161)
        Me.picVote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picVote.TabIndex = 13
        Me.picVote.TabStop = False
        '
        'PetVoting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.HotPink
        Me.ClientSize = New System.Drawing.Size(625, 506)
        Me.Controls.Add(Me.picVote)
        Me.Controls.Add(Me.lblBird)
        Me.Controls.Add(Me.lblFish)
        Me.Controls.Add(Me.lblCat)
        Me.Controls.Add(Me.lblDog)
        Me.Controls.Add(Me.picBird)
        Me.Controls.Add(Me.picFish)
        Me.Controls.Add(Me.picCat1)
        Me.Controls.Add(Me.picDog)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lstOut)
        Me.Controls.Add(Me.picCat)
        Me.Controls.Add(Me.btnVote)
        Me.Name = "PetVoting"
        Me.Text = "Who's Your Favorite Pet?"
        CType(Me.picCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCat1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFish, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBird, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVote As Button
    Friend WithEvents picCat As PictureBox
    Friend WithEvents lstOut As ListBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents picDog As PictureBox
    Friend WithEvents picCat1 As PictureBox
    Friend WithEvents picFish As PictureBox
    Friend WithEvents picBird As PictureBox
    Friend WithEvents lblDog As Label
    Friend WithEvents lblCat As Label
    Friend WithEvents lblFish As Label
    Friend WithEvents lblBird As Label
    Friend WithEvents picVote As PictureBox
End Class
