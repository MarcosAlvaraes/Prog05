<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.soma1 = New System.Windows.Forms.Button()
        Me.multi = New System.Windows.Forms.Button()
        Me.div = New System.Windows.Forms.Button()
        Me.soma = New System.Windows.Forms.Button()
        Me.subtra = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(87, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(367, 385)
        Me.Panel1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(75, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Resultado:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.soma1)
        Me.Panel2.Controls.Add(Me.multi)
        Me.Panel2.Controls.Add(Me.div)
        Me.Panel2.Controls.Add(Me.soma)
        Me.Panel2.Controls.Add(Me.subtra)
        Me.Panel2.Location = New System.Drawing.Point(65, 271)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(191, 85)
        Me.Panel2.TabIndex = 10
        '
        'soma1
        '
        Me.soma1.Location = New System.Drawing.Point(15, 18)
        Me.soma1.Name = "soma1"
        Me.soma1.Size = New System.Drawing.Size(75, 23)
        Me.soma1.TabIndex = 4
        Me.soma1.Text = "Soma"
        Me.soma1.UseVisualStyleBackColor = True
        '
        'multi
        '
        Me.multi.Location = New System.Drawing.Point(100, 18)
        Me.multi.Name = "multi"
        Me.multi.Size = New System.Drawing.Size(75, 23)
        Me.multi.TabIndex = 1
        Me.multi.Text = "Multiplicar"
        Me.multi.UseVisualStyleBackColor = True
        '
        'div
        '
        Me.div.Location = New System.Drawing.Point(100, 47)
        Me.div.Name = "div"
        Me.div.Size = New System.Drawing.Size(75, 23)
        Me.div.TabIndex = 3
        Me.div.Text = "Dividir"
        Me.div.UseVisualStyleBackColor = True
        '
        'soma
        '
        Me.soma.Location = New System.Drawing.Point(4, 204)
        Me.soma.Name = "soma"
        Me.soma.Size = New System.Drawing.Size(75, 23)
        Me.soma.TabIndex = 0
        Me.soma.Text = "Somar"
        Me.soma.UseVisualStyleBackColor = True
        '
        'subtra
        '
        Me.subtra.Location = New System.Drawing.Point(15, 47)
        Me.subtra.Name = "subtra"
        Me.subtra.Size = New System.Drawing.Size(75, 23)
        Me.subtra.TabIndex = 2
        Me.subtra.Text = "Subtrair"
        Me.subtra.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "2ª Valor Numérico:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "1ª Valor Numérico:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(156, 166)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 23)
        Me.TextBox3.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(156, 137)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 23)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(156, 108)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 4
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents div As Button
    Friend WithEvents subtra As Button
    Friend WithEvents multi As Button
    Friend WithEvents soma As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents soma1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
End Class
