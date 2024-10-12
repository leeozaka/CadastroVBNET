<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastraCorretor
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        CorretorId = New TextBox()
        CorretorCPF = New MaskedTextBox()
        CorretorNome = New TextBox()
        HnCadastrar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' CorretorId
        ' 
        CorretorId.Location = New Point(125, 45)
        CorretorId.Name = "CorretorId"
        CorretorId.Size = New Size(270, 23)
        CorretorId.TabIndex = 0
        ' 
        ' CorretorCPF
        ' 
        CorretorCPF.Location = New Point(125, 95)
        CorretorCPF.Mask = "000.000.000-00"
        CorretorCPF.Name = "CorretorCPF"
        CorretorCPF.Size = New Size(270, 23)
        CorretorCPF.TabIndex = 1
        CorretorCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
        ' 
        ' CorretorNome
        ' 
        CorretorNome.Location = New Point(125, 148)
        CorretorNome.Name = "CorretorNome"
        CorretorNome.PlaceholderText = "Nome"
        CorretorNome.Size = New Size(270, 23)
        CorretorNome.TabIndex = 2
        ' 
        ' HnCadastrar
        ' 
        HnCadastrar.Location = New Point(164, 207)
        HnCadastrar.Name = "HnCadastrar"
        HnCadastrar.Size = New Size(155, 113)
        HnCadastrar.TabIndex = 6
        HnCadastrar.Text = "Cadastrar"
        HnCadastrar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(56, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 15)
        Label1.TabIndex = 3
        Label1.Text = "Codigo"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(74, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(28, 15)
        Label2.TabIndex = 4
        Label2.Text = "CPF"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(62, 156)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 15)
        Label3.TabIndex = 5
        Label3.Text = "Nome"
        ' 
        ' CadastraCorretor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(497, 358)
        Controls.Add(HnCadastrar)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(CorretorNome)
        Controls.Add(CorretorCPF)
        Controls.Add(CorretorId)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "CadastraCorretor"
        Text = "CadastraCorretor"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CorretorId As TextBox
    Friend WithEvents CorretorCPF As MaskedTextBox
    Friend WithEvents CorretorNome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents HnCadastrar As Button
End Class
