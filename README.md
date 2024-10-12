# Cadastro de Clientes
Aplica��o de cadastro de clientes e corretores desenvolvida em Visual Basic .NET.

# Instala��o do App
## Pr�-requisitos
- .NET Framework: Certifique-se de que o .NET 8 Framework est� instalado na m�quina.
- SQL Server: Um servidor SQL Server deve estar dispon�vel para a aplica��o.

## Clonar o Reposit�rio
Clone o reposit�rio da aplica��o para a sua m�quina local:
```bash
git clone https://github.com/leeozaka/CadastroVB.git"
```

## Configura��o do Banco de Dados
1. Abra o SQL Server Management Studio.
1. Conecte-se ao servidor SQL Server.
1. Crie um banco db-cadastro.
1. Execute os scripts em `CadastroVB/Scripts/`
1. Altere a string de conex�o no arquivo `CadastroVB/App.config`.
1. A string de conex�o padr�o � `Data Source=.\SQLEXPRESS;Initial Catalog=db-cadastro;Integrated Security=True`.

## Restaura as depend�ncias
Abra o projeto no Visual Studio e restaure os pacotes NuGet:
```bash
dotnet restore
```

## Compila��o
Compile o projeto no Visual Studio:
```bash
dotnet build
```

## Execu��o
Execute o projeto no Visual Studio:
```bash
dotnet run
```