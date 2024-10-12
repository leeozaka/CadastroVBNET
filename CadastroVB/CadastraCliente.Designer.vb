<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CadastraCliente
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
        Corretor = New ComboBox()
        Nome = New TextBox()
        CPF = New MaskedTextBox()
        UF = New ComboBox()
        Cidades = New ComboBox()
        Button1 = New Button()
        Endereco = New TextBox()
        Corretores = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Corretor
        ' 
        Corretor.FormattingEnabled = True
        Corretor.Location = New Point(110, 45)
        Corretor.Name = "Corretor"
        Corretor.Size = New Size(243, 23)
        Corretor.TabIndex = 0
        ' 
        ' Nome
        ' 
        Nome.Location = New Point(110, 87)
        Nome.Name = "Nome"
        Nome.PlaceholderText = "Nome"
        Nome.Size = New Size(243, 23)
        Nome.TabIndex = 2
        ' 
        ' CPF
        ' 
        CPF.Location = New Point(110, 124)
        CPF.Mask = "000.000.000-00"
        CPF.Name = "CPF"
        CPF.Size = New Size(243, 23)
        CPF.TabIndex = 4
        CPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
        ' 
        ' UF
        ' 
        UF.FormattingEnabled = True
        UF.Location = New Point(110, 199)
        UF.Name = "UF"
        UF.Size = New Size(243, 23)
        UF.TabIndex = 6
        ' 
        ' Cidades
        ' 
        Cidades.FormattingEnabled = True
        Cidades.Location = New Point(110, 242)
        Cidades.Name = "Cidades"
        Cidades.Size = New Size(243, 23)
        Cidades.Sorted = True
        Cidades.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(393, 104)
        Button1.Name = "Button1"
        Button1.Size = New Size(132, 102)
        Button1.TabIndex = 10
        Button1.Text = "Cadastrar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Endereco
        ' 
        Endereco.Location = New Point(110, 162)
        Endereco.Name = "Endereco"
        Endereco.Size = New Size(243, 23)
        Endereco.TabIndex = 11
        ' 
        ' Corretores
        ' 
        Corretores.AutoSize = True
        Corretores.Location = New Point(42, 48)
        Corretores.Name = "Corretores"
        Corretores.Size = New Size(62, 15)
        Corretores.TabIndex = 1
        Corretores.Text = "Corretores"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(64, 90)
        Label1.Name = "Label1"
        Label1.Size = New Size(40, 15)
        Label1.TabIndex = 3
        Label1.Text = "Nome"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(76, 127)
        Label2.Name = "Label2"
        Label2.Size = New Size(28, 15)
        Label2.TabIndex = 5
        Label2.Text = "CPF"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(83, 201)
        Label3.Name = "Label3"
        Label3.Size = New Size(21, 15)
        Label3.TabIndex = 7
        Label3.Text = "UF"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(55, 244)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 15)
        Label4.TabIndex = 9
        Label4.Text = "Cidades"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(48, 165)
        Label5.Name = "Label5"
        Label5.Size = New Size(56, 15)
        Label5.TabIndex = 12
        Label5.Text = "Endereço"
        ' 
        ' CadastraCliente
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(552, 347)
        Controls.Add(Label5)
        Controls.Add(Endereco)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(Cidades)
        Controls.Add(Label3)
        Controls.Add(UF)
        Controls.Add(Label2)
        Controls.Add(CPF)
        Controls.Add(Label1)
        Controls.Add(Nome)
        Controls.Add(Corretores)
        Controls.Add(Corretor)
        FormBorderStyle = FormBorderStyle.FixedSingle
        ImeMode = ImeMode.Hiragana
        Name = "CadastraCliente"
        Text = "CadastraCliente"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Corretor As ComboBox
    Friend WithEvents Corretores As Label
    Friend WithEvents Nome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CPF As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents UF As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Cidades As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Endereco As TextBox
    Friend WithEvents Label5 As Label
End Class
