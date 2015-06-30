<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMain))
        Me.groupRange = New System.Windows.Forms.GroupBox()
        Me.labelEnd = New System.Windows.Forms.Label()
        Me.labelStart = New System.Windows.Forms.Label()
        Me.inputEnd = New System.Windows.Forms.TextBox()
        Me.inputStart = New System.Windows.Forms.TextBox()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.outputStatus = New System.Windows.Forms.TextBox()
        Me.outputResult = New System.Windows.Forms.TextBox()
        Me.groupSpec = New System.Windows.Forms.GroupBox()
        Me.labelSpec = New System.Windows.Forms.Label()
        Me.chkDivisor = New System.Windows.Forms.CheckBox()
        Me.inputSpec = New System.Windows.Forms.TextBox()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.btnCopyAll = New System.Windows.Forms.Button()
        Me.radioRange = New System.Windows.Forms.RadioButton()
        Me.radioSpec = New System.Windows.Forms.RadioButton()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.groupRange.SuspendLayout()
        Me.groupSpec.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupRange
        '
        Me.groupRange.Controls.Add(Me.labelEnd)
        Me.groupRange.Controls.Add(Me.labelStart)
        Me.groupRange.Controls.Add(Me.inputEnd)
        Me.groupRange.Controls.Add(Me.inputStart)
        resources.ApplyResources(Me.groupRange, "groupRange")
        Me.groupRange.Name = "groupRange"
        Me.groupRange.TabStop = False
        '
        'labelEnd
        '
        resources.ApplyResources(Me.labelEnd, "labelEnd")
        Me.labelEnd.Name = "labelEnd"
        '
        'labelStart
        '
        resources.ApplyResources(Me.labelStart, "labelStart")
        Me.labelStart.Name = "labelStart"
        '
        'inputEnd
        '
        resources.ApplyResources(Me.inputEnd, "inputEnd")
        Me.inputEnd.Name = "inputEnd"
        '
        'inputStart
        '
        resources.ApplyResources(Me.inputStart, "inputStart")
        Me.inputStart.Name = "inputStart"
        '
        'btnRun
        '
        resources.ApplyResources(Me.btnRun, "btnRun")
        Me.btnRun.Name = "btnRun"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'outputStatus
        '
        resources.ApplyResources(Me.outputStatus, "outputStatus")
        Me.outputStatus.Name = "outputStatus"
        Me.outputStatus.ReadOnly = True
        Me.outputStatus.TabStop = False
        '
        'outputResult
        '
        resources.ApplyResources(Me.outputResult, "outputResult")
        Me.outputResult.Name = "outputResult"
        Me.outputResult.ReadOnly = True
        Me.outputResult.TabStop = False
        '
        'groupSpec
        '
        Me.groupSpec.Controls.Add(Me.labelSpec)
        Me.groupSpec.Controls.Add(Me.chkDivisor)
        Me.groupSpec.Controls.Add(Me.inputSpec)
        resources.ApplyResources(Me.groupSpec, "groupSpec")
        Me.groupSpec.Name = "groupSpec"
        Me.groupSpec.TabStop = False
        '
        'labelSpec
        '
        resources.ApplyResources(Me.labelSpec, "labelSpec")
        Me.labelSpec.Name = "labelSpec"
        '
        'chkDivisor
        '
        resources.ApplyResources(Me.chkDivisor, "chkDivisor")
        Me.chkDivisor.Name = "chkDivisor"
        Me.chkDivisor.UseVisualStyleBackColor = True
        '
        'inputSpec
        '
        resources.ApplyResources(Me.inputSpec, "inputSpec")
        Me.inputSpec.Name = "inputSpec"
        '
        'btnCopy
        '
        resources.ApplyResources(Me.btnCopy, "btnCopy")
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.TabStop = False
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'btnCopyAll
        '
        resources.ApplyResources(Me.btnCopyAll, "btnCopyAll")
        Me.btnCopyAll.Name = "btnCopyAll"
        Me.btnCopyAll.TabStop = False
        Me.btnCopyAll.UseVisualStyleBackColor = True
        '
        'radioRange
        '
        resources.ApplyResources(Me.radioRange, "radioRange")
        Me.radioRange.Name = "radioRange"
        Me.radioRange.UseVisualStyleBackColor = True
        '
        'radioSpec
        '
        resources.ApplyResources(Me.radioSpec, "radioSpec")
        Me.radioSpec.Name = "radioSpec"
        Me.radioSpec.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        resources.ApplyResources(Me.btnClear, "btnClear")
        Me.btnClear.Name = "btnClear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'mainForm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.radioSpec)
        Me.Controls.Add(Me.radioRange)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.btnCopyAll)
        Me.Controls.Add(Me.groupSpec)
        Me.Controls.Add(Me.outputResult)
        Me.Controls.Add(Me.outputStatus)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.groupRange)
        Me.MaximizeBox = False
        Me.Name = "mainForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.groupRange.ResumeLayout(False)
        Me.groupRange.PerformLayout()
        Me.groupSpec.ResumeLayout(False)
        Me.groupSpec.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents groupRange As GroupBox
    Friend WithEvents inputStart As TextBox
    Friend WithEvents inputEnd As TextBox
    Friend WithEvents labelStart As Label
    Friend WithEvents labelEnd As Label
    Friend WithEvents btnRun As Button
    Friend WithEvents outputStatus As TextBox
    Friend WithEvents outputResult As TextBox
    Friend WithEvents groupSpec As GroupBox
    Friend WithEvents btnCopy As Button
    Friend WithEvents btnCopyAll As Button
    Friend WithEvents chkDivisor As CheckBox
    Friend WithEvents inputSpec As TextBox
    Friend WithEvents labelSpec As Label
    Friend WithEvents radioRange As RadioButton
    Friend WithEvents radioSpec As RadioButton
    Friend WithEvents btnClear As Button
End Class
