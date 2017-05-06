<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.btnShorten = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtShort = New System.Windows.Forms.TextBox()
        Me.btn_Paste = New System.Windows.Forms.Button()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.CaptureLink = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "URL:"
        '
        'txtURL
        '
        Me.txtURL.Location = New System.Drawing.Point(50, 15)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(196, 20)
        Me.txtURL.TabIndex = 1
        '
        'btnShorten
        '
        Me.btnShorten.Location = New System.Drawing.Point(323, 14)
        Me.btnShorten.Name = "btnShorten"
        Me.btnShorten.Size = New System.Drawing.Size(75, 53)
        Me.btnShorten.TabIndex = 2
        Me.btnShorten.Text = "Shorten URL"
        Me.btnShorten.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Short:"
        '
        'txtShort
        '
        Me.txtShort.Location = New System.Drawing.Point(50, 47)
        Me.txtShort.Name = "txtShort"
        Me.txtShort.Size = New System.Drawing.Size(196, 20)
        Me.txtShort.TabIndex = 4
        '
        'btn_Paste
        '
        Me.btn_Paste.Location = New System.Drawing.Point(252, 14)
        Me.btn_Paste.Name = "btn_Paste"
        Me.btn_Paste.Size = New System.Drawing.Size(65, 21)
        Me.btn_Paste.TabIndex = 5
        Me.btn_Paste.Text = "Paste"
        Me.btn_Paste.UseVisualStyleBackColor = True
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(252, 46)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(65, 21)
        Me.btnCopy.TabIndex = 6
        Me.btnCopy.Text = "Copy"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'CaptureLink
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 84)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.btn_Paste)
        Me.Controls.Add(Me.txtShort)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnShorten)
        Me.Controls.Add(Me.txtURL)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Google URL Shortener"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtURL As TextBox
    Friend WithEvents btnShorten As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtShort As TextBox
    Friend WithEvents btn_Paste As Button
    Friend WithEvents btnCopy As Button
    Friend WithEvents CaptureLink As Timer
End Class
