<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form1))
        tetris = New PictureBox()
        Timer1 = New Timer(components)
        enemy = New PictureBox()
        avatar = New PictureBox()
        enemy2 = New PictureBox()
        CType(tetris, ComponentModel.ISupportInitialize).BeginInit()
        CType(enemy, ComponentModel.ISupportInitialize).BeginInit()
        CType(avatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(enemy2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tetris
        ' 
        tetris.Image = CType(resources.GetObject("tetris.Image"), Image)
        tetris.Location = New Point(1, 1)
        tetris.Name = "tetris"
        tetris.Size = New Size(84, 67)
        tetris.SizeMode = PictureBoxSizeMode.Zoom
        tetris.TabIndex = 0
        tetris.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' enemy
        ' 
        enemy.Image = CType(resources.GetObject("enemy.Image"), Image)
        enemy.Location = New Point(141, 468)
        enemy.Name = "enemy"
        enemy.Size = New Size(91, 46)
        enemy.SizeMode = PictureBoxSizeMode.Zoom
        enemy.TabIndex = 2
        enemy.TabStop = False
        ' 
        ' avatar
        ' 
        avatar.Image = CType(resources.GetObject("avatar.Image"), Image)
        avatar.Location = New Point(119, 380)
        avatar.Name = "avatar"
        avatar.Size = New Size(125, 62)
        avatar.SizeMode = PictureBoxSizeMode.Zoom
        avatar.TabIndex = 3
        avatar.TabStop = False
        ' 
        ' enemy2
        ' 
        enemy2.Image = CType(resources.GetObject("enemy2.Image"), Image)
        enemy2.Location = New Point(44, 468)
        enemy2.Name = "enemy2"
        enemy2.Size = New Size(91, 46)
        enemy2.SizeMode = PictureBoxSizeMode.Zoom
        enemy2.TabIndex = 4
        enemy2.TabStop = False
        ' 
        ' form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(256, 577)
        Controls.Add(enemy2)
        Controls.Add(avatar)
        Controls.Add(enemy)
        Controls.Add(tetris)
        Name = "form1"
        Text = "Form1"
        CType(tetris, ComponentModel.ISupportInitialize).EndInit()
        CType(enemy, ComponentModel.ISupportInitialize).EndInit()
        CType(avatar, ComponentModel.ISupportInitialize).EndInit()
        CType(enemy2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents tetris As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents enemy As PictureBox
    Friend WithEvents avatar As PictureBox
    Friend WithEvents enemy2 As PictureBox

End Class
