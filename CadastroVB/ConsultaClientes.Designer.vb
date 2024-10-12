Imports System.Data.SqlClient
Imports System.Configuration

Partial Class ConsultaClientes
    Inherits System.Windows.Forms.Form

    ' Declare the controls 
    Private WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Private WithEvents btnCadastrarCliente As System.Windows.Forms.Button
    Private WithEvents btnCadastrarCorretor As System.Windows.Forms.Button
    Private WithEvents btnPesquisar As System.Windows.Forms.Button
    Private NomeCliente As System.Windows.Forms.TextBox
    Private CPF As System.Windows.Forms.TextBox
    Private chkAtivo As System.Windows.Forms.CheckBox
    Private NomeCorretor As System.Windows.Forms.TextBox
    Private CodCorretor As System.Windows.Forms.TextBox
    Private Estado As System.Windows.Forms.ComboBox
    Private Cidade As System.Windows.Forms.ComboBox
    Private WithEvents Label1 As Label
    Private WithEvents Label2 As Label
    Private WithEvents Label3 As Label
    Private WithEvents Label4 As Label
    Private WithEvents Label5 As Label
    Private WithEvents Label6 As Label
    Private WithEvents Label7 As Label

    Private Sub InitializeComponent()
        DataGridView1 = New DataGridView()
        btnCadastrarCliente = New Button()
        btnCadastrarCorretor = New Button()
        btnPesquisar = New Button()
        NomeCliente = New TextBox()
        CPF = New TextBox()
        chkAtivo = New CheckBox()
        NomeCorretor = New TextBox()
        CodCorretor = New TextBox()
        Estado = New ComboBox()
        Cidade = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Location = New Point(33, 180)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(949, 277)
        DataGridView1.TabIndex = 0
        ' 
        ' btnCadastrarCliente
        ' 
        btnCadastrarCliente.Location = New Point(488, 150)
        btnCadastrarCliente.Name = "btnCadastrarCliente"
        btnCadastrarCliente.Size = New Size(120, 23)
        btnCadastrarCliente.TabIndex = 1
        btnCadastrarCliente.Text = "Cadastrar Cliente"
        btnCadastrarCliente.UseVisualStyleBackColor = True
        ' 
        ' btnCadastrarCorretor
        ' 
        btnCadastrarCorretor.Location = New Point(285, 150)
        btnCadastrarCorretor.Name = "btnCadastrarCorretor"
        btnCadastrarCorretor.Size = New Size(120, 23)
        btnCadastrarCorretor.TabIndex = 2
        btnCadastrarCorretor.Text = "Cadastrar Corretor"
        btnCadastrarCorretor.UseVisualStyleBackColor = True
        ' 
        ' btnPesquisar
        ' 
        btnPesquisar.Location = New Point(640, 150)
        btnPesquisar.Name = "btnPesquisar"
        btnPesquisar.Size = New Size(120, 23)
        btnPesquisar.TabIndex = 3
        btnPesquisar.Text = "Pesquisar"
        btnPesquisar.UseVisualStyleBackColor = True
        ' 
        ' NomeCliente
        ' 
        NomeCliente.Location = New Point(123, 92)
        NomeCliente.Name = "NomeCliente"
        NomeCliente.Size = New Size(282, 23)
        NomeCliente.TabIndex = 4
        ' 
        ' CPF
        ' 
        CPF.Location = New Point(123, 121)
        CPF.Name = "CPF"
        CPF.Size = New Size(282, 23)
        CPF.TabIndex = 5
        ' 
        ' chkAtivo
        ' 
        chkAtivo.AutoSize = True
        chkAtivo.Location = New Point(478, 41)
        chkAtivo.Name = "chkAtivo"
        chkAtivo.Size = New Size(54, 19)
        chkAtivo.TabIndex = 6
        chkAtivo.Text = "Ativo"
        chkAtivo.UseVisualStyleBackColor = True
        ' 
        ' NomeCorretor
        ' 
        NomeCorretor.Location = New Point(123, 63)
        NomeCorretor.Name = "NomeCorretor"
        NomeCorretor.Size = New Size(282, 23)
        NomeCorretor.TabIndex = 7
        ' 
        ' CodCorretor
        ' 
        CodCorretor.Location = New Point(123, 34)
        CodCorretor.Name = "CodCorretor"
        CodCorretor.Size = New Size(282, 23)
        CodCorretor.TabIndex = 8
        ' 
        ' Estado
        ' 
        Estado.FormattingEnabled = True
        Estado.Location = New Point(478, 99)
        Estado.Name = "Estado"
        Estado.Size = New Size(282, 23)
        Estado.TabIndex = 9
        ' 
        ' Cidade
        ' 
        Cidade.FormattingEnabled = True
        Cidade.Location = New Point(478, 66)
        Cidade.Name = "Cidade"
        Cidade.Size = New Size(282, 23)
        Cidade.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(428, 102)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 15)
        Label1.TabIndex = 11
        Label1.Text = "Estado"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(33, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 15)
        Label2.TabIndex = 12
        Label2.Text = "Nome Cliente:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(33, 124)
        Label3.Name = "Label3"
        Label3.Size = New Size(31, 15)
        Label3.TabIndex = 13
        Label3.Text = "CPF:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(425, 69)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 15)
        Label4.TabIndex = 14
        Label4.Text = "Cidade:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(30, 66)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 15)
        Label5.TabIndex = 15
        Label5.Text = "Nome Corretor:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(30, 37)
        Label6.Name = "Label6"
        Label6.Size = New Size(82, 15)
        Label6.TabIndex = 16
        Label6.Text = "Cod. Corretor:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label7.Location = New Point(35, 9)
        Label7.Name = "Label7"
        Label7.Size = New Size(50, 21)
        Label7.TabIndex = 17
        Label7.Text = "Filtro"
        ' 
        ' ConsultaClientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1015, 487)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Cidade)
        Controls.Add(Estado)
        Controls.Add(CodCorretor)
        Controls.Add(NomeCorretor)
        Controls.Add(chkAtivo)
        Controls.Add(CPF)
        Controls.Add(NomeCliente)
        Controls.Add(btnPesquisar)
        Controls.Add(btnCadastrarCorretor)
        Controls.Add(btnCadastrarCliente)
        Controls.Add(DataGridView1)
        Name = "ConsultaClientes"
        Text = "Cadastra Consultor"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
End Class