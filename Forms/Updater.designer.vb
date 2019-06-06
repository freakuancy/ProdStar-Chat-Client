<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdater
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdater))
        Me.lblStep = New System.Windows.Forms.Label()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.prgStatus = New System.Windows.Forms.ProgressBar()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblCompletion = New System.Windows.Forms.Label()
        Me.prgTotal = New System.Windows.Forms.ProgressBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStep
        '
        Me.lblStep.AutoSize = True
        Me.lblStep.Location = New System.Drawing.Point(12, 18)
        Me.lblStep.Name = "lblStep"
        Me.lblStep.Size = New System.Drawing.Size(152, 13)
        Me.lblStep.TabIndex = 0
        Me.lblStep.Text = "Click 'Begin Update' to Update"
        '
        'lblProgress
        '
        Me.lblProgress.Location = New System.Drawing.Point(170, 18)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(164, 13)
        Me.lblProgress.TabIndex = 1
        Me.lblProgress.Text = "Update"
        Me.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'prgStatus
        '
        Me.prgStatus.Location = New System.Drawing.Point(15, 32)
        Me.prgStatus.Name = "prgStatus"
        Me.prgStatus.Size = New System.Drawing.Size(321, 18)
        Me.prgStatus.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClose.Location = New System.Drawing.Point(273, 128)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(63, 27)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnUpdate.Location = New System.Drawing.Point(164, 128)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(103, 27)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "Begin Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lblCompletion
        '
        Me.lblCompletion.AutoSize = True
        Me.lblCompletion.Location = New System.Drawing.Point(12, 60)
        Me.lblCompletion.Name = "lblCompletion"
        Me.lblCompletion.Size = New System.Drawing.Size(106, 13)
        Me.lblCompletion.TabIndex = 6
        Me.lblCompletion.Text = "Completion Progress:"
        '
        'prgTotal
        '
        Me.prgTotal.Location = New System.Drawing.Point(14, 74)
        Me.prgTotal.Name = "prgTotal"
        Me.prgTotal.Size = New System.Drawing.Size(321, 18)
        Me.prgTotal.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(23, 103)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(122, 55)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'frmUpdater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(348, 164)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblCompletion)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.prgTotal)
        Me.Controls.Add(Me.prgStatus)
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.lblStep)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmUpdater"
        Me.Text = "ProdStar® Communicate - Update"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStep As System.Windows.Forms.Label
    Friend WithEvents lblProgress As System.Windows.Forms.Label
    Friend WithEvents prgStatus As System.Windows.Forms.ProgressBar
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents lblCompletion As System.Windows.Forms.Label
    Friend WithEvents prgTotal As System.Windows.Forms.ProgressBar
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
